
//Formulario de Usuarios.


using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;



namespace CapaPresentacion.Usuarios

{


    public partial class FormUsu : Form
    {
        private int filaSeleccionada = -1; // variable para mantener el indice de mi fila seleccionada en mi dgv
        private DataGridViewButtonCell botonSeleccionado = null;
        private Usuarios.EditarUsuario formularioEditarUsuario;
        private Usuarios.AltaUsuario formularioAltaUsu;
        public FormUsu()
        {
            InitializeComponent();
            dataGridUsuario.CellFormatting += dataGridUsuario_CellFormatting;

        }

        //Métodos para abrir formulario.
        private void abrirFormularios(Form formulario)
        {
            if (formulario != null && !formulario.IsDisposed)
            {
                formulario.TopLevel = false; // Importante para evitar que sea un formulario independiente
                formulario.FormBorderStyle = FormBorderStyle.None; // Quita el borde del formulario
                formulario.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño del contenedor

                panelContenedorUsu.Controls.Add(formulario); // Agrega el formulario al panel
                panelContenedorUsu.Tag = formulario;
                formulario.BringToFront();

                formulario.Show();
                formulario.Activate();
            }
            else
            {
                MessageBox.Show("El formulario no está disponible.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Método para darle color a los usuarios "no activos"
        private void dataGridUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dataGridUsuario.Columns[e.ColumnIndex].Name == "Estado")
            {
                // Verifica si el valor de la celda es "No activo"
                if (e.Value != null && e.Value.ToString() == "No activo")
                {
                    // Establece el color de fondo de toda la fila en rosa
                    dataGridUsuario.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;
                }
                else
                {
                    // Restablece el color de fondo predeterminado para otras filas
                    dataGridUsuario.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Window;
                }
            }
        }


        //Método cuando carga el formulario.
        private void FormUsu_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Baja";
            dataGridUsuario.Columns.Add(btnEliminar);
            btnEliminar.Width = 40;

            DataGridViewButtonColumn btnAlta = new DataGridViewButtonColumn();
            btnAlta.Name = "Alta";
            dataGridUsuario.Columns.Add(btnAlta);
            btnAlta.Width = 40;

            List<USUARIO> listaUsuario = new CN_Usuario().Listar();

            foreach (USUARIO item in listaUsuario)
            {
                dataGridUsuario.Rows.Add(new object[] {"",item.idUsuario,item.documento,item.nombre,item.apellido,item.correo,item.usuario,item.clave,
                item.telefono,
                item.direccion,
                item.estado == true ? "Activo" : "No activo",
                item.oRol.idRol,
                item.oRol.descripcion
            });


            }

            //para que mueste en el cbBusqueda la cabecera del datagrid

            foreach (DataGridViewColumn columna in dataGridUsuario.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar"
                    && columna.Name != "Baja" && columna.Name != "Alta")
                {
                    cboBusqueda.Items.Add((new ComboBoxOpc() { Valor = columna.Name, Texto = columna.HeaderText }));
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

        }


        private void dataGridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridUsuario.Columns["btnSeleccionar"].Index && e.RowIndex >= 0)
            {

                filaSeleccionada = e.RowIndex;

                dataGridUsuario.Invalidate(); // Esto dispara el evento CellPainting

            }
        }
        
        //Método para el btn BajaUsuario
        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                DataGridViewRow fila = dataGridUsuario.Rows[filaSeleccionada];
                string estadoUsuario = fila.Cells["Estado"].Value.ToString(); // Obtener el estado del usuario


                if (estadoUsuario == "Activo")
                {
                    USUARIO usuario = new USUARIO();
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    usuario.idUsuario = Convert.ToInt32(dataGridUsuario.Rows[filaSeleccionada].Cells["idUsuario"].Value);

                    string mensaje = string.Empty;

                    // Llamo al método Eliminar en la capa de negocios

                    bool eliminacionExitosa = new CN_Usuario().Eliminar(usuario, out mensaje);

                    if (eliminacionExitosa)
                    {
                        MessageBox.Show("El usuario fue dado de baja");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ya fue dado de baja anteriormente");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     //Método para el btn AltaUsu
        private void btnAltaUsu_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                DataGridViewRow fila = dataGridUsuario.Rows[filaSeleccionada];
                string estadoUsuario = fila.Cells["Estado"].Value.ToString();

                if (estadoUsuario == "No activo")
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea dar de alta este usuario?", "Confirmación de alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    USUARIO usuario = new USUARIO();
                    usuario.idUsuario = Convert.ToInt32(dataGridUsuario.Rows[filaSeleccionada].Cells["idUsuario"].Value);

                    string mensaje = string.Empty;

                    // Llamo al método Alta en la capa de negocios

                    bool altaExitosa = new CN_Usuario().Alta(usuario, out mensaje);


                    if (altaExitosa)
                    {
                        MessageBox.Show("El usuario fue dado de alta nuevamente");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, El usuario ya fue dado de alta anterriormente");
                }



            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método para buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ComboBoxOpc)cboBusqueda.SelectedItem).Valor.ToString();
            if (dataGridUsuario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridUsuario.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.  //trim: espacion al final o al inicio
                        Text.Trim().ToUpper()))                                                          //toupper: convertir en mayuscula
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        //Metodo para limpiar el datagrid,despues de la busqueda
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dataGridUsuario.Rows)
            {
                row.Visible = true;
            }
        }

        private void dataGridUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;   // si se encuentra en la primer columna que no devuelva nada
            }

            if (e.ColumnIndex == dataGridUsuario.Columns["btnSeleccionar"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Verifica si esta celda es la que está seleccionada
                if (e.RowIndex == filaSeleccionada)
                {
                    var w = Properties.Resources.checkbox_ckeck_icon_143039.Width; //obtengo el ancho de mi icono
                    var h = Properties.Resources.checkbox_ckeck_icon_143039.Height; //obtengo el alto de mi icono

                    //posicionamiento de la imagen
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2; //pone nuestra imagen en el medio (eje x)
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2; // pone nuestra imagen en el medio del eje y

                    // Establece la imagen en el botón
                    e.Graphics.DrawImage(Properties.Resources.checkbox_ckeck_icon_143039, new Rectangle(x, y, w, h));
                }

                e.Handled = true;
            }
            else if (e.ColumnIndex >= 0 && this.dataGridUsuario.Columns[e.ColumnIndex].Name == "Baja" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Personalizar la apariencia del botón "Baja" con una imagen
                var w = Properties.Resources.cruz_pequena.Width; // Obtener el ancho de tu icono
                var h = Properties.Resources.cruz_pequena.Height; // Obtener el alto de tu icono

                // Posicionamiento de la imagen en el centro de la celda del botón "Baja"
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2; // Poner la imagen en el centro (eje x)
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2; // Poner la imagen en el centro del eje y

                // Dibujar la imagen en la celda del botón "Baja"
                e.Graphics.DrawImage(Properties.Resources.cruz_pequena, new Rectangle(x, y, w, h));

                e.Handled = true;
            }
            else if (e.ColumnIndex >= 0 && this.dataGridUsuario.Columns[e.ColumnIndex].Name == "Alta" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Personalizar la apariencia del botón "Alta" con una imagen
                var w = Properties.Resources.alta.Width; // Obtener el ancho de tu icono
                var h = Properties.Resources.alta.Height; // Obtener el alto de tu icono

                // Posicionamiento de la imagen en el centro de la celda del botón "Alta"
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2; // Poner la imagen en el centro (eje x)
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2; // Poner la imagen en el centro del eje y

                // Dibujar la imagen en la celda del botón "Alta"
                e.Graphics.DrawImage(Properties.Resources.alta, new Rectangle(x, y, w, h));

                e.Handled = true;
            }
        }

        private void dataGridUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridUsuario.Rows[e.RowIndex];

                if (e.ColumnIndex >= 0)
                {
                    if (dataGridUsuario.Columns[e.ColumnIndex].Name == "Baja")
                    {
                        string estadoUsu = fila.Cells["Estado"].Value.ToString();

                        if (estadoUsu == "Activo")
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                USUARIO usuario = new USUARIO();
                                usuario.idUsuario = Convert.ToInt32(fila.Cells["idUsuario"].Value);

                                string mensaje = string.Empty;

                                // Llamo al método Eliminar en la capa de negocios
                                bool eliminacionExitosa = new CN_Usuario().Eliminar(usuario, out mensaje);

                                if (eliminacionExitosa)
                                {
                                    MessageBox.Show("El usuario fue dado de baja exitosamente");
                                }
                                else
                                {
                                    MessageBox.Show($"Error al dar de baja al usuario: {mensaje}");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario ya fue dado de baja anteriormente");
                        }
                    }
                    else if (dataGridUsuario.Columns[e.ColumnIndex].Name == "Alta")
                    {
                        string estadoCliente = fila.Cells["Estado"].Value.ToString();

                        if (estadoCliente == "No activo")
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea dar de alta este usuario?", "Confirmación de alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                USUARIO usuario = new USUARIO();
                                usuario.idUsuario = Convert.ToInt32(fila.Cells["idUsuario"].Value);

                                string mensaje = string.Empty;

                                // Llamo al método Alta en la capa de negocios
                                bool altaExitosa = new CN_Usuario().Alta(usuario, out mensaje);

                                if (altaExitosa)
                                {
                                    MessageBox.Show("El usuario fue dado de alta nuevamente");
                                }
                                else
                                {
                                    MessageBox.Show($"Error al dar de alta al usuario: {mensaje}");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR, El usuario ya fue dado de alta anteriormente");
                        }
                    }
                }
            }
        }

        private void btnAltausuario_Click(object sender, EventArgs e)
        {
            if (formularioEditarUsuario != null && !formularioEditarUsuario.IsDisposed)
            {
                MessageBox.Show("Debe cerrar el formulario de edición antes de abrir otro formulario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (formularioAltaUsu == null || formularioAltaUsu.IsDisposed)
                {
                    formularioAltaUsu = new Usuarios.AltaUsuario();
                    abrirFormularios(formularioAltaUsu);
                }
                else
                {
                    abrirFormularios(formularioAltaUsu);
                }
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (formularioAltaUsu != null && !formularioAltaUsu.IsDisposed)
            {
                MessageBox.Show("Debe cerrar el formulario de alta antes de abrir otro formulario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (filaSeleccionada >= 0)
                {
                    if (formularioEditarUsuario == null || formularioEditarUsuario.IsDisposed)
                    {
                        formularioEditarUsuario = new Usuarios.EditarUsuario();

                        // Configurar los datos en el formulario de edición
                        formularioEditarUsuario.lblid.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["idUsuario"].Value.ToString();
                        formularioEditarUsuario.TBdni.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["dni"].Value.ToString();
                        formularioEditarUsuario.TBNombree.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["nombre"].Value.ToString();
                        formularioEditarUsuario.TBapellido.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["apellido"].Value.ToString();
                        formularioEditarUsuario.txtTelefono.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["telefono"].Value.ToString();
                        formularioEditarUsuario.txtDomicilio.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["Domicilio"].Value.ToString();
                        formularioEditarUsuario.textCorreo.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["Correo"].Value.ToString();
                        formularioEditarUsuario.TBusuario.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["usuario"].Value.ToString();

                        int index = Convert.ToInt32(dataGridUsuario.Rows[filaSeleccionada].Cells["idRol"].Value);
                        string estadostr = dataGridUsuario.Rows[filaSeleccionada].Cells["Estado"].Value.ToString();

                        formularioEditarUsuario.comboBox1.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
                        formularioEditarUsuario.comboBox1.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });

                        formularioEditarUsuario.comboBox1.DisplayMember = "Texto";
                        formularioEditarUsuario.comboBox1.ValueMember = "Valor";

                        if (estadostr == "Activo")
                        {
                            formularioEditarUsuario.comboBox1.SelectedIndex = 0;
                        }
                        else
                        {
                            formularioEditarUsuario.comboBox1.SelectedIndex = 1;
                        }

                        List<ROL> listaRol = new CN_Rol().Listar();

                        foreach (ROL item in listaRol)
                        {
                            formularioEditarUsuario.CBRol.Items.Add(new ComboBoxOpc() { Valor = item.idRol, Texto = item.descripcion });
                        }

                        formularioEditarUsuario.CBRol.DisplayMember = "Texto";
                        formularioEditarUsuario.CBRol.ValueMember = "Valor";
                        formularioEditarUsuario.CBRol.SelectedIndex = index - 1;
                    }

                    abrirFormularios(formularioEditarUsuario);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            // limpio el dataGridView
            dataGridUsuario.Rows.Clear();


            //traigo los datos de la base nuevamente
            List<USUARIO> listaUsuario = new CN_Usuario().Listar();

            foreach (USUARIO item in listaUsuario)
            {
                dataGridUsuario.Rows.Add(new object[] {"",item.idUsuario,item.documento,item.nombre,item.apellido,item.correo,item.usuario,item.clave,
                item.telefono,
                item.direccion,
                item.estado == true ? "Activo" : "No activo",
                item.oRol.idRol,
                item.oRol.descripcion
            });

                // Actualizo el datagrid
                dataGridUsuario.Refresh();
            }
        }
    }
}



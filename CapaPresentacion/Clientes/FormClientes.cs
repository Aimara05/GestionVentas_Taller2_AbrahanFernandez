
//Formulario de  Clientes
using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormClientes : Form
    {

        private int filaSeleccionada = -1; // variable para mantener el indice de mi fila seleccionada en mi dgv
        private DataGridViewButtonCell botonSeleccionado = null;


        public FormClientes()
        {
            InitializeComponent();
            dataGridClientes.CellFormatting += dataGridClientes_CellFormatting;
        }



        //Métodos para abrir formulario.
        private void abrirFormularios(Form formulario)
        {
            formulario.TopLevel = false; // Importante para evitar que sea un formulario independiente
            formulario.FormBorderStyle = FormBorderStyle.None; // Quita el borde del formulario
            formulario.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño del contenedor

            panelCliente.Controls.Add(formulario); // Agrega el formulario al panel
            panelCliente.Tag = formulario;
            formulario.BringToFront();

            formulario.Show();


        }

        //Método para cuando carga el form
        private void FormClientes_Load(object sender, EventArgs e)
        {


            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Baja";
            dataGridClientes.Columns.Add(btnEliminar);
            btnEliminar.Width =40;
           
            DataGridViewButtonColumn btnAlta = new DataGridViewButtonColumn();
            btnAlta.Name = "Alta";
            dataGridClientes.Columns.Add(btnAlta);
            btnAlta.Width = 40;

            List<CLIENTES> listaCliente = new CN_Cliente().Listar();

            foreach (CLIENTES item in listaCliente)
            {
                dataGridClientes.Rows.Add(new object[] {"",item.idCliente,item.documentoCliente,item.nombreCliente,item.apellidoCliente,item.telefono,
                item.correo,
                item.estado == true ? "Activo" : "No activo",

            });


            }

            //para que mueste en el cbBusqueda la cabecera del datagrid

            foreach (DataGridViewColumn columna in dataGridClientes.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBusqueda.Items.Add((new ComboBoxOpc() { Valor = columna.Name, Texto = columna.HeaderText }));
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

        }

        //Metodo para btn Alta Cliente
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            Clientes.AltaCliente altaCliente = new Clientes.AltaCliente();
            abrirFormularios(altaCliente);
        }

        //Método editar cliente
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                Clientes.EditarCliente editarCliente = new Clientes.EditarCliente();
                editarCliente.label1.Text = dataGridClientes.Rows[filaSeleccionada].Cells["idCliente"].Value.ToString();
                editarCliente.TBdni.Text = dataGridClientes.Rows[filaSeleccionada].Cells["dni"].Value.ToString();
                editarCliente.TBNombree.Text = dataGridClientes.Rows[filaSeleccionada].Cells["nombre"].Value.ToString();
                editarCliente.TBapellido.Text = dataGridClientes.Rows[filaSeleccionada].Cells["apellido"].Value.ToString();
                editarCliente.txtTelefono.Text = dataGridClientes.Rows[filaSeleccionada].Cells["telefono"].Value.ToString();
                editarCliente.txtCorreo.Text = dataGridClientes.Rows[filaSeleccionada].Cells["Correo"].Value.ToString();
                string estadostr = dataGridClientes.Rows[filaSeleccionada].Cells["Estado"].Value.ToString();



                editarCliente.comboBox1.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
                editarCliente.comboBox1.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });

                editarCliente.comboBox1.DisplayMember = "Texto";
                editarCliente.comboBox1.ValueMember = "Valor";

                if (estadostr == "Activo")
                {
                    editarCliente.comboBox1.SelectedIndex = 0;

                }
                else
                {
                    editarCliente.comboBox1.SelectedIndex = 1;
                }


                abrirFormularios(editarCliente);

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
 
        


       
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            // limpio el dataGridView
            dataGridClientes.Rows.Clear();


            //traigo los datos de la base nuevamente
            List<CLIENTES> listaCliente = new CN_Cliente().Listar();

            foreach (CLIENTES item in listaCliente)
            {
                dataGridClientes.Rows.Add(new object[] {"",item.idCliente,item.documentoCliente,item.nombreCliente,item.apellidoCliente,item.telefono,
                item.correo,
                item.estado == true ? "Activo" : "No activo",
            });

                // Actualizo el datagrid
                dataGridClientes.Refresh();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dataGridClientes.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string columnaFiltro = ((ComboBoxOpc)cboBusqueda.SelectedItem).Valor.ToString();
            if (dataGridClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridClientes.Rows)
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

        //Metodo para dar formato a la info del cliente

        private void dataGridClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridClientes.Columns[e.ColumnIndex].Name == "Estado")
            {
                // Verifica si el valor de la celda es "No activo"
                if (e.Value != null && e.Value.ToString() == "No activo")
                {
                    // Establece el color de fondo de toda la fila en rosa
                    dataGridClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;
                }
                else
                {
                    // Restablece el color de fondo predeterminado para otras filas
                    dataGridClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Window;
                }
            }
        }

        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridClientes.Columns["btnSeleccionar"].Index && e.RowIndex >= 0)
            {

                filaSeleccionada = e.RowIndex;

                dataGridClientes.Invalidate(); // Esto dispara el evento CellPainting

            }
        }

        private void dataGridClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;   // si se encuentra en la primer columna que no devuelva nada
            }

            if (e.ColumnIndex == dataGridClientes.Columns["btnSeleccionar"].Index)
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
            else if (e.ColumnIndex >= 0 && this.dataGridClientes.Columns[e.ColumnIndex].Name == "Baja" && e.RowIndex >= 0)
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
            else if (e.ColumnIndex >= 0 && this.dataGridClientes.Columns[e.ColumnIndex].Name == "Alta" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Personalizar la apariencia del botón "Alta" con una imagen
                var w = Properties.Resources.altaClienteUsuario.Width; // Obtener el ancho de tu icono
                var h = Properties.Resources.altaClienteUsuario.Height; // Obtener el alto de tu icono

                // Posicionamiento de la imagen en el centro de la celda del botón "Alta"
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2; // Poner la imagen en el centro (eje x)
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2; // Poner la imagen en el centro del eje y

                // Dibujar la imagen en la celda del botón "Alta"
                e.Graphics.DrawImage(Properties.Resources.altaClienteUsuario, new Rectangle(x, y, w, h));

                e.Handled = true;
            }

        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridClientes.Rows[e.RowIndex];

                if (e.ColumnIndex >= 0)
                {
                    if (dataGridClientes.Columns[e.ColumnIndex].Name == "Baja")
                    {
                        string estadoCliente = fila.Cells["Estado"].Value.ToString();

                        if (estadoCliente == "Activo")
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                CLIENTES cliente = new CLIENTES();
                                cliente.idCliente = Convert.ToInt32(fila.Cells["idCliente"].Value);

                                string mensaje = string.Empty;

                                // Llamo al método Eliminar en la capa de negocios
                                bool eliminacionExitosa = new CN_Cliente().Eliminar(cliente, out mensaje);

                                if (eliminacionExitosa)
                                {
                                    MessageBox.Show("El cliente fue dado de baja exitosamente");
                                }
                                else
                                {
                                    MessageBox.Show($"Error al dar de baja al cliente: {mensaje}");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El cliente ya fue dado de baja anteriormente");
                        }
                    }
                    else if (dataGridClientes.Columns[e.ColumnIndex].Name == "Alta")
                    {
                        string estadoCliente = fila.Cells["Estado"].Value.ToString();

                        if (estadoCliente == "No activo")
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea dar de alta este cliente?", "Confirmación de alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                CLIENTES cliente = new CLIENTES();
                                cliente.idCliente = Convert.ToInt32(fila.Cells["idCliente"].Value);

                                string mensaje = string.Empty;

                                // Llamo al método Alta en la capa de negocios
                                bool altaExitosa = new CN_Cliente().Alta(cliente, out mensaje);

                                if (altaExitosa)
                                {
                                    MessageBox.Show("El cliente fue dado de alta nuevamente");
                                }
                                else
                                {
                                    MessageBox.Show($"Error al dar de alta al cliente: {mensaje}");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR, El cliente ya fue dado de alta anteriormente");
                        }
                    }
                }
            }
        }

       
    }
}

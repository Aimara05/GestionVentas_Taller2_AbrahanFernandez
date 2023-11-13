using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.Prod_Categ;
using CapaPresentacion.Usuarios;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCategorias : Form
    {

        private int filaSeleccionada = -1; // variable para mantener el indice de mi fila seleccionada en mi dgv
        private DataGridViewButtonCell botonSeleccionado = null;

        public FormCategorias()
        {
            InitializeComponent();
            dataGridCateg.CellFormatting += dataGridCateg_CellFormatting;
        }

        //Métodos para abrir formulario.
        private void abrirFormularios(Form formulario)
        {
          
            formulario.TopLevel = false; // Importante para evitar que sea un formulario independiente
           formulario.FormBorderStyle = FormBorderStyle.None; // Quita el borde del formulario
           formulario.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño del contenedor

            panelFormu.Controls.Add(formulario); // Agrega el formulario al panel
            panelFormu.Tag =formulario;
           formulario.BringToFront();

           formulario.Show();

        }



        private void dataGridCateg_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridCateg.Columns[e.ColumnIndex].Name == "Estado")
            {
                // Verifica si el valor de la celda es "No activo"
                if (e.Value != null && e.Value.ToString() == "No activo")
                {
                    // Establece el color de fondo de toda la fila en rosa
                    dataGridCateg.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;
                }
                else
                {
                    // Restablece el color de fondo predeterminado para otras filas
                    dataGridCateg.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Window;
                }
            }
        }
        

        //metodo para cuando carga el form
        private void FormCategorias_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Baja";
            dataGridCateg.Columns.Add(btnEliminar);
            btnEliminar.Width = 40;

            DataGridViewButtonColumn btnAlta = new DataGridViewButtonColumn();
            btnAlta.Name = "Alta";
            dataGridCateg.Columns.Add(btnAlta);
            btnAlta.Width = 40;

            List<CATEGORIAS> listaCategoria = new CN_Categoria().Listar();

            foreach (CATEGORIAS item in listaCategoria)
            {
               dataGridCateg.Rows.Add(new object[] {"",item.idCateg,item.descripcion,
             
                item.estado == true ? "Activo" : "No activo",
               
            });


            }

            //para que mueste en el cbBusqueda la cabecera del datagrid

            foreach (DataGridViewColumn columna in dataGridCateg.Columns)
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

       

        private void btnEditarCateg_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                EditarCateg edit = new EditarCateg();
                edit.lblid.Text = dataGridCateg.Rows[filaSeleccionada].Cells["idCateg"].Value.ToString();
               
                edit.txtDescrip.Text = dataGridCateg.Rows[filaSeleccionada].Cells["descripcion"].Value.ToString();
                
                string estadostr = dataGridCateg.Rows[filaSeleccionada].Cells["Estado"].Value.ToString();



                edit.CBestado.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
                edit.CBestado.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });

                edit.CBestado.DisplayMember = "Texto";
                edit.CBestado.ValueMember = "Valor";

                if (estadostr == "Activo")
                {
                    edit.CBestado.SelectedIndex = 0;

                }
                else
                {
                    edit.CBestado.SelectedIndex = 1;
                }

                abrirFormularios(edit);

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoria antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnBajaCateg_Click(object sender, EventArgs e)
        {


            if (filaSeleccionada >= 0)
            {
                DataGridViewRow fila = dataGridCateg.Rows[filaSeleccionada];
                string estadoCategoria = fila.Cells["Estado"].Value.ToString(); // Obtener el estado del usuario


                if (estadoCategoria == "Activo")
                {
                   CATEGORIAS categorias = new CATEGORIAS();
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    categorias.idCateg = Convert.ToInt32(dataGridCateg.Rows[filaSeleccionada].Cells["idCateg"].Value);

                    string mensaje = string.Empty;

                    // Llamo al método Eliminar en la capa de negocios

                    bool eliminacionExitosa = new CN_Categoria().Eliminar(categorias, out mensaje);

                    if (eliminacionExitosa)
                    {
                        MessageBox.Show("El cliente fue dado de baja");
                    }
                }
                else
                {
                    MessageBox.Show("El cliente ya fue dado de baja anteriormente");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridCateg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridCateg.Columns["btnSeleccionar"].Index && e.RowIndex >= 0)
            {

                filaSeleccionada = e.RowIndex;

                dataGridCateg.Invalidate(); // Esto dispara el evento CellPainting

            }
        }

       

        private void dataGridCateg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;   // si se encuentra en la primer columna que no devuelva nada
            }

            if (e.ColumnIndex == dataGridCateg.Columns["btnSeleccionar"].Index)
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
            else if (e.ColumnIndex >= 0 && this.dataGridCateg.Columns[e.ColumnIndex].Name == "Baja" && e.RowIndex >= 0)
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
            else if (e.ColumnIndex >= 0 && this.dataGridCateg.Columns[e.ColumnIndex].Name == "Alta" && e.RowIndex >= 0)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            // limpio el dataGridView
          dataGridCateg.Rows.Clear();


            //traigo los datos de la base nuevamente
            List<CATEGORIAS> listaCategoria = new CN_Categoria().Listar();

            foreach (CATEGORIAS item in listaCategoria)
            {
              dataGridCateg.Rows.Add(new object[] {"",item.idCateg,item.descripcion,
                
                item.estado == true ? "Activo" : "No activo",
                
            });

                // Actualizo el datagrid
              dataGridCateg.Refresh();
            }
        }

            
             
         

        private void btnRegistrarCateg_Click(object sender, EventArgs e)
        {
            Prod_Categ.AgregarCateg altaCateg = new Prod_Categ.AgregarCateg();
            abrirFormularios(altaCateg);
        }

        private void panelTopCateg_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAltaCategoria_Click_1(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                DataGridViewRow fila = dataGridCateg.Rows[filaSeleccionada];
                string estadoCategorias = fila.Cells["Estado"].Value.ToString();

                if (estadoCategorias == "No activo")
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea dar de alta este usuario?", "Confirmación de alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    CATEGORIAS categorias = new CATEGORIAS();
                    categorias.idCateg = Convert.ToInt32(dataGridCateg.Rows[filaSeleccionada].Cells["idCateg"].Value);

                    string mensaje = string.Empty;

                    // Llamo al método Alta en la capa de negocios

                    bool altaExitosa = new CN_Categoria().Alta(categorias, out mensaje);


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

        private void dataGridCateg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridCateg.Rows[e.RowIndex];

                if (e.ColumnIndex >= 0)
                {
                    if (dataGridCateg.Columns[e.ColumnIndex].Name == "Baja")
                    {
                        string estadoCateg = fila.Cells["Estado"].Value.ToString();

                        if (estadoCateg == "Activo")
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                CATEGORIAS categorias = new CATEGORIAS();
                                categorias.idCateg = Convert.ToInt32(fila.Cells["idCateg"].Value);

                                string mensaje = string.Empty;

                                // Llamo al método Eliminar en la capa de negocios
                                bool eliminacionExitosa = new CN_Categoria().Eliminar(categorias, out mensaje);

                                if (eliminacionExitosa)
                                {
                                    MessageBox.Show("El categorias fue dado de baja exitosamente");
                                }
                                else
                                {
                                    MessageBox.Show($"Error al dar de baja al categorias: {mensaje}");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El categorias ya fue dado de baja anteriormente");
                        }
                    }
                    else if (dataGridCateg.Columns[e.ColumnIndex].Name == "Alta")
                    {
                        string estadoCateg = fila.Cells["Estado"].Value.ToString();

                        if (estadoCateg == "No activo")
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea dar de alta este categorias?", "Confirmación de alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                               CATEGORIAS categorias = new CATEGORIAS();
                                categorias.idCateg = Convert.ToInt32(fila.Cells["idCateg"].Value);

                                string mensaje = string.Empty;

                                // Llamo al método Alta en la capa de negocios
                                bool altaExitosa = new CN_Categoria().Alta(categorias, out mensaje);

                                if (altaExitosa)
                                {
                                    MessageBox.Show("El categorias fue dado de alta nuevamente");
                                }
                                else
                                {
                                    MessageBox.Show($"Error al dar de alta al categorias: {mensaje}");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR, El categorias ya fue dado de alta anteriormente");
                        }
                    }
                }
            }
        }
    }
}

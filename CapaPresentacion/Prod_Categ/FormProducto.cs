using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormProducto : Form
    {

        private int filaSeleccionada = -1; // variable para mantener el indice de mi fila seleccionada en mi dgv
        private DataGridViewButtonCell botonSeleccionado = null;

        public FormProducto()
        {
            InitializeComponent();
           dataGridProd.CellFormatting += dataGridProd_CellFormatting;
        }


        //Métodos para abrir formulario.
        private void abrirFormularios(Form formulario)
        {

            formulario.TopLevel = false; // Importante para evitar que sea un formulario independiente
            formulario.FormBorderStyle = FormBorderStyle.None; // Quita el borde del formulario
            formulario.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño del contenedor

            panelFormu.Controls.Add(formulario); // Agrega el formulario al panel
            panelFormu.Tag = formulario;
            formulario.BringToFront();

            formulario.Show();

        }


        //Metodo para agregar un producto
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            Prod_Categ.AltaProd altaprod = new Prod_Categ.AltaProd();
            abrirFormularios(altaprod);
        }


        //Metodo para editar producto
        private void btnEditarProd_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                Prod_Categ.EditarProd editarprod = new Prod_Categ.EditarProd();
                editarprod.lblidprod.Text = dataGridProd.Rows[filaSeleccionada].Cells["idProd"].Value.ToString();
                editarprod.txtNombre.Text = dataGridProd.Rows[filaSeleccionada].Cells["nombreProd"].Value.ToString();
                editarprod.TBdescr.Text = dataGridProd.Rows[filaSeleccionada].Cells["descripcionProd"].Value.ToString();
                editarprod.txtTalle.Text = dataGridProd.Rows[filaSeleccionada].Cells["talle"].Value.ToString();
                editarprod.txtStock.Text = dataGridProd.Rows[filaSeleccionada].Cells["stock"].Value.ToString();
                editarprod.txtPrecio.Text = dataGridProd.Rows[filaSeleccionada].Cells["precioUni"].Value.ToString();
                editarprod.txtStock.Text = dataGridProd.Rows[filaSeleccionada].Cells["stock"].Value.ToString();
                editarprod.txtStock.Text = dataGridProd.Rows[filaSeleccionada].Cells["stock"].Value.ToString();
                editarprod.txtStock.Text = dataGridProd.Rows[filaSeleccionada].Cells["stock"].Value.ToString();
                int indexMarca = Convert.ToInt32(dataGridProd.Rows[filaSeleccionada].Cells["idMarca"].Value);
                int indexCateg = Convert.ToInt32(dataGridProd.Rows[filaSeleccionada].Cells["idCateg"].Value);
                string estadostr = dataGridProd.Rows[filaSeleccionada].Cells["estado"].Value.ToString();

                editarprod.CBEstado.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
                editarprod.CBEstado.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });


                editarprod.CBEstado.DisplayMember = "Texto";
                editarprod.CBEstado.ValueMember = "Valor";

                if (estadostr == "Activo")
                {
                    editarprod.CBEstado.SelectedIndex = 0;

                }
                else
                {
                    editarprod.CBEstado.SelectedIndex = 1;
                }

                List<MARCAS> listaMarca = new CN_Marca().Listar();

                foreach (MARCAS item in listaMarca)
                {
                    editarprod.CbMarca.Items.Add(new ComboBoxOpc() { Valor = item.idMarca, Texto = item.descripcionMarca });

                }

                editarprod.CbMarca.DisplayMember = "Texto";
                editarprod.CbMarca.ValueMember = "Valor";
                editarprod.CbMarca.SelectedIndex = indexMarca - 1;


                List<CATEGORIAS> listaCategoria = new CN_Categoria().Listar();

                foreach (CATEGORIAS item in listaCategoria)
                {
                    editarprod.CBRol.Items.Add(new ComboBoxOpc() { Valor = item.idCateg, Texto = item.descripcion });

                }

                editarprod.CBRol.DisplayMember = "Texto";
                editarprod.CBRol.ValueMember = "Valor";
                editarprod.CBRol.SelectedIndex = indexCateg - 1;




                abrirFormularios(editarprod);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un productos antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void dataGridProd_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;   // si se encuentra en la primer columna que no devuelva nada
            }

            if (e.ColumnIndex == dataGridProd.Columns["btnSeleccionar"].Index)
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
            else if (e.ColumnIndex >= 0 && this.dataGridProd.Columns[e.ColumnIndex].Name == "Baja" && e.RowIndex >= 0)
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
            else if (e.ColumnIndex >= 0 && this.dataGridProd.Columns[e.ColumnIndex].Name == "Alta" && e.RowIndex >= 0)
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

        private void FormProducto_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Baja";
            dataGridProd.Columns.Add(btnEliminar);
            btnEliminar.Width = 40;

            DataGridViewButtonColumn btnAlta = new DataGridViewButtonColumn();
            btnAlta.Name = "Alta";
            dataGridProd.Columns.Add(btnAlta);
            btnAlta.Width = 40;


            List<PRODUCTOS> listaProducto = new CN_Producto().Listar();

            foreach (PRODUCTOS item in listaProducto)
            {
                dataGridProd.Rows.Add(new object[] {"",item.idProducto,item.nombreProd,item.descripcionProd,item.talle,item.stock,
                    item.estado == true ? "Activo" : "No activo",
                    item.precioUni,
                     item.oCategorias.idCateg,
                item.oCategorias.descripcion,
                item.oMarca.idMarca,
                item.oMarca.descripcionMarca


            });


            }

            //para que mueste en el cbBusqueda la cabecera del datagrid

            foreach (DataGridViewColumn columna in dataGridProd.Columns)
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

        //

        private void dataGridProd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dataGridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridProd.Columns["btnSeleccionar"].Index && e.RowIndex >= 0)
            {

                filaSeleccionada = e.RowIndex;

                dataGridProd.Invalidate(); // Esto dispara el evento CellPainting

            }
        }

        private void dataGridProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =dataGridProd.Rows[e.RowIndex];

                if (e.ColumnIndex >= 0)
                {
                    if (dataGridProd.Columns[e.ColumnIndex].Name == "Baja")
                    {
                        string estadoProducto = fila.Cells["Estado"].Value.ToString();

                        if (estadoProducto == "Activo")
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                PRODUCTOS productos = new PRODUCTOS();
                                productos.idProducto = Convert.ToInt32(fila.Cells["idProd"].Value);

                                string mensaje = string.Empty;

                                // Llamo al método Eliminar en la capa de negocios
                                bool eliminacionExitosa = new CN_Producto().Eliminar(productos, out mensaje);

                                if (eliminacionExitosa)
                                {
                                    MessageBox.Show("El productos fue dado de baja exitosamente");
                                }
                                else
                                {
                                    MessageBox.Show($"Error al dar de baja al productos: {mensaje}");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El productos ya fue dado de baja anteriormente");
                        }
                    }
                    else if (dataGridProd.Columns[e.ColumnIndex].Name == "Alta")
                    {
                        string estadoProducto = fila.Cells["Estado"].Value.ToString();

                        if (estadoProducto == "No activo")
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea dar de alta este productos?", "Confirmación de alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                PRODUCTOS productos = new PRODUCTOS();
                                productos.idProducto = Convert.ToInt32(fila.Cells["idProd"].Value);

                                string mensaje = string.Empty;

                                // Llamo al método Alta en la capa de negocios
                                bool altaExitosa = new CN_Producto().Alta(productos, out mensaje);

                                if (altaExitosa)
                                {
                                    MessageBox.Show("El productos fue dado de alta nuevamente");
                                }
                                else
                                {
                                    MessageBox.Show($"Error al dar de alta al productos: {mensaje}");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR, El productos ya fue dado de alta anteriormente");
                        }
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // limpio el dataGridView
          dataGridProd.Rows.Clear();


            //traigo los datos de la base nuevamente
            List<PRODUCTOS> listaProducto = new CN_Producto().Listar();

            foreach (PRODUCTOS item in listaProducto)
            {
              dataGridProd.Rows.Add(new object[] {"",item.idProducto,item.nombreProd,item.descripcionProd,item.talle,item.stock,
                
                item.estado == true ? "Activo" : "No activo",item.precioUni,
                item.oMarca.idMarca,
                item.oMarca.descripcionMarca,
                                item.oCategorias.idCateg,
                item.oCategorias.descripcion,

            });

                // Actualizo el datagrid
              dataGridProd.Refresh();
            }
        }

        private void dataGridProd_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridProd.Columns[e.ColumnIndex].Name == "estado")
            {
                // Verifica si el valor de la celda es "No activo"
                if (e.Value != null && e.Value.ToString() == "No activo")
                {
                    // Establece el color de fondo de toda la fila en rosa
                    dataGridProd.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;
                }
                else
                {
                    // Restablece el color de fondo predeterminado para otras filas
                    dataGridProd.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Window;
                }
            }
        }
    }
}

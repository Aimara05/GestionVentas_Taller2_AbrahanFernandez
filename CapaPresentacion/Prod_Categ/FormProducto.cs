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
        private Prod_Categ.EditarProd formularioEditarProd;
        private Prod_Categ.AltaProd formularioAltaProd;
        public FormProducto()
        {
            InitializeComponent();
           dataGridProd.CellFormatting += dataGridProd_CellFormatting;
        }

        // Método para abrir formularios
        private void abrirFormulario(Form formulario)
        {
            if (formulario != null && !formulario.IsDisposed)
            {
                formulario.TopLevel = false; // Importante para evitar que sea un formulario independiente
                formulario.FormBorderStyle = FormBorderStyle.None; // Quita el borde del formulario
                formulario.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño del contenedor

                panelFormu.Controls.Add(formulario); // Agrega el formulario al panel
                panelFormu.Tag = formulario;
                formulario.BringToFront();

                formulario.Show();
                formulario.Activate();
            }
            else
            {
                MessageBox.Show("El formulario no está disponible.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*private Prod_Categ.AltaProd formularioAltaProd;
        //Metodo para agregar un producto
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            // Verificar si hay algún formulario de edición abierto
            if (formularioEditarProd != null && !formularioEditarProd.IsDisposed)
            {
                MessageBox.Show("Debe cerrar el formulario abierto antes de abrir otro formulario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (formularioAltaProd == null || formularioAltaProd.IsDisposed)
                {
                    // Si no hay instancia abierta, crea una nueva
                    formularioAltaProd = new Prod_Categ.AltaProd();

                    // Mostrar el formulario de alta
                    abrirFormularios(formularioAltaProd);
                }
                else
                {
                    // Si ya hay una instancia abierta, activarla en lugar de abrir una nueva
                    formularioAltaProd.Activate();
                }
            }
        }
  
        
        private Prod_Categ.EditarProd formularioEditarProd;

        private void btnEditarProd_Click(object sender, EventArgs e)
        {
            // Verificar si hay algún formulario de alta abierto
            if (formularioAltaProd != null && !formularioAltaProd.IsDisposed)
            {
                MessageBox.Show("Debe cerrar el formulario de alta antes de abrir otro formulario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (formularioEditarProd == null || formularioEditarProd.IsDisposed)
                {
                    // Si no hay instancia abierta, crea una nueva
                    formularioEditarProd = new Prod_Categ.EditarProd();
                }
                else
                {

                    if (filaSeleccionada >= 0)
                    {
                        formularioEditarProd.lblidprod.Text = dataGridProd.Rows[filaSeleccionada].Cells["idProd"].Value.ToString();
                        formularioEditarProd.txtNombre.Text = dataGridProd.Rows[filaSeleccionada].Cells["nombreProd"].Value.ToString();
                        formularioEditarProd.TBdescr.Text = dataGridProd.Rows[filaSeleccionada].Cells["descripcionProd"].Value.ToString();
                        formularioEditarProd.txtTalle.Text = dataGridProd.Rows[filaSeleccionada].Cells["talle"].Value.ToString();
                        formularioEditarProd.txtStock.Text = dataGridProd.Rows[filaSeleccionada].Cells["stock"].Value.ToString();
                        formularioEditarProd.txtPrecio.Text = dataGridProd.Rows[filaSeleccionada].Cells["precioUni"].Value.ToString();

                        int indexMarca = Convert.ToInt32(dataGridProd.Rows[filaSeleccionada].Cells["idMarca"].Value);
                        int indexCateg = Convert.ToInt32(dataGridProd.Rows[filaSeleccionada].Cells["idCateg"].Value);
                        string estadostr = dataGridProd.Rows[filaSeleccionada].Cells["estado"].Value.ToString();

                        formularioEditarProd.CBEstado.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
                        formularioEditarProd.CBEstado.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });

                        formularioEditarProd.CBEstado.DisplayMember = "Texto";
                        formularioEditarProd.CBEstado.ValueMember = "Valor";

                        if (estadostr == "Activo")
                        {
                            formularioEditarProd.CBEstado.SelectedIndex = 0;
                        }
                        else
                        {
                            formularioEditarProd.CBEstado.SelectedIndex = 1;
                        }

                        List<MARCAS> listaMarca = new CN_Marca().Listar();
                        formularioEditarProd.CbMarca.Items.Clear();

                        foreach (MARCAS item in listaMarca)
                        {
                            formularioEditarProd.CbMarca.Items.Add(new ComboBoxOpc() { Valor = item.idMarca, Texto = item.descripcionMarca });
                        }

                        formularioEditarProd.CbMarca.DisplayMember = "Texto";
                        formularioEditarProd.CbMarca.ValueMember = "Valor";
                        formularioEditarProd.CbMarca.SelectedIndex = indexMarca - 1;

                        List<CATEGORIAS> listaCategoria = new CN_Categoria().Listar();
                        formularioEditarProd.CBRol.Items.Clear();

                        foreach (CATEGORIAS item in listaCategoria)
                        {
                            formularioEditarProd.CBRol.Items.Add(new ComboBoxOpc() { Valor = item.idCateg, Texto = item.descripcion });
                        }

                        formularioEditarProd.CBRol.DisplayMember = "Texto";
                        formularioEditarProd.CBRol.ValueMember = "Valor";
                        formularioEditarProd.CBRol.SelectedIndex = indexCateg - 1;

                        abrirFormularios(formularioEditarProd);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un producto antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

*/
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
                var w = Properties.Resources.altaProducto.Width; // Obtener el ancho de tu icono
                var h = Properties.Resources.altaProducto.Height; // Obtener el alto de tu icono

                // Posicionamiento de la imagen en el centro de la celda del botón "Alta"
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2; // Poner la imagen en el centro (eje x)
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2; // Poner la imagen en el centro del eje y

                // Dibujar la imagen en la celda del botón "Alta"
                e.Graphics.DrawImage(Properties.Resources.altaProducto, new Rectangle(x, y, w, h));

                e.Handled = true;
            }
        }


        //Método para cuando carge el formulario.
        public void FormProducto_Load(object sender, EventArgs e)
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
                if (columna.Visible == true && columna.Name != "btnSeleccionar"
                    && columna.Name != "btnSeleccionar"
                    && columna.Name != "Baja" && columna.Name != "Alta")
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


//Metodo para limpiar el datagrid de la busqueda
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dataGridProd.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnEditarProd_Click(object sender, EventArgs e)
        {

            if (formularioAltaProd != null && !formularioAltaProd.IsDisposed)
            {
                MessageBox.Show("Debe cerrar el formulario de alta antes de abrir otro formulario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (filaSeleccionada >= 0)
                {
                    if (formularioEditarProd == null || formularioEditarProd.IsDisposed)
                    {
                        formularioEditarProd = new Prod_Categ.EditarProd();

                        // Configurar los datos en el formulario de edición
                        formularioEditarProd.lblidprod.Text = dataGridProd.Rows[filaSeleccionada].Cells["idProd"].Value.ToString();
                        formularioEditarProd.txtNombre.Text = dataGridProd.Rows[filaSeleccionada].Cells["nombreProd"].Value.ToString();
                        formularioEditarProd.TBdescr.Text = dataGridProd.Rows[filaSeleccionada].Cells["descripcionProd"].Value.ToString();
                        formularioEditarProd.txtTalle.Text = dataGridProd.Rows[filaSeleccionada].Cells["talle"].Value.ToString();
                        formularioEditarProd.txtStock.Text = dataGridProd.Rows[filaSeleccionada].Cells["stock"].Value.ToString();
                        formularioEditarProd.txtPrecio.Text = dataGridProd.Rows[filaSeleccionada].Cells["precioUni"].Value.ToString();

                        int indexMarca = Convert.ToInt32(dataGridProd.Rows[filaSeleccionada].Cells["idMarca"].Value);
                        int indexCateg = Convert.ToInt32(dataGridProd.Rows[filaSeleccionada].Cells["idCateg"].Value);
                        string estadostr = dataGridProd.Rows[filaSeleccionada].Cells["estado"].Value.ToString();

                        formularioEditarProd.CBEstado.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
                        formularioEditarProd.CBEstado.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });

                        formularioEditarProd.CBEstado.DisplayMember = "Texto";
                        formularioEditarProd.CBEstado.ValueMember = "Valor";

                        if (estadostr == "Activo")
                        {
                            formularioEditarProd.CBEstado.SelectedIndex = 0;
                        }
                        else
                        {
                            formularioEditarProd.CBEstado.SelectedIndex = 1;
                        }

                        List<MARCAS> listaMarca = new CN_Marca().Listar();
                        formularioEditarProd.CbMarca.Items.Clear();

                        foreach (MARCAS item in listaMarca)
                        {
                            formularioEditarProd.CbMarca.Items.Add(new ComboBoxOpc() { Valor = item.idMarca, Texto = item.descripcionMarca });
                        }

                        formularioEditarProd.CbMarca.DisplayMember = "Texto";
                        formularioEditarProd.CbMarca.ValueMember = "Valor";
                        formularioEditarProd.CbMarca.SelectedIndex = indexMarca - 1;

                        List<CATEGORIAS> listaCategoria = new CN_Categoria().Listar();
                        formularioEditarProd.CBRol.Items.Clear();

                        foreach (CATEGORIAS item in listaCategoria)
                        {
                            formularioEditarProd.CBRol.Items.Add(new ComboBoxOpc() { Valor = item.idCateg, Texto = item.descripcion });
                        }

                        formularioEditarProd.CBRol.DisplayMember = "Texto";
                        formularioEditarProd.CBRol.ValueMember = "Valor";
                        formularioEditarProd.CBRol.SelectedIndex = indexCateg - 1;

                        abrirFormulario(formularioEditarProd);
                    }
                    else
                    {
                        abrirFormulario(formularioEditarProd);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (formularioEditarProd != null && !formularioEditarProd.IsDisposed)
            {
                MessageBox.Show("Debe cerrar el formulario de edición antes de abrir otro formulario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (formularioAltaProd == null || formularioAltaProd.IsDisposed)
                {
                    formularioAltaProd = new Prod_Categ.AltaProd();
                    abrirFormulario(formularioAltaProd);
                }
                else
                {
                    abrirFormulario(formularioAltaProd);
                }
            }
        }

        private void lblTituloCli_Click(object sender, EventArgs e)
        {

        }
    }
    }


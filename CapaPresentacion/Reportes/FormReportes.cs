using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using ClosedXML.Excel.Drawings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System.IO;
using System.Linq;
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class FormReportes : Form
    {
        private ReportesGraficos reportesGraficosForm;
        public FormReportes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       /* private void FormReportes_Load(object sender, EventArgs e)
        {
            foreach(DataGridViewColumn columna in dataGridReportes.Columns)
            {
                cboBusqueda.Items.Add(new ComboBoxOpc() {  Valor = columna.Name, Texto = columna.HeaderText });
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;
        }
       */
        private void Btnbuscarfecha_Click(object sender, EventArgs e)
        {
            List<REPORTEVENTA> lista = new List<REPORTEVENTA>();

            // Obtener datos desde la capa de negocios
            lista = new CN_Reporte().Venta(Dfechainicio.Value.ToString(), Dfechafin.Value.ToString());

            dataGridReportes.Rows.Clear();

            if (lista.Count == 0)
            {

                MessageBox.Show("No se encontraron ventas en las fechas seleccionadas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Agregar filas al DataGridView solo si la lista no está vacía
                foreach (REPORTEVENTA rv in lista)
                {
                    dataGridReportes.Rows.Add(new object[] {
                rv.FechaRegistro,
                rv.codigoFactura,
                rv.montoTotal,
                rv.TipoPago,
                rv.UsuarioNombre,
                rv.UsuarioApellido,
                rv.DniUsuario,
                rv.nombreCliente,
                rv.apellidoCliente,
                rv.documentoCliente,
            });
                }
            }
        }
   

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataGridReportes.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dataGridReportes.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dataGridReportes.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[] {
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                    row.Cells[6].Value.ToString(),
                    row.Cells[7].Value.ToString(),
                    row.Cells[8].Value.ToString(),
                    row.Cells[9].Value.ToString(),

                });
                    }
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            
            /*if (dataGridReportes.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dataGridReportes.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dataGridReportes.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[] {
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                    row.Cells[6].Value.ToString(),
                    row.Cells[7].Value.ToString(),
                    row.Cells[8].Value.ToString(),
                    row.Cells[9].Value.ToString(),
                    row.Cells[10].Value.ToString(),
                    row.Cells[11].Value.ToString(),
                    row.Cells[12].Value.ToString(),
                    row.Cells[13].Value.ToString(),
                    row.Cells[14].Value.ToString(),
                    row.Cells[15].Value.ToString(),
                    row.Cells[16].Value.ToString(),
                });
                    }
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var package = new ExcelPackage())
                        {
                            var hoja = package.Workbook.Worksheets.Add("Informe");
                            hoja.Cells.LoadFromDataTable(dt, true);

                            // Obtener los productos más vendidos
                            var productosMasVendidos = dt.AsEnumerable()
                                .GroupBy(r => r.Field<string>("NombreProducto"))
                                .Select(g => new { Producto = g.Key, Cantidad = g.Count() })
                                .OrderByDescending(p => p.Cantidad)
                                .Take(10);

                            // Obtener los vendedores más vendedores
                            var vendedoresMasVendedores = dt.AsEnumerable()
                                .GroupBy(r => $"{r.Field<string>("NombreUsuario")} {r.Field<string>("ApellidoUsuario")}")
                                .Select(g => new { Vendedor = g.Key, Cantidad = g.Count() })
                                .OrderByDescending(v => v.Cantidad)
                                .Take(10);

                            // Add a bar chart of the most sold products
                            var chartProductos = hoja.Drawings.AddChart("ProductosMasVendidos", eChartType.ColumnClustered);
                            chartProductos.Series.Add(hoja.Cells["B2:B" + (productosMasVendidos.Count() + 1)], hoja.Cells["A2:A" + (productosMasVendidos.Count() + 1)]);

                            // Add a bar chart of the top selling seller
                            var chartVendedores = hoja.Drawings.AddChart("VendedoresMasVendedores", eChartType.ColumnClustered);
                            chartVendedores.Series.Add(hoja.Cells["D2:D" + (vendedoresMasVendedores.Count() + 1)], hoja.Cells["C2:C" + (vendedoresMasVendedores.Count() + 1)]);

                            // Add a title to the product bar chart
                            chartProductos.Title.Text = "Productos más vendidos";

                            // Add labels to the product bar chart axes
                            chartProductos.XAxis.Title.Text = "Producto";
                            chartProductos.YAxis.Title.Text = "Cantidad vendida";

                            // Add a title to the seller bar chart
                            chartVendedores.Title.Text = "Vendedores más vendedores";

                            // Add labels to the seller bar chart axes
                            chartVendedores.XAxis.Title.Text = "Vendedor";
                            chartVendedores.YAxis.Title.Text = "Cantidad de ventas";

                            package.SaveAs(new FileInfo(saveFile.FileName));
                            MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar reporte: {ex.Message}\n{ex.StackTrace}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }*/


        }

        private void BtnGraficos_Click(object sender, EventArgs e)
        {
            if(reportesGraficosForm == null || reportesGraficosForm.IsDisposed)
            {
                reportesGraficosForm = new ReportesGraficos();
                abrirFormulario(reportesGraficosForm);
            }
            else
            {
                abrirFormulario(reportesGraficosForm);
            }
  

            // Mostrar el formulario como no modal (puedes interactuar con otros formularios mientras está abierto)
            
        }

        private void dataGridReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el evento se generó en la columna del botón y en una fila válida
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridReportes.Columns["btndetalles"].Index)
            {
                // Obtén el valor de la celda que contiene el código de factura
                string codigoFactura = dataGridReportes.Rows[e.RowIndex].Cells["codigoFactura"].Value.ToString();


                MostrarDetallesVenta(codigoFactura);
            }
        }

        private void MostrarDetallesVenta(string codigoFactura)
        {
    
            VENTAS oVenta = new CN_Ventas().ObtenerVenta(codigoFactura);

            if (oVenta.idVenta != 0)
            {

                dataGridDetalles.Rows.Clear();


                foreach (VENTADETALLE dv in oVenta.oDetalle_Venta)
                {
                    dataGridDetalles.Rows.Add(new object[] {
                dv.oProducto.nombreProd,
                dv.precioVenta,
                dv.cantidad,
                dv.subtotal
            });
                }
            }
            else
            {
                MessageBox.Show("No se encontró ninguna venta");
            }
        }

        private void dataGridReportes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 10)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.paraArticulos.Width;
                var h = Properties.Resources.paraArticulos.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.paraArticulos, new System.Drawing.Rectangle(x, y, w, h));

                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ComboBoxOpc)cboBusqueda.SelectedItem).Valor.ToString();

            if (dataGridReportes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridReportes.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dataGridReportes.Rows)
            {
                row.Visible = true;
            }
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columna in dataGridReportes.Columns)
            {
                if (columna.Visible == true && columna.Name != "btndetalles"
                   && columna.Name != "Baja" && columna.Name != "Alta")
                {
                    cboBusqueda.Items.Add(new ComboBoxOpc() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
        
                cboBusqueda.DisplayMember = "Texto";
                cboBusqueda.ValueMember = "Valor";
                cboBusqueda.SelectedIndex = 0;
            }

        private void abrirFormulario(Form formulario)
        {
            if (formulario != null && !formulario.IsDisposed)
            {
                formulario.TopLevel = false; // Importante para evitar que sea un formulario independiente
                formulario.FormBorderStyle = FormBorderStyle.None; // Quita el borde del formulario
                formulario.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño del contenedor

                panelContenedor.Controls.Add(formulario); // Agrega el formulario al panel
                panelContenedor.Tag = formulario;
                formulario.BringToFront();

                formulario.Show();
                formulario.Activate();
            }
            else
            {
                MessageBox.Show("El formulario no está disponible.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }


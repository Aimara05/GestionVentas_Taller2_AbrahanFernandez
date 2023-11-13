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

        private void FormReportes_Load(object sender, EventArgs e)
        {
            foreach(DataGridViewColumn columna in dataGridReportes.Columns)
            {
                cboBusqueda.Items.Add(new ComboBoxOpc() {  Valor = columna.Name, Texto = columna.HeaderText });
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;
        }

        private void Btnbuscarfecha_Click(object sender, EventArgs e)
        {
            List<REPORTEVENTA> lista = new List<REPORTEVENTA>();

            lista = new CN_Reporte().Venta(Dfechainicio.Value.ToString(), Dfechafin.Value.ToString());

            dataGridReportes.Rows.Clear();

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
                rv.idProducto,
                rv.NombreProducto,
                rv.Categoria,
                rv.Marca,
                rv.precioVenta,
                rv.cantidad,
                rv.subtotal
        });

            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ComboBoxOpc)cboBusqueda.SelectedItem).Valor.ToString();

            if(dataGridReportes.Rows.Count > 0 )
            {
                foreach(DataGridViewRow row in dataGridReportes.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void Btnlimp_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach(DataGridViewRow row in dataGridReportes.Rows )
            {
                row.Visible = true;
            }
        }

        private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

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
            }





            /*
             
 
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

            } */
        }

        private void BtnGraficos_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ReportesGraficos
            ReportesGraficos reportesGraficosForm = new ReportesGraficos();

            // Mostrar el formulario como no modal (puedes interactuar con otros formularios mientras está abierto)
            reportesGraficosForm.Show();
        }
    }
}

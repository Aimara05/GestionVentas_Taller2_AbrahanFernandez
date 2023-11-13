using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion.Reportes
{
    public partial class ReportesGraficos : Form
    {
        public ReportesGraficos()
        {
            InitializeComponent();
        }

        private void btnGenerarGraficos_Click(object sender, EventArgs e)
        {
            // Obtener las fechas seleccionadas en los DateTimePicker
            string fechaInicio = Dfechainicio2.Value.ToString("yyyy-MM-dd");
            string fechaFin = Dfechafin2.Value.ToString("yyyy-MM-dd");

            try
            {
                // Obtener los datos desde la capa de negocios
                DataTable datos = new CN_Reporte().ObtenerProductosMasVendidos(fechaInicio, fechaFin);

                // Verificar la cantidad de filas en el DataTable
                Console.WriteLine("Filas en DataTable: " + datos.Rows.Count);

                // Limpiar el gráfico antes de agregar nuevos datos
                grafico1.Series.Clear();
                grafico1.ChartAreas[0].AxisX.Title = "Productos";
                grafico1.ChartAreas[0].AxisY.Title = "Cantidad Vendida";

                // Crear una nueva serie para el gráfico
                var serie = grafico1.Series.Add("Cantidad Vendida");
                serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                // Agregar datos al gráfico
                foreach (DataRow fila in datos.Rows)
                {
                    string nombreProducto = fila["nombreProd"].ToString();
                    int cantidadVendida = Convert.ToInt32(fila["CantidadVendida"]);

                    // Agregar punto de datos a la serie del gráfico
                    serie.Points.AddXY(nombreProducto, cantidadVendida);
                }

                // Ajustar la escala del eje Y
                grafico1.ChartAreas[0].RecalculateAxesScale();
            }
            catch (Exception ex)
            {
                // Manejar errores e imprimir mensajes en la consola y en un MessageBox
                Console.WriteLine("Error al obtener datos: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);

                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnprodmontos_Click(object sender, EventArgs e)
        {
            // Obtener las fechas seleccionadas en los DateTimePicker
            string fechaInicio = Dfechainicio2.Value.ToString("yyyy-MM-dd");
            string fechaFin = Dfechafin2.Value.ToString("yyyy-MM-dd");

            try
            {
                // Obtener los datos desde la capa de negocios
                DataTable datos = new CN_Reporte().ObtenerMontosProdTotales(fechaInicio, fechaFin);

                // Verificar la cantidad de filas en el DataTable
                Console.WriteLine("Filas en DataTable: " + datos.Rows.Count);

                // Limpiar el gráfico antes de agregar nuevos datos
                grafico1.Series.Clear();
                grafico1.ChartAreas[0].AxisX.Title = "Productos";
                grafico1.ChartAreas[0].AxisY.Title = "Monto Total Recaudado en $Pesos";

                // Crear una nueva serie para el gráfico
                var serie = grafico1.Series.Add("Monto Total Recaudado en $Pesos");
                serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                // Agregar datos al gráfico
                foreach (DataRow fila in datos.Rows)
                {
                    string nombreProducto = fila["nombreProd"].ToString();
                    decimal montoTotalRecaudado = Convert.ToDecimal(fila["MontoTotalRecaudado"]);

                    // Agregar punto de datos a la serie del gráfico
                    serie.Points.AddXY(nombreProducto, montoTotalRecaudado);
                }

                // Ajustar la escala del eje Y
                grafico1.ChartAreas[0].RecalculateAxesScale();
            }
            catch (Exception ex)
            {
                // Manejar errores e imprimir mensajes en la consola y en un MessageBox
                Console.WriteLine("Error al obtener datos: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);

                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnvendventas_Click(object sender, EventArgs e)
        {
            // Obtener las fechas seleccionadas en los DateTimePicker
            string fechaInicio = Dfechainicio2.Value.ToString("yyyy-MM-dd");
            string fechaFin = Dfechafin2.Value.ToString("yyyy-MM-dd");

            try
            {
                // Obtener los datos desde la capa de negocios
                DataTable datos = new CN_Reporte().ObtenerVentasPorVendedor(fechaInicio, fechaFin);

                // Verificar la cantidad de filas en el DataTable
                Console.WriteLine("Filas en DataTable: " + datos.Rows.Count);

                // Limpiar el gráfico antes de agregar nuevos datos
                grafico1.Series.Clear();
                grafico1.ChartAreas[0].AxisX.Title = "Vendedor";
                grafico1.ChartAreas[0].AxisY.Title = "Cantidad de Ventas";

                // Crear una nueva serie para el gráfico
                var serie = grafico1.Series.Add("Cantidad de Ventas");
                serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                // Agregar datos al gráfico
                foreach (DataRow fila in datos.Rows)
                {
                    string nombreVendedor = fila["Vendedor"].ToString();
                    int cantidadVentas = Convert.ToInt32(fila["CantidadVentas"]);

                    // Agregar punto de datos a la serie del gráfico
                    serie.Points.AddXY(nombreVendedor, cantidadVentas);
                }

                // Ajustar la escala del eje Y
                grafico1.ChartAreas[0].RecalculateAxesScale();
            }
            catch (Exception ex)
            {
                // Manejar errores e imprimir mensajes en la consola y en un MessageBox
                Console.WriteLine("Error al obtener datos: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);

                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnvendmontos_Click(object sender, EventArgs e)
        {
            // Obtener las fechas seleccionadas en los DateTimePicker
            string fechaInicio = Dfechainicio2.Value.ToString("yyyy-MM-dd");
            string fechaFin = Dfechafin2.Value.ToString("yyyy-MM-dd");

            try
            {
                // Obtener los datos desde la capa de negocios
                DataTable datos = new CN_Reporte().ObtenerMontosPorVendedor(fechaInicio, fechaFin);

                // Verificar la cantidad de filas en el DataTable
                Console.WriteLine("Filas en DataTable: " + datos.Rows.Count);

                // Limpiar el gráfico antes de agregar nuevos datos
                grafico1.Series.Clear();
                grafico1.ChartAreas[0].AxisX.Title = "Vendedor";
                grafico1.ChartAreas[0].AxisY.Title = "Monto Total Generado en $Pesos";

                // Crear una nueva serie para el gráfico
                var serie = grafico1.Series.Add("Monto Total Generado en $Pesos");
                serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                // Agregar datos al gráfico
                foreach (DataRow fila in datos.Rows)
                {
                    string nombreVendedor = fila["Vendedor"].ToString();
                    decimal montoTotalGenerado = Convert.ToDecimal(fila["MontoTotalGenerado"]);

                    // Agregar punto de datos a la serie del gráfico
                    serie.Points.AddXY(nombreVendedor, montoTotalGenerado);
                }

                // Ajustar la escala del eje Y
                grafico1.ChartAreas[0].RecalculateAxesScale();
            }
            catch (Exception ex)
            {
                // Manejar errores e imprimir mensajes en la consola y en un MessageBox
                Console.WriteLine("Error al obtener datos: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);

                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

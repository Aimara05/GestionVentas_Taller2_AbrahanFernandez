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

                // Verificar si el DataTable no está vacío
                if (datos.Rows.Count == 0)
                {
                    // Mostrar un mensaje indicando que no se encontraron datos en las fechas seleccionadas
                    MessageBox.Show("No se encontraron datos en las fechas seleccionadas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Limpiar el gráfico antes de agregar nuevos datos
                    grafico1.Series.Clear();
                    grafico1.ChartAreas[0].AxisX.Title = "Productos";
                    grafico1.ChartAreas[0].AxisY.Title = "Cantidad Vendida";

                    // Crear una nueva serie para el gráfico de barras
                    var serieBarras = grafico1.Series.Add("Cantidad Vendida");
                    serieBarras.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                    // Agregar datos al gráfico de barras
                    foreach (DataRow fila in datos.Rows)
                    {
                        string nombreProducto = fila["nombreProd"].ToString();
                        int cantidadVendida = Convert.ToInt32(fila["CantidadVendida"]);

                        // Agregar punto de datos a la serie del gráfico de barras
                        serieBarras.Points.AddXY(nombreProducto, cantidadVendida);
                    }

                    // Ajustar la escala del eje Y
                    grafico1.ChartAreas[0].RecalculateAxesScale();

                    // Grafico2: Gráfico de torta
                    grafico2.Series.Clear();
                    grafico2.ChartAreas[0].AxisX.Title = "Productos";
                    grafico2.ChartAreas[0].AxisY.Title = "Cantidad Vendida";

                    // Crear una nueva serie para el gráfico de torta
                    var serieTorta = grafico2.Series.Add("Cantidad Vendida");
                    serieTorta.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    // Agregar datos al gráfico de torta
                    foreach (DataRow fila in datos.Rows)
                    {
                        string nombreProducto = fila["nombreProd"].ToString();
                        int cantidadVendida = Convert.ToInt32(fila["CantidadVendida"]);

                        // Agregar punto de datos a la serie del gráfico de torta
                        serieTorta.Points.AddXY(nombreProducto, cantidadVendida);
                    }
                }
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

                // Verificar si el DataTable no está vacío
                if (datos.Rows.Count == 0)
                {
                    // Mostrar un mensaje indicando que no se encontraron datos en las fechas seleccionadas
                    MessageBox.Show("No se encontraron datos en las fechas seleccionadas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Limpiar los gráficos antes de agregar nuevos datos
                    grafico1.Series.Clear();
                    grafico2.Series.Clear();

                    // Grafico1: Gráfico de barras
                    grafico1.ChartAreas[0].AxisX.Title = "Productos";
                    grafico1.ChartAreas[0].AxisY.Title = "Monto Total Recaudado en $Pesos";

                    // Crear una nueva serie para el gráfico de barras
                    var serieBarras = grafico1.Series.Add("Monto Total Recaudado en $Pesos");
                    serieBarras.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                    // Agregar datos al gráfico de barras
                    foreach (DataRow fila in datos.Rows)
                    {
                        string nombreProducto = fila["nombreProd"].ToString();
                        decimal montoTotalRecaudado = Convert.ToDecimal(fila["MontoTotalRecaudado"]);

                        // Agregar punto de datos a la serie del gráfico de barras
                        serieBarras.Points.AddXY(nombreProducto, montoTotalRecaudado);
                    }

                    // Ajustar la escala del eje Y
                    grafico1.ChartAreas[0].RecalculateAxesScale();

                    // Grafico2: Gráfico de torta
                    var serieTorta = grafico2.Series.Add("Monto Total Recaudado en $Pesos");
                    serieTorta.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    // Agregar datos al gráfico de torta
                    foreach (DataRow fila in datos.Rows)
                    {
                        string nombreProducto = fila["nombreProd"].ToString();
                        decimal montoTotalRecaudado = Convert.ToDecimal(fila["MontoTotalRecaudado"]);

                        // Agregar punto de datos a la serie del gráfico de torta
                        serieTorta.Points.AddXY(nombreProducto, montoTotalRecaudado);
                    }
                }
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

                // Verificar si el DataTable no está vacío
                if (datos.Rows.Count == 0)
                {
                    // Mostrar un mensaje indicando que no se encontraron ventas en las fechas seleccionadas
                    MessageBox.Show("No se encontraron ventas en las fechas seleccionadas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Limpiar los gráficos antes de agregar nuevos datos
                    grafico1.Series.Clear();
                    grafico2.Series.Clear();

                    // Grafico1: Gráfico de barras
                    grafico1.ChartAreas[0].AxisX.Title = "Vendedor";
                    grafico1.ChartAreas[0].AxisY.Title = "Cantidad de Ventas";

                    // Crear una nueva serie para el gráfico de barras
                    var serieBarras = grafico1.Series.Add("Cantidad de Ventas");
                    serieBarras.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                    // Agregar datos al gráfico de barras
                    foreach (DataRow fila in datos.Rows)
                    {
                        string nombreVendedor = fila["Vendedor"].ToString();
                        int cantidadVentas = Convert.ToInt32(fila["CantidadVentas"]);

                        // Agregar punto de datos a la serie del gráfico de barras
                        serieBarras.Points.AddXY(nombreVendedor, cantidadVentas);
                    }

                    // Ajustar la escala del eje Y del gráfico de barras
                    grafico1.ChartAreas[0].RecalculateAxesScale();

                    // Grafico2: Gráfico de torta
                    var serieTorta = grafico2.Series.Add("Cantidad de Ventas");
                    serieTorta.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    // Agregar datos al gráfico de torta
                    foreach (DataRow fila in datos.Rows)
                    {
                        string nombreVendedor = fila["Vendedor"].ToString();
                        int cantidadVentas = Convert.ToInt32(fila["CantidadVentas"]);

                        // Agregar punto de datos a la serie del gráfico de torta
                        serieTorta.Points.AddXY(nombreVendedor, cantidadVentas);
                    }
                }
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

                // Verificar si el DataTable no está vacío
                if (datos.Rows.Count == 0)
                {
                    // Mostrar un mensaje indicando que no se encontraron datos en las fechas seleccionadas
                    MessageBox.Show("No se encontraron datos en las fechas seleccionadas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Limpiar los gráficos antes de agregar nuevos datos
                    grafico1.Series.Clear();
                    grafico2.Series.Clear();

                    // Grafico1: Gráfico de barras
                    grafico1.ChartAreas[0].AxisX.Title = "Vendedor";
                    grafico1.ChartAreas[0].AxisY.Title = "Monto Total Generado en $Pesos";

                    // Crear una nueva serie para el gráfico de barras
                    var serieBarras = grafico1.Series.Add("Monto Total Generado en $Pesos");
                    serieBarras.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                    // Diccionario para almacenar nombres de vendedores y evitar duplicados en el gráfico de torta
                    Dictionary<string, bool> nombresVendedoresTorta = new Dictionary<string, bool>();

                    // Grafico2: Gráfico de torta
                    var serieTorta = grafico2.Series.Add("Monto Total Generado en $Pesos");
                    serieTorta.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    // Agregar datos a los gráficos
                    foreach (DataRow fila in datos.Rows)
                    {
                        string nombreVendedor = fila["Vendedor"].ToString();
                        decimal montoTotalGenerado = Convert.ToDecimal(fila["MontoTotalGenerado"]);

                        // Agregar punto de datos a la serie del gráfico de barras
                        serieBarras.Points.AddXY(nombreVendedor, montoTotalGenerado);

                        // Verificar si el nombre del vendedor ya se agregó al gráfico de torta
                        if (!nombresVendedoresTorta.ContainsKey(nombreVendedor))
                        {
                            // Agregar punto de datos a la serie del gráfico de torta
                            serieTorta.Points.AddXY(nombreVendedor, montoTotalGenerado);

                            // Agregar el nombre del vendedor al diccionario
                            nombresVendedoresTorta.Add(nombreVendedor, true);
                        }
                    }

                    // Ajustar la escala del eje Y del gráfico de barras
                    grafico1.ChartAreas[0].RecalculateAxesScale();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores e imprimir mensajes en la consola y en un MessageBox
                Console.WriteLine("Error al obtener datos: " + ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);

                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario de graficos?"
                     , "Confirmar Cancelar",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

using Microsoft.Win32;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace CapaPresentacion.Seguridad
{
    public partial class FormSeguridad : Form
    {
        public FormSeguridad()
        {
            InitializeComponent();
        }

        private void Seguridad_Load(object sender, EventArgs e)
        {
           
               
        }

        //Metodo para el boton guardar del backup
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection oconexion = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=DBInfiniteFenandezAbrahan;Integrated Security=True"))
            {
                oconexion.Open();

                // Crear SaveFileDialog
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    // Establecer la carpeta predeterminada
                    string rutaPredeterminada = @"C:\backup";

                    // Generar el nombre con timestamp
                    string nombreArchivoConTimestamp = GenerarNombreTimestamp();

                    // Establecer el nombre del archivo en el SaveFileDialog
                    saveFileDialog.FileName = nombreArchivoConTimestamp;
                    saveFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
                    saveFileDialog.InitialDirectory = rutaPredeterminada;
                    saveFileDialog.Title = "Guardar respaldo";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener la ruta seleccionada por el usuario
                        string rutaDeRespaldo = saveFileDialog.FileName;

                        using (SqlCommand command = new SqlCommand("BACKUP DATABASE DBInfiniteFenandezAbrahan TO DISK = @ruta", oconexion))
                        {
                            // Configurar el parámetro @ruta con el nuevo nombre del archivo
                            command.Parameters.AddWithValue("@ruta", rutaDeRespaldo);

                            // Asignar la ruta al TextBox en el formulario
                            txtBackup.Text = rutaDeRespaldo;

                            // Ejecutar el comando de respaldo
                            command.ExecuteNonQuery();

                            MessageBox.Show("Respaldo completado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }


        }

        //Metodo para el boton restaurar

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=DBInfiniteFenandezAbrahan;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("USE master; ALTER DATABASE DBInfiniteFenandezAbrahan SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE DBInfiniteFenandezAbrahan FROM DISK = @ruta WITH REPLACE; ALTER DATABASE DBInfiniteFenandezAbrahan SET MULTI_USER;", connection))
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
                    openFileDialog.Title = "Seleccionar respaldo";

                    // Establecer la carpeta predeterminada en el disco C:\backup
                    openFileDialog.InitialDirectory = @"C:\backup";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener la ruta y el nombre de archivo seleccionados por el usuario
                        string rutaDeRespaldo = openFileDialog.FileName;

                        // Asignar el valor al parámetro @ruta
                        command.Parameters.AddWithValue("@ruta", rutaDeRespaldo);

                        // Asignar la ruta al TextBox en el formulario
                        txtRestore.Text = rutaDeRespaldo;

                        // Ejecutar el comando de restauración
                        command.ExecuteNonQuery();

                        MessageBox.Show("Restauración completada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        string GenerarNombreTimestamp()
        {
            // Obtener la fecha y hora actual
            DateTime fechaActual = DateTime.Now;

            // Convertir la fecha y hora a formato yyyyMMddHHmmss
            string timestamp = fechaActual.ToString("yyyyMMddHHmmss");

            // Agregar el prefijo "respaldo-"
            string nombreArchivoConTimestamp = "respaldo-" + timestamp;

            return nombreArchivoConTimestamp;
        }
    }
}

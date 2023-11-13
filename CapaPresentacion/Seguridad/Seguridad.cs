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
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelSegur_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection oconexion = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=DBInfiniteFenandezAbrahan;Integrated Security=True"))
            {
                oconexion.Open();

                using (SqlCommand command = new SqlCommand("BACKUP DATABASE DBInfiniteFenandezAbrahan TO DISK = @ruta", oconexion))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
                    saveFileDialog.Title = "Guardar respaldo";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        command.Parameters.AddWithValue("@ruta", saveFileDialog.FileName);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Respaldo completado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=DBInfiniteFenandezAbrahan;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("USE master; ALTER DATABASE DBInfiniteFenandezAbrahan SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE DBInfiniteFenandezAbrahan FROM DISK = @ruta WITH REPLACE; ALTER DATABASE DBInfiniteFenandezAbrahan SET MULTI_USER;", connection))
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
                    openFileDialog.Title = "Seleccionar respaldo";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener la ruta y el nombre de archivo seleccionados por el usuario
                        string rutaDeRespaldo = openFileDialog.FileName;

                        // Asignar el valor al parámetro @ruta
                        command.Parameters.AddWithValue("@ruta", rutaDeRespaldo);

                        // Ejecutar el comando de restauración
                        command.ExecuteNonQuery();

                        MessageBox.Show("Restauración completada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

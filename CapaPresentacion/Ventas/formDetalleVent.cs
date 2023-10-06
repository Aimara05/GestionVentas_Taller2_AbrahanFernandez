using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Ventas
{
    public partial class formDetalleVent : Form
    {
        public formDetalleVent()
        {
            InitializeComponent();
        }

        private void lblRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void formDetalleVent_Load(object sender, EventArgs e)
        {

        }

        private void lblDni_Click(object sender, EventArgs e)
        {

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDniUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Verificar si no se ha seleccionado ninguna fila en el DataGridView
            if (dataGridVenta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos una fila en el DataGridView antes de imprimir.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // No continúes con la operación si no se ha seleccionado nada.
            }

            
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class modalCantModificar : Form
    {
        public int NuevaCantidad { get; private set; }
        public modalCantModificar()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Asignar el valor del NumericUpDown a la propiedad NuevaCantidad

            NuevaCantidad = (int)numericUpDownModif.Value;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

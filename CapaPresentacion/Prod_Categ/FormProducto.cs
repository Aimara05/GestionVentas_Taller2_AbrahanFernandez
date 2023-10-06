using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }


        //Métodos para abrir formulario.
        private void abrirFormularios(Form formulario)
        {
            formulario.Show();

        }
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            Prod_Categ.AltaProd altaprod = new Prod_Categ.AltaProd();
            abrirFormularios(altaprod);
        }

        private void btnEditarProd_Click(object sender, EventArgs e)
        {
            Prod_Categ.EditarProd editarprod = new Prod_Categ.EditarProd();
            abrirFormularios(editarprod);
        }

        private void dataGridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si no se ha seleccionado ninguna fila en el DataGridView
            if (dataGridUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // No continúes con la operación si no se ha seleccionado nada.
            }
        }

        private void btnAltaProd_Click(object sender, EventArgs e)
        {
            if (dataGridUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // No continúes con la operación si no se ha seleccionado nada.
            }
        }
    }
}

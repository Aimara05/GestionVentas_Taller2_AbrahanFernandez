
//Form editarCategorias
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Prod_Categ
{
    public partial class EditarCateg : Form
    {
        public EditarCateg()
        {
            InitializeComponent();
        }


        //VALIDACIONES
        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
        private void txtDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void picSalir_Click(object sender, EventArgs e)
        {

            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario?"
                   , "Confirmar Cancelar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //metodo cancelar form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario?"
                               , "Confirmar Cancelar",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //metodo salir del form
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(txtCod.Text) || string.IsNullOrWhiteSpace(txtDescrip.Text))
            // para validar valores null y espacios vacíos.
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

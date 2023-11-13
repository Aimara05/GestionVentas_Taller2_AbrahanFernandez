
//Form Editar Cliente
using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Clientes
{
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }


        //Método para cancelar el form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que quiere cancelar editar cliente?"
        , "Confirmar Cancelar",
             MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //VALIDACIONES
        private void TBdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TBNombree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TBapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtén el texto actual en el TextBox, incluyendo el carácter que se está escribiendo.
            string textoActual = txtCorreo.Text + e.KeyChar;

            // Define una expresión regular para validar el formato de correo electrónico.
            string patronCorreo = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            // Comprueba si el texto actual coincide con el patrón de correo electrónico.
            bool formatoValido = Regex.IsMatch(textoActual, patronCorreo);

            // Habilita o deshabilita el botón "Guardar" en función de si el formato es válido.
            BtnGuardar.Enabled = formatoValido;

            // Si el formato no es válido, muestra un mensaje de error.
            if (!formatoValido)
            {
                errorProvider1.SetError(txtCorreo, "El formato de correo electrónico no es válido.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

             
        //Método guardar cliente
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;


            if (string.IsNullOrWhiteSpace(TBdni.Text) || string.IsNullOrWhiteSpace(TBNombree.Text) ||
                string.IsNullOrWhiteSpace(TBapellido.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                 string.IsNullOrWhiteSpace(txtCorreo.Text)
                 || comboBox1.SelectedItem == null)  // para validar valores null y espacios vacíos.
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CLIENTES objcliente = new CLIENTES()
                {
                    idCliente = Convert.ToInt32(label1.Text),
                    documentoCliente = TBdni.Text,
                    nombreCliente = TBNombree.Text,
                    apellidoCliente = TBapellido.Text,
                    telefono = txtTelefono.Text,
                    correo = txtCorreo.Text,
                    estado = Convert.ToInt32(((ComboBoxOpc)comboBox1.SelectedItem).Valor) == 1 ? true : false
                };

                bool idclientegenerado = new CN_Cliente().Editar(objcliente, out mensaje);

                if (idclientegenerado != false)
                {
                    MessageBox.Show("Usuario Modificado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(mensaje);
                }


                this.Close();
            }
        }
         
        //Metodo para cerrar el formulario editar cliente
        private void picCerrar_Click_1(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario de Editar Cliente?"
                                 , "Confirmar Cancelar",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}

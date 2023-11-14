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
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            this.AcceptButton = BtnGuardar;
            CBEstado.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });

            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = -1;
        }

        //VALIDACION
        private void TBdni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
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

  




        //Metodo para cancelar form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que quiere cancelar ?"
         , "Confirmar Cancelar",
              MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

       
        //Metodo para el btn guardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            string mensaje = string.Empty;



            if (string.IsNullOrWhiteSpace(TBdni.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(TBapellido.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                 string.IsNullOrWhiteSpace(txtCorreo.Text) || CBEstado.SelectedItem == null) // para validar valores null y espacios vacíos.
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CLIENTES objcliente = new CLIENTES()
                {
                    documentoCliente = TBdni.Text,
                    nombreCliente = txtNombre.Text,
                    apellidoCliente = TBapellido.Text,
                    telefono = txtTelefono.Text,
                    correo = txtCorreo.Text,
                    estado = Convert.ToInt32(((ComboBoxOpc)CBEstado.SelectedItem).Valor) == 1 ? true : false
                };

                int idclientegenerado = new CN_Cliente().Registrar(objcliente, out mensaje);

                if (idclientegenerado != 0)
                {
                    MessageBox.Show("Cliente registrado de forma exitosa");

                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
        }
      
        //Metodo para el boton cerrar
        private void picCerrar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario de Agregar Cliente?"
                                 , "Confirmar Cancelar",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

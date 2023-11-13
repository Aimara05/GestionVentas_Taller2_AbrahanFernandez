
//Formulario de alta de usuario.

using CapaEntidad;
using CapaNegocios;
using CapaPresentacion;
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
using System.Transactions;
using System.Windows.Forms;



namespace CapaPresentacion.Usuarios
{
    public partial class AltaUsuario : Form
    {

        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void abrirFormularios(Form formulario)
        {
            formulario.Show();
        }

        //Método para cuando carga el form alta

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });

            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = -1;

            List<ROL> listaRol = new CN_Rol().Listar();

            foreach (ROL item in listaRol)
            {
                CBRol.Items.Add(new ComboBoxOpc() { Valor = item.idRol, Texto = item.descripcion });

            }

            CBRol.DisplayMember = "Texto";
            CBRol.ValueMember = "Valor";
            CBRol.SelectedIndex = -1;

        }

        //cerrar formulario
        private void picCerrar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario de alta?"
                     , "Confirmar Cancelar",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //cancelar el alta de usuario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que quiere cancelar el Alta de usuario?"
           , "Confirmar Cancelar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
        //Metodo para el btn Guardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;


            if (string.IsNullOrWhiteSpace(TBdni.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || 
                string.IsNullOrWhiteSpace(TBapellido.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || 
                string.IsNullOrWhiteSpace(txtDomicilio.Text) || string.IsNullOrWhiteSpace(textCorreo.Text)
                || string.IsNullOrWhiteSpace(TBusuario.Text) || string.IsNullOrWhiteSpace(TBcontrasena.Text) || CBRol.SelectedItem==null || CBEstado.SelectedItem==null )// para validar valores null y espacios vacíos.
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(TBcontrasena.Text);
                USUARIO objusuario = new USUARIO()
                {
                    documento = TBdni.Text,
                    nombre = txtNombre.Text,
                    apellido = TBapellido.Text,
                    telefono = txtTelefono.Text,
                    direccion = txtDomicilio.Text,
                    correo = textCorreo.Text,
                    usuario = TBusuario.Text,
                    clave = hashedPassword,
                    oRol = new ROL() { idRol = Convert.ToInt32(((ComboBoxOpc)CBRol.SelectedItem).Valor) },
                    estado = Convert.ToInt32(((ComboBoxOpc)CBEstado.SelectedItem).Valor) == 1 ? true : false
                };

                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    MessageBox.Show("Usuario registrado de forma exitosa");

                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            } 

           

        }


        //Metodos para validar los texBox
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

        private void textCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtén el texto actual en el TextBox, incluyendo el carácter que se está escribiendo.
            string textoActual = textCorreo.Text + e.KeyChar;

            // Define una expresión regular para validar el formato de correo electrónico.
            string patronCorreo = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            // Comprueba si el texto actual coincide con el patrón de correo electrónico.
            bool formatoValido = Regex.IsMatch(textoActual, patronCorreo);

            // Habilita o deshabilita el botón "Guardar" en función de si el formato es válido.
            BtnGuardar.Enabled = formatoValido;

            // Si el formato no es válido, muestra un mensaje de error.
            if (!formatoValido)
            {
                errorProvider1.SetError(textCorreo, "El formato de correo electrónico no es válido.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void TBusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir que el usuario edite el campo de texto.
            if (TBusuario.Text.Length >= 8 && e.KeyChar != '\b') // '\b' representa la tecla de retroceso (Backspace).
            {
                e.Handled = true; // Bloquear la entrada de caracteres adicionales.
            }
        }

        private void TBcontrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir que el usuario edite el campo de texto.
            if (TBcontrasena.Text.Length >= 8 && e.KeyChar != '\b') // '\b' representa la tecla de retroceso (Backspace).
            {
                e.Handled = true; // Bloquear la entrada de caracteres adicionales.
            }
        }

        private void picCerrar_Click_1(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario de Agregar Usuario?"
                     , "Confirmar Cancelar",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TBcontrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBcontrasena_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Permitir que el usuario edite el campo de texto.
            if (TBcontrasena.Text.Length >= 8 && e.KeyChar != '\b') // '\b' representa la tecla de retroceso (Backspace).
            {
                e.Handled = true; // Bloquear la entrada de caracteres adicionales.
            }
        }
    }
}

    


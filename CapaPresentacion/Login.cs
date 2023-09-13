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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void frm_clossing(object sender, FormClosingEventArgs e) //recibe un obj y un evento
        {
            {
                TBUsuario.Clear();
                TBContraseña.Clear();
                this.Show(); //muestra el formulario login que se oculto

            }

        }

        private void BCancelar_Click(object sender, EventArgs e)

        {
            DialogResult ask = MessageBox.Show("Seguro que quiere cancelar el menu de Session?"
           , "Confirmar Cancelar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            string usuario = TBUsuario.Text;
            string contraseña = TBContraseña.Text;

            string usuarioCorrecto = "Aimara05";
            string claveCorrecta = "11223344";

            
            if (string.IsNullOrWhiteSpace(TBUsuario.Text) || string.IsNullOrWhiteSpace(TBContraseña.Text)) // para validar valores null y espacios vacíos.
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                else if (usuario.Length < 5 || contraseña.Length < 5)
                {
                  MessageBox.Show("La longitud minima del usuario y/o contraseña debe ser de cinco caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                    else if (usuario== usuarioCorrecto && contraseña==claveCorrecta)
                    {
                        Inicio form = new Inicio(); //instancia
                        form.Show(); //se muestre el formulario
                        this.Hide();    //que se oculte el login

                        form.FormClosing += frm_clossing; //cuando estamos cerrando el formulario tome el evento
                    }
                        else if (usuario != usuarioCorrecto)
                        {
                            MessageBox.Show("usuario a incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (contraseña != claveCorrecta)
                        {
                            MessageBox.Show("contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
        }

        
    }
}
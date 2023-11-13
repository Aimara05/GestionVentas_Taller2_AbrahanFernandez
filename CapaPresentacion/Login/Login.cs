
//Formulario LOGIN
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;
using CapaEntidad;
using BCrypt.Net;



namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }



        //Método para que finalice la aplicacion
        private void frm_clossing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Clear();
            txtContrasena.Clear();

            if (Application.OpenForms.OfType<Login>().Any()) // Comprueba si el formulario de inicio aún está abierto
            {
                Login loginForm = Application.OpenForms.OfType<Login>().First();
                loginForm.Show(); // Muestra el formulario de inicio
            }
        }


        //Método para el btn "cancelar"
        private void btnCancelar_Click(object sender, EventArgs e)

        {
            DialogResult ask = MessageBox.Show("Seguro que quiere cancelar el Inicio Sesión?"
           , "Confirmar Cancelar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Método para el btn "ingresar"
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<USUARIO> TEST = new CN_Usuario().Listar();
            USUARIO ousuario = new CN_Usuario().Listar().Where(u => u.usuario == txtUsuario.Text).FirstOrDefault(); //expresiones lambda

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text)) // para validar valores null y espacios vacíos.
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ousuario != null) // validar si recibe informacion  la variable osuario
                {
                    string test = BCrypt.Net.BCrypt.EnhancedHashPassword(txtContrasena.Text);
                    bool passwordMatches2 = BCrypt.Net.BCrypt.EnhancedVerify(txtContrasena.Text, test);
                    bool passwordMatches = BCrypt.Net.BCrypt.EnhancedVerify(txtContrasena.Text, ousuario.clave);


                    if (passwordMatches)
                    {
                        if (ousuario.oRol.idRol == 1) // administrador
                        {
                            Inicio form = new Inicio(ousuario); //instancia
                            form.lblUsuario.Text = ousuario.nombre + " " + ousuario.apellido;
                            form.lblRol.Text = ousuario.oRol.descripcion;

                            form.btnUsuarios.Visible = false;
                            form.btnRegistrarVent.Visible = false;
                            form.btnSeguridad.Visible = false;
                            form.btnVentas.Visible = false;

                            form.Show(); //se muestre el formulario

                            this.Hide();    //que se oculte el login

                            form.FormClosing += frm_clossing; //cuando estamos cerrando el formulario tome el evento

                        }
                        else if (ousuario.oRol.idRol == 2) //superAdmin
                        {

                            Inicio form = new Inicio(ousuario);
                            form.lblUsuario.Text = ousuario.nombre + " " + ousuario.apellido;
                            form.lblRol.Text = ousuario.oRol.descripcion;

                            form.btnArticulos.Visible = false;
                            form.btnCategorias.Visible = false;
                            form.btnProductos.Visible = false;
                            form.btnClientes.Visible = false;
                            form.btnVentas.Visible = false;
                            form.btnReportes.Visible = false;
                            form.btnVentas.Visible = false;

                            form.Show(); //se muestre el formulario
                            this.Hide();    //que se oculte el login

                            form.FormClosing += frm_clossing;


                        }
                        else if (ousuario.oRol.idRol == 3) // vendedor
                        {
                            Inicio form = new Inicio(ousuario);
                            form.lblUsuario.Text = ousuario.nombre + " " + ousuario.apellido;
                            form.lblRol.Text = ousuario.oRol.descripcion;

                            form.btnUsuarios.Visible = false;
                            form.btnCategorias.Visible = false;

                            form.btnReportes.Visible = false;
                            form.btnSeguridad.Visible = false;

                            form.Show(); //se muestre el formulario
                            this.Hide();    //que se oculte el login

                            form.FormClosing += frm_clossing;
                        }
                    }
                    



                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos");
                }
            }

            }
     
      
        //Metodo para el boton cerrar
        private void picCerrar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que quiere cancelar el Inicio Sesión?"
         , "Confirmar Cancelar",
              MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Metodo para el boton mi
        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       //validaciones 
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Length > 8)
            {
                // Si la longitud de la contraseña es mayor a 8, truncar a 8 caracteres
                txtContrasena.Text = txtContrasena.Text.Substring(0, 8);
                txtContrasena.SelectionStart = txtContrasena.Text.Length; // Mover el cursor al final
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 8)
            {
                // Si la longitud de la contraseña es mayor a 8, truncar a 8 caracteres
                txtUsuario.Text = txtUsuario.Text.Substring(0, 8);
                txtUsuario.SelectionStart = txtUsuario.Text.Length; // Mover el cursor al final
            }
        }


        //metodo para iniciar session con la tecla enter
        private void txtContrasena_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                List<USUARIO> TEST = new CN_Usuario().Listar();
                USUARIO ousuario = new CN_Usuario().Listar().Where(u => u.usuario == txtUsuario.Text && u.clave == txtContrasena.Text).FirstOrDefault(); //expresiones lambda

                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text)) // para validar valores null y espacios vacíos.
                {
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ousuario != null) // validar si recibe informacion  la variable osuario
                    {
                        if (ousuario.oRol.idRol == 1) // administrador
                        {
                            Inicio form = new Inicio(ousuario); //instancia
                            form.lblUsuario.Text = ousuario.nombre + " " + ousuario.apellido;
                            form.lblRol.Text = ousuario.oRol.descripcion;

                            form.btnUsuarios.Visible = false;
                            form.btnRegistrarVent.Visible = false;
                            form.btnSeguridad.Visible = false;

                            form.Show(); //se muestre el formulario

                            this.Hide();    //que se oculte el login

                            form.FormClosing += frm_clossing; //cuando estamos cerrando el formulario tome el evento

                        }
                        else if (ousuario.oRol.idRol == 2) //superAdmin
                        {

                            Inicio form = new Inicio(ousuario);
                            form.lblUsuario.Text = ousuario.nombre + " " + ousuario.apellido;
                            form.lblRol.Text = ousuario.oRol.descripcion;

                            form.btnArticulos.Visible = false;
                            form.btnCategorias.Visible = false;
                            form.btnProductos.Visible = false;
                            form.btnClientes.Visible = false;
                            form.btnVentas.Visible = false;
                            form.btnReportes.Visible = false;
                            form.btnVentas.Visible = false;

                            form.Show(); //se muestre el formulario
                            this.Hide();    //que se oculte el login

                            form.FormClosing += frm_clossing;


                        }
                        else if (ousuario.oRol.idRol == 3) // vendedor
                        {
                            Inicio form = new Inicio(ousuario);
                            form.lblUsuario.Text = ousuario.nombre + " " + ousuario.apellido;
                            form.lblRol.Text = ousuario.oRol.descripcion;

                            form.btnUsuarios.Visible = false;
                            form.btnCategorias.Visible = false;

                            form.btnReportes.Visible = false;
                            form.btnSeguridad.Visible = false;

                            form.Show(); //se muestre el formulario
                            this.Hide();    //que se oculte el login

                            form.FormClosing += frm_clossing;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña incorrectos");
                    }
                }
            }
        }
    }
}
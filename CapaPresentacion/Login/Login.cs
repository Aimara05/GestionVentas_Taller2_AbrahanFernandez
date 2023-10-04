
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



namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        //Método para 
        private void frm_clossing(object sender, FormClosingEventArgs e) //recibe un obj y un evento
        {
            {
                txtUsuario.Clear();
                txtContrasena.Clear();
                this.Show(); //muestra el formulario login que se oculto
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
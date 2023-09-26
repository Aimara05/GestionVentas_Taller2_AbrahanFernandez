
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

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });

            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = 0;

            List<ROL> listaRol = new CN_Rol().Listar();

            foreach (ROL item in listaRol)
            {
                CBRol.Items.Add(new ComboBoxOpc() { Valor = item.idRol, Texto = item.descripcion });

            }

            CBRol.DisplayMember = "Texto";
            CBRol.ValueMember = "Valor";
            CBRol.SelectedIndex = 0;

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


        //método para la foto del usuario 
        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:";
            openFileDialog1.Filter = "Archivos Imagenes|*.jpg;*.png|Todos los archivos|*.*";
            openFileDialog1.ShowDialog();

            if (!string.IsNullOrWhiteSpace(openFileDialog1.FileName))
            {
                picImagenUsuario.ImageLocation = openFileDialog1.FileName;

                //funciones para ajustar el tamaño de la imagen en el picturebox.
                picImagenUsuario.SizeMode = PictureBoxSizeMode.Zoom;
                picImagenUsuario.SizeMode = PictureBoxSizeMode.StretchImage;

                
            }

        }

        



        

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            USUARIO objusuario = new USUARIO()
            {
                documento = TBdni.Text,
                nombre = txtNombre.Text,
                apellido = TBapellido.Text,
                telefono = txtTelefono.Text,
                direccion = txtDomicilio.Text,
                correo = textBox1.Text,
                usuario = TBusuario.Text,
                clave = TBcontrasena.Text,
                oRol = new ROL() {idRol = Convert.ToInt32(((ComboBoxOpc)CBRol.SelectedItem).Valor)  },
                estado = Convert.ToInt32(((ComboBoxOpc)CBEstado.SelectedItem).Valor) == 1 ? true : false
            };

            int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);
            
            if(idusuariogenerado !=0)
            {
                MessageBox.Show("Usuario registrado de forma exitosa");

            }
            else
            {
                MessageBox.Show(mensaje);
            }
            
            

            

            this.Close();


        }


    }

      
       
 }
    


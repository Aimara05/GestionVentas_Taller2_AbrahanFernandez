using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        //Definición de variables. 
        private static Button menuActivo = null;
        private static Form formActivo = null;
        private static USUARIO usuarioActual;

        public Inicio(USUARIO objUsuario)
        {
            InitializeComponent();
            personalizarDiseño();
            usuarioActual = objUsuario;
        }


        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioActual.usuario; //muestra el usuario logueado en el Inicio
        }


        //Metodos para menú desplegable.
        private void personalizarDiseño()
        {
            panelDesplegableArt.Visible = false;
            panelDesplegableVent.Visible = false;
        }


        private void ocultarSubmenu()
        {
            if (panelDesplegableArt.Visible)
            {
              panelDesplegableArt.Visible = false;
            }
            else if (panelDesplegableVent.Visible)
            {
              panelDesplegableVent.Visible = false;
            }
        }

        private void mostrarSubmenuArt(Panel panelSubMenu)
        {
            if (!panelDesplegableArt.Visible)
            {
                ocultarSubmenu();
                panelDesplegableArt.Visible = true;
            }
            else
            {
                panelDesplegableArt.Visible = false;
            }

        }
        private void mostrarSubmenuVenta(Panel panelSubMenu)
        {
            if (!panelDesplegableVent.Visible)
            {
                ocultarSubmenu();
                panelDesplegableVent.Visible = true;
            }
            else
            {
                panelDesplegableVent.Visible = false;
            }

        }

        //Fín de los metodos de menú desplegable.

        
        //Métodos para los Botones de cerrar, minimizar y maximizar del form Inicio
        private void picCerrar_Click_1(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar session?"
                                 , "Confirmar Cancelar",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            picRestaurar.Visible = false;
            picMaximizar.Visible = true;
        }

        private void picMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picMaximizar.Visible = false;
            picRestaurar.Visible = true;
        }


        //fin de los Métodos para los Botones de cerrar, minimizar y maximizar del form Inicio 



        //Metodos para abrir formulario.

        private void abrirFormularios(Button menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.Silver;

            }
            menu.BackColor = Color.White;

            menuActivo = menu;

            if (formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelContenedorForms.Controls.Add(formulario);
            formulario.Show();


        }


        //Metodo Salir de la áplicación
        private void BSalir_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar session?"
           , "Confirmar Cancelar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Metodo del botón Articulos.

        //Metodo del botón Productos.
        private void BProductos_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new FormProducto());

            ocultarSubmenu();
        }

        //Metodo del botón Categoría.
        private void BCategorias_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new FormCategorias());
            ocultarSubmenu();
        }

        //Metodo del botón Clientes.
        private void BClientes_Click(object sender, EventArgs e)
        {

            FormClientes formClientes = new FormClientes();

              if(usuarioActual.oRol.idRol == 3)
              {
                  formClientes.btnBajaUsuario.Visible = false;
                  formClientes.btnEditarCliente.Visible = false;
              }
              abrirFormularios((Button)sender, formClientes);



        }


        //Metodo del botón usuario.
        private void btnUsuarios_Click(object sender, EventArgs e)
        {

            abrirFormularios((Button)sender, new Usuarios.FormUsu());
        }

        private void btnRegistrarVent_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new FormRegistrarVentas());

            ocultarSubmenu();
        }

        private void btnDetalleVent_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new Ventas.formDetalleVent());
            ocultarSubmenu();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            mostrarSubmenuVenta(panelDesplegableVent);
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            mostrarSubmenuArt(panelDesplegableArt);
        }
















    private void panelContenedorForms_Paint(object sender, PaintEventArgs e)
    {

    }

    }
}
    


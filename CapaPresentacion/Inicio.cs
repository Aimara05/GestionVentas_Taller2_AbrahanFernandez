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
    public partial class Inicio : Form
    {
        //Definición de variables. 
        private static Button menuActivo = null;
        private static Form formActivo = null;

        public Inicio()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        //Funciones para menú desplegable.
        private void personalizarDiseño()
        {
            panelSubMenu.Visible = false;
        }

        private void ocultarSubmenu()
        {
            if (panelSubMenu.Visible)
            {
                panelSubMenu.Visible = false;
            }
        }

        private void mostrarSubmenu(Panel panelSubMenu)
        {
            if (!panelSubMenu.Visible)
            {
                ocultarSubmenu();
                panelSubMenu.Visible = true;
            }
            else
            {
                panelSubMenu.Visible = false;
            }
        }
        //Fín de las funciones de menú desplegable.


        //Función para abrir formulario.
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

            panelContenedorForm.Controls.Add(formulario);
            formulario.Show();


        }


        //Función Salir de la áplicación
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


        //Función del botón usuario.
        private void BUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new FormUsuarios());
        }

        //Función del botón Articulos.

        private void BArticulos_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubMenu);
        }


        //Función del botón Productos.
        private void BProductos_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new FormProducto());

            ocultarSubmenu();
        }

        //Función del botón Categoría.
        private void BCategorias_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new FormCategorias());
            ocultarSubmenu();
        }

        //Función del botón Clientes.
        private void BClientes_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new FormClientes());
        }

        //Función del botón Compras.
        private void BCompras_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new FormCompras());
        }

        //Función del botón Proveedores.
        private void BProveedores_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new FormProveedores());
        }

        //Función del botón Ventas.
        private void BVentas_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new FormVentas());
        }

        //Función del botón Reportes.
        private void BReportes_Click(object sender, EventArgs e)
        {
            abrirFormularios((Button)sender, new FormReportes());
        }

        private void LUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}

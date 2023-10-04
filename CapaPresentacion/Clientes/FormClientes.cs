
//Form Clientes
using CapaPresentacion.Utilidades;
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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        //Métodos para abrir formulario.
        private void abrirFormularios(Form formulario)
        {
            formulario.Show();

        }

        //Método para cuando carga el form
        private void FormClientes_Load(object sender, EventArgs e)
        {
            //para que mueste en el cbBusqueda la cabecera del datagrid

            foreach (DataGridViewColumn columna in dataGridUsuario.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBusqueda.Items.Add((new ComboBoxOpc() { Valor = columna.Name, Texto = columna.HeaderText }));
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

        }

        //Metodo para btn Alta Cliente
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            Clientes.AltaCliente altaCliente = new Clientes.AltaCliente();
            abrirFormularios(altaCliente);
        }

        //Método editar cliente
       private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Clientes.EditarCliente editarCliente = new Clientes.EditarCliente();
            abrirFormularios(editarCliente);
        }


        //Método para buscar clientes
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ComboBoxOpc)cboBusqueda.SelectedItem).Valor.ToString();
            if (dataGridUsuario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridUsuario.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.  //trim: espacion al final o al inicio
                        Text.Trim().ToUpper()))                                                          //toupper: convertir en mayuscula
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        //Metodo para limpiar el datagrid,despues de la busqueda
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dataGridUsuario.Rows)
            {
                row.Visible = true;
            }
        }
    }
}

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

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            Clientes.AltaCliente altaCliente = new Clientes.AltaCliente();
            abrirFormularios(altaCliente);
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Clientes.EditarCliente editarCliente = new Clientes.EditarCliente();
            abrirFormularios(editarCliente);
        }
    }
}

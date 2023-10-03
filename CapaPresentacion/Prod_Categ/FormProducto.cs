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
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }


        //Métodos para abrir formulario.
        private void abrirFormularios(Form formulario)
        {
            formulario.Show();

        }
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            Prod_Categ.AltaProd altaprod = new Prod_Categ.AltaProd();
            abrirFormularios(altaprod);
        }

        private void btnEditarProd_Click(object sender, EventArgs e)
        {
            Prod_Categ.EditarProd editarprod = new Prod_Categ.EditarProd();
            abrirFormularios(editarprod);
        }
    }
}

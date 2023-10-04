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
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        //Métodos para abrir formulario.
        private void abrirFormularios(Form formulario)
        {
            formulario.Show();

        }

        private void btnAltaCateg_Click(object sender, EventArgs e)
        {
            Prod_Categ.AltaCateg altaCateg = new Prod_Categ.AltaCateg();
            abrirFormularios(altaCateg);
        }

        private void btnEditarCateg_Click(object sender, EventArgs e)
        {
            Prod_Categ.EditarCateg editarCateg = new Prod_Categ.EditarCateg();
            abrirFormularios(editarCateg);
        }
    }
}

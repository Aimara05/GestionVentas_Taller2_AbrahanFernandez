using CapaEntidad;
using CapaNegocios;
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

namespace CapaPresentacion.Prod_Categ
{
    public partial class EditarProd : Form
    {
        public EditarProd()
        {
            InitializeComponent();
        }

        //metodo para cancelar form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario de alta?"
                    , "Confirmar Cancelar",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }


      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario de alta?"
                     , "Confirmar Cancelar",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //VALIDACIONES
        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TBdescr_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //metodo del btn guardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(TBdescr.Text) || string.IsNullOrWhiteSpace(txtStock.Text) ||
               string.IsNullOrWhiteSpace(txtPrecio.Text) || CBRol.SelectedItem == null || // Validar ComboBox cbRol
        CBEstado.SelectedItem == null) // para validar valores null y espacios vacíos.
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PRODUCTOS objproducto = new PRODUCTOS() 
                {
                    idProducto = Convert.ToInt32(lblidprod.Text),
                    nombreProd = txtNombre.Text,
                    descripcionProd = TBdescr.Text,
                    talle = txtTalle.Text,
                    stock = Convert.ToInt32(txtStock.Text),
                    precioUni = Convert.ToSingle(txtPrecio.Text),
                    oMarca = new MARCAS()
                    {
                        idMarca = Convert.ToInt32(((ComboBoxOpc)CbMarca.SelectedItem).Valor)
                    },
                    oCategorias = new CATEGORIAS()
                    {
                        idCateg = Convert.ToInt32(((ComboBoxOpc)CBRol.SelectedItem).Valor)
                    },
                    estado = Convert.ToInt32(((ComboBoxOpc)CBEstado.SelectedItem).Valor) == 1 ? true : false


                };

                bool idproductogenerado = new CN_Producto().Editar(objproducto, out mensaje);

                if (idproductogenerado != false)
                {
                    MessageBox.Show("Producto Modificado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(mensaje);
                }


                this.Close();
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarProd_Load(object sender, EventArgs e)
        {

        }
    }
}

using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.Utilidades;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapaPresentacion.Prod_Categ
{
    public partial class AltaProd : Form
    {
        public AltaProd()
        {
            InitializeComponent();
        }


        //Metodo para el botón cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que quiere cancelar el agregar producto?"
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

      //VALIDACIONES

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



        private void picCerrar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario de Agregar Producto?"
                     , "Confirmar Cancelar",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }


     /*   // Método para el botón Imagen 
        private void btnImgProd_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:";
            openFileDialog1.Filter = "Archivos Imagenes|*.jpg;*.png|Todos los archivos|*.*";
            openFileDialog1.ShowDialog();

            if (!string.IsNullOrWhiteSpace(openFileDialog1.FileName))
            {
                picImgProd.ImageLocation = openFileDialog1.FileName;

                //funciones para ajustar el tamaño de la imagen en el picturebox.
                picImgProd.SizeMode = PictureBoxSizeMode.Zoom;
                picImgProd.SizeMode = PictureBoxSizeMode.StretchImage;

                txtImagen.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }*/

        private void AltaProd_Load(object sender, EventArgs e)
        {
            this.AcceptButton = BtnGuardar;
            CBEstado.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
            CBEstado.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });

            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "Valor";
            CBEstado.SelectedIndex = -1;

            List<CATEGORIAS> listaCategoria = new CN_Categoria().Listar();

            foreach (CATEGORIAS item in listaCategoria)
            {
                CBcateg.Items.Add(new ComboBoxOpc() { Valor = item.idCateg, Texto = item.descripcion });

            }

            CBcateg.DisplayMember = "Texto";
            CBcateg.ValueMember = "Valor";
            CBcateg.SelectedIndex = -1;

            List<MARCAS> listaMarca = new CN_Marca().Listar();

            foreach (MARCAS item in listaMarca)
            {
                CBMarca.Items.Add(new ComboBoxOpc() { Valor = item.idMarca, Texto = item.descripcionMarca });

            }

            CBMarca.DisplayMember = "Texto";
            CBMarca.ValueMember = "Valor";
            CBMarca.SelectedIndex = -1;

        }

         private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtDescr.Text) || string.IsNullOrWhiteSpace(txtStock.Text) ||
               string.IsNullOrWhiteSpace(txtPrecio.Text) || CBcateg.SelectedItem == null || CBMarca.SelectedItem == null || // Validar ComboBox cbRol
        CBEstado.SelectedItem == null)
            // para validar valores null y espacios vacíos.
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PRODUCTOS objproducto = new PRODUCTOS()
                {

                    nombreProd = txtNombre.Text,
                    descripcionProd = txtDescr.Text,
                    talle = txtTalle.Text,
                    stock = int.Parse(txtStock.Text),
                    precioUni = double.Parse(txtPrecio.Text),
                    oCategorias = new CATEGORIAS() { idCateg = Convert.ToInt32(((ComboBoxOpc)CBcateg.SelectedItem).Valor) },
                    oMarca = new MARCAS() { idMarca = Convert.ToInt32(((ComboBoxOpc)CBMarca.SelectedItem).Valor) },
                    estado = Convert.ToInt32(((ComboBoxOpc)CBEstado.SelectedItem).Valor) == 1 ? true : false
                };

                int idproductogenerado = new CN_Producto().Registrar(objproducto, out mensaje);

                if (idproductogenerado != 0)
                {
                    MessageBox.Show("Producto registrado de forma exitosa");

                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
        }

      
    }
}


//Form de Agregar Categoria.
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
    public partial class AgregarCateg : Form
    {
        public AgregarCateg()
        {
            InitializeComponent();
        }

        //Método pata el btn guardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(txtDescrip.Text)  || CBestado.SelectedItem == null)
                // para validar valores null y espacios vacíos.
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CATEGORIAS objcategoria = new CATEGORIAS()
                {
                    descripcion = txtDescrip.Text,
                    estado = Convert.ToInt32(((ComboBoxOpc)CBestado.SelectedItem).Valor) == 1 ? true : false
                };

                int idcategoriagenerada = new CN_Categoria().Registrar(objcategoria, out mensaje);

                if (idcategoriagenerada != 0)
                {
                    MessageBox.Show("Categoria agregada de forma exitosa");

                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
        }

        //Método para cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario?"
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

        private void txtDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        //Metodo para salir del form
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario?"
                   , "Confirmar Cancelar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AltaCateg_Load(object sender, EventArgs e)
        {

            CBestado.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
            CBestado.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });

            CBestado.DisplayMember = "Texto";
            CBestado.ValueMember = "Valor";
            CBestado.SelectedIndex = -1;

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario de Agregar Cliente?"
                                 , "Confirmar Cancelar",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}


//Form editarCategorias
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
    public partial class EditarCateg : Form
    {
        public EditarCateg()
        {
            InitializeComponent();
        }


    
        

        private void picSalir_Click(object sender, EventArgs e)
        {

            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario?"
                   , "Confirmar Cancelar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //metodo cancelar form
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
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(txtDescrip.Text)) // para validar valores null y espacios vacíos.
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CATEGORIAS objcategoria = new CATEGORIAS()
                {
                    idCateg = Convert.ToInt32(lblid.Text),
                    descripcion = txtDescrip.Text,
                    
                    estado = Convert.ToInt32(((ComboBoxOpc)CBestado.SelectedItem).Valor) == 1 ? true : false
                };

                bool idcategoriagenerado = new CN_Categoria().Editar(objcategoria, out mensaje);

                if (idcategoriagenerado != false)
                {
                    MessageBox.Show("Categoria Modificado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(mensaje);
                }


                this.Close();
            }
        }

        private void EditarCateg_Load(object sender, EventArgs e)
        {

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Seguro que desea cerrar el formulario de editar categoria?"
                                 , "Confirmar Cancelar",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
    }


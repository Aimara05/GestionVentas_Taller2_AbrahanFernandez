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

namespace CapaPresentacion.Modales
{
    public partial class mdProducto : Form
    {
        public PRODUCTOS _Producto {get;set;} // guardo el producto que voy a seleccionar
        public mdProducto()
        {
            InitializeComponent();
        }

        private void mdProducto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dataGridProd.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBusqueda.Items.Add((new ComboBoxOpc() { Valor = columna.Name, Texto = columna.HeaderText }));
                }
               

            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

            List<PRODUCTOS> listaProducto = new CN_Producto().Listar();

            foreach (PRODUCTOS item in listaProducto)
            {
                if (item.estado)
                {
                    dataGridProd.Rows.Add(new object[] {item.idProducto,item.nombreProd,item.descripcionProd,item.stock,

                    item.precioUni,
            });
                }


            }
        }

        private void dataGridProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            if (iRow >= 0 && iCol >= 0)
            {
                _Producto = new PRODUCTOS()
                {
                    idProducto = Convert.ToInt32(dataGridProd.Rows[iRow].Cells["idProducto"].Value.ToString()),
                    nombreProd = dataGridProd.Rows[iRow].Cells["nombreProd"].Value.ToString(),
                    descripcionProd = dataGridProd.Rows[iRow].Cells["descripcionProd"].Value.ToString(),
                    stock = Convert.ToInt32(dataGridProd.Rows[iRow].Cells["stock"].Value.ToString()),
                    precioUni = float.Parse(dataGridProd.Rows[iRow].Cells["precioUni"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ComboBoxOpc)cboBusqueda.SelectedItem).Valor.ToString();
            if (dataGridProd.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridProd.Rows)
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

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dataGridProd.Rows)
            {
                row.Visible = true;
            }
        }

        //Método para el boton cerrar 
        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}

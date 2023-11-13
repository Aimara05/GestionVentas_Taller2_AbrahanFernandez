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
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdCliente : Form
    {
        public CLIENTES _Cliente { get; set; } // propiedad unica para almacenar el cliente al cual hemos seleccidonado
        public mdCliente()
        {
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dataGridUsuario.Columns)
            {
                cboBusqueda.Items.Add((new ComboBoxOpc() { Valor = columna.Name, Texto = columna.HeaderText }));

            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;


            List<CLIENTES> listaCliente = new CN_Cliente().Listar();

            foreach (CLIENTES item in listaCliente)
            {
                if (item.estado)
                {
                    dataGridUsuario.Rows.Add(new object[] { item.idCliente, item.documentoCliente, item.nombreCliente, item.apellidoCliente, item.correo, item.telefono, item.estado });
                }



            }
        }

        private void dataGridUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            if (iRow >= 0 && iCol >= 0)
            {
                _Cliente = new CLIENTES()
                {
                    idCliente = Convert.ToInt32(dataGridUsuario.Rows[iRow].Cells["idCliente"].Value.ToString()),
                    documentoCliente = dataGridUsuario.Rows[iRow].Cells["documento"].Value.ToString(),
                    nombreCliente = dataGridUsuario.Rows[iRow].Cells["nombre"].Value.ToString(),
                    apellidoCliente = dataGridUsuario.Rows[iRow].Cells["apellido"].Value.ToString(),
                    correo = dataGridUsuario.Rows[iRow].Cells["correo"].Value.ToString(),
                    telefono = dataGridUsuario.Rows[iRow].Cells["telefono"].Value.ToString(),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

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

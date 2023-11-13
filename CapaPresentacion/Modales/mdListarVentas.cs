using CapaEntidad;
using CapaNegocios;

using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace CapaPresentacion.Modales
{
    public partial class mdListarVentas : Form
    {
        public VENTAS _Venta { get;set; }
        private USUARIO _Usuario;
        public mdListarVentas(USUARIO oUsuario=null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void mdListarVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dataGridVenta.Columns)
            {
                cboBusqueda.Items.Add((new ComboBoxOpc() { Valor = columna.Name, Texto = columna.HeaderText }));

            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

            List<VENTAS> listaVenta = new CN_Ventas().Listar(_Usuario);
            
            foreach (VENTAS item in listaVenta)
            {
                dataGridVenta.Rows.Add(new object[] { item.idVenta, item.oUsuario.idUsuario, item.oCliente.idCliente, item.oCliente.nombreCliente, 
                    item.oCliente.apellidoCliente, item.oTipoPago.idTipoPago, item.oTipoPago.descripcion, 
                    item.codigoFactura, item.fechaReg, item.montoTotal, });
            }



        }

        private void dataGridVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            if (iRow >= 0 && iCol >= 0)
            {
                _Venta = new VENTAS()
                {
                    idVenta = Convert.ToInt32(dataGridVenta.Rows[iRow].Cells["idVenta"].Value.ToString()),
                    oUsuario = new USUARIO() { 
                        idUsuario = Convert.ToInt32(dataGridVenta.Rows[iRow].Cells["idUsuario"].Value.ToString()),
                    },
                    oCliente = new CLIENTES()
                    {
                        idCliente = Convert.ToInt32(dataGridVenta.Rows[iRow].Cells["idCliente"].Value.ToString()),
                        nombreCliente = dataGridVenta.Rows[iRow].Cells["nombreCliente"].Value.ToString(),
                        apellidoCliente = dataGridVenta.Rows[iRow].Cells["apellidoCliente"].Value.ToString(),

                    },
                    oTipoPago = new TIPOPAGO()
                    {
                        idTipoPago = Convert.ToInt32(dataGridVenta.Rows[iRow].Cells["idTipoPago"].Value.ToString()),
                        descripcion = dataGridVenta.Rows[iRow].Cells["descripcion"].Value.ToString(),
                    },
                    codigoFactura = dataGridVenta.Rows[iRow].Cells["codigoFactura"].Value.ToString(),
                    fechaReg = dataGridVenta.Rows[iRow].Cells["fechaReg"].Value.ToString(),
                    montoTotal = Convert.ToDecimal(dataGridVenta.Rows[iRow].Cells["montoTotal"].Value.ToString()),

                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ComboBoxOpc)cboBusqueda.SelectedItem).Valor.ToString();
            if (dataGridVenta.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridVenta.Rows)
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
            foreach (DataGridViewRow row in dataGridVenta.Rows)
            {
                row.Visible = true;
            }
        }
    }
}

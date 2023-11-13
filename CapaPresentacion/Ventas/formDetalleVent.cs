using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.Modales;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Ventas
{
    public partial class formDetalleVent : Form
    {
        private USUARIO _Usuario;
        public formDetalleVent(USUARIO oUsuario=null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }


        private void formDetalleVent_Load(object sender, EventArgs e)
        {
            txtcodigoFactura.Select();

        }


        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDniUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtcodigoFactura.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", "Infinite Store");
            Texto_Html = Texto_Html.Replace("@direcnegocio", "Los Cocos 5431");

            Texto_Html = Texto_Html.Replace("@codigoFactura", txtcodigoFactura.Text);

            Texto_Html = Texto_Html.Replace("@doccliente", txtdnicliente.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnomyapecliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfechaventa.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtnomyapeusuario.Text);

            string filas = string.Empty;
            foreach(DataGridViewRow row in dataGridVenta.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txttotal.Text);



            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txtcodigoFactura.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if(savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }

        }

      

        private void bfactura_Click(object sender, EventArgs e)
        {
            

        }

        private void btnLimpiardetalle_Click(object sender, EventArgs e)
        {
            txtcodigoFactura.Text = "";
            txtfechaventa.Text = "";
            txttotal.Text = "";
            txtDniUsu.Text = "";
            txtnomyapeusuario.Text = "";
            txtdnicliente.Text = "";
            txtnomyapecliente.Text = "";
            txtidcliente.Text = "";
            txttelcliente.Text = "";
            txtcorreocliente.Text = "";
            dataGridVenta.Rows.Clear();
        }

        private void txtidcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bbuscarventas_Click(object sender, EventArgs e)
        {
            using (var modal = new mdListarVentas(_Usuario))
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtcodigoFactura.Text = modal._Venta.codigoFactura.ToString();
                }
            }

            VENTAS oVenta = new CN_Ventas().ObtenerVenta(txtcodigoFactura.Text);

            if (oVenta.idVenta != 0)
            {
                //datos venta
                txtcodigoFactura.Text = oVenta.codigoFactura;
                txtfechaventa.Text = oVenta.fechaReg;
                txttotal.Text = oVenta.montoTotal.ToString("0.00");


                //datos usuario
                txtDniUsu.Text = oVenta.oUsuario.documento;
                string nombrecompleto = oVenta.oUsuario.nombre + " " + oVenta.oUsuario.apellido;
                txtnomyapeusuario.Text = nombrecompleto;

                //datos cliente
                txtidcliente.Text = oVenta.oCliente.idCliente.ToString();
                txtdnicliente.Text = oVenta.oCliente.documentoCliente;
                string nombyapecliente = oVenta.oCliente.nombreCliente + " " + oVenta.oCliente.apellidoCliente;
                txtnomyapecliente.Text = nombyapecliente;
                txttelcliente.Text = oVenta.oCliente.telefono;
                txtcorreocliente.Text = oVenta.oCliente.correo;

                //datos datagrid
                dataGridVenta.Rows.Clear();
                foreach (VENTADETALLE dv in oVenta.oDetalle_Venta)
                {
                    dataGridVenta.Rows.Add(new object[] {
                        dv.oProducto.nombreProd,
                        dv.precioVenta,
                        dv.cantidad,
                        dv.subtotal
                    });
                }


            }
            else
            {
                MessageBox.Show("No se encontro ninguna venta");
            }
        }
    }
}

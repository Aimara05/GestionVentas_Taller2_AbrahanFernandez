using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
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

namespace CapaPresentacion
{
    public partial class FormRegistrarVentas : Form
    {
        private USUARIO _Usuario; // en esta variable voy a guardar el usuario que realizo la venta
        public FormRegistrarVentas(USUARIO oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox4.Text) || 
              string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox9.Text) ||
              string.IsNullOrWhiteSpace(numericUpDown1.Text) || string.IsNullOrWhiteSpace(textBox7.Text) ||
              string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown1.Value == 0)
            {

                MessageBox.Show("la cantidad del producto no debe ser cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult ask = MessageBox.Show("Desea agregar un nuevo producto ?"
         , "Confirmar",
              MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {
                    decimal precio = 0;
                    bool producto_existe = false;

                    //valido si se selecciono un producto
                    if (int.Parse(textBox2.Text) == 0)
                    {
                        MessageBox.Show("Debe seleccionar un producto","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                        return;
                    }

                    //valido que el precio ingresado sea un valor correcto
                    if(!decimal.TryParse(textBox5.Text, out precio))
                    {
                        MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox5.Select();
                        return;
                    }

                    //valido que la cantidad no sea mayor al stock
                    if(Convert.ToInt32(textBox9.Text) < Convert.ToInt32(numericUpDown1.Value.ToString()))
                    {
                        MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    //Valido si existe el producto en el datagridView

                    /*foreach(DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (fila.Cells["idProducto"].Value.ToString() == textBox2.Text) // aca consulto si el producto que estoy intentando agregar ya existe en el datagrid view
                        {
                            producto_existe = true;
                            break;
                        }
                    }*/

                    if (!producto_existe)
                    {
                        
                        bool respuesta = new CN_Ventas().RestarStock(
                            Convert.ToInt32(textBox2.Text),
                            Convert.ToInt32(numericUpDown1.Value.ToString())
                            );

                        if (respuesta)
                        {
                            dataGridView1.Rows.Add(new object[] {
                            textBox2.Text,
                            textBox4.Text,
                            precio.ToString(),
                            numericUpDown1.Value.ToString(),
                            (numericUpDown1.Value * precio).ToString()


                        });

                            calcularTotal();
                            limpiarProducto();

                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar al datagrid");
                        }



                    }else
                    {
                        MessageBox.Show("El producto no se pudo cargar");
                    }



                }
            }
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox12.Text)||
              string.IsNullOrWhiteSpace(textBox7.Text) ||
              string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox1.Text) ||
               CbTipopago.SelectedItem==null || string.IsNullOrWhiteSpace(textBox11.Text) ||
                string.IsNullOrWhiteSpace(textBox10.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de poder realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Desea registrar la venta ?"
         , "Confirmar",
              MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {
                    DataTable detalle_venta = new DataTable();

                    detalle_venta.Columns.Add("idProducto", typeof(int));
                    detalle_venta.Columns.Add("precioVenta", typeof(float));
                    detalle_venta.Columns.Add("cantidad", typeof(int));
                    detalle_venta.Columns.Add("subtotal", typeof(float));


                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        detalle_venta.Rows.Add(new object[] {
                            row.Cells["idProducto"].Value.ToString(),
                            row.Cells["precio"].Value.ToString(),
                            row.Cells["cantidad"].Value.ToString(),
                            row.Cells["subtotal"].Value.ToString(),
                        });
                    }

                    int idcorrelativo = new CN_Ventas().ObtenerCorrelativo();
                    string numeroFactura = string.Format("{0:00000}", idcorrelativo);
                    calcularCAmbio();

                    VENTAS oVenta = new VENTAS()
                    {
                        oUsuario = new USUARIO() {
                            idUsuario = _Usuario.idUsuario,
                            nombre = _Usuario.nombre,
                            apellido = _Usuario.apellido
                        },
                        oCliente = new CLIENTES() { 
                            idCliente = Convert.ToInt32(txtIdCliente.Text),
                            documentoCliente = textBox7.Text,
                            nombreCliente = textBox8.Text 
                        },
                        oTipoPago = new TIPOPAGO() { idTipoPago = Convert.ToInt32(((ComboBoxOpc)CbTipopago.SelectedItem).Valor) },
                        codigoFactura = numeroFactura,
                        montoTotal = Convert.ToDecimal(textBox11.Text),
                        estadoVenta = true,
                        fechaReg = textBox1.Text

                    };

                    string mensaje = String.Empty;
                    bool respuesta = new CN_Ventas().Registrar(oVenta, detalle_venta, out mensaje);

                    if(respuesta){
                        var result = MessageBox.Show("Numero de venta generada:\n" + numeroFactura + "\n\n Desea imprimir la factura de compra?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            

                            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();

                            Texto_Html = Texto_Html.Replace("@nombrenegocio", "Infinite Store");
                            Texto_Html = Texto_Html.Replace("@direcnegocio", "Los Cocos 5431");

                            Texto_Html = Texto_Html.Replace("@codigoFactura", oVenta.codigoFactura.ToString());

                            Texto_Html = Texto_Html.Replace("@doccliente", oVenta.oCliente.documentoCliente);
                            Texto_Html = Texto_Html.Replace("@nombrecliente", oVenta.oCliente.nombreCliente);
                            Texto_Html = Texto_Html.Replace("@fecharegistro", oVenta.fechaReg);
                            string nombyapeusuario = oVenta.oUsuario.nombre + " " + oVenta.oUsuario.apellido;
                            Texto_Html = Texto_Html.Replace("@usuarioregistro", nombyapeusuario);

                            StringBuilder filasHtml = new StringBuilder();
                            foreach (DataRow detalleRow in detalle_venta.Rows)
                            {
                                filasHtml.AppendLine("<tr>");
                                filasHtml.AppendLine("<td>" + detalleRow["idProducto"].ToString() + "</td>");
                                filasHtml.AppendLine("<td>" + detalleRow["precioVenta"].ToString() + "</td>");
                                filasHtml.AppendLine("<td>" + detalleRow["cantidad"].ToString() + "</td>");
                                filasHtml.AppendLine("<td>" + detalleRow["subtotal"].ToString() + "</td>");
                                filasHtml.AppendLine("</tr>");
                            }

  
                            Texto_Html = Texto_Html.Replace("@filas", filasHtml.ToString());
                            Texto_Html = Texto_Html.Replace("@montototal", oVenta.montoTotal.ToString());
                            //Texto_Html = Texto_Html.Replace("@pagocon", txtmontopago.Text);
                            //Texto_Html = Texto_Html.Replace("@cambio", txtmontocambio.Text);


                            SaveFileDialog savefile = new SaveFileDialog();
                            savefile.FileName = string.Format("Compra_{0}.pdf", oVenta.codigoFactura.ToString());
                            savefile.Filter = "Pdf Files|*.pdf";

                            if (savefile.ShowDialog() == DialogResult.OK)
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

                    }
                    else
                    {
                        MessageBox.Show(mensaje,"Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }






                }
            }

        }

       

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void FormRegistrarVentas_Load(object sender, EventArgs e)
        {

            List<TIPOPAGO> listaTipopago = new CN_Tipopago().Listar();

            foreach (TIPOPAGO item in listaTipopago)
            {
                CbTipopago.Items.Add(new ComboBoxOpc() { Valor = item.idTipoPago, Texto = item.descripcion });

            }

            CbTipopago.DisplayMember = "Texto";
            CbTipopago.ValueMember = "Valor";
            CbTipopago.SelectedIndex = -1;

            textBox1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBox2.Text = "0";

            textBox11.Text = "0";
            textBox12.Text = "";
            textBox10.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdCliente.Text = modal._Cliente.idCliente.ToString();
                    textBox7.Text = modal._Cliente.documentoCliente;

                    //junte el nombre y apellido en una sola variable
                    string nombreCompleto = modal._Cliente.nombreCliente + " " + modal._Cliente.apellidoCliente;

                    textBox8.Text = nombreCompleto;
                    txtCorreo.Text = modal._Cliente.correo;
                    txtTel.Text = modal._Cliente.telefono;

                    textBox2.Select();

                }
                else
                {
                    textBox7.Select();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textBox2.Text = modal._Producto.idProducto.ToString();
                    textBox4.Text = modal._Producto.nombreProd;
                    textBox5.Text = modal._Producto.precioUni.ToString();
                    textBox9.Text = modal._Producto.stock.ToString();
                    numericUpDown1.Select();
                }
                else
                {
                    textBox2.Select();
                }
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;

            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Subtotal"].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells["Subtotal"].Value.ToString());
                    }
                }
                textBox11.Text = total.ToString();
            }
        }

        private void limpiarProducto()
        {
            textBox2.Text = "0";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox9.Text = "";
            numericUpDown1.Value = 1;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.cruz_pequena.Width;
                var h = Properties.Resources.cruz_pequena.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.cruz_pequena, new System.Drawing.Rectangle(x, y, w, h));

                e.Handled = true;
            }


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new CN_Ventas().SumarStock(
                        Convert.ToInt32(dataGridView1.Rows[index].Cells["idProducto"].Value.ToString()),
                        Convert.ToInt32(dataGridView1.Rows[index].Cells["cantidad"].Value.ToString())
                        );

                    if (respuesta)
                    {
                        dataGridView1.Rows.RemoveAt(index);

                        if (dataGridView1.Rows.Count == 0)
                        {
                            textBox11.Text = "0";
                        }
                        else
                        {
                            calcularTotal();
                        }
                    }
                    
                }
            }


        }



        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if(textBox12.Text.Trim().Length == 0 && e.KeyChar.ToString()== ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if(Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void calcularCAmbio()
        {
            if (textBox11.Text.Trim() == "")
            {
                MessageBox.Show("No se cargo ningun producto en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(textBox11.Text);

            if(textBox12.Text.Trim() == "")
            {
                textBox12.Text = "0";
            }
            
            if(decimal.TryParse(textBox12.Text.Trim(), out pagacon)) {
                if(pagacon < total)
                {
                    MessageBox.Show("El monto de pago no puede ser menor que el total", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    decimal cambio = pagacon - total;
                    textBox10.Text = cambio.ToString();
                }
            }

        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                calcularCAmbio();
            }
        }

        private void panelRigtUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }

}

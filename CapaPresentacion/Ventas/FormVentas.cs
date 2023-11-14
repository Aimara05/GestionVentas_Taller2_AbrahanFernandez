
//Formulario de Ventas

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
        
        //Metodo para cuando carga el formulario.
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

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");


            //junte el nombre y apellido en una sola variable
            string nombreCompleto = _Usuario.nombre + " " + _Usuario.apellido;
            txtVendedor.Text =nombreCompleto; //muestra el usuario logueado 

            txtCodProd.Text = "0";

            txtTotal.Text = "0";
            txtPagaCon.Text = "";
            txtCambio.Text = "";
        }


        //Metodo calcular el total de la compra.
        private void calcularTotal()
        {
            decimal total = 0;

            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["cantidad"].Value != null && row.Cells["precio"].Value != null)
                    {
                        int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value.ToString());
                        decimal precioUnitario = Convert.ToDecimal(row.Cells["precio"].Value.ToString());

                        decimal subtotal = cantidad * precioUnitario;
                        row.Cells["Subtotal"].Value = subtotal.ToString();

                        total += subtotal;
                    }
                }
                txtTotal.Text = total.ToString();
            }
        }


        //Método limpiar producto
        private void limpiarProducto()
        {
            txtCodProd.Text = "0";
            txtProd.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            numericUpDown1.Value = 1;
        }

         //Calcular el cambio
        private void calcularCAmbio()
        {
            if (txtTotal.Text.Trim() == "")
            {
                MessageBox.Show("No se cargo ningun producto en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTotal.Text);

            if (txtPagaCon.Text.Trim() == "")
            {
                txtPagaCon.Text = "0";
            }

            if (decimal.TryParse(txtPagaCon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    MessageBox.Show("El monto de pago no puede ser menor que el total", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtCambio.Text = cambio.ToString();
                }
            }

        }


        //Método para agregar producto
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProd.Text) ||
               string.IsNullOrWhiteSpace(txtPrecio.Text) ||
               string.IsNullOrWhiteSpace(txtStock.Text) ||
               string.IsNullOrWhiteSpace(numericUpDown1.Text) ||
               string.IsNullOrWhiteSpace(txtDni.Text) ||
               string.IsNullOrWhiteSpace(txtCliente.Text) ||
               string.IsNullOrWhiteSpace(txtFecha.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("La cantidad del producto no debe ser cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              
                    decimal precio = 0;
                    bool producto_existe = false;

                    // Valido si se seleccionó un producto
                    if (int.Parse(txtCodProd.Text) == 0)
                    {
                        MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Valido que el precio ingresado sea un valor correcto
                    if (!decimal.TryParse(txtPrecio.Text, out precio))
                    {
                        MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPrecio.Select();
                        return;
                    }

                    // Valido que la cantidad no sea mayor al stock
                    if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(numericUpDown1.Value.ToString()))
                    {
                        MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Validar si existe el producto en el DataGridView
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (fila.Cells["idProducto"].Value.ToString() == txtCodProd.Text)
                        {
                            producto_existe = true;
                            break;
                        }
                    }

                    if (!producto_existe)
                    {
                        bool respuesta = new CN_Ventas().RestarStock(
                            Convert.ToInt32(txtCodProd.Text),
                            Convert.ToInt32(numericUpDown1.Value.ToString())
                        );

                        if (respuesta)
                        {
                            
                            dataGridView1.Rows.Add(new object[] {
                    txtCodProd.Text,
                    txtProd.Text,
                    txtStock.Text,
                    precio.ToString(),
                  
                    numericUpDown1.Value.ToString(),
                    
                    (numericUpDown1.Value * precio).ToString(),
                    
                });

                            calcularTotal();
                            limpiarProducto();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar al DataGridView", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El producto ya existe en la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                
            }
        }


        //Método para realizar venta
        private void btnRealizarVent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPagaCon.Text) ||
              string.IsNullOrWhiteSpace(txtDni.Text) ||
              string.IsNullOrWhiteSpace(txtCliente.Text) || string.IsNullOrWhiteSpace(txtFecha.Text) ||
               CbTipopago.SelectedItem == null || string.IsNullOrWhiteSpace(txtTotal.Text) ||
                string.IsNullOrWhiteSpace(txtCambio.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de poder realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridView1.Rows.Count < 1)
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
                        oUsuario = new USUARIO()
                        {
                            idUsuario = _Usuario.idUsuario,
                            nombre = _Usuario.nombre,
                            apellido = _Usuario.apellido
                        },
                        oCliente = new CLIENTES()
                        {
                            idCliente = Convert.ToInt32(txtIdCliente.Text),
                            documentoCliente = txtDni.Text,
                            nombreCliente = txtCliente.Text
                        },
                        oTipoPago = new TIPOPAGO() { idTipoPago = Convert.ToInt32(((ComboBoxOpc)CbTipopago.SelectedItem).Valor) },
                        codigoFactura = numeroFactura,
                        montoTotal = Convert.ToDecimal(txtTotal.Text),
                        estadoVenta = true,
                        fechaReg = txtFecha.Text

                    };

                    string mensaje = String.Empty;
                    bool respuesta = new CN_Ventas().Registrar(oVenta, detalle_venta, out mensaje);

                    if (respuesta)
                    {
                        var result = MessageBox.Show("Numero de venta generada:\n" + numeroFactura + "\n\n Desea imprimir la factura de compra?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {


                            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();



                            Texto_Html = Texto_Html.Replace("@codigoFactura", oVenta.codigoFactura.ToString());

                            Texto_Html = Texto_Html.Replace("@DOCUMENTO", oVenta.oCliente.documentoCliente);
                            string nombrecompletocliente = oVenta.oCliente.nombreCliente + " " + oVenta.oCliente.apellidoCliente;
                            Texto_Html = Texto_Html.Replace("@CLIENTE", nombrecompletocliente);
                            Texto_Html = Texto_Html.Replace("@FECHA", oVenta.fechaReg);
                            string nombyapeusuario = oVenta.oUsuario.nombre + " " + oVenta.oUsuario.apellido;
                            Texto_Html = Texto_Html.Replace("@VENDEDOR", nombyapeusuario);

                            StringBuilder filasHtml = new StringBuilder();

                            List<PRODUCTOS> listaProductos = new CN_Producto().Listar();
                            foreach (DataRow detalleRow in detalle_venta.Rows)
                            {
                                filasHtml.AppendLine("<tr>");
                                filasHtml.AppendLine("<td>" + detalleRow["cantidad"].ToString() + "</td>");

                                int idProducto = Convert.ToInt32(detalleRow["idProducto"]);
                                PRODUCTOS producto = listaProductos.Find(p => p.idProducto == idProducto);
                                string nombreProducto = (producto != null) ? producto.nombreProd : "Nombre no encontrado";

                                filasHtml.AppendLine("<td>" + nombreProducto + "</td>");
                                filasHtml.AppendLine("<td>" + detalleRow["precioVenta"].ToString() + "</td>");
                                filasHtml.AppendLine("<td>" + detalleRow["subtotal"].ToString() + "</td>");
                                filasHtml.AppendLine("</tr>");
                            }


                            Texto_Html = Texto_Html.Replace("@FILAS", filasHtml.ToString());
                            Texto_Html = Texto_Html.Replace("@TOTAL", oVenta.montoTotal.ToString());
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

                        limpiarProducto();
                        txtDni.Text = "";
                        txtCliente.Text = "";
                        txtTel.Text = "";
                        txtCorreo.Text = "";
                        txtTotal.Text = "";
                        dataGridView1.Rows.Clear();
                        CbTipopago.SelectedIndex = -1;
                        txtPagaCon.Text = "";
                        txtCambio.Text = "";


                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }






                }
            }
        }
        
        
        
        //Validaciones
        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularCAmbio();
            }
        }

        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPagaCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
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

        //Metodo del boton buscar clientes.
        private void cboBusqueda_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdCliente.Text = modal._Cliente.idCliente.ToString();
                    txtDni.Text = modal._Cliente.documentoCliente;

                    //junte el nombre y apellido en una sola variable
                    string nombreCompleto = modal._Cliente.nombreCliente + " " + modal._Cliente.apellidoCliente;

                    txtCliente.Text = nombreCompleto;
                    txtCorreo.Text = modal._Cliente.correo;
                    txtTel.Text = modal._Cliente.telefono;

                    txtCodProd.Select();

                }
                else
                {
                    txtDni.Select();
                }
            }
        }

        //Método para el botón buscar producto.
        private void cboBusquedaProd_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtCodProd.Text = modal._Producto.idProducto.ToString();
                    txtProd.Text = modal._Producto.nombreProd;
                    txtPrecio.Text = modal._Producto.precioUni.ToString();
                    txtStock.Text = modal._Producto.stock.ToString();
                    numericUpDown1.Select();
                }
                else
                {
                    txtCodProd.Select();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    int rowIndex = e.RowIndex;

                    if (dataGridView1.Rows[rowIndex].Cells["cantidad"].Value != null &&
                        int.TryParse(dataGridView1.Rows[rowIndex].Cells["cantidad"].Value.ToString(), out int cantidadOriginal) &&
                        dataGridView1.Rows[rowIndex].Cells["stock"].Value != null &&
                        int.TryParse(dataGridView1.Rows[rowIndex].Cells["stock"].Value.ToString(), out int stockOriginal))
                    {
                        using (modalCantModificar modal = new modalCantModificar())
                        {
                            modal.numericUpDownModif.Value = cantidadOriginal;
                            modal.ShowDialog();

                            // Verificar si el usuario presionó "Modificar" en el formulario modal
                            if (modal.DialogResult == DialogResult.OK)
                            {
                                // Obtener la nueva cantidad desde el modal
                                int nuevaCantidad = Convert.ToInt32(modal.NuevaCantidad);

                                // Verificar que la nueva cantidad sea menor o igual al stock original
                                if (nuevaCantidad <= stockOriginal)
                                {
                                    // Actualizar el valor en el DataGridView con la nueva cantidad
                                    dataGridView1.Rows[rowIndex].Cells["cantidad"].Value = nuevaCantidad;

                                    // Obtener el ID del producto
                                    int idProducto = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["idProducto"].Value.ToString());

                                    // Calcular la diferencia entre la nueva cantidad y la cantidad original
                                    int diferencia = nuevaCantidad - cantidadOriginal;

                                    // Actualizar el stock en la base de datos
                                    bool respuesta = false;
                                    if (diferencia > 0)
                                    {
                                        // Si la diferencia es positiva, restar al stock
                                        respuesta = new CN_Ventas().RestarStock(idProducto, diferencia);
                                    }
                                    else if (diferencia < 0)
                                    {
                                        // Si la diferencia es negativa, sumar al stock
                                        respuesta = new CN_Ventas().SumarStock(idProducto, Math.Abs(diferencia));
                                    }
                                    else
                                    {
                                        // Si la diferencia es cero, no hay cambios en el stock
                                        respuesta = true;
                                    }

                                    if (respuesta)
                                    {
                                        // Calcular el total después de actualizar el stock
                                        calcularTotal();
                                    }
                                    else
                                    {
                                        // Manejar el caso en que la actualización del stock no fue exitosa
                                        MessageBox.Show("Error al actualizar el stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La cantidad modificada no puede ser mayor al stock original.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        // Manejar el caso en el que la celda no contiene un valor convertible a int
                        MessageBox.Show("La cantidad o el stock en la celda no es un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                            txtTotal.Text = "0";
                        }
                        else
                        {
                            calcularTotal();
                        }
                    }

                }
            }
            

        }
        //Metodo para dibujar los botones editar y eliminar en el datagrid
        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.cruz_pequena.Width;
                var h = Properties.Resources.cruz_pequena.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.cruz_pequena, new System.Drawing.Rectangle(x, y, w, h));

                e.Handled = true;
            }
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.alta.Width;
                var h = Properties.Resources.alta.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.alta, new System.Drawing.Rectangle(x, y, w, h));

                e.Handled = true;
            }
        }

        private void txtCambio_Click(object sender, EventArgs e)
        {
            calcularCAmbio();
        }
    }
}

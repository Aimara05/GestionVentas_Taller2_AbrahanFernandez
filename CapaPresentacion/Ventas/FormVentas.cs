using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormRegistrarVentas : Form
    {
        public FormRegistrarVentas()
        {
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
            if(string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || 
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
                    
                }
            }
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
              string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox9.Text) ||
              string.IsNullOrWhiteSpace(textBox7.Text) ||
              string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox11.Text) ||
                string.IsNullOrWhiteSpace(textBox10.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de poder realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(numericUpDown1.Value == 0)
            {

                MessageBox.Show("la cantidad del producto no debe ser cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult ask = MessageBox.Show("Desea registrar la venta ?"
         , "Confirmar",
              MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {
                    
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
              string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox9.Text) ||
              string.IsNullOrWhiteSpace(numericUpDown1.Text) || string.IsNullOrWhiteSpace(textBox7.Text) ||
              string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox11.Text) ||
                string.IsNullOrWhiteSpace(textBox10.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de poder realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown1.Value == 0)
            {

                MessageBox.Show("la cantidad del producto no debe ser cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult ask = MessageBox.Show("Desea imprimir la factura de venta ?"
         , "Confirmar",
              MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {

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
    }
}

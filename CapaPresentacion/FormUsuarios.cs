using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using CapaPresentacion.Utilidades; //se creo la clase para los comboBox

namespace CapaPresentacion
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        //limpia los textbox
        public void limpiar ()
        {
            TBdni.Clear();
            TIdUsuario.Clear();
            TBNombree.Clear();
            TBapellido.Clear();
            TBusuario.Clear();
            TBcontrasena.Clear();
            TBConfContra.Clear();
            CBRol.SelectedIndex = 0;
            CBestado.SelectedIndex = 0;
            
        }

        //metodo cargar formulario de usuarios
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CBestado.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Activo" });
            CBestado.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "No Activo" });
            CBestado.DisplayMember = "Texto";
            CBestado.ValueMember = "Valor";
            CBestado.SelectedIndex = 0;
            CBRol.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "Vendedor" });
            CBRol.Items.Add(new ComboBoxOpc() { Valor = 0, Texto = "Administrador" });
            CBRol.DisplayMember = "Texto";
            CBRol.ValueMember = "Valor";
            CBRol.SelectedIndex = 0;
            cboBusqueda.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "dni" });
            cboBusqueda.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "nombre" });
            cboBusqueda.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "apellido" });
            cboBusqueda.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "correo" });
            cboBusqueda.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "rol" });
            cboBusqueda.Items.Add(new ComboBoxOpc() { Valor = 1, Texto = "estado" });
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;
        }


        //metodo del boton guardar
        private void BGuardar_Click(object sender, EventArgs e)
        {
            //validaciones
            if (string.IsNullOrWhiteSpace(TBdni.Text) || string.IsNullOrWhiteSpace(TBNombree.Text) || string.IsNullOrWhiteSpace(TBapellido.Text) || String.IsNullOrWhiteSpace(TBusuario.Text) || String.IsNullOrWhiteSpace(TBcontrasena.Text) || String.IsNullOrWhiteSpace(TBConfContra.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TBdni.Text.Length != 8)
            {
                MessageBox.Show("Formato del dni incorrecto, debe contener 8 caracteres.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (TBcontrasena.Text.Length < 5)
            {
                MessageBox.Show("Formato de la contraseña incorrecta, debe tener al menos 5 caracteres.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if(TBcontrasena.Text != TBConfContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                dataGridUsuario.Rows.Add(new object[] {"",TIdUsuario.Text, TBdni.Text,TBNombree.Text,TBapellido.Text,
                TBusuario.Text,TBcontrasena.Text,
                ((ComboBoxOpc) CBRol.SelectedItem).Valor.ToString(),
                ((ComboBoxOpc) CBRol.SelectedItem).Texto.ToString(),
                ((ComboBoxOpc) CBestado.SelectedItem).Valor.ToString(),
                ((ComboBoxOpc) CBestado.SelectedItem).Texto.ToString()
            });
            }
            limpiar();
        }


        //metodos de validacion 
        private void TBdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solamente se pueden ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void TBNombree_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    MessageBox.Show("Solamente se pueden ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
            
        }

        private void TBapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solamente se pueden ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}

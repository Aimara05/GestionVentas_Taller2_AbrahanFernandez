using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;



namespace CapaPresentacion.Usuarios
{
    public partial class FormUsu : Form
    {
        public FormUsu()
        {
            InitializeComponent();

        }

        //Metodos para abrir formulario.
        private void abrirFormularios(Form formulario)
        {


            

            formulario.Show();


        }


        private void FormUsu_Load(object sender, EventArgs e)
        {
             //mostrar todos los usuarios
            List<USUARIO> listaUsuario = new CN_Usuario().Listar();

            foreach (USUARIO item in listaUsuario)
            {
                dataGridUsuario.Rows.Add(new object[] {"",item.idUsuario,item.documento,item.nombre,item.apellido,item.correo,item.usuario,item.telefono,
                item.direccion,
                item.estado == true ? "Activo" : "No activo",
                item.oRol.descripcion
            });


            }
        }

        private void picUsuario_Click(object sender, EventArgs e)
        {

        }

        private void dataGridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (dataGridUsuario.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if(indice >= 0)
                {
                    EditarUsuario edit = new EditarUsuario();
                    edit.TBdni.Text = dataGridUsuario.Rows[indice].Cells["dni"].Value.ToString();
                    edit.TBNombree.Text = dataGridUsuario.Rows[indice].Cells["nombre"].Value.ToString();
                    edit.TBapellido.Text = dataGridUsuario.Rows[indice].Cells["apellido"].Value.ToString();
                    edit.txtTelefono.Text = dataGridUsuario.Rows[indice].Cells["telefono"].Value.ToString();
                    edit.txtDomicilio.Text = dataGridUsuario.Rows[indice].Cells["Domicilio"].Value.ToString();
                    edit.textBox1.Text = dataGridUsuario.Rows[indice].Cells["Correo"].Value.ToString();
                    edit.TBusuario.Text = dataGridUsuario.Rows[indice].Cells["usuario"].Value.ToString();


                    abrirFormularios(edit);
                }

            } */
        } 

        private void btnAltausuario_Click(object sender, EventArgs e)
        {
            Usuarios.AltaUsuario altauser = new Usuarios.AltaUsuario();
            abrirFormularios(altauser);


        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            abrirFormularios(new Usuarios.EditarUsuario());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // limpio el dataGridView
            dataGridUsuario.Rows.Clear();


            //traigo los datos de la base nuevamente
            List<USUARIO> listaUsuario = new CN_Usuario().Listar();

            foreach (USUARIO item in listaUsuario)
            {
                dataGridUsuario.Rows.Add(new object[] {"",item.idUsuario,item.documento,item.nombre,item.apellido,item.correo,item.usuario,item.telefono,
                item.direccion,
                item.estado == true ? "Activo" : "No activo",
                item.oRol.descripcion
            });


                // Actualizo el datagrid
                dataGridUsuario.Refresh();
                 }
        }
    }
}

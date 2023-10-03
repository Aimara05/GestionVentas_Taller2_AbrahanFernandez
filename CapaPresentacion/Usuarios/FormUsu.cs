
//Formulario de Usuarios.


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
        private int filaSeleccionada = -1; // variable para mantener el indice de mi fila seleccionada en mi dgv
        public FormUsu()
        {
            InitializeComponent();
        }
        
        //Métodos para abrir formulario.
        private void abrirFormularios(Form formulario)
        {
            formulario.Show();

        }

        //Método cuando carga el formulario.
        private void FormUsu_Load(object sender, EventArgs e)
        {

            List<USUARIO> listaUsuario = new CN_Usuario().Listar();

            foreach (USUARIO item in listaUsuario)
            {
                dataGridUsuario.Rows.Add(new object[] {"",item.idUsuario,item.documento,item.nombre,item.apellido,item.correo,item.usuario,item.clave,
                item.telefono,
                item.direccion,
                item.estado == true ? "Activo" : "No activo",
                item.oRol.idRol,
                item.oRol.descripcion
            });


            }

            foreach (DataGridViewColumn columna in dataGridUsuario.Columns)
            {
                if (columna.Visible== true && columna.Name != "btnSeleccionar")
                {
                 cboBusqueda.Items.Add((new ComboBoxOpc() { Valor = columna.Name, Texto = columna.HeaderText }));
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

        }

        //
        private void dataGridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridUsuario.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                filaSeleccionada = e.RowIndex;                             
            } 
        } 


        //Método para btn Usuarios
        private void btnAltausuario_Click(object sender, EventArgs e)
        {
            Usuarios.AltaUsuario altauser = new Usuarios.AltaUsuario();
            abrirFormularios(altauser);
        }


        //metodo para el btn editarUsuario
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                EditarUsuario edit = new EditarUsuario();
                edit.lblid.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["idUsuario"].Value.ToString();
                edit.TBdni.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["dni"].Value.ToString();
                edit.TBNombree.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["nombre"].Value.ToString();
                edit.TBapellido.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["apellido"].Value.ToString();
                edit.txtTelefono.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["telefono"].Value.ToString();
                edit.txtDomicilio.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["Domicilio"].Value.ToString();
                edit.textCorreo.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["Correo"].Value.ToString();
                edit.TBusuario.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["usuario"].Value.ToString();
                edit.TBcontrasena.Text = dataGridUsuario.Rows[filaSeleccionada].Cells["clave"].Value.ToString();


                

                  foreach (ComboBoxOpc oc in edit.CBRol.Items)
                  {
                      if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridUsuario.Rows[filaSeleccionada].Cells["idRol"].Value))
                      {
                          int indice_combo = edit.CBRol.Items.IndexOf(oc);
                          edit.CBRol.SelectedIndex = indice_combo;
                          break;
                      }

                  }
                  foreach (ComboBoxOpc oc in edit.comboBox1.Items)
                  {
                      if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridUsuario.Rows[filaSeleccionada].Cells["Estado"].Value))
                      {
                          int indice_combo = edit.comboBox1.Items.IndexOf(oc);
                          edit.comboBox1.SelectedIndex = indice_combo;
                          break;
                      }

                  }



                abrirFormularios(edit);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //Método para el botón refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // limpio el dataGridView
            dataGridUsuario.Rows.Clear();


            //traigo los datos de la base nuevamente
            List<USUARIO> listaUsuario = new CN_Usuario().Listar();

            foreach (USUARIO item in listaUsuario)
            {
                dataGridUsuario.Rows.Add(new object[] {"",item.idUsuario,item.documento,item.nombre,item.apellido,item.correo,item.usuario,item.clave,
                item.telefono,
                item.direccion,
                item.estado == true ? "Activo" : "No activo",
                item.oRol.idRol,
                item.oRol.descripcion
            }); 
            



                // Actualizo el datagrid
                dataGridUsuario.Refresh();
                 }
        }


        //Método para el btn BajaUsuario
        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                DataGridViewRow fila = dataGridUsuario.Rows[filaSeleccionada];
                string estadoUsuario = fila.Cells["Estado"].Value.ToString(); // Obtener el estado del usuario

                
                if(estadoUsuario == "Activo")
                {
                    USUARIO usuario = new USUARIO();
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    usuario.idUsuario = Convert.ToInt32(dataGridUsuario.Rows[filaSeleccionada].Cells["idUsuario"].Value);

                    string mensaje = string.Empty;

                    // Llamo al método Eliminar en la capa de negocios

                    bool eliminacionExitosa = new CN_Usuario().Eliminar(usuario, out mensaje);

                    if (eliminacionExitosa)
                    {
                        MessageBox.Show("El usuario fue dado de baja");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ya fue dado de baja anteriormente");
                }

               


            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
        //Método para el btn AltaUsu
        private void btnAltaUsu_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                DataGridViewRow fila = dataGridUsuario.Rows[filaSeleccionada];
                string estadoUsuario = fila.Cells["Estado"].Value.ToString();

                if(estadoUsuario == "No activo")
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea dar de alta este usuario?", "Confirmación de alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    USUARIO usuario = new USUARIO();
                    usuario.idUsuario = Convert.ToInt32(dataGridUsuario.Rows[filaSeleccionada].Cells["idUsuario"].Value);

                    string mensaje = string.Empty;

                    // Llamo al método Alta en la capa de negocios

                    bool altaExitosa = new CN_Usuario().Alta(usuario, out mensaje);


                    if (altaExitosa)
                    {
                        MessageBox.Show("El usuario fue dado de alta nuevamente");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, El usuario ya fue dado de alta anterriormente");
                }

                

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario antes de continuar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

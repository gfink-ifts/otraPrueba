using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _17_J_ADO2
{
    public partial class UpdateDelete : Form
    {
        string cadenaConex = @"data source=DESKTOP-N7AEFM4\SQLEXPRESS; initial catalog = Ejercitacion; integrated security= SSPI";
        SqlConnection cn;

        public UpdateDelete()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (validarTextBoxes())
            {
                string prov = txt_provincia.Text;
                string id_cliente = txt_idUsuario.Text;

                string query = "UPDATE clientes SET provincia = @prov WHERE id_cliente = @id";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@prov", prov);
                cmd.Parameters.AddWithValue("@id", id_cliente);

                ejecutarQuery(cn, cmd);
                mostrarMensaje("Usuario modificado");
                limpiarForm();
            }
            else
            {
                mostrarMensaje("Por favor completar todos los campos");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_idUsuario.Text != "")
            {
                int id_cliente = Convert.ToInt32(txt_idUsuario.Text);
                string instruccion = "DELETE clientes WHERE id_cliente = @id";
                SqlCommand cmd = new SqlCommand(instruccion,cn);
                cmd.Parameters.AddWithValue("@id", id_cliente);
                ejecutarQuery(cn, cmd);
                mostrarMensaje("Usuario eliminado");
                limpiarForm();
            }
            else
            {
                mostrarMensaje("Por favor ingresar el ID de usuario");
            }
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "SELECT id_cliente, nombre, apellido FROM CLIENTES";

            cn.Open();

            da = new SqlDataAdapter(query, cn);

            da.Fill(dt);
            cn.Close();

            cbo_usuarios.DataSource = dt;
            cbo_usuarios.DisplayMember = "apellido";
            cbo_usuarios.ValueMember = "id_cliente";
        }

        private void limpiarForm()
        {
            foreach (Control variable in this.Controls)
            {
                if (variable is TextBox)
                {
                    (variable as TextBox).Clear();
                }
            }
        }
        private bool validarTextBoxes()
        {
            bool respuesta = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if ((c as TextBox).Text == "")
                    {
                        respuesta = false;
                    }
                }
            }
            return respuesta;
        }
        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void ejecutarQuery(SqlConnection conex, SqlCommand comando)
        {
            conex.Open();
            comando.ExecuteNonQuery();
            conex.Close();
        }
    }
}

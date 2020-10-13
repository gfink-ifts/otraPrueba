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
    public partial class FormAltaCliente : Form
    {
        string cadenaConex = @"data source=DESKTOP-N7AEFM4\SQLEXPRESS; initial catalog = Ejercitacion; integrated security= SSPI";
        SqlConnection cn;
        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            if (validarTextBoxes())
            {
                string nombre, apellido, direccion, provincia, fecha_registracion;

                nombre = txt_nombre.Text;
                apellido = txt_apellido.Text;
                direccion = txt_direccion.Text;
                provincia = txt_provincia.Text;
                fecha_registracion = txt_fecha.Text;
            
                string cmd = "insert into Clientes (nombre,apellido,direccion,provincia,fecha_registracion) "+
                                "values ( @nombre, @apellido, @dire, @prov, @fecha )";

                SqlCommand comando = new SqlCommand(cmd, cn);

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@dire", direccion);
                comando.Parameters.AddWithValue("@prov", provincia);
                comando.Parameters.AddWithValue("@fecha", fecha_registracion);

                //cn.Open();
                //comando.ExecuteNonQuery();
                //cn.Close();

                ejecutarQuery(cn, comando);
                mostrarMensaje("Usuario creado correctamente");

                limpiarForm();
            }
            else
            {
                mostrarMensaje("Por favor completar todos los campos");
            }
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
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
                    if ( (c as TextBox).Text == "")
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
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

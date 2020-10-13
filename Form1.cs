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
    public partial class Form1 : Form
    {
        string cadenaConex = @"data source=DESKTOP-N7AEFM4\SQLEXPRESS; initial catalog = Ejercitacion; integrated security= SSPI";
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            string desc,  tipo;
            int precio;

            desc = txt_descripcion.Text;
            precio = Convert.ToInt32(txt_precio.Text);
            tipo = txt_tipoProducto.Text;

            string cmd = "insert into Productos (descripcion,precio,id_tipo)" +
                " values ( @linkDescripcion, @linkPrecio, @linkTipo )";

            SqlCommand comando = new SqlCommand(cmd, cn);

            

            comando.Parameters.AddWithValue("@linkDescripcion", desc);
            comando.Parameters.AddWithValue("@linkPrecio", precio);
            comando.Parameters.AddWithValue("@linkTipo", tipo);

            cn.Open();
            comando.ExecuteNonQuery();
            cn.Close();


            /*
            SqlCommand comandoVacio = new SqlCommand();
            comandoVacio = cn.CreateCommand();
            comandoVacio.CommandText = "insert into Productos (descripcion,precio,id_tipo) "+
                "values ('" + txt_descripcion.Text + "'," +
                precio + "," + txt_tipoProducto.Text + ")";

            cn.Open();
            comando.ExecuteNonQuery();
            cn.Close();
            */

            /*
            SqlCommand comandoConsulta = new SqlCommand("insert into Productos (descripcion,precio,id_tipo) values ('"+txt_descripcion.Text+"',"+txt_precio.Text +","+ txt_tipoProducto.Text , cn);
            cn.Open();
            comando.ExecuteNonQuery();
            cn.Close();
            */

            /*
            string comandoParaNewSqlCommand = "insert into Productos (descripcion,precio,id_tipo) values ('" + txt_descripcion.Text + "'," + txt_precio.Text + "," + txt_tipoProducto.Text; 
            SqlCommand comandoConsulta = new SqlCommand(comandoParaNewSqlCommand, cn);
            cn.Open();
            comando.ExecuteNonQuery();
            cn.Close();
            */
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
        }

    }
}

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
    public partial class selectForm : Form
    {
        string cadenaConex = @"data source=DESKTOP-N7AEFM4\SQLEXPRESS; initial catalog = Ejercitacion; integrated security= SSPI";
        SqlConnection cn;
        public selectForm()
        {
            InitializeComponent();
        }

        private void btn_mostrarClientes_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "SELECT * FROM CLIENTES";

            cn.Open();

            da = new SqlDataAdapter(query, cn);

            da.Fill(dt);

            cn.Close();

            dataGridClientes.DataSource = dt;

        }

        private void selectForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
        }

        private void btn_mostrarProductos_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "SELECT p.descripcion,p.precio,tp.descripcion as Tipo FROM PRODUCTOS as p, tipo_producto as tp " +
                            "WHERE p.id_tipo = tp.id_tipo";

            cn.Open();

            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();

            dataGridClientes.DataSource = dt;
        }

        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            string producto = txt_producto.Text;
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cn.Open();
            string consulta = "select * from productos  where descripcion like @prod";
            da = new SqlDataAdapter(consulta, cn);
            da.SelectCommand.Parameters.AddWithValue("@prod" , "%" + producto + "%");
            
            da.Fill(dt);
            dataGridClientes.DataSource = dt;
            cn.Close();
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txt_cliente.Text;
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cn.Open();
            string consulta = "select nombre, apellido, direccion from clientes "+
                              "where nombre like @nombre or apellido like @nombre";
            da = new SqlDataAdapter(consulta, cn);
            da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            da.Fill(dt);
            dataGridClientes.DataSource = dt;
            cn.Close();
        }
    }
}

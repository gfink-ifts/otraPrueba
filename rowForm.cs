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
    public partial class rowForm : Form
    {
        string cadenaConex = @"data source=DESKTOP-N7AEFM4\SQLEXPRESS; initial catalog = Ejercitacion; integrated security= SSPI";
        SqlConnection cn;
        public rowForm()
        {
            InitializeComponent();
        }

        private void rowForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            txt_desc.Enabled = false;
            txt_id.Enabled = false;
            txt_precio.Enabled = false;
            txt_tipo.Enabled = false;

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consulta = "select descripcion, id_producto from Productos";
            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            da.Fill(dt);
            cn.Close();
            cbo_productos.DataSource = dt;
            cbo_productos.ValueMember = "id_producto";
            cbo_productos.DisplayMember = "descripcion";

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string producto = txt_producto.Text;
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cn.Open();
            string consulta = "select p.id_producto,p.descripcion, p.precio, tp.descripcion from productos as p, tipo_producto as tp" +
                " where p.descripcion like @prod and tp.id_tipo = p.id_tipo";
            da = new SqlDataAdapter(consulta, cn);
            da.SelectCommand.Parameters.AddWithValue("@prod", "%" + producto + "%");
            da.Fill(dt);
            cn.Close();

            if (dt.Rows.Count > 0)
            {
                txt_id.Text = Convert.ToString(dt.Rows[0][0]);
                txt_desc.Text = Convert.ToString(dt.Rows[0][1]);
                txt_precio.Text = Convert.ToString(dt.Rows[0][2]);
                txt_tipo.Text = Convert.ToString(dt.Rows[0][3]);
            }
            else
            {
                MessageBox.Show("No se encontraron resultados");
            }
        }

        private void btn_buscarCombo_Click(object sender, EventArgs e)
        {
            string idProducto = cbo_productos.SelectedValue.ToString();
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cn.Open();
            string consulta = "select p.id_producto, p.descripcion, p.precio, tp.descripcion" +
                               " from productos as p, tipo_producto as tp" + 
                               " where tp.id_tipo = p.id_tipo" +
                               " and p.id_producto = @prod";
            da = new SqlDataAdapter(consulta, cn);
            da.SelectCommand.Parameters.AddWithValue("@prod", idProducto);
            da.Fill(dt);
            cn.Close();

            if (dt.Rows.Count > 0)
            {
                txt_id.Text = dt.Rows[0][0].ToString();
                txt_tipo.Text = dt.Rows[0][3].ToString();
                txt_precio.Text = Convert.ToString(dt.Rows[0][2]);
                txt_desc.Text = Convert.ToString(dt.Rows[0][1]);
            }
            else
            {
                MessageBox.Show("No se encontro el producto");
            }
        }
    }
}

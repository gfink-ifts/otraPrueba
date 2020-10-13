using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_J_ADO2
{
    public partial class Portada : Form
    {
        FormAltaCliente formClientes = new FormAltaCliente();
        Form1 formProd = new Form1();
        public Portada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formClientes.Show();
        }

        private void btn_altaProd_Click(object sender, EventArgs e)
        {
            formProd.Show();
        }

        private void btn_modificarForm_Click(object sender, EventArgs e)
        {
            UpdateDelete form = new UpdateDelete();
            form.Show();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            selectForm form = new selectForm();
            form.Show();
        }

        private void btn_rowForm_Click(object sender, EventArgs e)
        {
            rowForm form = new rowForm();
            form.Show();
        }
    }
}

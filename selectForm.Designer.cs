namespace _17_J_ADO2
{
    partial class selectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.btn_mostrarClientes = new System.Windows.Forms.Button();
            this.btn_mostrarProductos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.btn_buscarProducto = new System.Windows.Forms.Button();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(18, 18);
            this.dataGridClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.Size = new System.Drawing.Size(790, 629);
            this.dataGridClientes.TabIndex = 0;
            // 
            // btn_mostrarClientes
            // 
            this.btn_mostrarClientes.Location = new System.Drawing.Point(880, 18);
            this.btn_mostrarClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_mostrarClientes.Name = "btn_mostrarClientes";
            this.btn_mostrarClientes.Size = new System.Drawing.Size(242, 52);
            this.btn_mostrarClientes.TabIndex = 1;
            this.btn_mostrarClientes.Text = "Mostrar Clientes";
            this.btn_mostrarClientes.UseVisualStyleBackColor = true;
            this.btn_mostrarClientes.Click += new System.EventHandler(this.btn_mostrarClientes_Click);
            // 
            // btn_mostrarProductos
            // 
            this.btn_mostrarProductos.Location = new System.Drawing.Point(880, 109);
            this.btn_mostrarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_mostrarProductos.Name = "btn_mostrarProductos";
            this.btn_mostrarProductos.Size = new System.Drawing.Size(242, 52);
            this.btn_mostrarProductos.TabIndex = 2;
            this.btn_mostrarProductos.Text = "Mostrar Productos";
            this.btn_mostrarProductos.UseVisualStyleBackColor = true;
            this.btn_mostrarProductos.Click += new System.EventHandler(this.btn_mostrarProductos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(880, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion :";
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(987, 248);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(135, 26);
            this.txt_producto.TabIndex = 4;
            // 
            // btn_buscarProducto
            // 
            this.btn_buscarProducto.Location = new System.Drawing.Point(880, 306);
            this.btn_buscarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_buscarProducto.Name = "btn_buscarProducto";
            this.btn_buscarProducto.Size = new System.Drawing.Size(242, 52);
            this.btn_buscarProducto.TabIndex = 5;
            this.btn_buscarProducto.Text = "Buscar Producto";
            this.btn_buscarProducto.UseVisualStyleBackColor = true;
            this.btn_buscarProducto.Click += new System.EventHandler(this.btn_buscarProducto_Click);
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.Location = new System.Drawing.Point(880, 474);
            this.btn_buscarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(242, 52);
            this.btn_buscarCliente.TabIndex = 8;
            this.btn_buscarCliente.Text = "Buscar Cliente";
            this.btn_buscarCliente.UseVisualStyleBackColor = true;
            this.btn_buscarCliente.Click += new System.EventHandler(this.btn_buscarCliente_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(1019, 416);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(103, 26);
            this.txt_cliente.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(880, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre/Apellido :";
            // 
            // selectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_buscarCliente);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscarProducto);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mostrarProductos);
            this.Controls.Add(this.btn_mostrarClientes);
            this.Controls.Add(this.dataGridClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "selectForm";
            this.Text = "selectForm";
            this.Load += new System.EventHandler(this.selectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Button btn_mostrarClientes;
        private System.Windows.Forms.Button btn_mostrarProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Button btn_buscarProducto;
        private System.Windows.Forms.Button btn_buscarCliente;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label2;
    }
}
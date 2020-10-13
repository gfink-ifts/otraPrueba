namespace _17_J_ADO2
{
    partial class rowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_productos = new System.Windows.Forms.ComboBox();
            this.btn_buscarCombo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto :";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(137, 186);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(210, 32);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar / Texto";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(137, 130);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(210, 26);
            this.txt_producto.TabIndex = 2;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(143, 389);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(204, 26);
            this.txt_precio.TabIndex = 18;
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(143, 343);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(204, 26);
            this.txt_tipo.TabIndex = 17;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(143, 294);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(204, 26);
            this.txt_desc.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Precio : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripcion :";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(143, 245);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(204, 26);
            this.txt_id.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id :";
            // 
            // cbo_productos
            // 
            this.cbo_productos.FormattingEnabled = true;
            this.cbo_productos.Location = new System.Drawing.Point(137, 22);
            this.cbo_productos.Name = "cbo_productos";
            this.cbo_productos.Size = new System.Drawing.Size(210, 28);
            this.cbo_productos.TabIndex = 19;
            // 
            // btn_buscarCombo
            // 
            this.btn_buscarCombo.Location = new System.Drawing.Point(137, 75);
            this.btn_buscarCombo.Name = "btn_buscarCombo";
            this.btn_buscarCombo.Size = new System.Drawing.Size(210, 32);
            this.btn_buscarCombo.TabIndex = 20;
            this.btn_buscarCombo.Text = "Buscar / Combo";
            this.btn_buscarCombo.UseVisualStyleBackColor = true;
            this.btn_buscarCombo.Click += new System.EventHandler(this.btn_buscarCombo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Producto :";
            // 
            // rowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 454);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_buscarCombo);
            this.Controls.Add(this.cbo_productos);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label1);
            this.Name = "rowForm";
            this.Text = "rowForm";
            this.Load += new System.EventHandler(this.rowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_productos;
        private System.Windows.Forms.Button btn_buscarCombo;
        private System.Windows.Forms.Label label6;
    }
}
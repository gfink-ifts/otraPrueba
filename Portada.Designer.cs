namespace _17_J_ADO2
{
    partial class Portada
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_altaProd = new System.Windows.Forms.Button();
            this.btn_modificarForm = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_rowForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alta de clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_altaProd
            // 
            this.btn_altaProd.Location = new System.Drawing.Point(78, 165);
            this.btn_altaProd.Name = "btn_altaProd";
            this.btn_altaProd.Size = new System.Drawing.Size(232, 83);
            this.btn_altaProd.TabIndex = 1;
            this.btn_altaProd.Text = "Alta de productos";
            this.btn_altaProd.UseVisualStyleBackColor = true;
            this.btn_altaProd.Click += new System.EventHandler(this.btn_altaProd_Click);
            // 
            // btn_modificarForm
            // 
            this.btn_modificarForm.Location = new System.Drawing.Point(78, 257);
            this.btn_modificarForm.Name = "btn_modificarForm";
            this.btn_modificarForm.Size = new System.Drawing.Size(232, 83);
            this.btn_modificarForm.TabIndex = 2;
            this.btn_modificarForm.Text = "Modificar / Eliminar";
            this.btn_modificarForm.UseVisualStyleBackColor = true;
            this.btn_modificarForm.Click += new System.EventHandler(this.btn_modificarForm_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(78, 349);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(232, 83);
            this.btn_select.TabIndex = 3;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_rowForm
            // 
            this.btn_rowForm.Location = new System.Drawing.Point(346, 72);
            this.btn_rowForm.Name = "btn_rowForm";
            this.btn_rowForm.Size = new System.Drawing.Size(232, 83);
            this.btn_rowForm.TabIndex = 4;
            this.btn_rowForm.Text = "Manejar Row";
            this.btn_rowForm.UseVisualStyleBackColor = true;
            this.btn_rowForm.Click += new System.EventHandler(this.btn_rowForm_Click);
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 495);
            this.Controls.Add(this.btn_rowForm);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_modificarForm);
            this.Controls.Add(this.btn_altaProd);
            this.Controls.Add(this.button1);
            this.Name = "Portada";
            this.Text = "Portada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_altaProd;
        private System.Windows.Forms.Button btn_modificarForm;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_rowForm;
    }
}
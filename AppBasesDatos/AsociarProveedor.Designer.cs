namespace pruebaInterfaz
{
    partial class AsociarProveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.proveedores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ganancia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Location = new System.Drawing.Point(-5, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 11);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // proveedores
            // 
            this.proveedores.BackColor = System.Drawing.Color.LightGreen;
            this.proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proveedores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.proveedores.Location = new System.Drawing.Point(134, 79);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(170, 21);
            this.proveedores.TabIndex = 36;
            this.proveedores.SelectedIndexChanged += new System.EventHandler(this.proveedores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Proveedor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // partes
            // 
            this.partes.BackColor = System.Drawing.Color.LightGreen;
            this.partes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.partes.Location = new System.Drawing.Point(134, 45);
            this.partes.Name = "partes";
            this.partes.Size = new System.Drawing.Size(170, 21);
            this.partes.TabIndex = 34;
            this.partes.SelectedIndexChanged += new System.EventHandler(this.partes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(229, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Asociar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Parte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Precio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(134, 115);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(170, 20);
            this.precio.TabIndex = 38;
            this.precio.TextChanged += new System.EventHandler(this.precio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ganancia";
            // 
            // ganancia
            // 
            this.ganancia.Location = new System.Drawing.Point(134, 154);
            this.ganancia.Name = "ganancia";
            this.ganancia.Size = new System.Drawing.Size(170, 20);
            this.ganancia.TabIndex = 40;
            // 
            // AsociarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ganancia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.proveedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AsociarProveedor";
            this.Text = "AsociarProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox proveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox partes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ganancia;
    }
}
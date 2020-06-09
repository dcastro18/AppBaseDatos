namespace pruebaInterfaz
{
    partial class ActualizarPrecios
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
            this.label5 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.proveedores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ganancia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Precio";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(146, 132);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(170, 20);
            this.precio.TabIndex = 45;
            // 
            // proveedores
            // 
            this.proveedores.BackColor = System.Drawing.Color.LightGreen;
            this.proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proveedores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.proveedores.Location = new System.Drawing.Point(146, 96);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(170, 21);
            this.proveedores.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Proveedor";
            // 
            // partes
            // 
            this.partes.BackColor = System.Drawing.Color.LightGreen;
            this.partes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.partes.Location = new System.Drawing.Point(146, 62);
            this.partes.Name = "partes";
            this.partes.Size = new System.Drawing.Size(170, 21);
            this.partes.TabIndex = 42;
            this.partes.SelectedIndexChanged += new System.EventHandler(this.partes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(241, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Parte";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Location = new System.Drawing.Point(1, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 10);
            this.panel1.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ganancia";
            // 
            // ganancia
            // 
            this.ganancia.Location = new System.Drawing.Point(146, 167);
            this.ganancia.Name = "ganancia";
            this.ganancia.Size = new System.Drawing.Size(170, 20);
            this.ganancia.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 50;
            this.label4.Text = "Porcentaje";
            // 
            // ActualizarPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(403, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ganancia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.proveedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ActualizarPrecios";
            this.Text = "ActualizarPrecios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.ComboBox proveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox partes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ganancia;
        private System.Windows.Forms.Label label4;
    }
}
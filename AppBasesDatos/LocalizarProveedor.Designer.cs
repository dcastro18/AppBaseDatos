namespace pruebaInterfaz
{
    partial class LocalizarProveedor
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
            this.partes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listaProveedores = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Location = new System.Drawing.Point(-1, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 11);
            this.panel1.TabIndex = 41;
            // 
            // partes
            // 
            this.partes.BackColor = System.Drawing.Color.LightGreen;
            this.partes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.partes.Location = new System.Drawing.Point(89, 117);
            this.partes.Name = "partes";
            this.partes.Size = new System.Drawing.Size(170, 21);
            this.partes.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(184, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Localizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Parte";
            // 
            // listaProveedores
            // 
            this.listaProveedores.FormattingEnabled = true;
            this.listaProveedores.Location = new System.Drawing.Point(360, 12);
            this.listaProveedores.Name = "listaProveedores";
            this.listaProveedores.Size = new System.Drawing.Size(278, 277);
            this.listaProveedores.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.Location = new System.Drawing.Point(314, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 288);
            this.panel2.TabIndex = 42;
            // 
            // LocalizarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(678, 324);
            this.Controls.Add(this.listaProveedores);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.partes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "LocalizarProveedor";
            this.Text = "LocalizarProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox partes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaProveedores;
        private System.Windows.Forms.Panel panel2;
    }
}
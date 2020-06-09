namespace pruebaInterfaz
{
    partial class AsociarOrden
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
            this.detalleOrden = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cedulas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ordenes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Location = new System.Drawing.Point(1, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 10);
            this.panel1.TabIndex = 53;
            // 
            // proveedores
            // 
            this.proveedores.BackColor = System.Drawing.Color.LightGreen;
            this.proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proveedores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.proveedores.Location = new System.Drawing.Point(107, 174);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(170, 21);
            this.proveedores.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Proveedor";
            // 
            // partes
            // 
            this.partes.BackColor = System.Drawing.Color.LightGreen;
            this.partes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.partes.Location = new System.Drawing.Point(107, 131);
            this.partes.Name = "partes";
            this.partes.Size = new System.Drawing.Size(170, 21);
            this.partes.TabIndex = 50;
            this.partes.SelectedIndexChanged += new System.EventHandler(this.partes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(202, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Parte";
            // 
            // detalleOrden
            // 
            this.detalleOrden.FormattingEnabled = true;
            this.detalleOrden.Location = new System.Drawing.Point(372, 32);
            this.detalleOrden.Name = "detalleOrden";
            this.detalleOrden.Size = new System.Drawing.Size(278, 264);
            this.detalleOrden.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.Location = new System.Drawing.Point(334, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 302);
            this.panel2.TabIndex = 54;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(107, 218);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(170, 20);
            this.cantidad.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Cantidad";
            // 
            // cedulas
            // 
            this.cedulas.BackColor = System.Drawing.Color.LightGreen;
            this.cedulas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cedulas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cedulas.Location = new System.Drawing.Point(107, 39);
            this.cedulas.Name = "cedulas";
            this.cedulas.Size = new System.Drawing.Size(170, 21);
            this.cedulas.TabIndex = 59;
            this.cedulas.SelectedIndexChanged += new System.EventHandler(this.cedulas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Nombre";
            // 
            // Ordenes
            // 
            this.Ordenes.BackColor = System.Drawing.Color.LightGreen;
            this.Ordenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ordenes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Ordenes.Location = new System.Drawing.Point(107, 84);
            this.Ordenes.Name = "Ordenes";
            this.Ordenes.Size = new System.Drawing.Size(170, 21);
            this.Ordenes.TabIndex = 61;
            this.Ordenes.SelectedIndexChanged += new System.EventHandler(this.Ordenes_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Ordenes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "Total con IVA:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // monto
            // 
            this.monto.AutoSize = true;
            this.monto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto.Location = new System.Drawing.Point(457, 299);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(14, 15);
            this.monto.TabIndex = 63;
            this.monto.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "Nombre - Proveedor - Cantidad - Precio Derivado";
            // 
            // AsociarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(671, 336);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ordenes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cedulas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.detalleOrden);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.proveedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AsociarOrden";
            this.Text = "AsociarOrden";
            this.Load += new System.EventHandler(this.AsociarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
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
        private System.Windows.Forms.ListBox detalleOrden;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cedulas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Ordenes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label monto;
        private System.Windows.Forms.Label label7;
    }
}
﻿namespace pruebaInterfaz
{
    partial class ListarPartesAuto
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
            this.anno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listaPartes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Location = new System.Drawing.Point(2, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 10);
            this.panel1.TabIndex = 37;
            // 
            // anno
            // 
            this.anno.BackColor = System.Drawing.Color.LightGreen;
            this.anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.anno.Location = new System.Drawing.Point(101, 141);
            this.anno.Name = "anno";
            this.anno.Size = new System.Drawing.Size(170, 21);
            this.anno.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Año";
            // 
            // modelo
            // 
            this.modelo.BackColor = System.Drawing.Color.LightGreen;
            this.modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modelo.Location = new System.Drawing.Point(101, 98);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(170, 21);
            this.modelo.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(196, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Modelo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.Location = new System.Drawing.Point(333, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 288);
            this.panel2.TabIndex = 38;
            // 
            // listaPartes
            // 
            this.listaPartes.FormattingEnabled = true;
            this.listaPartes.Location = new System.Drawing.Point(371, 17);
            this.listaPartes.Name = "listaPartes";
            this.listaPartes.Size = new System.Drawing.Size(278, 277);
            this.listaPartes.TabIndex = 39;
            // 
            // ListarPartesAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(680, 334);
            this.Controls.Add(this.listaPartes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.anno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ListarPartesAuto";
            this.Text = "ListarPartesAuto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox anno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox modelo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listaPartes;
    }
}
namespace pruebaInterfaz
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarClienteNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteViejoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspenderClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarParteNuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarUnaParteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociarPartesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociarPartesConTipoDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPartesPorTiposDeAutomóvilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listarPartesPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.organizacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.partesToolStripMenuItem,
            this.ordenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarClienteNuevoToolStripMenuItem,
            this.modificarClienteViejoToolStripMenuItem,
            this.suspenderClienteToolStripMenuItem,
            this.listarClientesToolStripMenuItem,
            this.activarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // insertarClienteNuevoToolStripMenuItem
            // 
            this.insertarClienteNuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem,
            this.organizacionToolStripMenuItem});
            this.insertarClienteNuevoToolStripMenuItem.Name = "insertarClienteNuevoToolStripMenuItem";
            this.insertarClienteNuevoToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.insertarClienteNuevoToolStripMenuItem.Text = "Insertar cliente nuevo";
            this.insertarClienteNuevoToolStripMenuItem.Click += new System.EventHandler(this.insertarClienteNuevoToolStripMenuItem_Click);
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.personaToolStripMenuItem.Text = "Persona";
            this.personaToolStripMenuItem.Click += new System.EventHandler(this.personaToolStripMenuItem_Click);
            // 
            // organizacionToolStripMenuItem
            // 
            this.organizacionToolStripMenuItem.Name = "organizacionToolStripMenuItem";
            this.organizacionToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.organizacionToolStripMenuItem.Text = "Organizacion";
            this.organizacionToolStripMenuItem.Click += new System.EventHandler(this.organizacionToolStripMenuItem_Click);
            // 
            // modificarClienteViejoToolStripMenuItem
            // 
            this.modificarClienteViejoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem1,
            this.organizacionToolStripMenuItem1});
            this.modificarClienteViejoToolStripMenuItem.Name = "modificarClienteViejoToolStripMenuItem";
            this.modificarClienteViejoToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.modificarClienteViejoToolStripMenuItem.Text = "Modificar cliente viejo";
            this.modificarClienteViejoToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteViejoToolStripMenuItem_Click);
            // 
            // suspenderClienteToolStripMenuItem
            // 
            this.suspenderClienteToolStripMenuItem.Name = "suspenderClienteToolStripMenuItem";
            this.suspenderClienteToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.suspenderClienteToolStripMenuItem.Text = "Suspender cliente";
            this.suspenderClienteToolStripMenuItem.Click += new System.EventHandler(this.suspenderClienteToolStripMenuItem_Click);
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.organizacionesToolStripMenuItem});
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.listarClientesToolStripMenuItem.Text = "Listar clientes";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // partesToolStripMenuItem
            // 
            this.partesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarParteNuevaToolStripMenuItem,
            this.borrarUnaParteToolStripMenuItem,
            this.asociarPartesToolStripMenuItem,
            this.asociarPartesConTipoDeToolStripMenuItem,
            this.actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem,
            this.listarPartesPorTiposDeAutomóvilesToolStripMenuItem,
            this.listarPartesPorProveedorToolStripMenuItem});
            this.partesToolStripMenuItem.Name = "partesToolStripMenuItem";
            this.partesToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.partesToolStripMenuItem.Text = "Partes";
            this.partesToolStripMenuItem.Click += new System.EventHandler(this.partesToolStripMenuItem_Click);
            // 
            // insertarParteNuevaToolStripMenuItem
            // 
            this.insertarParteNuevaToolStripMenuItem.Name = "insertarParteNuevaToolStripMenuItem";
            this.insertarParteNuevaToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.insertarParteNuevaToolStripMenuItem.Text = "Insertar parte nueva";
            this.insertarParteNuevaToolStripMenuItem.Click += new System.EventHandler(this.insertarParteNuevaToolStripMenuItem_Click);
            // 
            // borrarUnaParteToolStripMenuItem
            // 
            this.borrarUnaParteToolStripMenuItem.Name = "borrarUnaParteToolStripMenuItem";
            this.borrarUnaParteToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.borrarUnaParteToolStripMenuItem.Text = "Borrar una parte";
            this.borrarUnaParteToolStripMenuItem.Click += new System.EventHandler(this.borrarUnaParteToolStripMenuItem_Click);
            // 
            // asociarPartesToolStripMenuItem
            // 
            this.asociarPartesToolStripMenuItem.Name = "asociarPartesToolStripMenuItem";
            this.asociarPartesToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.asociarPartesToolStripMenuItem.Text = "Asociar partes con proveedores";
            this.asociarPartesToolStripMenuItem.Click += new System.EventHandler(this.asociarPartesToolStripMenuItem_Click);
            // 
            // asociarPartesConTipoDeToolStripMenuItem
            // 
            this.asociarPartesConTipoDeToolStripMenuItem.Name = "asociarPartesConTipoDeToolStripMenuItem";
            this.asociarPartesConTipoDeToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.asociarPartesConTipoDeToolStripMenuItem.Text = "Asociar partes con tipo de automovil";
            this.asociarPartesConTipoDeToolStripMenuItem.Click += new System.EventHandler(this.asociarPartesConTipoDeToolStripMenuItem_Click);
            // 
            // actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem
            // 
            this.actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem.Name = "actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem";
            this.actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem.Text = "Actualizar precios de una parte";
            this.actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem.Click += new System.EventHandler(this.actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem_Click);
            // 
            // listarPartesPorTiposDeAutomóvilesToolStripMenuItem
            // 
            this.listarPartesPorTiposDeAutomóvilesToolStripMenuItem.Name = "listarPartesPorTiposDeAutomóvilesToolStripMenuItem";
            this.listarPartesPorTiposDeAutomóvilesToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.listarPartesPorTiposDeAutomóvilesToolStripMenuItem.Text = "Listar partes por tipos de automóviles";
            this.listarPartesPorTiposDeAutomóvilesToolStripMenuItem.Click += new System.EventHandler(this.listarPartesPorTiposDeAutomóvilesToolStripMenuItem_Click);
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem,
            this.asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem});
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            // 
            // insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem
            // 
            this.insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem.Name = "insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem";
            this.insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem.Size = new System.Drawing.Size(572, 24);
            this.insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem.Text = "Insertar una nueva orden para un cliente";
            this.insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem.Click += new System.EventHandler(this.insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem_Click);
            // 
            // asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem
            // 
            this.asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem.Name = "asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem";
            this.asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem.Size = new System.Drawing.Size(572, 24);
            this.asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem.Text = "Asociar a una orden la compra de una cantidad de partes de un proveedor";
            this.asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem.Click += new System.EventHandler(this.asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarea Programada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "- Bases de Datos 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estudiantes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "David Castro - 2018105813";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Esteban Mata - 2018110735";
            // 
            // listarPartesPorProveedorToolStripMenuItem
            // 
            this.listarPartesPorProveedorToolStripMenuItem.Name = "listarPartesPorProveedorToolStripMenuItem";
            this.listarPartesPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(328, 24);
            this.listarPartesPorProveedorToolStripMenuItem.Text = "Listar partes por proveedor";
            this.listarPartesPorProveedorToolStripMenuItem.Click += new System.EventHandler(this.listarPartesPorProveedorToolStripMenuItem_Click);
            // 
            // personaToolStripMenuItem1
            // 
            this.personaToolStripMenuItem1.Name = "personaToolStripMenuItem1";
            this.personaToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.personaToolStripMenuItem1.Text = "Persona";
            this.personaToolStripMenuItem1.Click += new System.EventHandler(this.personaToolStripMenuItem1_Click);
            // 
            // organizacionToolStripMenuItem1
            // 
            this.organizacionToolStripMenuItem1.Name = "organizacionToolStripMenuItem1";
            this.organizacionToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.organizacionToolStripMenuItem1.Text = "Organizacion";
            this.organizacionToolStripMenuItem1.Click += new System.EventHandler(this.organizacionToolStripMenuItem1_Click);
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // organizacionesToolStripMenuItem
            // 
            this.organizacionesToolStripMenuItem.Name = "organizacionesToolStripMenuItem";
            this.organizacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.organizacionesToolStripMenuItem.Text = "Organizaciones";
            this.organizacionesToolStripMenuItem.Click += new System.EventHandler(this.organizacionesToolStripMenuItem_Click);
            // 
            // activarClienteToolStripMenuItem
            // 
            this.activarClienteToolStripMenuItem.Name = "activarClienteToolStripMenuItem";
            this.activarClienteToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.activarClienteToolStripMenuItem.Text = "Activar Cliente";
            this.activarClienteToolStripMenuItem.Click += new System.EventHandler(this.activarClienteToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(543, 329);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarClienteNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteViejoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspenderClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarParteNuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarUnaParteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociarPartesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociarPartesConTipoDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPartesPorTiposDeAutomóvilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPartesPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem organizacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activarClienteToolStripMenuItem;
    }
}


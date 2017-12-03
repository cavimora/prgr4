namespace CreditoCobro.AplicacionBanco
{
    partial class FrmProjections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjections));
            this.dtvProyeccion = new System.Windows.Forms.DataGridView();
            this.dtvCreditos = new System.Windows.Forms.DataGridView();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtvClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInstitucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPeople = new MetroFramework.Controls.MetroLabel();
            this.btnNewProjection = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoPlanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDesdeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDesdeTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDesdeEXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbCredits = new MetroFramework.Controls.MetroLabel();
            this.lbProjections = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProyeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvProyeccion
            // 
            this.dtvProyeccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvProyeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProyeccion.Location = new System.Drawing.Point(92, 308);
            this.dtvProyeccion.Name = "dtvProyeccion";
            this.dtvProyeccion.Size = new System.Drawing.Size(792, 412);
            this.dtvProyeccion.TabIndex = 15;
            // 
            // dtvCreditos
            // 
            this.dtvCreditos.AllowUserToResizeColumns = false;
            this.dtvCreditos.AllowUserToResizeRows = false;
            this.dtvCreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCreditos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monto,
            this.Tasa,
            this.Plazo});
            this.dtvCreditos.Location = new System.Drawing.Point(541, 120);
            this.dtvCreditos.MultiSelect = false;
            this.dtvCreditos.Name = "dtvCreditos";
            this.dtvCreditos.ReadOnly = true;
            this.dtvCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvCreditos.Size = new System.Drawing.Size(343, 139);
            this.dtvCreditos.TabIndex = 14;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Tasa
            // 
            this.Tasa.DataPropertyName = "Tasa";
            this.Tasa.HeaderText = "Tasa";
            this.Tasa.Name = "Tasa";
            this.Tasa.ReadOnly = true;
            // 
            // Plazo
            // 
            this.Plazo.DataPropertyName = "Plazo";
            this.Plazo.HeaderText = "Plazo";
            this.Plazo.Name = "Plazo";
            this.Plazo.ReadOnly = true;
            // 
            // dtvClientes
            // 
            this.dtvClientes.AllowUserToResizeColumns = false;
            this.dtvClientes.AllowUserToResizeRows = false;
            this.dtvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Nombre,
            this.Apellido,
            this.Apellido2,
            this.IdInstitucion});
            this.dtvClientes.Location = new System.Drawing.Point(92, 120);
            this.dtvClientes.MultiSelect = false;
            this.dtvClientes.Name = "dtvClientes";
            this.dtvClientes.ReadOnly = true;
            this.dtvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvClientes.Size = new System.Drawing.Size(443, 139);
            this.dtvClientes.TabIndex = 13;
            this.dtvClientes.Click += new System.EventHandler(this.dtvClientes_Click);
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "Id";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido1";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Apellido2
            // 
            this.Apellido2.DataPropertyName = "Apellido2";
            this.Apellido2.HeaderText = "Apellido 2";
            this.Apellido2.Name = "Apellido2";
            this.Apellido2.ReadOnly = true;
            // 
            // IdInstitucion
            // 
            this.IdInstitucion.DataPropertyName = "IdInstitucion";
            this.IdInstitucion.HeaderText = "IdInstitucion";
            this.IdInstitucion.Name = "IdInstitucion";
            this.IdInstitucion.ReadOnly = true;
            this.IdInstitucion.Visible = false;
            // 
            // lbPeople
            // 
            this.lbPeople.AutoSize = true;
            this.lbPeople.Location = new System.Drawing.Point(92, 97);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(60, 19);
            this.lbPeople.TabIndex = 16;
            this.lbPeople.Text = "Personas";
            // 
            // btnNewProjection
            // 
            this.btnNewProjection.Location = new System.Drawing.Point(541, 265);
            this.btnNewProjection.Name = "btnNewProjection";
            this.btnNewProjection.Size = new System.Drawing.Size(119, 37);
            this.btnNewProjection.TabIndex = 17;
            this.btnNewProjection.Text = "Generar Proyección";
            this.btnNewProjection.UseSelectable = true;
            this.btnNewProjection.Click += new System.EventHandler(this.btnNewProjection_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarComoToolStripMenuItem,
            this.importarComoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportarComoToolStripMenuItem
            // 
            this.exportarComoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentoExcelToolStripMenuItem,
            this.textoPlanoToolStripMenuItem,
            this.documentoXMLToolStripMenuItem});
            this.exportarComoToolStripMenuItem.Name = "exportarComoToolStripMenuItem";
            this.exportarComoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.exportarComoToolStripMenuItem.Text = "Exportar";
            // 
            // documentoExcelToolStripMenuItem
            // 
            this.documentoExcelToolStripMenuItem.Name = "documentoExcelToolStripMenuItem";
            this.documentoExcelToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.documentoExcelToolStripMenuItem.Text = "Documento Excel";
            this.documentoExcelToolStripMenuItem.Click += new System.EventHandler(this.documentoExcelToolStripMenuItem_Click);
            // 
            // textoPlanoToolStripMenuItem
            // 
            this.textoPlanoToolStripMenuItem.Name = "textoPlanoToolStripMenuItem";
            this.textoPlanoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.textoPlanoToolStripMenuItem.Text = "Texto Plano ";
            this.textoPlanoToolStripMenuItem.Click += new System.EventHandler(this.textoPlanoToolStripMenuItem_Click);
            // 
            // documentoXMLToolStripMenuItem
            // 
            this.documentoXMLToolStripMenuItem.Name = "documentoXMLToolStripMenuItem";
            this.documentoXMLToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.documentoXMLToolStripMenuItem.Text = "Documento XML";
            this.documentoXMLToolStripMenuItem.Click += new System.EventHandler(this.documentoXMLToolStripMenuItem_Click);
            // 
            // importarComoToolStripMenuItem
            // 
            this.importarComoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarDesdeXMLToolStripMenuItem,
            this.cargarDesdeTXTToolStripMenuItem,
            this.importarDesdeEXCELToolStripMenuItem});
            this.importarComoToolStripMenuItem.Name = "importarComoToolStripMenuItem";
            this.importarComoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.importarComoToolStripMenuItem.Text = "Importar";
            // 
            // importarDesdeXMLToolStripMenuItem
            // 
            this.importarDesdeXMLToolStripMenuItem.Name = "importarDesdeXMLToolStripMenuItem";
            this.importarDesdeXMLToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.importarDesdeXMLToolStripMenuItem.Text = "Importar desde XML";
            this.importarDesdeXMLToolStripMenuItem.Click += new System.EventHandler(this.importarDesdeXMLToolStripMenuItem_Click);
            // 
            // cargarDesdeTXTToolStripMenuItem
            // 
            this.cargarDesdeTXTToolStripMenuItem.Name = "cargarDesdeTXTToolStripMenuItem";
            this.cargarDesdeTXTToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cargarDesdeTXTToolStripMenuItem.Text = "Importar desde TXT";
            this.cargarDesdeTXTToolStripMenuItem.Click += new System.EventHandler(this.cargarDesdeTXTToolStripMenuItem_Click);
            // 
            // importarDesdeEXCELToolStripMenuItem
            // 
            this.importarDesdeEXCELToolStripMenuItem.Name = "importarDesdeEXCELToolStripMenuItem";
            this.importarDesdeEXCELToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.importarDesdeEXCELToolStripMenuItem.Text = "Importar desde EXCEL";
            this.importarDesdeEXCELToolStripMenuItem.Click += new System.EventHandler(this.importarDesdeEXCELToolStripMenuItem_Click);
            // 
            // lbCredits
            // 
            this.lbCredits.AutoSize = true;
            this.lbCredits.Location = new System.Drawing.Point(541, 97);
            this.lbCredits.Name = "lbCredits";
            this.lbCredits.Size = new System.Drawing.Size(58, 19);
            this.lbCredits.TabIndex = 21;
            this.lbCredits.Text = "Creditos";
            // 
            // lbProjections
            // 
            this.lbProjections.AutoSize = true;
            this.lbProjections.Location = new System.Drawing.Point(92, 286);
            this.lbProjections.Name = "lbProjections";
            this.lbProjections.Size = new System.Drawing.Size(85, 19);
            this.lbProjections.TabIndex = 22;
            this.lbProjections.Text = "Proyecciones";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(765, 265);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 37);
            this.metroButton1.TabIndex = 23;
            this.metroButton1.Text = "Limpiar Datos";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FrmProjections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 714);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lbProjections);
            this.Controls.Add(this.lbCredits);
            this.Controls.Add(this.btnNewProjection);
            this.Controls.Add(this.lbPeople);
            this.Controls.Add(this.dtvProyeccion);
            this.Controls.Add(this.dtvCreditos);
            this.Controls.Add(this.dtvClientes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmProjections";
            this.Text = "Proyecciónes";
            this.Load += new System.EventHandler(this.FrmProjections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProyeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvProyeccion;
        private System.Windows.Forms.DataGridView dtvCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plazo;
        private System.Windows.Forms.DataGridView dtvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInstitucion;
        private MetroFramework.Controls.MetroLabel lbPeople;
        private MetroFramework.Controls.MetroButton btnNewProjection;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentoExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoPlanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentoXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarComoToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lbCredits;
        private MetroFramework.Controls.MetroLabel lbProjections;
        private System.Windows.Forms.ToolStripMenuItem importarDesdeXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDesdeTXTToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ToolStripMenuItem importarDesdeEXCELToolStripMenuItem;
    }
}
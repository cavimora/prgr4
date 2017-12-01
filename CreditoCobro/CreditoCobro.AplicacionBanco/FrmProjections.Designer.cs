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
            this.btnExportar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProyeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvProyeccion
            // 
            this.dtvProyeccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvProyeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProyeccion.Location = new System.Drawing.Point(92, 286);
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
            this.dtvCreditos.Location = new System.Drawing.Point(541, 98);
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
            this.dtvClientes.Location = new System.Drawing.Point(92, 98);
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
            this.lbPeople.Location = new System.Drawing.Point(92, 76);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(60, 19);
            this.lbPeople.TabIndex = 16;
            this.lbPeople.Text = "Personas";
            // 
            // btnNewProjection
            // 
            this.btnNewProjection.Location = new System.Drawing.Point(92, 243);
            this.btnNewProjection.Name = "btnNewProjection";
            this.btnNewProjection.Size = new System.Drawing.Size(119, 37);
            this.btnNewProjection.TabIndex = 17;
            this.btnNewProjection.Text = "Generar Proyección";
            this.btnNewProjection.UseSelectable = true;
            this.btnNewProjection.Click += new System.EventHandler(this.btnNewProjection_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(217, 243);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(119, 37);
            this.btnExportar.TabIndex = 18;
            this.btnExportar.Text = "Exportar Datos";
            this.btnExportar.UseSelectable = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // FrmProjections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 714);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnNewProjection);
            this.Controls.Add(this.lbPeople);
            this.Controls.Add(this.dtvProyeccion);
            this.Controls.Add(this.dtvCreditos);
            this.Controls.Add(this.dtvClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProjections";
            this.Text = "Proyecciónes";
            this.Load += new System.EventHandler(this.FrmProjections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProyeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).EndInit();
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
        private MetroFramework.Controls.MetroButton btnExportar;
    }
}
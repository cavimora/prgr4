namespace CreditoCobro.AplicacionBanco
{
    partial class FrmOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperations));
            this.dtvCreditos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPlazo = new MetroFramework.Controls.MetroTextBox();
            this.txtTasa = new MetroFramework.Controls.MetroTextBox();
            this.txtMonto = new MetroFramework.Controls.MetroTextBox();
            this.lblPlazo = new MetroFramework.Controls.MetroLabel();
            this.lblTasa = new MetroFramework.Controls.MetroLabel();
            this.lblMonto = new MetroFramework.Controls.MetroLabel();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvCreditos
            // 
            this.dtvCreditos.AllowUserToResizeColumns = false;
            this.dtvCreditos.AllowUserToResizeRows = false;
            this.dtvCreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCreditos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Monto,
            this.Tasa,
            this.Plazo});
            this.dtvCreditos.Location = new System.Drawing.Point(23, 207);
            this.dtvCreditos.MultiSelect = false;
            this.dtvCreditos.Name = "dtvCreditos";
            this.dtvCreditos.ReadOnly = true;
            this.dtvCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvCreditos.Size = new System.Drawing.Size(453, 394);
            this.dtvCreditos.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            // txtPlazo
            // 
            // 
            // 
            // 
            this.txtPlazo.CustomButton.Image = null;
            this.txtPlazo.CustomButton.Location = new System.Drawing.Point(339, 1);
            this.txtPlazo.CustomButton.Name = "";
            this.txtPlazo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPlazo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlazo.CustomButton.TabIndex = 1;
            this.txtPlazo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPlazo.CustomButton.UseSelectable = true;
            this.txtPlazo.CustomButton.Visible = false;
            this.txtPlazo.Enabled = false;
            this.txtPlazo.Lines = new string[0];
            this.txtPlazo.Location = new System.Drawing.Point(115, 135);
            this.txtPlazo.MaxLength = 32767;
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.PasswordChar = '\0';
            this.txtPlazo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlazo.SelectedText = "";
            this.txtPlazo.SelectionLength = 0;
            this.txtPlazo.SelectionStart = 0;
            this.txtPlazo.ShortcutsEnabled = true;
            this.txtPlazo.Size = new System.Drawing.Size(361, 23);
            this.txtPlazo.TabIndex = 33;
            this.txtPlazo.UseSelectable = true;
            this.txtPlazo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlazo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTasa
            // 
            // 
            // 
            // 
            this.txtTasa.CustomButton.Image = null;
            this.txtTasa.CustomButton.Location = new System.Drawing.Point(339, 1);
            this.txtTasa.CustomButton.Name = "";
            this.txtTasa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTasa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTasa.CustomButton.TabIndex = 1;
            this.txtTasa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTasa.CustomButton.UseSelectable = true;
            this.txtTasa.CustomButton.Visible = false;
            this.txtTasa.Enabled = false;
            this.txtTasa.Lines = new string[0];
            this.txtTasa.Location = new System.Drawing.Point(115, 95);
            this.txtTasa.MaxLength = 32767;
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.PasswordChar = '\0';
            this.txtTasa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTasa.SelectedText = "";
            this.txtTasa.SelectionLength = 0;
            this.txtTasa.SelectionStart = 0;
            this.txtTasa.ShortcutsEnabled = true;
            this.txtTasa.Size = new System.Drawing.Size(361, 23);
            this.txtTasa.TabIndex = 32;
            this.txtTasa.UseSelectable = true;
            this.txtTasa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTasa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMonto
            // 
            // 
            // 
            // 
            this.txtMonto.CustomButton.Image = null;
            this.txtMonto.CustomButton.Location = new System.Drawing.Point(339, 1);
            this.txtMonto.CustomButton.Name = "";
            this.txtMonto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMonto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMonto.CustomButton.TabIndex = 1;
            this.txtMonto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMonto.CustomButton.UseSelectable = true;
            this.txtMonto.CustomButton.Visible = false;
            this.txtMonto.Enabled = false;
            this.txtMonto.Lines = new string[0];
            this.txtMonto.Location = new System.Drawing.Point(115, 56);
            this.txtMonto.MaxLength = 32767;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMonto.SelectedText = "";
            this.txtMonto.SelectionLength = 0;
            this.txtMonto.SelectionStart = 0;
            this.txtMonto.ShortcutsEnabled = true;
            this.txtMonto.Size = new System.Drawing.Size(361, 23);
            this.txtMonto.TabIndex = 31;
            this.txtMonto.UseSelectable = true;
            this.txtMonto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMonto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(23, 139);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(41, 19);
            this.lblPlazo.TabIndex = 30;
            this.lblPlazo.Text = "Plazo";
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Location = new System.Drawing.Point(23, 99);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(33, 19);
            this.lblTasa.TabIndex = 29;
            this.lblTasa.Text = "Tasa";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(23, 60);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(48, 19);
            this.lblMonto.TabIndex = 28;
            this.lblMonto.Text = "Monto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(357, 164);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 37);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(23, 164);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(119, 37);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 622);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtPlazo);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblPlazo);
            this.Controls.Add(this.lblTasa);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.dtvCreditos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOperations";
            this.Text = "Operaciónes";
            this.Load += new System.EventHandler(this.FrmOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvCreditos;
        private MetroFramework.Controls.MetroTextBox txtPlazo;
        private MetroFramework.Controls.MetroTextBox txtTasa;
        private MetroFramework.Controls.MetroTextBox txtMonto;
        private MetroFramework.Controls.MetroLabel lblPlazo;
        private MetroFramework.Controls.MetroLabel lblTasa;
        private MetroFramework.Controls.MetroLabel lblMonto;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plazo;
    }
}
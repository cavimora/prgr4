namespace CreditoCobro.AplicacionBanco
{
    partial class FrmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClients));
            this.dtvClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInstitucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewProjection = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.lblCedula = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblApellido1 = new MetroFramework.Controls.MetroLabel();
            this.lblApellido2 = new MetroFramework.Controls.MetroLabel();
            this.txtCedula = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtApellido1 = new MetroFramework.Controls.MetroTextBox();
            this.txtApellido2 = new MetroFramework.Controls.MetroTextBox();
            this.btnNewOper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).BeginInit();
            this.SuspendLayout();
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
            this.dtvClientes.Location = new System.Drawing.Point(23, 254);
            this.dtvClientes.MultiSelect = false;
            this.dtvClientes.Name = "dtvClientes";
            this.dtvClientes.ReadOnly = true;
            this.dtvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvClientes.Size = new System.Drawing.Size(443, 227);
            this.dtvClientes.TabIndex = 14;
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
            // btnNewProjection
            // 
            this.btnNewProjection.Location = new System.Drawing.Point(23, 211);
            this.btnNewProjection.Name = "btnNewProjection";
            this.btnNewProjection.Size = new System.Drawing.Size(119, 37);
            this.btnNewProjection.TabIndex = 18;
            this.btnNewProjection.Text = "Nuevo";
            this.btnNewProjection.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(183, 211);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 37);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "Editar";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(347, 211);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(119, 37);
            this.metroButton2.TabIndex = 20;
            this.metroButton2.Text = "Eliminar";
            this.metroButton2.UseSelectable = true;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(24, 64);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(50, 19);
            this.lblCedula.TabIndex = 21;
            this.lblCedula.Text = "Cédula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(24, 143);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(67, 19);
            this.lblApellido1.TabIndex = 23;
            this.lblApellido1.Text = "Apellido 1";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(24, 186);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(69, 19);
            this.lblApellido2.TabIndex = 24;
            this.lblApellido2.Text = "Apellido 2";
            // 
            // txtCedula
            // 
            // 
            // 
            // 
            this.txtCedula.CustomButton.Image = null;
            this.txtCedula.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.txtCedula.CustomButton.Name = "";
            this.txtCedula.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCedula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCedula.CustomButton.TabIndex = 1;
            this.txtCedula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCedula.CustomButton.UseSelectable = true;
            this.txtCedula.CustomButton.Visible = false;
            this.txtCedula.Enabled = false;
            this.txtCedula.Lines = new string[0];
            this.txtCedula.Location = new System.Drawing.Point(116, 60);
            this.txtCedula.MaxLength = 32767;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCedula.SelectedText = "";
            this.txtCedula.SelectionLength = 0;
            this.txtCedula.SelectionStart = 0;
            this.txtCedula.ShortcutsEnabled = true;
            this.txtCedula.Size = new System.Drawing.Size(350, 23);
            this.txtCedula.TabIndex = 25;
            this.txtCedula.UseSelectable = true;
            this.txtCedula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCedula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Enabled = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(116, 99);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(350, 23);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApellido1
            // 
            // 
            // 
            // 
            this.txtApellido1.CustomButton.Image = null;
            this.txtApellido1.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.txtApellido1.CustomButton.Name = "";
            this.txtApellido1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellido1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido1.CustomButton.TabIndex = 1;
            this.txtApellido1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido1.CustomButton.UseSelectable = true;
            this.txtApellido1.CustomButton.Visible = false;
            this.txtApellido1.Enabled = false;
            this.txtApellido1.Lines = new string[0];
            this.txtApellido1.Location = new System.Drawing.Point(116, 139);
            this.txtApellido1.MaxLength = 32767;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.PasswordChar = '\0';
            this.txtApellido1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido1.SelectedText = "";
            this.txtApellido1.SelectionLength = 0;
            this.txtApellido1.SelectionStart = 0;
            this.txtApellido1.ShortcutsEnabled = true;
            this.txtApellido1.Size = new System.Drawing.Size(350, 23);
            this.txtApellido1.TabIndex = 27;
            this.txtApellido1.UseSelectable = true;
            this.txtApellido1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellido1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApellido2
            // 
            // 
            // 
            // 
            this.txtApellido2.CustomButton.Image = null;
            this.txtApellido2.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.txtApellido2.CustomButton.Name = "";
            this.txtApellido2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellido2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido2.CustomButton.TabIndex = 1;
            this.txtApellido2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido2.CustomButton.UseSelectable = true;
            this.txtApellido2.CustomButton.Visible = false;
            this.txtApellido2.Enabled = false;
            this.txtApellido2.Lines = new string[0];
            this.txtApellido2.Location = new System.Drawing.Point(116, 182);
            this.txtApellido2.MaxLength = 32767;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.PasswordChar = '\0';
            this.txtApellido2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido2.SelectedText = "";
            this.txtApellido2.SelectionLength = 0;
            this.txtApellido2.SelectionStart = 0;
            this.txtApellido2.ShortcutsEnabled = true;
            this.txtApellido2.Size = new System.Drawing.Size(350, 23);
            this.txtApellido2.TabIndex = 28;
            this.txtApellido2.UseSelectable = true;
            this.txtApellido2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellido2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnNewOper
            // 
            this.btnNewOper.BackColor = System.Drawing.Color.DimGray;
            this.btnNewOper.FlatAppearance.BorderSize = 0;
            this.btnNewOper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnNewOper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnNewOper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOper.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOper.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewOper.Image = global::CreditoCobro.AplicacionBanco.Properties.Resources.curriculum;
            this.btnNewOper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewOper.Location = new System.Drawing.Point(347, 487);
            this.btnNewOper.Name = "btnNewOper";
            this.btnNewOper.Size = new System.Drawing.Size(119, 39);
            this.btnNewOper.TabIndex = 29;
            this.btnNewOper.Text = "&Operaciones";
            this.btnNewOper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewOper.UseVisualStyleBackColor = false;
            // 
            // FrmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 548);
            this.Controls.Add(this.btnNewOper);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnNewProjection);
            this.Controls.Add(this.dtvClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClients";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInstitucion;
        private MetroFramework.Controls.MetroButton btnNewProjection;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel lblCedula;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblApellido1;
        private MetroFramework.Controls.MetroLabel lblApellido2;
        private MetroFramework.Controls.MetroTextBox txtCedula;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtApellido1;
        private MetroFramework.Controls.MetroTextBox txtApellido2;
        private System.Windows.Forms.Button btnNewOper;
    }
}
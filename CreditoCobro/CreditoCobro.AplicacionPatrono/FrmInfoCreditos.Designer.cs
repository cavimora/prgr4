namespace CreditoCobro.AplicacionPatrono
{
    partial class FrmInfoCreditos
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lbProjections = new MetroFramework.Controls.MetroLabel();
            this.lbCredits = new MetroFramework.Controls.MetroLabel();
            this.btnNewProjection = new MetroFramework.Controls.MetroButton();
            this.dtvProyeccion = new System.Windows.Forms.DataGridView();
            this.dtvCreditos = new System.Windows.Forms.DataGridView();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDesdeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDesdeTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDesdeEXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCed = new MetroFramework.Controls.MetroTextBox();
            this.txtNom = new MetroFramework.Controls.MetroTextBox();
            this.txtApe1 = new MetroFramework.Controls.MetroTextBox();
            this.txtApe2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProyeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(762, 278);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 37);
            this.metroButton1.TabIndex = 32;
            this.metroButton1.Text = "Limpiar Datos";
            this.metroButton1.UseSelectable = true;
            // 
            // lbProjections
            // 
            this.lbProjections.AutoSize = true;
            this.lbProjections.Location = new System.Drawing.Point(92, 299);
            this.lbProjections.Name = "lbProjections";
            this.lbProjections.Size = new System.Drawing.Size(85, 19);
            this.lbProjections.TabIndex = 31;
            this.lbProjections.Text = "Proyecciones";
            // 
            // lbCredits
            // 
            this.lbCredits.AutoSize = true;
            this.lbCredits.Location = new System.Drawing.Point(538, 99);
            this.lbCredits.Name = "lbCredits";
            this.lbCredits.Size = new System.Drawing.Size(58, 19);
            this.lbCredits.TabIndex = 30;
            this.lbCredits.Text = "Creditos";
            // 
            // btnNewProjection
            // 
            this.btnNewProjection.Location = new System.Drawing.Point(631, 278);
            this.btnNewProjection.Name = "btnNewProjection";
            this.btnNewProjection.Size = new System.Drawing.Size(119, 37);
            this.btnNewProjection.TabIndex = 28;
            this.btnNewProjection.Text = "Generar Proyección";
            this.btnNewProjection.UseSelectable = true;
            // 
            // dtvProyeccion
            // 
            this.dtvProyeccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvProyeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProyeccion.Location = new System.Drawing.Point(92, 321);
            this.dtvProyeccion.Name = "dtvProyeccion";
            this.dtvProyeccion.Size = new System.Drawing.Size(792, 412);
            this.dtvProyeccion.TabIndex = 26;
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
            this.dtvCreditos.Location = new System.Drawing.Point(538, 122);
            this.dtvCreditos.MultiSelect = false;
            this.dtvCreditos.Name = "dtvCreditos";
            this.dtvCreditos.ReadOnly = true;
            this.dtvCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvCreditos.Size = new System.Drawing.Size(343, 139);
            this.dtvCreditos.TabIndex = 25;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarComoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
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
            // 
            // importarDesdeEXCELToolStripMenuItem
            // 
            this.importarDesdeEXCELToolStripMenuItem.Name = "importarDesdeEXCELToolStripMenuItem";
            this.importarDesdeEXCELToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.importarDesdeEXCELToolStripMenuItem.Text = "Importar desde EXCEL";
            // 
            // txtCed
            // 
            // 
            // 
            // 
            this.txtCed.CustomButton.Image = null;
            this.txtCed.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtCed.CustomButton.Name = "";
            this.txtCed.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCed.CustomButton.TabIndex = 1;
            this.txtCed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCed.CustomButton.UseSelectable = true;
            this.txtCed.CustomButton.Visible = false;
            this.txtCed.Lines = new string[0];
            this.txtCed.Location = new System.Drawing.Point(166, 116);
            this.txtCed.MaxLength = 32767;
            this.txtCed.Name = "txtCed";
            this.txtCed.PasswordChar = '\0';
            this.txtCed.ReadOnly = true;
            this.txtCed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCed.SelectedText = "";
            this.txtCed.SelectionLength = 0;
            this.txtCed.SelectionStart = 0;
            this.txtCed.ShortcutsEnabled = true;
            this.txtCed.Size = new System.Drawing.Size(136, 23);
            this.txtCed.TabIndex = 33;
            this.txtCed.UseSelectable = true;
            this.txtCed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNom
            // 
            // 
            // 
            // 
            this.txtNom.CustomButton.Image = null;
            this.txtNom.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtNom.CustomButton.Name = "";
            this.txtNom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNom.CustomButton.TabIndex = 1;
            this.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNom.CustomButton.UseSelectable = true;
            this.txtNom.CustomButton.Visible = false;
            this.txtNom.Lines = new string[0];
            this.txtNom.Location = new System.Drawing.Point(166, 169);
            this.txtNom.MaxLength = 32767;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.ReadOnly = true;
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(136, 23);
            this.txtNom.TabIndex = 34;
            this.txtNom.UseSelectable = true;
            this.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApe1
            // 
            // 
            // 
            // 
            this.txtApe1.CustomButton.Image = null;
            this.txtApe1.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtApe1.CustomButton.Name = "";
            this.txtApe1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApe1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApe1.CustomButton.TabIndex = 1;
            this.txtApe1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApe1.CustomButton.UseSelectable = true;
            this.txtApe1.CustomButton.Visible = false;
            this.txtApe1.Lines = new string[0];
            this.txtApe1.Location = new System.Drawing.Point(167, 217);
            this.txtApe1.MaxLength = 32767;
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.PasswordChar = '\0';
            this.txtApe1.ReadOnly = true;
            this.txtApe1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApe1.SelectedText = "";
            this.txtApe1.SelectionLength = 0;
            this.txtApe1.SelectionStart = 0;
            this.txtApe1.ShortcutsEnabled = true;
            this.txtApe1.Size = new System.Drawing.Size(136, 23);
            this.txtApe1.TabIndex = 35;
            this.txtApe1.UseSelectable = true;
            this.txtApe1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApe1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApe2
            // 
            // 
            // 
            // 
            this.txtApe2.CustomButton.Image = null;
            this.txtApe2.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtApe2.CustomButton.Name = "";
            this.txtApe2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApe2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApe2.CustomButton.TabIndex = 1;
            this.txtApe2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApe2.CustomButton.UseSelectable = true;
            this.txtApe2.CustomButton.Visible = false;
            this.txtApe2.Lines = new string[0];
            this.txtApe2.Location = new System.Drawing.Point(166, 266);
            this.txtApe2.MaxLength = 32767;
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.PasswordChar = '\0';
            this.txtApe2.ReadOnly = true;
            this.txtApe2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApe2.SelectedText = "";
            this.txtApe2.SelectionLength = 0;
            this.txtApe2.SelectionStart = 0;
            this.txtApe2.ShortcutsEnabled = true;
            this.txtApe2.Size = new System.Drawing.Size(136, 23);
            this.txtApe2.TabIndex = 36;
            this.txtApe2.UseSelectable = true;
            this.txtApe2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApe2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(110, 116);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Cédula";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(105, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Nombre";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(98, 221);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Apellido 1";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(96, 270);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "Apellido 2";
            // 
            // FrmInfoCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 698);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtApe2);
            this.Controls.Add(this.txtApe1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lbProjections);
            this.Controls.Add(this.lbCredits);
            this.Controls.Add(this.btnNewProjection);
            this.Controls.Add(this.dtvProyeccion);
            this.Controls.Add(this.dtvCreditos);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmInfoCreditos";
            this.Text = "información de Creditos";
            this.Load += new System.EventHandler(this.FrmInfoCreditos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProyeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel lbProjections;
        private MetroFramework.Controls.MetroLabel lbCredits;
        private MetroFramework.Controls.MetroButton btnNewProjection;
        private System.Windows.Forms.DataGridView dtvProyeccion;
        private System.Windows.Forms.DataGridView dtvCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plazo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarDesdeXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDesdeTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarDesdeEXCELToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox txtCed;
        private MetroFramework.Controls.MetroTextBox txtNom;
        private MetroFramework.Controls.MetroTextBox txtApe1;
        private MetroFramework.Controls.MetroTextBox txtApe2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
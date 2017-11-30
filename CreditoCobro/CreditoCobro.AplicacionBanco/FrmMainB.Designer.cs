namespace CreditoCobro.AplicacionBanco
{
    partial class FrmMainB
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plnMenu = new System.Windows.Forms.Panel();
            this.BtnMore = new System.Windows.Forms.Button();
            this.BtnPays = new System.Windows.Forms.Button();
            this.BtnArchives = new System.Windows.Forms.Button();
            this.rec1 = new System.Windows.Forms.Panel();
            this.btnProyections = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.plnTop = new System.Windows.Forms.Panel();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pClock = new System.Windows.Forms.Panel();
            this.lbClock = new MetroFramework.Controls.MetroLabel();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInstitucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCreditos = new System.Windows.Forms.DataGridView();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtgProyeccion = new System.Windows.Forms.DataGridView();
            this.plnMenu.SuspendLayout();
            this.plnTop.SuspendLayout();
            this.pClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProyeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 494);
            this.panel2.TabIndex = 1;
            // 
            // plnMenu
            // 
            this.plnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plnMenu.Controls.Add(this.BtnMore);
            this.plnMenu.Controls.Add(this.BtnPays);
            this.plnMenu.Controls.Add(this.BtnArchives);
            this.plnMenu.Controls.Add(this.rec1);
            this.plnMenu.Controls.Add(this.btnProyections);
            this.plnMenu.Controls.Add(this.panel9);
            this.plnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plnMenu.Location = new System.Drawing.Point(3, 38);
            this.plnMenu.Name = "plnMenu";
            this.plnMenu.Size = new System.Drawing.Size(55, 618);
            this.plnMenu.TabIndex = 4;
            this.plnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // BtnMore
            // 
            this.BtnMore.BackgroundImage = global::CreditoCobro.AplicacionBanco.Properties.Resources.menu2;
            this.BtnMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMore.FlatAppearance.BorderSize = 0;
            this.BtnMore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMore.Location = new System.Drawing.Point(10, 8);
            this.BtnMore.Name = "BtnMore";
            this.BtnMore.Size = new System.Drawing.Size(33, 33);
            this.BtnMore.TabIndex = 13;
            this.BtnMore.UseVisualStyleBackColor = true;
            this.BtnMore.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPays
            // 
            this.BtnPays.FlatAppearance.BorderSize = 0;
            this.BtnPays.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnPays.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnPays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPays.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPays.Image = global::CreditoCobro.AplicacionBanco.Properties.Resources.point_of_service;
            this.BtnPays.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPays.Location = new System.Drawing.Point(9, 275);
            this.BtnPays.Name = "BtnPays";
            this.BtnPays.Size = new System.Drawing.Size(182, 39);
            this.BtnPays.TabIndex = 12;
            this.BtnPays.Text = "&Aplicación de Pagos";
            this.BtnPays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPays.UseVisualStyleBackColor = true;
            // 
            // BtnArchives
            // 
            this.BtnArchives.FlatAppearance.BorderSize = 0;
            this.BtnArchives.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnArchives.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnArchives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArchives.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArchives.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnArchives.Image = global::CreditoCobro.AplicacionBanco.Properties.Resources.file1;
            this.BtnArchives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnArchives.Location = new System.Drawing.Point(6, 198);
            this.BtnArchives.Name = "BtnArchives";
            this.BtnArchives.Size = new System.Drawing.Size(182, 39);
            this.BtnArchives.TabIndex = 11;
            this.BtnArchives.Text = "&Nuevo Archivo  Planilla";
            this.BtnArchives.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnArchives.UseVisualStyleBackColor = true;
            // 
            // rec1
            // 
            this.rec1.BackColor = System.Drawing.Color.White;
            this.rec1.Location = new System.Drawing.Point(7, 104);
            this.rec1.Name = "rec1";
            this.rec1.Size = new System.Drawing.Size(188, 1);
            this.rec1.TabIndex = 8;
            this.rec1.Visible = false;
            // 
            // btnProyections
            // 
            this.btnProyections.FlatAppearance.BorderSize = 0;
            this.btnProyections.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnProyections.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnProyections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyections.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyections.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProyections.Image = global::CreditoCobro.AplicacionBanco.Properties.Resources.credit_card2;
            this.btnProyections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyections.Location = new System.Drawing.Point(4, 122);
            this.btnProyections.Name = "btnProyections";
            this.btnProyections.Size = new System.Drawing.Size(182, 39);
            this.btnProyections.TabIndex = 10;
            this.btnProyections.Text = "&Proyección de Créditos";
            this.btnProyections.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProyections.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::CreditoCobro.AplicacionBanco.Properties.Resources.money;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel9.Location = new System.Drawing.Point(74, 18);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(68, 71);
            this.panel9.TabIndex = 8;
            // 
            // plnTop
            // 
            this.plnTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plnTop.Controls.Add(this.BtnMinimize);
            this.plnTop.Controls.Add(this.btnMaximize);
            this.plnTop.Controls.Add(this.btnClose);
            this.plnTop.Controls.Add(this.metroLabel1);
            this.plnTop.Controls.Add(this.panel7);
            this.plnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plnTop.Location = new System.Drawing.Point(3, 3);
            this.plnTop.Name = "plnTop";
            this.plnTop.Size = new System.Drawing.Size(1042, 35);
            this.plnTop.TabIndex = 5;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Image = global::CreditoCobro.AplicacionBanco.Properties.Resources.minus_symbol1;
            this.BtnMinimize.Location = new System.Drawing.Point(968, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(22, 35);
            this.BtnMinimize.TabIndex = 9;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::CreditoCobro.AplicacionBanco.Properties.Resources.expand;
            this.btnMaximize.Location = new System.Drawing.Point(990, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 35);
            this.btnMaximize.TabIndex = 10;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::CreditoCobro.AplicacionBanco.Properties.Resources.cross_out1;
            this.btnClose.Location = new System.Drawing.Point(1015, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(6, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Bank App";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(197, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(710, 453);
            this.panel7.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 656);
            this.panel3.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 656);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1045, 3);
            this.panel6.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1045, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 653);
            this.panel8.TabIndex = 7;
            // 
            // pClock
            // 
            this.pClock.Controls.Add(this.lbClock);
            this.pClock.Dock = System.Windows.Forms.DockStyle.Right;
            this.pClock.Location = new System.Drawing.Point(949, 38);
            this.pClock.Name = "pClock";
            this.pClock.Size = new System.Drawing.Size(96, 618);
            this.pClock.TabIndex = 8;
            // 
            // lbClock
            // 
            this.lbClock.AutoSize = true;
            this.lbClock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbClock.Location = new System.Drawing.Point(42, 8);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(51, 19);
            this.lbClock.TabIndex = 12;
            this.lbClock.Text = "-------";
            this.lbClock.UseCustomBackColor = true;
            this.lbClock.UseCustomForeColor = true;
            // 
            // Clock
            // 
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToResizeColumns = false;
            this.dtgClientes.AllowUserToResizeRows = false;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Nombre,
            this.Apellido,
            this.Apellido2,
            this.IdInstitucion});
            this.dtgClientes.Location = new System.Drawing.Point(77, 49);
            this.dtgClientes.MultiSelect = false;
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(443, 139);
            this.dtgClientes.TabIndex = 9;
            this.dtgClientes.Click += new System.EventHandler(this.dtgClientes_CellContentClick);
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
            // dtgCreditos
            // 
            this.dtgCreditos.AllowUserToResizeColumns = false;
            this.dtgCreditos.AllowUserToResizeRows = false;
            this.dtgCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCreditos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monto,
            this.Tasa,
            this.Plazo});
            this.dtgCreditos.Location = new System.Drawing.Point(526, 49);
            this.dtgCreditos.MultiSelect = false;
            this.dtgCreditos.Name = "dtgCreditos";
            this.dtgCreditos.ReadOnly = true;
            this.dtgCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCreditos.Size = new System.Drawing.Size(343, 139);
            this.dtgCreditos.TabIndex = 10;
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
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(526, 205);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(343, 23);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar Proyeccion";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtgProyeccion
            // 
            this.dtgProyeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProyeccion.Location = new System.Drawing.Point(77, 235);
            this.dtgProyeccion.Name = "dtgProyeccion";
            this.dtgProyeccion.Size = new System.Drawing.Size(792, 412);
            this.dtgProyeccion.TabIndex = 12;
            // 
            // FrmMainB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1048, 659);
            this.Controls.Add(this.dtgProyeccion);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtgCreditos);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.pClock);
            this.Controls.Add(this.plnMenu);
            this.Controls.Add(this.plnTop);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.FrmMainB_Load);
            this.plnMenu.ResumeLayout(false);
            this.plnTop.ResumeLayout(false);
            this.plnTop.PerformLayout();
            this.pClock.ResumeLayout(false);
            this.pClock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProyeccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel plnMenu;
        private System.Windows.Forms.Panel plnTop;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnProyections;
        private System.Windows.Forms.Panel rec1;
        private System.Windows.Forms.Button BtnArchives;
        private System.Windows.Forms.Button BtnPays;
        private System.Windows.Forms.Button BtnMore;
        private System.Windows.Forms.Panel pClock;
        private MetroFramework.Controls.MetroLabel lbClock;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInstitucion;
        private System.Windows.Forms.DataGridView dtgCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plazo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dtgProyeccion;
    }
}
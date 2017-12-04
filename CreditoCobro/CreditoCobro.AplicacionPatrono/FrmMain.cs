using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditoCobro.AplicacionPatrono
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //55; 618
            //200; 618
            if (plnMenu.Height == 624 & plnMenu.Width == 55)
            {
                plnMenu.Height = 624;
                plnMenu.Width = 200;
                rec1.Visible = true;
                BtnMore.Location = new Point(162, 8);
                btnProyections.Enabled = true;
                //BtnArchives.Enabled = true;
               
                //btnNewOper.Enabled = true;
            }
            else
            {
                plnMenu.Height = 624;
                plnMenu.Width = 55;
                rec1.Visible = false;
                BtnMore.Location = new Point(10, 8);
                btnProyections.Enabled = false;
                //bt.Enabled = false;
               
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnProyections.Enabled = false;
            //BtnArchives.Enabled = false;
            
        }
        private void CerrarProyecciones(object sender, CancelEventArgs e)
        {
            projections = null;
        }
        FrmInfoCreditos projections;
        private void btnProyections_Click(object sender, EventArgs e)
        {
            if (projections == null)
            {
                projections = new FrmInfoCreditos();
                projections.FormClosing += CerrarProyecciones;
                projections.Show();
            }
            else
            {
                projections.Focus();
            }
        }

        private void BtnPays_Click(object sender, EventArgs e)
        {
            
        }
    }
}

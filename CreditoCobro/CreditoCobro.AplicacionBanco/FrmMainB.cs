using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreditoCobro.NegocioBanco;
using CreditoCobro.DTO;

namespace CreditoCobro.AplicacionBanco
{
    public partial class FrmMainB : Form
    {
        public FrmMainB()
        {
            InitializeComponent();
            
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            //55; 618
            //200; 618
            if (plnMenu.Height == 618 & plnMenu.Width == 55)
            {
                plnMenu.Height = 618;
                plnMenu.Width = 200;
                rec1.Visible = true;
                BtnMore.Location = new Point(162,8);
                btnProyections.Enabled = true;
                BtnArchives.Enabled = true;
                BtnPays.Enabled = true;
                btnNewClient.Enabled = true;
                btnNewOper.Enabled = true;
            }
            else
            {
                plnMenu.Height = 618;
                plnMenu.Width = 55;
                rec1.Visible = false;
                BtnMore.Location = new Point(10,8);
                btnProyections.Enabled = false;
                BtnArchives.Enabled = false;
                BtnPays.Enabled = false;
                btnNewClient.Enabled = false;
                btnNewOper.Enabled = false;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                
            }
            else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void btnProyections_Click(object sender, EventArgs e)
        {
            FrmProjections projections = new FrmProjections();
            projections.Show();
        }

        private void FrmMainB_Load(object sender, EventArgs e)
        {
            Clock.Start();
            btnProyections.Enabled = false;
            BtnArchives.Enabled = false;
            BtnPays.Enabled = false;
        }
    }
}
;
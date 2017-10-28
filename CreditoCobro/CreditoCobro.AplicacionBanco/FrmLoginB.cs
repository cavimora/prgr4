using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditoCobro.AplicacionBanco
{
    public partial class FrmLoginB : MetroFramework.Forms.MetroForm
    {
        public FrmLoginB()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void ChShowPsw_CheckedChanged(object sender, EventArgs e)
        {
            if (ChShowPsw.Checked == true)
            {
                TxtPassword.UseSystemPasswordChar = false;
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmMainB Form1 = new FrmMainB();
            Form1.Show();
            
        }
    }
}

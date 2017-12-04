using CreditoCobro.NegocioPatrono;
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
    public partial class FrmLoginP : MetroFramework.Forms.MetroForm
    {
        public FrmLoginP()
        {
            InitializeComponent();
        }

        private void FrmLoginP_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
             clsLogin log = new clsLogin();

            if (log.LoginUsuario(TxtUser.Text.Trim(), TxtPassword.Text.Trim()))
            {
                FrmMain Form1 = new FrmMain();
                Form1.Show();
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "No se pudo realizar el login", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}

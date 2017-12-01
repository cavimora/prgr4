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
    public partial class FrmClients : MetroFramework.Forms.MetroForm
    {
        public FrmClients()
        {
            InitializeComponent();
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {

        }

        FrmOperations operations;
        private void btnNewOper_Click(object sender, EventArgs e)
        {
            if(operations == null)
            {
                operations = new FrmOperations();
                operations.Show();
            }
            else
            {
                operations.Focus();
            }
        }
    }
}

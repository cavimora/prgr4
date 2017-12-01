using CreditoCobro.DTO;
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
    public partial class FrmOperations : MetroFramework.Forms.MetroForm
    {
        public FrmOperations()
        {
            InitializeComponent();
        }

        private DtoCliente _cliente;

        public FrmOperations(DtoCliente cliente)
        {
            InitializeComponent();

            _cliente = cliente;
        }

        private void FrmOperations_Load(object sender, EventArgs e)
        {

        }
    }
}

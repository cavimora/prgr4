using CreditoCobro.DTO;
using CreditoCobro.NegocioBanco;
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
        private Clientes _nclientes;
        private Credito _ncredito;
        private List<DtoCliente> _clientes;

        public FrmClients()
        {
            InitializeComponent();
            _nclientes = new Clientes();
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            _clientes = _nclientes.GetClientes();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dtvClientes.DataSource = null;
            dtvClientes.DataSource = _clientes;
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

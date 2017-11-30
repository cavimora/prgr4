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

    public partial class FrmProjections : MetroFramework.Forms.MetroForm
    {
        private Clientes _nclientes;
        private Credito _ncredito;
        private List<DtoCliente> _clientes;
        public FrmProjections()
        {
            InitializeComponent();
            _nclientes = new Clientes();
        }
           
        private void FrmProjections_Load(object sender, EventArgs e)
        {
            _clientes = _nclientes.GetClientes();
            CargarClientes();
        }
        private void CargarClientes()
        {
            dtvClientes.DataSource = null;
            dtvClientes.DataSource = _clientes;
        }
        private void btnNewProjection_Click(object sender, EventArgs e)
        {
            var index = dtvCreditos.CurrentCell.RowIndex;
            _ncredito = new Credito(_cDetallado.Creditos.ElementAt(index));
            dtvProyeccion.DataSource = null;
            dtvProyeccion.DataSource = _ncredito.GetProyeccion();
        }
        DtoCliente _cDetallado;
        private void dtvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dtvClientes.CurrentCell.RowIndex;
            _cDetallado = _nclientes.GetCliente(_clientes.ElementAt(index).IdCliente);
            dtvProyeccion.DataSource = null;
            dtvCreditos.DataSource = null;
            dtvCreditos.DataSource = _cDetallado.Creditos;
        }
    }
}

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
    public partial class FrmOperations : MetroFramework.Forms.MetroForm
    {

        private Clientes _nclientes;
        public FrmOperations()
        {
            InitializeComponent();
        }

        private DtoCliente _cliente;
        private Credito _ncredito;

        public FrmOperations(DtoCliente cliente)
        {
            InitializeComponent();

            _cliente = cliente;
            _nclientes = new Clientes();
            _cliente = _nclientes.GetCliente(_cliente.IdCliente);

            txtMonto.Enabled = false;
            txtPlazo.Enabled = false;
            txtTasa.Enabled = false;
        }

        private void FrmOperations_Load(object sender, EventArgs e)
        {
            dtvCreditos.DataSource = _cliente.Creditos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text.Trim().ToLower().Equals("nuevo"))
            {
                btnNuevo.Text = "Guardar";
                btnEliminar.Text = "Cancelar";

                txtMonto.Enabled = true;
                txtMonto.Text = "";
                txtPlazo.Enabled = true;
                txtPlazo.Text = "";
                txtTasa.Enabled = true;
                txtTasa.Text = "";
            }
            else
            {
                try
                {
                    if (txtMonto.Text.Trim() == "" && txtPlazo.Text.Trim() == "" && txtTasa.Text.Trim() == "")
                    {
                        throw new Exception("Todos los campos deben tener datos");
                    }
                    else
                    {
                        DtoCredito cred = new DtoCredito()
                        {
                            Monto = double.Parse(txtMonto.Text),
                            Tasa = double.Parse(txtTasa.Text),
                            Plazo = int.Parse(txtPlazo.Text),
                        };
                        _ncredito = new Credito(cred);
                        if (_ncredito.AddCredito(cred, _cliente))
                        {
                            txtMonto.Enabled = false;
                            txtMonto.Text = "";
                            txtPlazo.Enabled = false;
                            txtPlazo.Text = "";
                            txtTasa.Enabled = false;
                            txtTasa.Text = "";

                            btnNuevo.Text = "Nuevo";
                            btnEliminar.Text = "Eliminar";

                            _cliente = _nclientes.GetCliente(_cliente.IdCliente);
                            dtvCreditos.DataSource = _cliente.Creditos;
                        }
                    }
                }
                catch(Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (btnEliminar.Text.Trim().ToLower().Equals("cancelar"))
            {
                txtMonto.Enabled = false;
                txtMonto.Text = "";
                txtPlazo.Enabled = false;
                txtPlazo.Text = "";
                txtTasa.Enabled = false;
                txtTasa.Text = "";

                btnNuevo.Text = "Nuevo";
                btnEliminar.Text = "Eliminar";
            }
            else
            {
                var index = dtvCreditos.CurrentCell.RowIndex;
                _ncredito = new Credito(_cliente.Creditos.ElementAt(index));

                if(_ncredito.DeleteCredito(_cliente.Creditos.ElementAt(index)))
                {
                    _cliente = _nclientes.GetCliente(_cliente.IdCliente);
                    dtvCreditos.DataSource = _cliente.Creditos;
                }
            }
        }
    }
}

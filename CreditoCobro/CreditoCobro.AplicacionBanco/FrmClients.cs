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
            //this.FormClosing += WindowClose;
            _nclientes = new Clientes();
        }



        private void FrmClients_Load(object sender, EventArgs e)
        {

            CargarClientes();
        }

        private void CargarClientes()
        {
            _clientes = _nclientes.GetClientes();
            dtvClientes.DataSource = null;
            dtvClientes.DataSource = _clientes;
        }

        FrmOperations operations;
        private void btnNewOper_Click(object sender, EventArgs e)
        {
            if (operations == null)
            {
                operations = new FrmOperations();
                operations.Show();
            }
            else
            {
                operations.Focus();
            }
        }

        private void FrmClients_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void dtvClientes_Click(object sender, EventArgs e)
        {

        }


        private void LimpiarCampos()
        {
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
        }

        private void ManejoDeCampos(bool estado)
        {
            txtApellido1.Enabled = estado;
            txtApellido2.Enabled = estado;
            txtCedula.Enabled = estado;
            txtNombre.Enabled = estado;
        }

        private void btnNewProjection_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text.Trim().ToLower().Equals("nuevo"))
            {
                ManejoDeCampos(true);
                LimpiarCampos();
                btnNuevo.Text = "Guardar";
                btnEliminar.Text = "Cancelar";
                //btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
                txtCedula.Focus();
            }
            else
            {
                try
                {
                    if (txtApellido1.Text.Trim() != "" && txtApellido2.Text.Trim() != "" && txtCedula.Text.Trim() != "" && txtNombre.Text.Trim() != "")
                    {
                        DtoCliente nCliente = new DtoCliente()
                        {
                            Apellido1 = txtApellido1.Text,
                            Apellido2 = txtApellido2.Text,
                            IdCliente = txtCedula.Text,
                            Nombre = txtNombre.Text
                        };
                        if (_nclientes.AddCliente(nCliente))
                        {
                            CargarClientes();
                            LimpiarCampos();
                            ManejoDeCampos(false);
                            btnNuevo.Text = "Nuevo";
                            btnEliminar.Text = "Eliminar";
                            btnEliminar.Enabled = true;
                            btnEditar.Enabled = true;
                        }
                    }
                    else
                    {
                        throw new Exception("Todos los campos tienen que tener Valores");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text.Trim().ToLower().Equals("editar"))
            {
                var index = dtvClientes.CurrentCell.RowIndex;
                txtApellido1.Text = _clientes.ElementAt(index).Apellido1;
                txtApellido2.Text = _clientes.ElementAt(index).Apellido2;
                txtCedula.Text = _clientes.ElementAt(index).IdCliente;
                txtNombre.Text = _clientes.ElementAt(index).Nombre;
                ManejoDeCampos(true);
                txtCedula.Enabled = false;
                btnEditar.Text = "Guardar";
                btnEliminar.Text = "Cancelar";
                //btnEliminar.Enabled = false;
                btnNuevo.Enabled = false;
            }
            else
            {
                try
                {
                    if (txtApellido1.Text.Trim() != "" && txtApellido2.Text.Trim() != "" && txtCedula.Text.Trim() != "" && txtNombre.Text.Trim() != "")
                    {
                        DtoCliente nCliente = new DtoCliente()
                        {
                            Apellido1 = txtApellido1.Text,
                            Apellido2 = txtApellido2.Text,
                            IdCliente = txtCedula.Text,
                            Nombre = txtNombre.Text
                        };
                        if (_nclientes.EditCliente(nCliente))
                        {
                            CargarClientes();
                            LimpiarCampos();
                            ManejoDeCampos(false);
                            btnEditar.Text = "Editar";
                            btnEliminar.Text = "Eliminar";
                            btnEliminar.Enabled = true;
                            btnNuevo.Enabled = true;
                        }
                    }
                    else
                    {
                        throw new Exception("Todos los campos tienen que tener Valores");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (btnEliminar.Text.Trim().ToLower().Equals("cancelar"))
            {
                btnEditar.Text = "Editar";
                btnNuevo.Text = "Nuevo";
                btnEliminar.Text = "Eliminar";
                btnEditar.Enabled = true;
                ManejoDeCampos(false);
                LimpiarCampos();
                btnNuevo.Enabled = true;
            }
            else
            {
                var index = dtvClientes.CurrentCell.RowIndex;
                if(MessageBox.Show("¿Seguro que desea eliminar al cliente con id " + _clientes.ElementAt(index).IdCliente + " y todos sus registros?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        if (_nclientes.DeleteCliente(_clientes.ElementAt(index)))
                        {
                                CargarClientes();
                                LimpiarCampos();
                                ManejoDeCampos(false);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}

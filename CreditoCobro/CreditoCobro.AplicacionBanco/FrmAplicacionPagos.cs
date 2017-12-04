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
    public partial class FrmAplicacionPagos : MetroFramework.Forms.MetroForm
    {
        string vFileDialog;
        public FrmAplicacionPagos()
        {
            InitializeComponent();
        }
        private void btnPagos_Click(object sender, EventArgs e)
        {
            foreach (var credito in _creditos.Rows)
            {
                var idCred = int.Parse(((System.Data.DataRow)credito)["IdCred"].ToString());
                var proyecciones = ((System.Data.DataRow)credito)["Proyeccion"];
                foreach (var proyeccion in ((DataTable)proyecciones).Rows)
                {
                    int idProyeccion = int.Parse(((System.Data.DataRow)proyeccion)["Cuota"].ToString());
                    bool isPago = bool.Parse(((System.Data.DataRow)proyeccion)["isPago"].ToString());
                    Proyecciones.UpdateProyeccion(idCred, idProyeccion, isPago);
                }
            }
        }
               
        private System.Data.DataTable _creditos;
        public void cargarXML()
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "XML|*.xml";    // Se define el tipo de dato a cargar

            if (oFD.ShowDialog() == DialogResult.OK)  //si se selecciona OK
            {
                dtvProyeccion.Rows.Clear();
                vFileDialog = oFD.FileName;   // guardamos en la variable el documento seleccionado
                System.Data.DataTable rXML = new System.Data.DataTable();
                rXML.ReadXml(vFileDialog);
                // dtvProyeccion.DataSource = rXML;
                txtCed.Text = rXML.Rows[0]["Cedula"].ToString();
                txtNom.Text = rXML.Rows[0]["Nombre"].ToString();
                txtApe1.Text = rXML.Rows[0]["Apellido 1"].ToString();
                txtApe2.Text = rXML.Rows[0]["Apellido 2"].ToString();
                _creditos = ((System.Data.DataTable)rXML.Rows[0]["Creditos"]);
                dtvCreditos.DataSource = _creditos;
            }
        }

        private void importarDesdeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarXML();
        }

        private void dtvCreditos_Click(object sender, EventArgs e)
        {
            var index = dtvCreditos.CurrentCell.RowIndex;
            dtvProyeccion.DataSource = null;
            dtvProyeccion.DataSource = _creditos.Rows[index]["Proyeccion"];
        }

        private void FrmAplicacionPagos_Load(object sender, EventArgs e)
        {
            
        }
    }
}

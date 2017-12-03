using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreditoCobro.Negocio;
namespace CreditoCobro.AplicacionPatrono
{
    public partial class FrmProyection : MetroFramework.Forms.MetroForm
    {
        string vFileDialog;
        DataTable tXML;
        public FrmProyection()
        {
            InitializeComponent();
        }
        public System.Data.DataTable llenarXML(DataGridView pDTG)
        {
            System.Data.DataTable tResultado = new System.Data.DataTable();
            tResultado.TableName = "aXML";
            tResultado.Columns.Add("Cuota");
            tResultado.Columns.Add("Principal");
            tResultado.Columns.Add("Intereses");
            tResultado.Columns.Add("Saldo");
            tResultado.Columns.Add("Pago");

            foreach (DataGridViewRow dgv in pDTG.Rows)
            {
                DataRow row = tResultado.NewRow();

                row["Cuota"] = dgv.Cells[0].Value.ToString();
                row["Principal"] = dgv.Cells[1].Value.ToString();
                row["Intereses"] = dgv.Cells[2].Value.ToString();
                row["Saldo"] = dgv.Cells[3].Value.ToString();
                row["Pago"] = dgv.Cells[4].Value.ToString();

                tResultado.Rows.Add(row);

            }

            return tResultado;
        }
        //metodo para generar archivo XML
        public void exportarXML()
        {
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Filter = "XML|*.xml";     //se definen los tipos de datos
            if (sFD.ShowDialog() == DialogResult.OK)
            {
                vFileDialog = sFD.FileName;  //se le asigna un nombre
                tXML.WriteXml(vFileDialog, XmlWriteMode.WriteSchema);
            }
        }
        private void FrmProyection_Load(object sender, EventArgs e)
        {

        }

        private void dtvCreditos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbCredits_Click(object sender, EventArgs e)
        {

        }
    }
}

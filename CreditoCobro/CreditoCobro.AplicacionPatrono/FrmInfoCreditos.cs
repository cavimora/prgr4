using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace CreditoCobro.AplicacionPatrono
{
    public partial class FrmInfoCreditos : MetroFramework.Forms.MetroForm
    {
        string vFileDialog;
        public System.Data.DataTable tXML;
        OleDbConnection oleDbConnection;
        OleDbDataAdapter oleDbDataAdapter;
        System.Data.DataTable tExcel;
        public FrmInfoCreditos()
        {
            InitializeComponent();
        }

        private void FrmInfoCreditos_Load(object sender, EventArgs e)
        {

        }

        #region Metodos exportar/Importar

        //metodo para exportar archivos texto plano 

        
        
        //metodo para generar archivo XML
       

        //metodo para importar xml
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

                dtvCreditos.DataSource = ((System.Data.DataTable)rXML.Rows[0]["Proyeccion"]);
            }
        }

        public void cargarTxt()
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "TEXTO PLANO|*.txt";    // Se define el tipo de dato a cargar            
            char caracter = '|';
            dtvProyeccion.DataSource = null;
            if (oFD.ShowDialog() == DialogResult.OK)  //si se selecciona OK
            {
                vFileDialog = oFD.FileName;   // guardamos en la variable el documento seleccionado
                lecturaArchivo(dtvProyeccion, caracter, vFileDialog);
            }
        }

        //Metodo para cargar los titulos del datagridview
        public void nombrarTitulos(DataGridView tabla, string[] titulos)
        {
            for (int i = 0; i <= tabla.ColumnCount - 1; i++)
            {
                tabla.Columns[i].HeaderText = titulos[i];
            }
        }

        //metodo para agregar las filas al datagridview
        public void agregarFila(DataGridView tabla, string Linea, char caracter, int fila)
        {
            string[] aFilas = Linea.Split(caracter);
            tabla.Rows.Add(aFilas);
        }

        //metodo para leer el txt
        public void lecturaArchivo(DataGridView tabla, char caracter, string ruta)
        {
            StreamReader sReader = new StreamReader(ruta);
            int fila = 0;
            string Linea = "";
            //tabla.Rows.Clear();
            do
            {
                Linea = sReader.ReadLine();
                if ((Linea != null))
                {
                    if (fila == 0)
                    {
                        tabla.ColumnCount = Linea.Split(caracter).Length;
                        nombrarTitulos(tabla, Linea.Split(caracter));
                        fila += 1;
                    }
                    else
                    {
                        agregarFila(tabla, Linea, caracter, fila);
                        fila += 1;
                    }
                }
            }
            while (!(Linea == null));
            {
                sReader.Close();
            }
        }

        //metodo para importar Excel
        public void cargarExcel()
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "EXCEL| *.xlsx"; //se define el formato de importacion
            if (oFD.ShowDialog() == DialogResult.OK)  //si se selecciona OK
            {
                vFileDialog = oFD.FileName;   // guardamos en la variable el documento seleccionado
                oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source =" + vFileDialog + ";Extended Properties = 'Excel 12.0 Xml;HDR=Yes'");
                oleDbDataAdapter = new OleDbDataAdapter("Select * From [Hoja1$]", oleDbConnection);
                tExcel = new System.Data.DataTable();
                oleDbDataAdapter.Fill(tExcel);
                dtvProyeccion.DataSource = tExcel;
            }
        }
        #endregion
        private void documentoXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importarDesdeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarXML();
        }
    }
}

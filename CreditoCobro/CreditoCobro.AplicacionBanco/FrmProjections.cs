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
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;


namespace CreditoCobro.AplicacionBanco
{

    public partial class FrmProjections : MetroFramework.Forms.MetroForm
    {
        private Clientes _nclientes;
        private Credito _ncredito;
        private List<DtoCliente> _clientes;
        string vFileDialog;
        public System.Data.DataTable tXML;


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
            try
            {
                var index = dtvCreditos.CurrentCell.RowIndex;
                _ncredito = new Credito(_cDetallado.Creditos.ElementAt(index));
                dtvProyeccion.DataSource = null;
                dtvProyeccion.DataSource = _ncredito.GetProyeccion();
                tXML = llenarXML(dtvProyeccion);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe seleccionar la información de la persona deseada ", "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        DtoCliente _cDetallado;
        private void dtvClientes_Click(object sender, EventArgs e)
        {
            var index = dtvClientes.CurrentCell.RowIndex;
            _cDetallado = _nclientes.GetCliente(_clientes.ElementAt(index).IdCliente);
            dtvProyeccion.DataSource = null;
            dtvCreditos.DataSource = null;
            dtvCreditos.DataSource = _cDetallado.Creditos;
        }

        private void BtnArchives_Click(object sender, EventArgs e)
        {
            ///Codigo Para Exportar Los Datos de un Cliente
            //ExportarExcel();
        }


        #region Metodos Exportacion/Importacion
        //metodo para exportar archivos excel
        public void ExportarExcel()
        {
            SaveFileDialog oFD = new SaveFileDialog();
            oFD.Filter = "Excel|*.xlsx"; // Se define el tipo de dato a guardar 
            if (oFD.ShowDialog() == DialogResult.OK)  //si se selecciona OK
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 20;
                vFileDialog = oFD.FileName;   // guardamos en la variable el documento seleccionado

                for (int i = 1; i < dtvProyeccion.Columns.Count + 1; i++) // se recorren las columnas del dtvClientes
                {
                    ExcelApp.Cells[1, i] = dtvProyeccion.Columns[i - 1].HeaderText; // Se colocan las header del dtvClientes
                }

                for (int i = 0; i < dtvProyeccion.Rows.Count; i++) // se recorren las filas 
                {
                    for (int j = 0; j < dtvProyeccion.Columns.Count; j++)// se recorren cada columns de la fila
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dtvProyeccion.Rows[i].Cells[j].Value.ToString(); // se alamcena la fila de la posicion i y la columna j
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(oFD.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }

        //metodo para exportar archivos texto plano 

        public void exportarTxt()
        {
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Filter = "TEXTO PLANO|*.txt";     //se definen los tipos de datos
            if (sFD.ShowDialog() == DialogResult.OK)
            {
                vFileDialog = sFD.FileName;  //se le asigna un nombre
                TextWriter sWriter = new StreamWriter(vFileDialog);
                sWriter.Write("\t" + "Cuota" + "\t" + "|" + "\t" + "Principal" + "\t" + "|" + "\t" + "Intereses" + "\t" + "|" + "\t" + "Saldo" + "\t" + "|" + "\t" + "isPago" + "\t" + Environment.NewLine);
                sWriter.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < dtvProyeccion.Rows.Count; i++)
                {
                    for (int j = 0; j < dtvProyeccion.Columns.Count; j++)
                    {
                        sWriter.Write("\t" + dtvProyeccion.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    sWriter.WriteLine("");
                    sWriter.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                }
                sWriter.Close();
            }
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
                dtvProyeccion.DataSource = rXML;
            }
        }

        public void cargarTxt()
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "TEXTO PLANO|*.txt";    // Se define el tipo de dato a cargar            
            char caracter = '|';

            if (oFD.ShowDialog() == DialogResult.OK)  //si se selecciona OK
            {
                vFileDialog = oFD.FileName;   // guardamos en la variable el documento seleccionado
                lecturaArchivo(dtvClientes, caracter, vFileDialog);
            }
        }

        //Metodo para cargar los titulos del datagridview
        public static void nombrarTitulos(DataGridView tabla, string[] titulos)
        {
            for (int i = 0; i <= tabla.ColumnCount - 1; i++)
            {
                tabla.Columns[i].HeaderText = titulos[i];
            }
        }

        //metodo para agregar las filas al datagridview
        public static void agregarFila(DataGridView tabla, string Linea, char caracter, int fila)
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
            tabla.Rows.Clear();

            do
            {
                Linea = sReader.ReadLine();
                if ((Linea != null))
                {
                    if (fila == 0)
                    {
                        dtvProyeccion.ColumnCount = Linea.Split(caracter).Length;
                        nombrarTitulos(dtvProyeccion, Linea.Split(caracter));
                        fila += 1;
                    }
                    else
                    {
                        agregarFila(dtvClientes, Linea, caracter, fila);
                        fila += 1;
                    }
                }
            }
            while (!(Linea == null));
            {
                sReader.Close();
            }
        }


        #endregion

        private void documentoExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        private void textoPlanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportarTxt();
        }

        private void documentoXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportarXML();

        }

        private void importarDesdeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarXML();
        }

    }    

}

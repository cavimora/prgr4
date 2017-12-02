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

namespace CreditoCobro.AplicacionBanco
{

    public partial class FrmProjections : MetroFramework.Forms.MetroForm
    {
        private Clientes _nclientes;
        private Credito _ncredito;
        private List<DtoCliente> _clientes;
        string vFileDialog;
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
            Exportar();
        }


        #region Metodos Ecportacion/Importacion
        //metodo para exportar archivos
        public void Exportar()
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "Excel|*.xlxs";
            oFD.Filter = "Bloc de Notas|*.txt";
            // oFD.Filter = "Excel|*.xml";// Se define el tipo de dato a guardar

            if (oFD.ShowDialog() == DialogResult.OK)  //si se selecciona OK
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                ExcelApp.Aplication.workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 20;
                vFileDialog = oFD.FileName;   // guardamos en la variable el documento seleccionado

                for (int i = 1; i < dtvClientes.Columns.Count + 1; i++) // se recorren las columnas del dtvClientes
                {
                    ExcelApp.Cells[1, i] = dtvClientes.Rows[i - 1].HeaderCell; // Se colocan las header del dtvClientes
                }

                for (int i = 0; i < dtvClientes.Rows.Count; i++) // se recorren las filas 
                {
                    for (int j = 0; j < dtvClientes.Columns.Count; j++)// se recorren cada columns de la fila
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dtvClientes.Rows[i].Cells[j].Value.ToString(); // se alamcena la fila de la posicion i y la columna j
                    }
                }

                ExcelApp.ActiveWorkBook.SaveCopyAs(oFD.FileName.ToString());
                ExcelApp.ActiveWorkBook.Saved = true;
                ExcelApp.Quit();
            }
        }

        //metodo para importar archivos
        public void Importar()
        {
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Filter = "Excel|*.xlxs";     //se definen los tipos de datos
            sFD.Filter = "Bloc de Notas|*.txt";     //se definen los tipos de datos

            if (vFileDialog != null)  // si el archivo ya existe
            {
                using (StreamWriter sWriter = new StreamWriter(vFileDialog))
                {
                    sWriter.Write(dtvClientes.Text); // se sobreescribe
                }
            }
            else // si el archivo no existe
            {
                if (sFD.ShowDialog() == DialogResult.OK)
                {
                    vFileDialog = sFD.FileName;  //se le asigna un nombre
                    using (StreamWriter sWriter = new StreamWriter(sFD.FileName))
                    {
                        sWriter.Write(dtvClientes.Text); //lo guarda el archivo con el nombre asignado con anterioridad
                    }
                }
            }
        }
        #endregion
    }
}

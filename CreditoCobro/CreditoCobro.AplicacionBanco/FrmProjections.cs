﻿using System;
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
            oFD.Filter = "Excel|*.xlsx|XML|*.xml|TXT|*.txt";// Se define el tipo de dato a guardar 
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
            //TextWriter sw = new TextWriter("@C:\Users\luisd\OneDrive\Documentos\CarpetaDefault\");
        }
         
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using CreditoCobro.DTO;
using CreditoCobro.Datos;

namespace CreditoCobro.NegocioBanco
{
    public class Credito
    {
        private List<DtoProyeccion> _proyeccion;
        private int _decimalPoints;
        private DtoCredito _credito;
        private Entities _db;

        public Credito(DtoCredito credito)
        {
            _decimalPoints = 2;
            _credito = credito;


        }

        public List<DtoProyeccion> GetProyeccion()
        {
            double cuota = Math.Round((Financial.Pmt(_credito.Tasa / 100, _credito.Plazo, -_credito.Monto)), _decimalPoints, MidpointRounding.AwayFromZero);//*100)/100;
            double saldo = _credito.Monto;
            _proyeccion = new List<DtoProyeccion>();
            //int i = 1;
            //while(saldo > 0)
            for (int i = 0; i < _credito.Plazo; i++)
            {
                var intereses = Math.Round((saldo * (_credito.Tasa / 100)), _decimalPoints, MidpointRounding.AwayFromZero);//*100)/100;
                var principal = Math.Round((cuota - intereses), _decimalPoints, MidpointRounding.AwayFromZero);//*100)/100;
                saldo = Math.Round((saldo - principal), _decimalPoints, MidpointRounding.AwayFromZero);//*100)/100;
                //saldo = saldo < 0 ? Math.Round(saldo) : saldo;
                _proyeccion.Add(new DtoProyeccion()
                {
                    Cuota = i + 1,
                    Intereses = intereses,
                    Principal = principal,
                    Saldo = saldo
                });
            }

            return _proyeccion;
        }


        //private void CargarInfoCredito()
        //{
        //    try
        //    {
        //        using (_db = new Entities())
        //        {
        //            var res = (from creds in _db.B_Credito
        //                      where creds.IdCredito == _creditoId
        //                      select new
        //                      {
        //                          Monto = creds.MontoAprobado,
        //                          Tasa = creds.Tasa,
        //                          Plazo = creds.Plazo
        //                      }).FirstOrDefault();
        //            if (res != null)
        //            {
        //                this.Monto = (double)res.Monto;
        //                this.Tasa = (double)res.Tasa;
        //                this.Plazo = (int)res.Plazo;
        //                return;
        //            }
        //            throw new Exception("No se pudo encontrar el crédito con el Id: " + _creditoId.ToString());

        //        }
        //    }
        //    catch(Exception ex)
        //    {

        //    }
        //}
        //private double Round(double dNumber)
        //{
        //    string sNumber = dNumber.ToString();
        //    string[] arrNumber = sNumber.Split(',');
        //    if(arrNumber.Count() > 1)
        //        dNumber = Convert.ToInt32(arrNumber[1].ToCharArray()[0]) >= 5 ? Convert.ToDouble(arrNumber[0]) + 1 : dNumber = Convert.ToDouble(arrNumber[0]) - 1;
        //    return dNumber;
        //}
    }
}

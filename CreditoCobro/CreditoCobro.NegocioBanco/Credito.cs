using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using CreditoCobro.DTO;

namespace CreditoCobro.NegocioBanco
{
    public class Credito
    {
        public string Operacion { get; set; }
        public double Monto { get; set; }
        public double Tasa { get; set; }
        public int Plazo { get; set; }

        private List<DtoProyeccion> _proyeccion;
        private int _decimalPoints;

        public Credito()
        {
            _decimalPoints = 2;
        }

        public List<DtoProyeccion> GetProyeccion()
        {
            double cuota = Math.Round((Financial.Pmt(Tasa / 100, Plazo, -Monto)), _decimalPoints, MidpointRounding.AwayFromZero);//*100)/100;
            double saldo = Monto;
            _proyeccion = new List<DtoProyeccion>();
            //int i = 1;
            //while(saldo > 0)
            for (int i = 0; i < Plazo; i++)
            {
                var intereses = Math.Round((saldo * (Tasa / 100)), _decimalPoints, MidpointRounding.AwayFromZero);//*100)/100;
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

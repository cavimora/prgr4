using CreditoCobro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditoCobro.Datos;

namespace CreditoCobro.NegocioBanco
{
    public static class Proyecciones
    {
        //public List<DtoProyeccion> _proyecciones;
        public static Entities _db;


        //public Proyecciones() { }

        public static bool AddProyecciones(List<DtoProyeccion> proyecciones, DtoCredito credito)
        {
            try
            {
                using (_db = new Entities())
                {
                    foreach (DtoProyeccion proyeccion in proyecciones)
                    {
                        B_Proyeccion dbProy = new B_Proyeccion()
                        {
                            IdCredito = credito.Id,
                            IdCuota = proyeccion.Cuota,
                            AlDia = proyeccion.IsPago,
                            //Amortiza = proyeccion.Principal,
                            Principal = (decimal)proyeccion.Principal,
                            Intereses = (decimal)proyeccion.Intereses,
                            Saldo = (decimal)proyeccion.Saldo
                        };
                        _db.B_Proyeccion.Add(dbProy);
                    }
                    if (_db.SaveChanges() <= 0) throw new Exception("Ocurrio un error a la hora de guardar las proyecciones en la base de datos");
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool UpdateProyeccion(int idCredito, int idProyeccion, bool estado)
        {
            try
            {
                using (_db = new Entities())
                {
                    var proyeccion = _db.B_Proyeccion.Where(p => p.IdCredito == idCredito && p.IdCuota == idProyeccion).FirstOrDefault();
                    if (proyeccion != null)
                        proyeccion.AlDia = estado;
                    else
                    {

                    }
                    if (_db.SaveChanges() <= 0) { } //throw new Exception("No se pudo actualizar el pago");
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static List<DtoProyeccion> GetProyecciones(int idCredito)
        {
            List<DtoProyeccion> proyecciones;
            try
            {
                proyecciones = new List<DtoProyeccion>();

                using (_db = new Entities())
                {
                    proyecciones = (from p in _db.B_Proyeccion
                                   where p.IdCredito == idCredito
                                   select new DtoProyeccion
                                   {
                                       Cuota = p.IdCuota,
                                       Intereses = (double)p.Intereses,
                                       IsPago = (bool)p.AlDia,
                                       Principal = (double)p.Principal,
                                       Saldo = (double)p.Saldo
                                   }).ToList();
                }

                return proyecciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

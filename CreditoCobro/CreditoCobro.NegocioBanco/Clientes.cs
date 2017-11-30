using CreditoCobro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditoCobro.Datos;

namespace CreditoCobro.NegocioBanco
{
    public class Clientes
    {
        private List<DtoCliente> _clientes;
        private DtoCliente _cliente;
        private Entities _db;

        public Clientes() { }

        /// <summary>
        /// Retorna una lista de clientes sin detalles de los creditos
        /// </summary>
        /// <returns></returns>
        public List<DtoCliente> GetClientes()
        {
            try
            {
                using (_db = new Entities())
                {
                    _clientes = (from cliente in _db.B_Cliente
                                 select new DtoCliente
                                 {
                                     Apellido1 = cliente.Apellido1,
                                     Apellido2 = cliente.Apellido2,
                                     IdCliente = cliente.IdCliente,
                                     IdInstitucion = (int)cliente.IdInstitucion,
                                     Nombre = cliente.Nombre
                                 }).ToList();
                    return _clientes;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna detalles de un cliente, incluyendo la lista de creditos a nombre de el
        /// </summary>
        /// <param name="idCliente">Id del cliente</param>
        /// <returns></returns>
        public DtoCliente GetCliente(string idCliente)
        {
            try
            {
                using (_db = new Entities())
                {
                    _cliente = (from cliente in _db.B_Cliente
                                where cliente.IdCliente == idCliente
                                select new DtoCliente
                                {
                                    Apellido1 = cliente.Apellido1,
                                    Apellido2 = cliente.Apellido2,
                                    IdCliente = cliente.IdCliente,
                                    IdInstitucion = (int)cliente.IdInstitucion,
                                    Nombre = cliente.Nombre
                                }).FirstOrDefault();

                    _cliente.Creditos = (from creds in _db.B_Credito
                                         where creds.IdCliente == idCliente
                                         select new DtoCredito
                                         {
                                             Monto = (double)creds.MontoAprobado,
                                             Plazo = (int)creds.Plazo,
                                             Tasa = (double)creds.Tasa

                                         }).ToList();

                    return _cliente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

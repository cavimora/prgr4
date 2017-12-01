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

        public bool AddCliente(DtoCliente cliente)
        {
            try
            {
                using (_db = new Entities())
                {
                    var exists = _db.B_Cliente.Where(c => c.IdCliente.Trim().Equals(cliente.IdCliente.Trim())).FirstOrDefault();
                    if (exists != null) throw new Exception("El Id: " + cliente.IdCliente.ToString() + " ya esta asociado a otro cliente");
                    var institucion = _db.B_Institucion.FirstOrDefault();
                    B_Cliente nuevoCliente = new B_Cliente()
                    {
                        Nombre = cliente.Nombre,
                        Apellido1 = cliente.Apellido1,
                        Apellido2 = cliente.Apellido2,
                        IdCliente = cliente.IdCliente,
                        IdInstitucion = institucion.IdInstitucion
                    };
                    _db.B_Cliente.Add(nuevoCliente);
                    if (_db.SaveChanges() <= 0) throw new Exception("Hubo un problema a la hora de ingresar el cliente, por favor intente de nuevo.");
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditCliente(DtoCliente cliente)
        {
            try
            {
                using (_db = new Entities())
                {
                    var dbCliente = _db.B_Cliente.Where(c => c.IdCliente.Trim().Equals(cliente.IdCliente.Trim())).FirstOrDefault();
                    if (dbCliente != null)
                    {
                        dbCliente.Nombre = cliente.Nombre;
                        dbCliente.Apellido1 = cliente.Apellido1;
                        dbCliente.Apellido2 = cliente.Apellido2;
                        dbCliente.IdCliente = cliente.IdCliente;
                        if (_db.SaveChanges() <= 0) throw new Exception("Hubo un problema a la hora de modificar el cliente, por favor intente de nuevo.");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteCliente(DtoCliente cliente)
        {
            try
            {
                using (_db = new Entities())
                {
                    var dbCliente = _db.B_Cliente.Where(c => c.IdCliente.Trim().Equals(cliente.IdCliente.Trim())).FirstOrDefault();
                    if (dbCliente != null)
                    {
                        _db.B_Cliente.Remove(dbCliente);
                        if (_db.SaveChanges() <= 0) throw new Exception("Hubo un problema a la hora de eliminar el cliente, por favor intente de nuevo.");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

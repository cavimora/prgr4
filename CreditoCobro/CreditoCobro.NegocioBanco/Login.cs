using CreditoCobro.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoCobro.NegocioBanco
{
    public class Login
    {
        public Login() { }

        public Entities _db;

        public bool LoginUsuario(string usuario, string contrasena)
        {
            try
            {
                using (_db = new Entities())
                {
                    var res = (from u in _db.G_Usuarios
                              where u.usuario == usuario && u.contrasena == contrasena
                              select u).FirstOrDefault();
                    if (res != null)
                        return true;

                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditoCobro.Datos;

namespace CreditoCobro.NegocioBanco
{
    public class Class1
    {
        Entities Context;
        public void getEmpleados()
        {

            using (Context = new Entities())
            {
                var res = from empleados in Context.P_Empleado
                          select empleados;
            }
        }
    }
}

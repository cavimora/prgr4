using System.Collections.Generic;

namespace CreditoCobro.DTO
{
    public class DtoCliente
    {
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int IdInstitucion { get; set; }

        public List<DtoCredito> Creditos { get; set; }
    }
}

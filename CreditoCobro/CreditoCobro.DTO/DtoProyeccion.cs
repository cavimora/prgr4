namespace CreditoCobro.DTO
{
    public class DtoProyeccion
    {
        public int Cuota { get; set; }
        public double Principal { get; set; }
        public double Intereses { get; set; }
        public double Saldo { get; set; }
        public bool IsPago { get; set; }
    }
}

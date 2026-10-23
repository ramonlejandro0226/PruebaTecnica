namespace PruebaTecnica.Models
{
    public class Facturas
    {
        public int Id { get; set; }

        public int IdOrdenes { get; set; }


        public DateTime Fecha { get; set; }

        public Ordenes ordenes { get; set; }
    }
}

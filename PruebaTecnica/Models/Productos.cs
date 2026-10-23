namespace PruebaTecnica.Models
{
    public class Productos
    {

        public int Id { get; set; }

        public required string nombre { get; set; }

        public int Precio { get; set; }

        public required string Provedor { get; set; }


    }
}

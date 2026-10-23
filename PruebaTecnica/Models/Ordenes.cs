namespace PruebaTecnica.Models
{
    public class Ordenes
    {
        public int Id { get; set; }


        public int IdClientes { get; set; }

        public int IdProductos { get; set; }

        public ICollection<Productos> Productos { get; set; }

        public ICollection<Clientes> Clientes { get; set; }

    }
}

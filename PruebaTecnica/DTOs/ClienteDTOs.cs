namespace PruebaTecnica.DTOs
{
    public class ClienteDTOs
    {

        public record ClienteDTO(int ID, string Nombre, string Apellido);


       public record ClienteCreateDTO(string Nombre, string Apellido);

    }
}

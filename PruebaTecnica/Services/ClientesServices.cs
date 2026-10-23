using PruebaTecnica.DTOs;

namespace PruebaTecnica.Services
{
    public class ClientesServices : ClientesInterface
    {
        public Task<ClienteDTOs.ClienteDTO> CreateClientesAsync(string Nombre, string Apellido)
        {

            return Task.FromResult(new ClienteDTOs.ClienteDTO
            {
                ID = new Random().Next(1, 1000),
                Nombre = Nombre,
                Apellido = Apellido
            });

        }
    }
}

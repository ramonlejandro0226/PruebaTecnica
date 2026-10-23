using static PruebaTecnica.DTOs.ClienteDTOs;

namespace PruebaTecnica.Services
{
    public interface ClientesInterface
    {

        Task<ClienteDTO> CreateClientesAsync(string Nombre, string Apellido);

    }
}

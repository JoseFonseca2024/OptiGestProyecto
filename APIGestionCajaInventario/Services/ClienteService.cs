using APIGestionCajaInventario.DAO.Interfaces;
using APIGestionCajaInventario.DAO;
using APIGestionCajaInventario.Dto.Clientes;
using APIGestionCajaInventario.Models;
using System.Security.Claims;
using APIGestionCajaInventario.Services.Interfaces;

namespace APIGestionCajaInventario.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _repository;
        private readonly UsuarioDAO _usuarioDAO;

        public ClienteService(IClienteRepository repository, UsuarioDAO usuarioDAO)
        {
            _repository = repository;
            _usuarioDAO = usuarioDAO;
        }

        public async Task<IEnumerable<ClienteDto>> ObtenerPorEmpresaAsync(ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);
            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var clientes = await _repository.GetAllPorEmpresaAsync(empresa.EmpresaID);

            return clientes.Select(c => new ClienteDto
            {
                ClienteID = c.ClienteID,
                NombreCliente = c.NombreCliente,
                TelefonoCliente = c.TelefonoCliente
            });
        }

        public async Task<ClienteDto?> ObtenerPorIdAsync(int id, ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);
            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var cliente = await _repository.GetByIdPorEmpresaAsync(id, empresa.EmpresaID);
            if (cliente == null) return null;

            return new ClienteDto
            {
                ClienteID = cliente.ClienteID,
                NombreCliente = cliente.NombreCliente,
                TelefonoCliente = cliente.TelefonoCliente
            };
        }

        public async Task<int> CrearAsync(ClienteCreateDto dto, ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);
            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var cliente = new Cliente
            {
                NombreCliente = dto.NombreCliente,
                TelefonoCliente = dto.TelefonoCliente,
                EmpresaID = empresa.EmpresaID
            };

            return await _repository.CreateAsync(cliente);
        }

        public async Task<bool> ActualizarAsync(int id, ClienteUpdateDto dto, ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);
            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var cliente = await _repository.GetByIdPorEmpresaAsync(id, empresa.EmpresaID);
            if (cliente == null) return false;

            cliente.NombreCliente = dto.NombreCliente;
            cliente.TelefonoCliente = dto.TelefonoCliente;

            return await _repository.UpdateAsync(cliente);
        }

        public async Task<bool> EliminarAsync(int id, ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);
            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            return await _repository.DeletePorEmpresaAsync(id, empresa.EmpresaID);
        }
    }
}

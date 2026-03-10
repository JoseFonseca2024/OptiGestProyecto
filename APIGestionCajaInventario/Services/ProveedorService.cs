using System.Security.Claims;
using APIGestionCajaInventario.DAO;
using APIGestionCajaInventario.DAO.Interfaces;
using APIGestionCajaInventario.Dto.Proveedores;
using APIGestionCajaInventario.Models;

namespace APIGestionCajaInventario.Services
{
    public class ProveedorService
    {
        private readonly IProveedorRepository _repository;
        private readonly UsuarioDAO _usuarioDAO;

        public ProveedorService(IProveedorRepository repository, UsuarioDAO usuarioDAO)
        {
            _repository = repository;
            _usuarioDAO = usuarioDAO;
        }

        public async Task<IEnumerable<ProveedorDto>> ObtenerPorEmpresaAsync(ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);
            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var proveedores = await _repository.GetAllPorEmpresaAsync(empresa.EmpresaID);

            return proveedores.Select(p => new ProveedorDto
            {
                ProveedorID = p.ProveedorID,
                NombreProveedor = p.NombreProveedor,
                TelefonoProveedor = p.TelefonoProveedor,
            });
        }

        public async Task<ProveedorDto?> ObtenerPorIdAsync(int id, ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);
            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var proveedor = await _repository.GetByIdPorEmpresaAsync(id, empresa.EmpresaID);
            if (proveedor == null) return null;

            return new ProveedorDto
            {
                ProveedorID = proveedor.ProveedorID,
                NombreProveedor = proveedor.NombreProveedor,
                TelefonoProveedor = proveedor.TelefonoProveedor,
            };
        }

        public async Task<int> CrearAsync(ProveedorCreateDto dto, ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);
            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var proveedor = new Proveedor
            {
                NombreProveedor = dto.NombreProveedor,
                TelefonoProveedor = dto.TelefonoProveedor,
                EmpresaID = empresa.EmpresaID
            };

            return await _repository.CreateAsync(proveedor);
        }

        public async Task<bool> ActualizarAsync(int id, ProveedorUpdateDto dto, ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);
            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var proveedor = await _repository.GetByIdPorEmpresaAsync(id, empresa.EmpresaID);
            if (proveedor == null) return false;

            proveedor.NombreProveedor = dto.NombreProveedor;
            proveedor.TelefonoProveedor = dto.TelefonoProveedor;

            return await _repository.UpdateAsync(proveedor);
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
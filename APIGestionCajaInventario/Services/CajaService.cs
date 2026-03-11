using APIGestionCajaInventario.DAO.Interfaces;
using APIGestionCajaInventario.DAO;
using APIGestionCajaInventario.Dto.Cajas;
using APIGestionCajaInventario.Models;
using System.Security.Claims;

namespace APIGestionCajaInventario.Services
{
    public class CajaService
    {
        private readonly IRepository<Cajas> _repository;
        private readonly UsuarioDAO _usuarioDAO;

        public CajaService(IRepository<Cajas> repository, UsuarioDAO usuarioDAO)
        {
            _repository = repository;
            _usuarioDAO = usuarioDAO;
        }

        public async Task<IEnumerable<Cajas>> ObtenerCajasPorEmpresaAsync(ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);

            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            return await ((CajaDAO)_repository).GetByEmpresaAsync(empresa.EmpresaID);
        }

        public async Task<CajaDto?> ObtenerPorIdAsync(int id)
        {
            var caja = await _repository.GetByIdAsync(id);
            if (caja == null) return null;

            return new CajaDto
            {
                CajaID = caja.CajaID,
                NombreCaja = caja.NombreCaja,
                SaldoActual = caja.SaldoActual,
                Activa = caja.Activa,
                EmpresaNombre = caja.EmpresaNombre
            };
        }

        public async Task<int> CrearAsync(CajaCreateDto dto, ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);

            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var caja = new Cajas
            {
                NombreCaja = dto.NombreCaja,
                EmpresaID = empresa.EmpresaID,
                Activa = false
            };

            return await _repository.CreateAsync(caja);
        }

        public async Task<bool> ActualizarAsync(int id, CajaUpdateDto dto, ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);
            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var cajaExistente = await _repository.GetByIdAsync(id);
            if (cajaExistente == null || cajaExistente.EmpresaID != empresa.EmpresaID)
                return false;

            cajaExistente.NombreCaja = dto.NombreCaja;
            return await _repository.UpdateAsync(cajaExistente);
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

            var caja = await _repository.GetByIdAsync(id);
            if (caja == null || caja.EmpresaID != empresa.EmpresaID)
                return false;

            return await _repository.DeleteAsync(id);
        }

        public async Task<bool> TransferirAsync(TransferenciaDto dto, ClaimsPrincipal user)
        {
            return await ((CajaDAO)_repository).TransferirAsync(dto.CajaOrigenID, dto.CajaDestinoID, dto.Monto);
        }
    }
}

using APIGestionCajaInventario.DAO;
using APIGestionCajaInventario.Dto.Empresas;
using APIGestionCajaInventario.Models;
using APIGestionCajaInventario.Services.Interfaces;

namespace APIGestionCajaInventario.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly EmpresaDAO _empresaDAO;

        public EmpresaService(EmpresaDAO empresaDAO)
        {
            _empresaDAO = empresaDAO;
        }

        public async Task<int> CrearEmpresaYAsociarAsync(EmpresaCreateDto dto, int usuarioId)
        {
            return await _empresaDAO.CrearEmpresaYAsociarConUsuarioAsync(dto, usuarioId);
        }

        public async Task<Empresa?> ObtenerEmpresaUnicaPorUsuarioAsync(int usuarioId)
        {
            return await _empresaDAO.ObtenerEmpresaUnicaPorUsuarioAsync(usuarioId);
        }

        public async Task<(bool ok, string error)> ActualizarEmpresaAsync(Empresa empresa)
        {
            return await _empresaDAO.ActualizarEmpresaAsync(empresa);
        }

        public async Task<bool> VerificarRucAsync(string ruc)
        {
            var empresas = await _empresaDAO.ObtenerEmpresasPorRucAsync(ruc);
            return empresas.Any();
        }
    }
}

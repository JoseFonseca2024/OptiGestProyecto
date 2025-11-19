using APIGestionCajaInventario.Dto.Empresas;
using APIGestionCajaInventario.Models;

namespace APIGestionCajaInventario.Services.Interfaces
{
    public interface IEmpresaService
    {
        Task<int> CrearEmpresaYAsociarAsync(EmpresaCreateDto dto, int usuarioId);
        Task<Empresa?> ObtenerEmpresaUnicaPorUsuarioAsync(int usuarioId);
        Task<(bool ok, string error)> ActualizarEmpresaAsync(Empresa empresa);
        Task<bool> VerificarRucAsync(string ruc);
    }

}

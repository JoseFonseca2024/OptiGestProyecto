using AppGestionCajaInventario.Models.Dto.Empresas;
using AppGestionCajaInventario.Models.Dto.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository.Interfaces
{
    public interface IAdminRepository
    {
        Task<List<UsuarioDto>> ObtenerUsuariosAsync();
        Task<List<RolDto>> ObtenerRolesAsync();
        Task<bool> RegistrarUsuarioAsync(UsuarioCreateDto dto);
        Task<bool> ActualizarUsuarioAsync(UsuarioUpdateDto dto);

        Task<EmpresaDto?> ObtenerEmpresaDelUsuarioAsync();
        Task<bool> VerificarRucAsync(string ruc);
        Task<int> CrearEmpresaAsync(EmpresaCreateDto dto);
        Task<bool> ActualizarEmpresaAsync(EmpresaUpdateDto dto);
    }
}

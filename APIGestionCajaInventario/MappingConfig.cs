using AutoMapper;
using APIGestionCajaInventario.Models;
using APIGestionCajaInventario.Dto.Empresas;
using APIGestionCajaInventario.Dto.Usuarios;

namespace APIGestionCajaInventario
{
    public class MappingConfig : Profile
        {
        public MappingConfig()
        {
            CreateMap<EmpresaCreateDto, Empresa>().ReverseMap();
            CreateMap<EmpresaUpdateDto, Empresa>().ReverseMap();
            CreateMap<Empresa, EmpresaDto>().ReverseMap();

            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<UsuarioCreateDto, Usuario>();
            CreateMap<UsuarioUpdateDto, Usuario>();

            CreateMap<Rol, RolDto>().ReverseMap();
        }

    }

}

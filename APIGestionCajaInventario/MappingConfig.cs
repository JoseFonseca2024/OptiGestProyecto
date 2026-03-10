using AutoMapper;
using APIGestionCajaInventario.Models;
using APIGestionCajaInventario.Dto.Empresas;
using APIGestionCajaInventario.Dto.Usuarios;
using APIGestionCajaInventario.Dto.Productos;
using APIGestionCajaInventario.Dto.Clientes;
using APIGestionCajaInventario.Dto.Proveedores;

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

            CreateMap<Producto, ProductosDto>().ReverseMap();
            CreateMap<ProductosCreateDto, Producto>();
            CreateMap<ProductosUpdateDto, Producto>();

            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Proveedor, ProveedorDto>().ReverseMap();

            CreateMap<Rol, RolDto>().ReverseMap();
        }

    }

}

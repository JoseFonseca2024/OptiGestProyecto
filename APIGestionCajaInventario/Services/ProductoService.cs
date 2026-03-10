using APIGestionCajaInventario.DAO;
using APIGestionCajaInventario.DAO.Interfaces;
using APIGestionCajaInventario.Dto.Productos;
using APIGestionCajaInventario.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Security.Claims;

namespace APIGestionCajaInventario.Services
{
    public class ProductoService
    {
        private readonly IRepository<Producto> _repository;
        private readonly UsuarioDAO _usuarioDAO;

        public ProductoService(IRepository<Producto> repository, UsuarioDAO usuarioDAO)
        {
            _repository = repository;
            _usuarioDAO = usuarioDAO;
        }

        public async Task<IEnumerable<Producto>> ObtenerProductosPorEmpresaAsync(ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);

            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var productos = await _repository.GetAllAsync();
            return productos.Where(p => p.EmpresaID == empresa.EmpresaID);
        }


        public async Task<ProductosDto?> ObtenerPorIdAsync(int id)
        {
            var producto = await _repository.GetByIdAsync(id);
            if (producto == null) return null;

            return new ProductosDto
            {
                ProductoID = producto.ProductoID,
                NombreProducto = producto.NombreProducto,
                CodigoProducto = producto.CodigoProducto,
                CostoPromedio = producto.CostoPromedio,
                PrecioUnitario = producto.PrecioUnitario,
                StockActual = producto.StockActual
            };
        }

        public async Task<int> CrearAsync(ProductosCreateDto dto, ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);

            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var producto = new Producto
            {
                NombreProducto = dto.NombreProducto,
                CodigoProducto = dto.CodigoProducto,
                CostoPromedio = dto.CostoPromedio,
                PrecioUnitario = dto.PrecioUnitario,
                EmpresaID = empresa.EmpresaID
            };

            return await _repository.CreateAsync(producto);
        }

        public async Task<bool> ActualizarAsync(int id, ProductosUpdateDto dto, ClaimsPrincipal user)
        {
            var usuarioIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (usuarioIdClaim == null)
                throw new UnauthorizedAccessException("Token sin UsuarioID.");

            int usuarioId = int.Parse(usuarioIdClaim.Value);
            var empresa = await _usuarioDAO.ObtenerEmpresaPorUsuarioAsync(usuarioId);
            if (empresa == null)
                throw new InvalidOperationException("Empresa no encontrada para el usuario.");

            var productoExistente = await _repository.GetByIdAsync(id);
            if (productoExistente == null || productoExistente.EmpresaID != empresa.EmpresaID)
                return false; //  no existe o no pertenece a la empresa

            // Actualizamos solo los campos modificables
            productoExistente.NombreProducto = dto.NombreProducto;
            productoExistente.CodigoProducto = dto.CodigoProducto;
            productoExistente.CostoPromedio = dto.CostoPromedio;
            productoExistente.PrecioUnitario = dto.PrecioUnitario;

            return await _repository.UpdateAsync(productoExistente);
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

            var producto = await _repository.GetByIdAsync(id);
            if (producto == null || producto.EmpresaID != empresa.EmpresaID)
                return false; //  no existe o no pertenece a la empresa

            return await _repository.DeleteAsync(id);
        }
    }
}

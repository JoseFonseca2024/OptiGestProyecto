using APIGestionCajaInventario.Dto.Productos;
using APIGestionCajaInventario.Models;
using APIGestionCajaInventario.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionCajaInventario.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductoService _service;

        private readonly IMapper _mapper;

        public ProductosController(ProductoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpGet("por-empresa")]
        public async Task<ActionResult<IEnumerable<ProductosDto>>> GetAll()
        {
            var productos = await _service.ObtenerProductosPorEmpresaAsync(User);
            var dto = _mapper.Map<List<ProductosDto>>(productos);
            return Ok(dto);
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductosDto>> GetById(int id)
        {
            var producto = await _service.ObtenerPorIdAsync(id);
            if (producto == null) return NotFound();
            return Ok(producto);
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ProductosCreateDto dto)
        {
            var id = await _service.CrearAsync(dto, User);
            return CreatedAtAction(nameof(GetById), new { id }, dto);
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] ProductosUpdateDto dto)
        {
            var actualizado = await _service.ActualizarAsync(id, dto, User);
            return actualizado ? NoContent() : NotFound();
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.EliminarAsync(id, User);
            return eliminado ? NoContent() : NotFound();
        }

    }
}

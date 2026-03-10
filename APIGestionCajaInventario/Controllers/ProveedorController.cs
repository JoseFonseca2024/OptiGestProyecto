using APIGestionCajaInventario.Dto.Proveedores;
using APIGestionCajaInventario.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionCajaInventario.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class ProveedorController : ControllerBase
    {
        private readonly ProveedorService _proveedorService;
        private readonly IMapper _mapper;

        public ProveedorController(ProveedorService proveedorService, IMapper mapper)
        {
            _proveedorService = proveedorService;
            _mapper = mapper;
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpGet("por-empresa")]
        public async Task<ActionResult<IEnumerable<ProveedorDto>>> GetAll()
        {
            var proveedores = await _proveedorService.ObtenerPorEmpresaAsync(User);
            return Ok(proveedores);
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpGet("{id}")]
        public async Task<ActionResult<ProveedorDto>> GetById(int id)
        {
            var proveedor = await _proveedorService.ObtenerPorIdAsync(id, User);
            if (proveedor == null) return NotFound();
            return Ok(proveedor);
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ProveedorCreateDto dto)
        {
            var id = await _proveedorService.CrearAsync(dto, User);
            return CreatedAtAction(nameof(GetById), new { id }, dto);
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] ProveedorUpdateDto dto)
        {
            var actualizado = await _proveedorService.ActualizarAsync(id, dto, User);
            return actualizado ? NoContent() : NotFound();
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _proveedorService.EliminarAsync(id, User);
            return eliminado ? NoContent() : NotFound();
        }
    }
}

using APIGestionCajaInventario.Dto.Clientes;
using APIGestionCajaInventario.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionCajaInventario.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClienteController(ClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpGet("por-empresa")]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetAll()
        {
            var clientes = await _clienteService.ObtenerPorEmpresaAsync(User);
            return Ok(clientes);
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteDto>> GetById(int id)
        {
            var cliente = await _clienteService.ObtenerPorIdAsync(id, User);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ClienteCreateDto dto)
        {
            var id = await _clienteService.CrearAsync(dto, User);
            return CreatedAtAction(nameof(GetById), new { id }, dto);
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] ClienteUpdateDto dto)
        {
            var actualizado = await _clienteService.ActualizarAsync(id, dto, User);
            return actualizado ? NoContent() : NotFound();
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _clienteService.EliminarAsync(id, User);
            return eliminado ? NoContent() : NotFound();
        }
    }
}

using APIGestionCajaInventario.Dto;
using APIGestionCajaInventario.Dto.Documentos;
using APIGestionCajaInventario.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionCajaInventario.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentosController : ControllerBase
    {
        private readonly DocumentoService _documentoService;

        public DocumentosController(DocumentoService documentoService)
        {
            _documentoService = documentoService;
        }

        [Authorize(Roles = "Administrador,Cajero")]
        [HttpPost("registrar")]
        public async Task<ActionResult<ApiResponse<DocumentoResponseDto>>> RegistrarDocumento([FromBody] DocumentoRequestDto request)
        {
            try
            {
                var result = await _documentoService.RegistrarDocumentoAsync(request);

                return Ok(new ApiResponse<DocumentoResponseDto>
                {
                    Error = false,
                    Message = "Documento registrado correctamente",
                    Data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<DocumentoResponseDto>
                {
                    Error = true,
                    Message = $"Error al registrar documento: {ex.Message}",
                    Data = null
                });
            }
        }
    }
}

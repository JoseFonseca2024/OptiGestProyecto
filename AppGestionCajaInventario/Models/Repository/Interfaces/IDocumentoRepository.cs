using AppGestionCajaInventario.Models.Dto.Documentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository.Interfaces
{
    public interface IDocumentoRepository
    {
        Task<DocumentoResponseDto?> RegistrarDocumentoAsync(DocumentoRequestDto request);
    }
}

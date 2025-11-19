using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Dto.Empresas
{
    public class EmpresaCreateDto
    {
        public string NombreEmpresa { get; set; } = null!;
        public string RUC { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Actividad { get; set; } = null!;
    }

}

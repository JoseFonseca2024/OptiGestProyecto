using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Models
{
    public class Empresa
    {
        public int EmpresaID { get; set; }

        [Required, StringLength(150)]
        public string NombreEmpresa { get; set; } = string.Empty;

        [Required, StringLength(20)]
        public string RUC { get; set; } = string.Empty;

        [Required, StringLength(200)]
        public string Direccion { get; set; } = string.Empty;

        [Required, StringLength(15)]
        public string Telefono { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string Actividad { get; set; } = string.Empty;
    }
}

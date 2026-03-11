using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Models
{
    public class Cajas
    {
        public int CajaID { get; set; }
        [Required, StringLength(50)]
        public string NombreCaja { get; set; } = string.Empty;
        [Range(0, double.MaxValue)]
        public decimal SaldoActual { get; set; }
        public bool Activa { get; set; } = true;

        [Required]
        public int EmpresaID { get; set; }

        public Empresa? Empresa { get; set; }
        public string EmpresaNombre { get; set; } = string.Empty;
    }
}

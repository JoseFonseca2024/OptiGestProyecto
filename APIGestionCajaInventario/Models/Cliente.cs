using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Models
{
    public class Cliente
    { 
        public int ClienteID { get; set; }
        [Required, StringLength(150)]
        public string NombreCliente { get; set; } = string.Empty;
        [Required, StringLength(15)]
        public string TelefonoCliente { get; set; } = string.Empty;

        [Required]
        public int EmpresaID { get; set; }

        public Empresa? Empresa { get; set; }
    }
}

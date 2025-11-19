using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Models
{
    public class Clientes
    { 
        public int ClienteID { get; set; }
        [Required, StringLength(150)]
        public string NombreCliente { get; set; }
        [Required, StringLength(15)]
        public string TelefonoCliente { get; set; }
    }
}

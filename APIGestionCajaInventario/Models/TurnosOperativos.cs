namespace APIGestionCajaInventario.Models
{
    public class TurnosOperativos
    {
        public int TurnoID { get; set; }
        public int CajaID { get; set; }
        public int UsuarioID { get; set; }
        public decimal MontoInicial { get; set; }
        public decimal? MontoFinal { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime? FechaCierre { get; set; }
        public bool Activo { get; set; }

        // Campos de apoyo para mapeo
        public string NombreCaja { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;
    }
}

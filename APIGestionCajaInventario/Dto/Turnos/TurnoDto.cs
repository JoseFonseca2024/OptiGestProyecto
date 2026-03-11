namespace APIGestionCajaInventario.Dto.Turnos
{
    public class TurnoDto
    {
        public int TurnoID { get; set; }
        public int CajaID { get; set; }
        public string NombreCaja { get; set; } = string.Empty;
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public decimal MontoInicial { get; set; }
        public decimal? MontoFinal { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime? FechaCierre { get; set; }
        public bool Activo { get; set; }
    }

}

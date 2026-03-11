namespace APIGestionCajaInventario.Dto.Turnos
{
    public class TurnoCreateDto
    {
        public int CajaID { get; set; }
        public int UsuarioID { get; set; }
        public decimal MontoInicial { get; set; }
    }

}

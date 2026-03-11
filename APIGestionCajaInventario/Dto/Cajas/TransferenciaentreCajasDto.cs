namespace APIGestionCajaInventario.Dto.Cajas
{
    public class TransferenciaDto
    {
        public int CajaOrigenID { get; set; }
        public int CajaDestinoID { get; set; }
        public decimal Monto { get; set; }
    }
}

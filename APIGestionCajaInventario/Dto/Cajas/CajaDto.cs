namespace APIGestionCajaInventario.Dto.Cajas
{
    public class CajaDto
    {
        public int CajaID { get; set; }
        public string NombreCaja { get; set; } = string.Empty;
        public decimal SaldoActual { get; set; }
        public bool Activa { get; set; }
        public string EmpresaNombre { get; set; } = string.Empty;
    }

}

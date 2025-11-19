namespace APIGestionCajaInventario.Dto.Empresas
{
    public class EmpresaDto
    {
        public int EmpresaID { get; set; }
        public string NombreEmpresa { get; set; } = null!;
        public string RUC { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Actividad { get; set; } = null!;
    }
}

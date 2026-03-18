namespace APIGestionCajaInventario.Dto
{
    public class ApiResponse<T>
    {
        public bool Error { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
    }
}

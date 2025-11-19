namespace APIGestionCajaInventario.Services.Interfaces
{
    public interface IEmailService
    {
        Task EnviarCodigoAsync(string emailDestino, string codigo);
    }
}

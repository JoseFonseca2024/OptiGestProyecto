using APIGestionCajaInventario.Services.Interfaces;
using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;

namespace APIGestionCajaInventario.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task EnviarCodigoAsync(string emailDestino, string codigo)
        {
            var cuenta = _config["Correo:Cuenta"];
            var clave = _config["Correo:ClaveApp"];

            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("Sistema Caja", cuenta));
            mensaje.To.Add(new MailboxAddress("", emailDestino));
            mensaje.Subject = "Código de Verificación - Sistema Caja";

            mensaje.Headers.Add("X-Mailer", "SistemaCajaInventario");
            mensaje.Headers.Add("X-Priority", "3");
            mensaje.Headers.Add("X-MSMail-Priority", "Normal");

            // Cuerpo HTML generado desde plantilla
            mensaje.Body = new TextPart(TextFormat.Html)
            {
                Text = EmailTemplates.GenerateVerificationEmail(codigo)
            };

            using var cliente = new SmtpClient();
            cliente.ServerCertificateValidationCallback = (s, c, h, e) => true;

            await cliente.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            await cliente.AuthenticateAsync(cuenta, clave);
            await cliente.SendAsync(mensaje);
            await cliente.DisconnectAsync(true);
        }
    }
}

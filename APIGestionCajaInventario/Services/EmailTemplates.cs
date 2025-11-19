namespace APIGestionCajaInventario.Services
{
    public static class EmailTemplates
    {
        public static string GenerateVerificationEmail(string code)
        {
            return $@"
<!DOCTYPE html>
<html lang='es'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Código de Verificación</title>
    <style>
        body {{
            font-family: 'Roboto', Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f5f5f5;
            color: #202124;
        }}
        .container {{
            max-width: 600px;
            margin: 0 auto;
            background-color: #ffffff;
            border: 1px solid #e0e0e0;
            border-radius: 8px;
            overflow: hidden;
        }}
        .header {{
            background-color: #1a73e8;
            color: #ffffff;
            padding: 20px;
            text-align: center;
        }}
        .header h1 {{
            margin: 0;
            font-size: 24px;
            font-weight: 500;
        }}
        .content {{
            padding: 30px;
            text-align: left;  /* Texto de introducción alineado a la izquierda */
        }}
        .content p {{
            font-size: 16px;
            line-height: 1.5;
            margin: 20px 0;
        }}
        .welcome {{
            font-size: 18px;
            font-weight: bold;
            color: #1a73e8;
        }}
        .code-box {{
            display: block;  /* Cambié a block para mejor centrado */
            margin: 20px auto;  /* Centra horizontalmente */
            background-color: #f8f9fa;
            border: 2px solid #1a73e8;
            border-radius: 8px;
            padding: 20px;
            font-size: 32px;
            font-weight: bold;
            color: #1a73e8;
            letter-spacing: 4px;
            text-align: center;  /* Texto dentro centrado */
            width: fit-content;  /* Ajusta al contenido */
        }}
        .footer {{
            background-color: #f8f9fa;
            padding: 20px;
            text-align: center;
            font-size: 12px;
            color: #5f6368;
            border-top: 1px solid #e0e0e0;
        }}
        .footer a {{
            color: #1a73e8;
            text-decoration: none;
        }}
        .footer p {{
            margin: 5px 0;
        }}
    </style>
</head>
<body>
    <div class='container'>
        <div class='header'>
            <h1>Sistema de Gestion Optima de Caja e Inventario</h1>
            <p>Verificación de Seguridad</p>
        </div>
        <div class='content'>
            <p class='welcome'>¡Bienvenido al Sistema de Gestión Óptima de Caja e Inventario!</p>
            <p>Este sistema está diseñado para lograr una gestión óptima y estandarizada en los procesos de registro dentro de tu negocio. Se enfoca en el control preciso de las transacciones entre las cuentas de Caja e Inventario, permitiéndote registrar productos con nombre, costo, precio con IVA y stock.</p>
            <p>Además, almacena movimientos de ventas y compras que afectan simultáneamente ambas cuentas: en una venta, se incrementa la Caja y se reduce el inventario; en una compra, disminuye la Caja y aumenta el stock. Cada operación se registra con fecha, monto y variación de existencias, brindándote una perspectiva clara y confiable para una mejor toma de decisiones.</p>
            <p>Para comenzar, verifica tu cuenta con el siguiente código:</p>
            <div class='code-box'>{code}</div>
            <p>Este código expira en <strong>3 minutos</strong>. Si no lo usas a tiempo, solicita uno nuevo.</p>
            <p>Si no solicitaste este código, ignora este mensaje o contacta a nuestro soporte.</p>
        </div>
        <div class='footer'>
            <p><strong>Sistema de Gestion Optima de Caja e Inventario</strong> - Servicio Seguro de Verificación</p>
            <p>¿Necesitas ayuda? <a href='mailto:soporte@sistemacaja.com'>Contáctanos</a></p>
            <p>Este es un mensaje automático. No respondas a este email.</p>
            <p><a href='#'>Política de Privacidad</a> | <a href='#'>Términos de Servicio</a></p>
        </div>
    </div>
</body>
</html>";
        }
    }

}

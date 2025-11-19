namespace APIGestionCajaInventario.Data
{
    internal static class Procedimientos
    {
        public const string SP_VALIDARUSUARIO = "sp_validarusuario";
        public const string SP_REGISTRARUSUARIOINICIAL = "sp_RegistrarUsuarioInicial";
        public const string SP_VERIFICAR_USUARIO_O_CORREO = "sp_verificar_usuario_o_correo";
        public const string SP_CREAR_EMPRESA_Y_ASOCIAR_CON_USUARIO = "sp_CrearEmpresaYAsociarconUsuario";
        public const string SP_ACTUALIZAR_EMPRESA = "sp_ActualizarEmpresa";
        public const string SP_VERIFICAR_ACCESO_EMPRESA = "sp_VerificarAccesoEmpresa";
        public const string SP_OBTENER_USUARIOS_POR_EMPRESA = "sp_obtener_usuarios_por_empresa";
        public const string SP_OBTENER_EMPRESA_POR_USUARIO = "sp_obtener_empresa_por_usuario";
        public const string SP_REGISTRAR_USUARIO_EN_EMPRESA = "sp_registrar_usuario_en_empresa";
        public const string SP_ACTUALIZAR_USUARIO = "sp_actualizar_usuario";
    }
}

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

        // Productos
        public const string SP_OBTENER_PRODUCTOS = "sp_obtener_productos";
        public const string SP_OBTENER_PRODUCTOS_POR_ID = "sp_obtener_productos_por_id";
        public const string SP_CREAR_PRODUCTO = "sp_crear_producto";
        public const string SP_ACTUALIZAR_PRODUCTO = "sp_actualizar_producto";
        public const string SP_ELIMINAR_PRODUCTO = "sp_eliminar_producto";
        public const string SP_OBTENER_PRODUCTOS_POR_EMPRESA = "sp_obtener_productos_por_empresa";

        // Clientes
        public const string SP_OBTENER_CLIENTES_POR_EMPRESA = "sp_listar_clientes_por_empresa";
        public const string SP_OBTENER_CLIENTE_POR_ID = "sp_obtener_cliente_por_empresa";
        public const string SP_CREAR_CLIENTE = "sp_crear_cliente";
        public const string SP_ACTUALIZAR_CLIENTE = "sp_actualizar_cliente_por_empresa";
        public const string SP_ELIMINAR_CLIENTE = "sp_eliminar_cliente_por_empresa";

        // Proveedores
        public const string SP_OBTENER_PROVEEDORES_POR_EMPRESA = "sp_listar_proveedores_por_empresa";
        public const string SP_OBTENER_PROVEEDOR_POR_ID = "sp_obtener_proveedor_por_empresa";
        public const string SP_CREAR_PROVEEDOR = "sp_crear_proveedor";
        public const string SP_ACTUALIZAR_PROVEEDOR = "sp_actualizar_proveedor_por_empresa";
        public const string SP_ELIMINAR_PROVEEDOR = "sp_eliminar_proveedor_por_empresa";

        //Cajas
        public const string SP_OBTENER_CAJAS = "sp_obtener_cajas";
        public const string SP_OBTENER_CAJA_POR_ID = "sp_obtener_caja_por_id";
        public const string SP_OBTENER_CAJAS_POR_EMPRESA = "sp_obtener_cajas_por_empresa";
        public const string SP_CREAR_CAJA = "sp_crear_caja";
        public const string SP_ACTUALIZAR_CAJA = "sp_actualizar_caja";
        public const string SP_ELIMINAR_CAJA = "sp_eliminar_caja";
        public const string SP_TRANSFERENCIA_ENTRE_CAJAS = "sp_TransferenciaEntreCajas";

        //Turnos
        public const string SP_ABRIR_TURNO = "sp_abrir_turno";
    }
}

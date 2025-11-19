namespace AppGestionCajaInventario
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            mstPrincipal = new MenuStrip();
            imiUsuarios = new FontAwesome.Sharp.IconMenuItem();
            registrarNuevoUsuarioToolStripMenuItem = new ToolStripMenuItem();
            registroDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            imiEmpresas = new FontAwesome.Sharp.IconMenuItem();
            imiTurnos = new FontAwesome.Sharp.IconMenuItem();
            iniciarNuevoTurnoToolStripMenuItem = new ToolStripMenuItem();
            historialDeTurnosToolStripMenuItem = new ToolStripMenuItem();
            cerrarTurnoToolStripMenuItem = new ToolStripMenuItem();
            imiFacturar = new FontAwesome.Sharp.IconMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            reciboDeCajaToolStripMenuItem = new ToolStripMenuItem();
            imiComprar = new FontAwesome.Sharp.IconMenuItem();
            imiCotizar = new FontAwesome.Sharp.IconMenuItem();
            imiCajas = new FontAwesome.Sharp.IconMenuItem();
            verCajasToolStripMenuItem = new ToolStripMenuItem();
            imiInventario = new FontAwesome.Sharp.IconMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            promocionesToolStripMenuItem = new ToolStripMenuItem();
            imiClientes = new FontAwesome.Sharp.IconMenuItem();
            imiProveedores = new FontAwesome.Sharp.IconMenuItem();
            imiAjustes = new FontAwesome.Sharp.IconMenuItem();
            notasDeCreditoToolStripMenuItem = new ToolStripMenuItem();
            generarUnaNuevaNotaToolStripMenuItem = new ToolStripMenuItem();
            notasDeDebitoToolStripMenuItem = new ToolStripMenuItem();
            generarNuevaNotaToolStripMenuItem = new ToolStripMenuItem();
            imiOperaciones = new FontAwesome.Sharp.IconMenuItem();
            verLasOperacionesRegistradasToolStripMenuItem = new ToolStripMenuItem();
            verDocumentosRegistradosToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            cotizacionesToolStripMenuItem = new ToolStripMenuItem();
            notasDeCreditoToolStripMenuItem1 = new ToolStripMenuItem();
            notasDeCreditoToolStripMenuItem2 = new ToolStripMenuItem();
            notasDeDebitoToolStripMenuItem1 = new ToolStripMenuItem();
            verMovimientosToolStripMenuItem2 = new ToolStripMenuItem();
            movimientosDeCajaToolStripMenuItem = new ToolStripMenuItem();
            movimientosDeInventarioToolStripMenuItem = new ToolStripMenuItem();
            imiCerrarSesion = new FontAwesome.Sharp.IconMenuItem();
            mstTitulo = new MenuStrip();
            tslTitulo = new ToolStripLabel();
            lblFechayHora = new Label();
            fechayhora = new System.Windows.Forms.Timer(components);
            timerFechayHora = new System.Windows.Forms.Timer(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            mstPrincipal.SuspendLayout();
            mstTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 146);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 555);
            panel1.TabIndex = 7;
            // 
            // mstPrincipal
            // 
            mstPrincipal.Items.AddRange(new ToolStripItem[] { imiUsuarios, imiEmpresas, imiTurnos, imiFacturar, imiComprar, imiCotizar, imiCajas, imiInventario, imiClientes, imiProveedores, imiAjustes, imiOperaciones });
            mstPrincipal.Location = new Point(0, 73);
            mstPrincipal.Name = "mstPrincipal";
            mstPrincipal.Padding = new Padding(7, 2, 0, 2);
            mstPrincipal.Size = new Size(1311, 73);
            mstPrincipal.TabIndex = 5;
            mstPrincipal.Text = "menuStrip1";
            // 
            // imiUsuarios
            // 
            imiUsuarios.DropDownItems.AddRange(new ToolStripItem[] { registrarNuevoUsuarioToolStripMenuItem, registroDeUsuariosToolStripMenuItem });
            imiUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            imiUsuarios.IconColor = Color.Black;
            imiUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiUsuarios.IconSize = 50;
            imiUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            imiUsuarios.Name = "imiUsuarios";
            imiUsuarios.Size = new Size(64, 69);
            imiUsuarios.Text = "Usuarios";
            imiUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // registrarNuevoUsuarioToolStripMenuItem
            // 
            registrarNuevoUsuarioToolStripMenuItem.Name = "registrarNuevoUsuarioToolStripMenuItem";
            registrarNuevoUsuarioToolStripMenuItem.Size = new Size(198, 22);
            registrarNuevoUsuarioToolStripMenuItem.Text = "Registrar nuevo usuario";
            registrarNuevoUsuarioToolStripMenuItem.Click += registrarNuevoUsuarioToolStripMenuItem_Click;
            // 
            // registroDeUsuariosToolStripMenuItem
            // 
            registroDeUsuariosToolStripMenuItem.Name = "registroDeUsuariosToolStripMenuItem";
            registroDeUsuariosToolStripMenuItem.Size = new Size(198, 22);
            registroDeUsuariosToolStripMenuItem.Text = "Registro de Usuarios";
            registroDeUsuariosToolStripMenuItem.Click += registroDeUsuariosToolStripMenuItem_Click;
            // 
            // imiEmpresas
            // 
            imiEmpresas.IconChar = FontAwesome.Sharp.IconChar.Building;
            imiEmpresas.IconColor = Color.Black;
            imiEmpresas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiEmpresas.IconSize = 50;
            imiEmpresas.ImageScaling = ToolStripItemImageScaling.None;
            imiEmpresas.Name = "imiEmpresas";
            imiEmpresas.Size = new Size(69, 69);
            imiEmpresas.Text = "Empresas";
            imiEmpresas.TextImageRelation = TextImageRelation.ImageAboveText;
            imiEmpresas.Click += imiEmpresas_Click;
            // 
            // imiTurnos
            // 
            imiTurnos.DropDownItems.AddRange(new ToolStripItem[] { iniciarNuevoTurnoToolStripMenuItem, historialDeTurnosToolStripMenuItem, cerrarTurnoToolStripMenuItem });
            imiTurnos.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            imiTurnos.IconColor = Color.Black;
            imiTurnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiTurnos.IconSize = 50;
            imiTurnos.ImageScaling = ToolStripItemImageScaling.None;
            imiTurnos.Name = "imiTurnos";
            imiTurnos.Size = new Size(62, 69);
            imiTurnos.Text = "Turnos";
            imiTurnos.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iniciarNuevoTurnoToolStripMenuItem
            // 
            iniciarNuevoTurnoToolStripMenuItem.Name = "iniciarNuevoTurnoToolStripMenuItem";
            iniciarNuevoTurnoToolStripMenuItem.Size = new Size(173, 22);
            iniciarNuevoTurnoToolStripMenuItem.Text = "Iniciar nuevoTurno";
            // 
            // historialDeTurnosToolStripMenuItem
            // 
            historialDeTurnosToolStripMenuItem.Name = "historialDeTurnosToolStripMenuItem";
            historialDeTurnosToolStripMenuItem.Size = new Size(173, 22);
            historialDeTurnosToolStripMenuItem.Text = "Historial de Turnos";
            // 
            // cerrarTurnoToolStripMenuItem
            // 
            cerrarTurnoToolStripMenuItem.Name = "cerrarTurnoToolStripMenuItem";
            cerrarTurnoToolStripMenuItem.Size = new Size(173, 22);
            cerrarTurnoToolStripMenuItem.Text = "Cerrar Turno";
            // 
            // imiFacturar
            // 
            imiFacturar.DropDownItems.AddRange(new ToolStripItem[] { facturaToolStripMenuItem, reciboDeCajaToolStripMenuItem });
            imiFacturar.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            imiFacturar.IconColor = Color.Black;
            imiFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiFacturar.IconSize = 50;
            imiFacturar.ImageScaling = ToolStripItemImageScaling.None;
            imiFacturar.Name = "imiFacturar";
            imiFacturar.Size = new Size(62, 69);
            imiFacturar.Text = "Facturar";
            imiFacturar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(152, 22);
            facturaToolStripMenuItem.Text = "Factura";
            // 
            // reciboDeCajaToolStripMenuItem
            // 
            reciboDeCajaToolStripMenuItem.Name = "reciboDeCajaToolStripMenuItem";
            reciboDeCajaToolStripMenuItem.Size = new Size(152, 22);
            reciboDeCajaToolStripMenuItem.Text = "Recibo de Caja";
            // 
            // imiComprar
            // 
            imiComprar.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            imiComprar.IconColor = Color.Black;
            imiComprar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiComprar.IconSize = 50;
            imiComprar.ImageScaling = ToolStripItemImageScaling.None;
            imiComprar.Name = "imiComprar";
            imiComprar.Size = new Size(66, 69);
            imiComprar.Text = "Comprar";
            imiComprar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // imiCotizar
            // 
            imiCotizar.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            imiCotizar.IconColor = Color.Black;
            imiCotizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiCotizar.IconSize = 50;
            imiCotizar.ImageScaling = ToolStripItemImageScaling.None;
            imiCotizar.Name = "imiCotizar";
            imiCotizar.Size = new Size(62, 69);
            imiCotizar.Text = "Cotizar";
            imiCotizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // imiCajas
            // 
            imiCajas.DropDownItems.AddRange(new ToolStripItem[] { verCajasToolStripMenuItem });
            imiCajas.IconChar = FontAwesome.Sharp.IconChar.Donate;
            imiCajas.IconColor = Color.Black;
            imiCajas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiCajas.IconSize = 50;
            imiCajas.ImageScaling = ToolStripItemImageScaling.None;
            imiCajas.Name = "imiCajas";
            imiCajas.Size = new Size(62, 69);
            imiCajas.Text = "Cajas";
            imiCajas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // verCajasToolStripMenuItem
            // 
            verCajasToolStripMenuItem.Name = "verCajasToolStripMenuItem";
            verCajasToolStripMenuItem.Size = new Size(122, 22);
            verCajasToolStripMenuItem.Text = "Ver cajas ";
            // 
            // imiInventario
            // 
            imiInventario.DropDownItems.AddRange(new ToolStripItem[] { stockToolStripMenuItem, promocionesToolStripMenuItem });
            imiInventario.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            imiInventario.IconColor = Color.Black;
            imiInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiInventario.IconSize = 50;
            imiInventario.ImageScaling = ToolStripItemImageScaling.None;
            imiInventario.Name = "imiInventario";
            imiInventario.Size = new Size(72, 69);
            imiInventario.Text = "Inventario";
            imiInventario.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(144, 22);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // promocionesToolStripMenuItem
            // 
            promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            promocionesToolStripMenuItem.Size = new Size(144, 22);
            promocionesToolStripMenuItem.Text = "Promociones";
            // 
            // imiClientes
            // 
            imiClientes.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            imiClientes.IconColor = Color.Black;
            imiClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiClientes.IconSize = 50;
            imiClientes.ImageScaling = ToolStripItemImageScaling.None;
            imiClientes.Name = "imiClientes";
            imiClientes.Size = new Size(62, 69);
            imiClientes.Text = "Clientes";
            imiClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // imiProveedores
            // 
            imiProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            imiProveedores.IconColor = Color.Black;
            imiProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiProveedores.IconSize = 50;
            imiProveedores.ImageScaling = ToolStripItemImageScaling.None;
            imiProveedores.Name = "imiProveedores";
            imiProveedores.Size = new Size(84, 69);
            imiProveedores.Text = "Proveedores";
            imiProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // imiAjustes
            // 
            imiAjustes.DropDownItems.AddRange(new ToolStripItem[] { notasDeCreditoToolStripMenuItem, notasDeDebitoToolStripMenuItem });
            imiAjustes.IconChar = FontAwesome.Sharp.IconChar.PlusMinus;
            imiAjustes.IconColor = Color.Black;
            imiAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiAjustes.IconSize = 50;
            imiAjustes.ImageScaling = ToolStripItemImageScaling.None;
            imiAjustes.Name = "imiAjustes";
            imiAjustes.Size = new Size(140, 69);
            imiAjustes.Text = "Ajustes y Devoluciones";
            imiAjustes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // notasDeCreditoToolStripMenuItem
            // 
            notasDeCreditoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarUnaNuevaNotaToolStripMenuItem });
            notasDeCreditoToolStripMenuItem.Name = "notasDeCreditoToolStripMenuItem";
            notasDeCreditoToolStripMenuItem.Size = new Size(163, 22);
            notasDeCreditoToolStripMenuItem.Text = "Notas de Credito";
            // 
            // generarUnaNuevaNotaToolStripMenuItem
            // 
            generarUnaNuevaNotaToolStripMenuItem.Name = "generarUnaNuevaNotaToolStripMenuItem";
            generarUnaNuevaNotaToolStripMenuItem.Size = new Size(200, 22);
            generarUnaNuevaNotaToolStripMenuItem.Text = "Generar una nueva nota";
            // 
            // notasDeDebitoToolStripMenuItem
            // 
            notasDeDebitoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarNuevaNotaToolStripMenuItem });
            notasDeDebitoToolStripMenuItem.Name = "notasDeDebitoToolStripMenuItem";
            notasDeDebitoToolStripMenuItem.Size = new Size(163, 22);
            notasDeDebitoToolStripMenuItem.Text = "Notas de Debito";
            // 
            // generarNuevaNotaToolStripMenuItem
            // 
            generarNuevaNotaToolStripMenuItem.Name = "generarNuevaNotaToolStripMenuItem";
            generarNuevaNotaToolStripMenuItem.Size = new Size(177, 22);
            generarNuevaNotaToolStripMenuItem.Text = "Generar nueva nota";
            // 
            // imiOperaciones
            // 
            imiOperaciones.DropDownItems.AddRange(new ToolStripItem[] { verLasOperacionesRegistradasToolStripMenuItem, verDocumentosRegistradosToolStripMenuItem, verMovimientosToolStripMenuItem2 });
            imiOperaciones.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            imiOperaciones.IconColor = Color.Black;
            imiOperaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiOperaciones.IconSize = 50;
            imiOperaciones.ImageScaling = ToolStripItemImageScaling.None;
            imiOperaciones.Name = "imiOperaciones";
            imiOperaciones.Size = new Size(85, 69);
            imiOperaciones.Text = "Operaciones";
            imiOperaciones.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // verLasOperacionesRegistradasToolStripMenuItem
            // 
            verLasOperacionesRegistradasToolStripMenuItem.Name = "verLasOperacionesRegistradasToolStripMenuItem";
            verLasOperacionesRegistradasToolStripMenuItem.Size = new Size(266, 22);
            verLasOperacionesRegistradasToolStripMenuItem.Text = "Ver todas las operaciones registradas";
            // 
            // verDocumentosRegistradosToolStripMenuItem
            // 
            verDocumentosRegistradosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturasToolStripMenuItem, comprasToolStripMenuItem, cotizacionesToolStripMenuItem, notasDeCreditoToolStripMenuItem1 });
            verDocumentosRegistradosToolStripMenuItem.Name = "verDocumentosRegistradosToolStripMenuItem";
            verDocumentosRegistradosToolStripMenuItem.Size = new Size(266, 22);
            verDocumentosRegistradosToolStripMenuItem.Text = "Ver documentos registrados";
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(141, 22);
            facturasToolStripMenuItem.Text = "Facturas";
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(141, 22);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // cotizacionesToolStripMenuItem
            // 
            cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            cotizacionesToolStripMenuItem.Size = new Size(141, 22);
            cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            // 
            // notasDeCreditoToolStripMenuItem1
            // 
            notasDeCreditoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { notasDeCreditoToolStripMenuItem2, notasDeDebitoToolStripMenuItem1 });
            notasDeCreditoToolStripMenuItem1.Name = "notasDeCreditoToolStripMenuItem1";
            notasDeCreditoToolStripMenuItem1.Size = new Size(141, 22);
            notasDeCreditoToolStripMenuItem1.Text = "Ajustes";
            // 
            // notasDeCreditoToolStripMenuItem2
            // 
            notasDeCreditoToolStripMenuItem2.Name = "notasDeCreditoToolStripMenuItem2";
            notasDeCreditoToolStripMenuItem2.Size = new Size(163, 22);
            notasDeCreditoToolStripMenuItem2.Text = "Notas de Credito";
            // 
            // notasDeDebitoToolStripMenuItem1
            // 
            notasDeDebitoToolStripMenuItem1.Name = "notasDeDebitoToolStripMenuItem1";
            notasDeDebitoToolStripMenuItem1.Size = new Size(163, 22);
            notasDeDebitoToolStripMenuItem1.Text = "Notas de Debito";
            // 
            // verMovimientosToolStripMenuItem2
            // 
            verMovimientosToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { movimientosDeCajaToolStripMenuItem, movimientosDeInventarioToolStripMenuItem });
            verMovimientosToolStripMenuItem2.Name = "verMovimientosToolStripMenuItem2";
            verMovimientosToolStripMenuItem2.Size = new Size(266, 22);
            verMovimientosToolStripMenuItem2.Text = "Ver movimientos ";
            // 
            // movimientosDeCajaToolStripMenuItem
            // 
            movimientosDeCajaToolStripMenuItem.Name = "movimientosDeCajaToolStripMenuItem";
            movimientosDeCajaToolStripMenuItem.Size = new Size(216, 22);
            movimientosDeCajaToolStripMenuItem.Text = "Movimientos de Caja";
            // 
            // movimientosDeInventarioToolStripMenuItem
            // 
            movimientosDeInventarioToolStripMenuItem.Name = "movimientosDeInventarioToolStripMenuItem";
            movimientosDeInventarioToolStripMenuItem.Size = new Size(216, 22);
            movimientosDeInventarioToolStripMenuItem.Text = "Movimientos de inventario";
            // 
            // imiCerrarSesion
            // 
            imiCerrarSesion.BackColor = Color.Crimson;
            imiCerrarSesion.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            imiCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            imiCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            imiCerrarSesion.IconColor = Color.White;
            imiCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            imiCerrarSesion.IconSize = 42;
            imiCerrarSesion.ImageScaling = ToolStripItemImageScaling.None;
            imiCerrarSesion.Name = "imiCerrarSesion";
            imiCerrarSesion.Size = new Size(164, 69);
            imiCerrarSesion.Text = "Cerrar Sesion";
            imiCerrarSesion.TextImageRelation = TextImageRelation.TextBeforeImage;
            imiCerrarSesion.Click += imiCerrarSesion_Click;
            // 
            // mstTitulo
            // 
            mstTitulo.AutoSize = false;
            mstTitulo.BackColor = Color.CornflowerBlue;
            mstTitulo.Items.AddRange(new ToolStripItem[] { imiCerrarSesion, tslTitulo });
            mstTitulo.Location = new Point(0, 0);
            mstTitulo.Name = "mstTitulo";
            mstTitulo.RightToLeft = RightToLeft.Yes;
            mstTitulo.Size = new Size(1311, 73);
            mstTitulo.TabIndex = 3;
            mstTitulo.Text = "menuStrip2";
            // 
            // tslTitulo
            // 
            tslTitulo.Alignment = ToolStripItemAlignment.Right;
            tslTitulo.BackColor = Color.CornflowerBlue;
            tslTitulo.Font = new Font("League Spartan SemiBold", 21.75F, FontStyle.Bold);
            tslTitulo.ForeColor = Color.White;
            tslTitulo.Margin = new Padding(0, 2, 5, 10);
            tslTitulo.Name = "tslTitulo";
            tslTitulo.Size = new Size(130, 57);
            tslTitulo.Text = "OptiGest";
            // 
            // lblFechayHora
            // 
            lblFechayHora.AutoSize = true;
            lblFechayHora.BackColor = Color.CornflowerBlue;
            lblFechayHora.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblFechayHora.ForeColor = Color.White;
            lblFechayHora.Location = new Point(11, 49);
            lblFechayHora.Name = "lblFechayHora";
            lblFechayHora.Size = new Size(103, 18);
            lblFechayHora.TabIndex = 0;
            lblFechayHora.Text = "lblFechayHora";
            // 
            // timerFechayHora
            // 
            timerFechayHora.Tick += correrReloj;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(266, 22);
            toolStripMenuItem1.Text = "Ver todas las operaciones registradas";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(266, 22);
            toolStripMenuItem2.Text = "Ver documentos registrados";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(141, 22);
            toolStripMenuItem3.Text = "Facturas";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(141, 22);
            toolStripMenuItem4.Text = "Compras";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(141, 22);
            toolStripMenuItem5.Text = "Cotizaciones";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem7, toolStripMenuItem8 });
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(141, 22);
            toolStripMenuItem6.Text = "Ajustes";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(163, 22);
            toolStripMenuItem7.Text = "Notas de Credito";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(163, 22);
            toolStripMenuItem8.Text = "Notas de Debito";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem10, toolStripMenuItem11 });
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(266, 22);
            toolStripMenuItem9.Text = "Ver movimientos ";
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(216, 22);
            toolStripMenuItem10.Text = "Movimientos de Caja";
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(216, 22);
            toolStripMenuItem11.Text = "Movimientos de inventario";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 701);
            Controls.Add(lblFechayHora);
            Controls.Add(panel1);
            Controls.Add(mstPrincipal);
            Controls.Add(mstTitulo);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            mstPrincipal.ResumeLayout(false);
            mstPrincipal.PerformLayout();
            mstTitulo.ResumeLayout(false);
            mstTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip mstPrincipal;
        private FontAwesome.Sharp.IconMenuItem imiUsuarios;
        private FontAwesome.Sharp.IconMenuItem imiTurnos;
        private ToolStripMenuItem historialDeTurnosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem imiFacturar;
        private FontAwesome.Sharp.IconMenuItem imiComprar;
        private FontAwesome.Sharp.IconMenuItem imiCotizar;
        private FontAwesome.Sharp.IconMenuItem imiCajas;
        private ToolStripMenuItem verCajasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem imiClientes;
        private FontAwesome.Sharp.IconMenuItem imiProveedores;
        private FontAwesome.Sharp.IconMenuItem imiAjustes;
        private ToolStripMenuItem notasDeCreditoToolStripMenuItem;
        private ToolStripMenuItem generarUnaNuevaNotaToolStripMenuItem;
        private ToolStripMenuItem notasDeDebitoToolStripMenuItem;
        private ToolStripMenuItem generarNuevaNotaToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem imiOperaciones;
        private ToolStripMenuItem verLasOperacionesRegistradasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem imiCerrarSesion;
        private MenuStrip mstTitulo;
        private ToolStripLabel tslTitulo;
        private Label lblFechayHora;
        private System.Windows.Forms.Timer fechayhora;
        private ToolStripMenuItem verDocumentosRegistradosToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem cotizacionesToolStripMenuItem;
        private ToolStripMenuItem notasDeCreditoToolStripMenuItem1;
        private ToolStripMenuItem notasDeCreditoToolStripMenuItem2;
        private ToolStripMenuItem notasDeDebitoToolStripMenuItem1;
        private ToolStripMenuItem verMovimientosToolStripMenuItem2;
        private FontAwesome.Sharp.IconMenuItem imiInventario;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem promocionesToolStripMenuItem;
        private ToolStripMenuItem movimientosDeCajaToolStripMenuItem;
        private ToolStripMenuItem movimientosDeInventarioToolStripMenuItem;
        private ToolStripMenuItem iniciarNuevoTurnoToolStripMenuItem;
        private ToolStripMenuItem cerrarTurnoToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem reciboDeCajaToolStripMenuItem;
        private System.Windows.Forms.Timer timerFechayHora;
        private FontAwesome.Sharp.IconMenuItem imiEmpresas;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem registrarNuevoUsuarioToolStripMenuItem;
        private ToolStripMenuItem registroDeUsuariosToolStripMenuItem;
    }
}

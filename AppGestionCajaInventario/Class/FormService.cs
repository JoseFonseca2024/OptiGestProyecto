using AppGestionCajaInventario.Controllers;
using AppGestionCajaInventario.Forms.FormsLogins;
using AppGestionCajaInventario.Models.Dto.Cajas;
using AppGestionCajaInventario.Models.Dto.Clientes;
using AppGestionCajaInventario.Models.Dto.Empresas;
using AppGestionCajaInventario.Models.Dto.Productos;
using AppGestionCajaInventario.Models.Dto.Proveedores;
using AppGestionCajaInventario.Models.Dto.Usuarios;
using AppGestionCajaInventario.Models.Repository;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using FontAwesome.Sharp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace AppGestionCajaInventario.Class
{
    public class FormService
    {

        public void MostrarFormenPanel(Form form, Panel panel)
        {
            if (panel.Controls.Count > 0)
            {
                Form? formularioactual = panel.Controls[0] as Form;
                if (formularioactual != null)
                {
                    formularioactual.Close();
                }
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel.Controls.Clear();
            panel.Controls.Add(form);
            panel.Tag = form;
            form.Show();
        }

        public async Task LoginAsync(Form form1, ApiClient _apiClient, TextBox txt1, TextBox txt2)
        {
            string username = txt1.Text.Trim();
            string password = txt2.Text.Trim();

            try
            {
                var loginResponse = await _apiClient.LoginUsers.ObtenerLoginResponseAsync(username, password);
                var token = loginResponse.Token;
                var rol = loginResponse.Rol;

                if (!string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _apiClient.SetAuthToken(token);
                    form1.Hide();
                    var mainForm = new MainForm(_apiClient, rol, token);
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Error en el inicio de sesión. Verifique sus credenciales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con el servidor. Detalles: {ex.Message}",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("La solicitud al servidor tardó demasiado. Intente de nuevo más tarde.",
                    "Tiempo de espera agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar iniciar sesión:\n{ex.Message}",
                    "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CambiarColorIconButton(IconButton iconButton, Color color1, Color color2)
        {
            iconButton.MouseEnter += (s, e) =>
            {
                iconButton.IconColor = color2;
            };

            iconButton.MouseLeave += (s, e) =>
            {
                iconButton.IconColor = color1;
            };
        }

        public void AlternarVisibilidad(TextBox txtClave, IconButton botonIcono)
        {
            if (txtClave.UseSystemPasswordChar) // Contraseña oculta
            {
                botonIcono.IconChar = IconChar.EyeSlash;
                txtClave.UseSystemPasswordChar = false;
            }
            else // Contraseña visible
            {
                botonIcono.IconChar = IconChar.Eye;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        public void LimpiarCampos(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox txt) txt.Clear();
                else if (control is MaskedTextBox msk) msk.Clear();
                else if (control is ComboBox cmb) cmb.SelectedIndex = -1;
                else if (control.HasChildren) LimpiarCampos(control);
            }
        }

        public bool VerificarCamposVacios(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox txt && string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show("Algunos campos están vacíos. Por favor verifique que todos estén llenos.",
                                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (control.HasChildren)
                {
                    if (!VerificarCamposVacios(control)) return false;
                }
            }
            return true;
        }

        public bool EsCorreoValido(string email)
        {
            try
            {
                var direccion = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void IniciarTemporizador(System.Windows.Forms.Timer timer, Label lblTemporizador, Action onExpirado, int segundosTotales = 600)
        {
            int segundosRestantes = segundosTotales;
            timer.Interval = 1000;

            timer.Tick += (s, e) =>
            {
                segundosRestantes--;
                int minutos = segundosRestantes / 60;
                int segundos = segundosRestantes % 60;
                lblTemporizador.Text = $"Tiempo restante: {minutos:D2}:{segundos:D2}";

                if (segundosRestantes <= 0)
                {
                    timer.Stop();
                    onExpirado?.Invoke();
                }
            };

            timer.Start();
        }

        public async Task<string?> ReenviarCodigoAsync(string email, ApiClient apiClient, Button botonBloqueado, int bloqueoSegundos = 60)
        {
            botonBloqueado.Enabled = false;
            string nuevoCodigo = new Random().Next(100000, 999999).ToString();

            try
            {
                bool reenviado = await apiClient.LoginUsers.EnviarCodigoVerificacionAsync(email, nuevoCodigo);
                if (reenviado)
                {
                    MessageBox.Show("Código reenviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return nuevoCodigo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reenviar el código: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await Task.Delay(bloqueoSegundos * 1000);
            botonBloqueado.Enabled = true;
            return null;
        }

        public string GenerarCodigoVerificacion()
        {
            // Genera un código de 6 dígitos aleatorio
            return new Random().Next(100000, 999999).ToString();
        }

        public async Task<bool> EnviarCodigoYMostrarFormularioAsync(string nombre, string email, string clave, ApiClient apiClient, FormCrearUsuario formPadre, LoginForm loginForm)
        {
            string codigo = GenerarCodigoVerificacion();

            try
            {
                bool enviado = await apiClient.LoginUsers.EnviarCodigoVerificacionAsync(email, codigo);
                if (!enviado)
                {
                    MessageBox.Show("No se pudo enviar el código de verificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                var form = new FormConfirmacióndeClave(nombre, email, clave, codigo, apiClient, formPadre, loginForm);
                form.ShowDialog();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el código: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> RegistrarUsuarioAsync(string nombreUsuario, string email, string clave, ApiClient apiClient)
        {
            try
            {
                bool registrado = await apiClient.LoginUsers.RegistrarUsuarioAsync(nombreUsuario, email, clave);
                if (registrado)
                {
                    MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ConfigurarMenuPorRol(string rol, IconMenuItem imi1, IconMenuItem imi2, IconMenuItem imi3, IconMenuItem imi4)
        {
            switch (rol)
            {
                case "Cajero":
                    imi1.Visible = false;
                    imi2.Visible = false;
                    imi3.Visible = false;
                    imi4.Visible = false;
                    break;

                case "Administrador":
                    imi1.Visible = true;
                    imi2.Visible = true;
                    imi3.Visible = true;
                    imi4.Visible = true;
                    break;
            }
        }

        public void CerrarSesion(Form formularioActual, ApiClient apiClient)
        {
            var confirm = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                apiClient.SetAuthToken(null);

                var loginForm = new LoginForm();
                loginForm.Show();

                formularioActual.Close();
            }
        }

        public async Task CargarEmpresaAsync(IAdminRepository adminRepository, DataGridView dgvEmpresas, Button btnRegistrar, Button btnActualizar)
        {
            try
            {
                var empresa = await adminRepository.ObtenerEmpresaDelUsuarioAsync();

                if (empresa != null)
                {
                    dgvEmpresas.DataSource = new List<EmpresaDto> { empresa };
                    btnRegistrar.Enabled = false;
                    btnActualizar.Enabled = true;
                }
                else
                {
                    dgvEmpresas.DataSource = null;
                    btnRegistrar.Enabled = true;
                    btnActualizar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empresa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task CargarUsuariosAsync(IAdminRepository adminRepository, DataGridView dgv)
        {
            var usuarios = await adminRepository.ObtenerUsuariosAsync();
            dgv.DataSource = usuarios ?? new List<UsuarioDto>();
        }

        public void CargarComboBoxEstado(ComboBox cmbEstado)
        {
            cmbEstado.DataSource = new List<KeyValuePair<string, bool>>
        {
            new KeyValuePair<string, bool>("Activo", true),
            new KeyValuePair<string, bool>("Inactivo", false)
        };
            cmbEstado.DisplayMember = "Key";
            cmbEstado.ValueMember = "Value";
        }

        public async Task CargarRolesAsync(IAdminRepository repo, ComboBox combo)
        {
            var roles = await repo.ObtenerRolesAsync();
            combo.DataSource = roles;
            combo.DisplayMember = "NombreRol";
            combo.ValueMember = "RolID";
        }

        public async Task RegistrarEmpresa(
            string nombre,
            string ruc,
            string direccion,
            string telefono,
            string actividad,
            IAdminRepository adminRepository)
        {
            try
            {
                var dto = new EmpresaCreateDto
                {
                    NombreEmpresa = nombre,
                    RUC = ruc,
                    Direccion = direccion,
                    Telefono = telefono,
                    Actividad = actividad
                };

                var empresaId = await adminRepository.CrearEmpresaAsync(dto);

                MessageBox.Show($"Empresa creada con ID: {empresaId}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear empresa:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task ActualizarEmpresa(EmpresaUpdateDto dto, IAdminRepository adminRepository)
        {
            try
            {
                var ok = await adminRepository.ActualizarEmpresaAsync(dto);

                if (ok)
                {
                    MessageBox.Show("Empresa actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la empresa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar empresa:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task ActualizarUsuario(UsuarioUpdateDto dto, IAdminRepository adminRepository, DataGridView dgvUsuarios)
        {
            try
            {
                var ok = await adminRepository.ActualizarUsuarioAsync(dto);
                if (ok)
                {
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarUsuariosAsync(adminRepository, dgvUsuarios);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar usuario:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task CargarProductos(IProductoRepository _productoRepository, DataGridView dgvProductos)
        {
            var productos = await _productoRepository.ObtenerProductosPorEmpresaAsync();
            dgvProductos.DataSource = productos;
        }

        public async Task<bool> AgregarProductoAsync(IProductoRepository productoRepository, ProductosCreateDto productosDto)
        {
            return await productoRepository.CrearAsync(productosDto);
        }

        public async Task<bool> ActualizarProductoAsync(IProductoRepository productoRepository, int id, ProductosUpdateDto dto)
        {
            return await productoRepository.ActualizarAsync(id, dto);
        }

        public async Task<bool> EliminarProductoAsync(IProductoRepository productoRepository, int id)
        {
            return await productoRepository.EliminarAsync(id);
        }

        public async Task CargarClientesAsync(IClienteRepository clienteRepository, DataGridView dgvClientes)
        {
            var clientes = await clienteRepository.ObtenerClientesPorEmpresaAsync();
            dgvClientes.DataSource = clientes;
        }

        public async Task<bool> RegistrarClienteAsync(IClienteRepository clienteRepository, ClienteCreateDto dto)
        {
            return await clienteRepository.CrearAsync(dto);
        }

        public async Task<bool> ActualizarClienteAsync(IClienteRepository clienteRepository, int id, ClienteUpdateDto dto)
        {
            return await clienteRepository.ActualizarAsync(id, dto);
        }

        public async Task<bool> EliminarClienteAsync(IClienteRepository clienteRepository, int id)
        {
            return await clienteRepository.EliminarAsync(id);
        }

        public async Task CargarProveedoresAsync(IProveedorRepository proveedorRepository, DataGridView dgvProveedores)
        {
            var proveedores = await proveedorRepository.GetAllPorEmpresaAsync();
            dgvProveedores.DataSource = proveedores;
        }

        public async Task<bool> RegistrarProveedorAsync(IProveedorRepository proveedorRepository, ProveedorCreateDto dto)
        {
            return await proveedorRepository.CrearAsync(dto);
        }

        public async Task<bool> ActualizarProveedorAsync(IProveedorRepository proveedorRepository, int id, ProveedorUpdateDto dto)
        {
            return await proveedorRepository.ActualizarAsync(id, dto);
        }

        public async Task<bool> EliminarProveedorAsync(IProveedorRepository proveedorRepository, int id)
        {
            return await proveedorRepository.EliminarAsync(id);
        }

        public async Task CargarCajasporEmpresasAsync(ICajaRepository cajaRepository, DataGridView dgvCajas)
        {
            var cajas = await cajaRepository.ObtenerCajasporEmpresaAsync();
            dgvCajas.DataSource = cajas;
        }

        public async Task<bool> RegistrarCajaAsync (ICajaRepository cajaRepository, CajaCreateDto dto)
        {
            return await cajaRepository.CrearAsync(dto);
        }

        public async Task<bool> ActualizarCajaAsync (ICajaRepository cajaRepository, int id, CajaUpdateDto dto)
        {
            return await cajaRepository.ActualizarAsync(id, dto);
        } 
    }
}

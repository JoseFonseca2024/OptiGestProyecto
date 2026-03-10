using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Models.Dto.Productos;
using AppGestionCajaInventario.Models.Repository;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCajaInventario.Forms.FormProductos
{
    public partial class FormProductos : Form
    {
        private readonly FormService formService = new FormService();
        private readonly IProductoRepository _productoRepository;
        public FormProductos(IProductoRepository productoRepository)
        {
            InitializeComponent();
            _productoRepository = productoRepository ?? throw new ArgumentNullException(nameof(productoRepository));
        }

        private async void FormProductos_Load(object sender, EventArgs e)
        {
            await formService.CargarProductos(_productoRepository, dgvProductos);
        }

        private async void ibtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!formService.VerificarCamposVacios(this)) return;

            if (!decimal.TryParse(txtCosto.Text, out var costo) || !decimal.TryParse(txtPrecio.Text, out var precio))
            {
                MessageBox.Show("Costo y precio deben ser valores numéricos válidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new ProductosCreateDto
            {
                NombreProducto = txtNombrProducto.Text.Trim(),
                CodigoProducto = txtCodigoProducto.Text.Trim(),
                CostoPromedio = decimal.Parse(txtCosto.Text),
                PrecioUnitario = decimal.Parse(txtPrecio.Text)
            };

            bool creado = await formService.AgregarProductoAsync(_productoRepository, dto);
            if (creado)
            {
                MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formService.LimpiarCampos(this);
                await formService.CargarProductos(_productoRepository, dgvProductos);
            }
            else
            {
                MessageBox.Show("Error al registrar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ibtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow?.DataBoundItem is not ProductosDto productoSeleccionado)
            {
                MessageBox.Show("Seleccione un producto para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!formService.VerificarCamposVacios(this)) return;

            if (!decimal.TryParse(txtCosto.Text, out var costo) || !decimal.TryParse(txtPrecio.Text, out var precio))
            {
                MessageBox.Show("Costo y precio deben ser valores numéricos válidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new ProductosUpdateDto
            {
                NombreProducto = txtNombrProducto.Text.Trim(),
                CodigoProducto = txtCodigoProducto.Text.Trim(),
                CostoPromedio = costo,
                PrecioUnitario = precio
            };

            bool actualizado = await formService.ActualizarProductoAsync(_productoRepository, productoSeleccionado.ProductoID, dto);
            if (actualizado)
            {
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await formService.CargarProductos(_productoRepository, dgvProductos);
                formService.LimpiarCampos(this);
            }
            else
            {
                MessageBox.Show("Error al actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void ibtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow?.DataBoundItem is not ProductosDto productoSeleccionado)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"¿Está seguro de eliminar '{productoSeleccionado.NombreProducto}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            bool eliminado = await formService.EliminarProductoAsync(_productoRepository, productoSeleccionado.ProductoID);
            if (eliminado)
            {
                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await formService.CargarProductos(_productoRepository, dgvProductos);
                formService.LimpiarCampos(this);
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var producto = (ProductosDto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
                txtNombrProducto.Text = producto.NombreProducto;
                txtCodigoProducto.Text = producto.CodigoProducto;
                txtCosto.Text = producto.CostoPromedio.ToString();
                txtPrecio.Text = producto.PrecioUnitario.ToString();
            }
        }
    }
}

using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        ProductoBLL productoBLL;
        int? idProductoSeleccionado;
        public Form1()
        {
            InitializeComponent();
            productoBLL = new ProductoBLL();
            CargarProductos();
            dataGridView1.ClearSelection();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = this.tbNuevoNombre.Text;
                double precio = double.Parse(this.tbNuevoPrecio.Value.ToString());
                int cantidad = int.Parse(this.tbNuevoCantidad.Value.ToString());
                string descripcion = this.tbNuevoDescripcion.Text;
                if (!ProductoValido(nombre,precio,cantidad,descripcion))
                {
                    throw new Exception("El producto ingresado no es válido");
                }
                Producto nuevoProducto = new Producto(nombre, precio, cantidad, descripcion);
                productoBLL.AgregarProducto(nuevoProducto);
                LimpiarFormularioCreacion();
                this.CargarProductos();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void CargarProductos()
        {
            idProductoSeleccionado = null;
            LimpiarFormularioEdicion();
            List<Producto> productos = productoBLL.ObtenerProductos();
            dataGridView1.DataSource = productos;
            dataGridView1.ClearSelection();
        }

        private bool ProductoValido(string nombre,double precio,int cantidad,string descripcion)
        {
            bool valido = false;
            valido = nombre.Length > 0;
            if (!valido)
            {
                MessageBox.Show("El nombre del producto no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            valido = precio > 0;
            if (!valido)
            {
                MessageBox.Show("El precio del producto debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            valido = cantidad > 0;
            if (!valido)
            {
                MessageBox.Show("La cantidad del producto debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            valido = descripcion.Length > 0;
            if (!valido)
            {
                MessageBox.Show("La descripción del producto no puede estar vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valido;
        }

        private void LimpiarFormularioCreacion()
        {
            this.tbNuevoNombre.Clear();
            this.tbNuevoPrecio.Value = 0;
            this.tbNuevoCantidad.Value = 0;
            this.tbNuevoDescripcion.Clear();
        }
        private void LimpiarFormularioEdicion()
        {
            this.tbEditarNombre.Clear();
            this.tbEditarPrecio.Value = 0;
            this.tbEditarCantidad.Value = 0;
            this.tbEditarDescripcion.Clear();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<Producto> listadoProductos = dataGridView1.DataSource as List<Producto>;

                if (listadoProductos == null)
                {
                    MessageBox.Show("No hay productos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int indiceSeleccionado = dataGridView1.SelectedRows[0].Index;
                Producto productoSeleccionado = listadoProductos.ElementAt(indiceSeleccionado);
                if (productoSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un producto para poder eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    bool eliminado = productoBLL.EliminarProducto(productoSeleccionado.Id);
                    if(!eliminado)
                    {
                        MessageBox.Show("No pudo eliminarse el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.CargarProductos();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == null)
            {
                throw new Exception("No se ha seleccionado un producto para editar");
            }
            try
            {
                string nombre = this.tbEditarNombre.Text;
                double precio = (double)tbEditarPrecio.Value;
                int cantidad = int.Parse(this.tbEditarCantidad.Value.ToString());
                string descripcion = this.tbEditarDescripcion.Text;
                if (!ProductoValido(nombre, precio, cantidad, descripcion))
                {
                    throw new Exception("El producto editado no es válido");
                }

                Producto nuevoProducto = new Producto((int)idProductoSeleccionado, nombre, precio, cantidad, descripcion);
                bool editado = productoBLL.EditarProducto(nuevoProducto);
                if(editado)
                {
                    this.CargarProductos();
                    LimpiarFormularioEdicion();
                    MessageBox.Show("Producto editado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    throw new Exception("No pudo editarse el producto");
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection filasSeleccionadas = dataGridView1.SelectedRows;
            List<Producto> listadoProductos = new List<Producto>();
            listadoProductos = dataGridView1.DataSource as List<Producto>;

            if (filasSeleccionadas.Count > 0)
            {
                int indiceSeleccionado = filasSeleccionadas[0].Index;
                Producto productoSeleccionado = listadoProductos.ElementAt(indiceSeleccionado);
                Producto productoEdicion = new Producto();
                productoEdicion.Nombre = productoSeleccionado.Nombre;
                productoEdicion.Precio = productoSeleccionado.Precio;
                productoEdicion.Cantidad = productoSeleccionado.Cantidad;
                productoEdicion.Descripcion = productoSeleccionado.Descripcion;
                tbEditarNombre.Text = productoEdicion.Nombre;
                tbEditarPrecio.Value = (decimal)productoEdicion.Precio;
                tbEditarCantidad.Value = productoEdicion.Cantidad;
                tbEditarDescripcion.Text = productoEdicion.Descripcion;
                idProductoSeleccionado = productoSeleccionado.Id;
            }
        }
    }
}

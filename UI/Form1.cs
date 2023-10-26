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
        public Form1()
        {
            InitializeComponent();
            productoBLL = new ProductoBLL();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = this.tbNuevoNombre.Text;
                double precio = double.Parse(this.tbNuevoPrecio.Value.ToString());
                double cantidad = double.Parse(this.tbNuevoCantidad.Value.ToString());
                string descripcion = this.tbNuevoDescripcion.Text;
                Producto nuevoProducto = new Producto(nombre, precio, cantidad, descripcion);
                productoBLL.AgregarProducto(nuevoProducto);
            }
            catch (Exception ex){

            }
           
        }

        private void CargarProductos()
        {
            List<Producto> productos = productoBLL.ObtenerProductos();

            //dataGridView1.DataSource;
        }
    }
}

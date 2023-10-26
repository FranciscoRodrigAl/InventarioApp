using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoBLL
    {
        private ProductosDAL productoDAL;

        public ProductoBLL()
        {
            productoDAL = new ProductosDAL();
        }

        public void AgregarProducto(Producto producto)
        {
            Producto productoExiste = ObtenerProductos().Where(p => p.Nombre.Equals(producto.Nombre)).FirstOrDefault();
            if(productoExiste != null)
            {
                throw new Exception("El producto ya fue ingresado");

            }
            producto.Nombre = producto.Nombre.Trim();
            if (!productoDAL.SaveProducto(producto))
            {
                throw new Exception("No se guardó el producto");
            }
        }

        public List<Producto> ObtenerProductos()
        {
            return productoDAL.ObtenerProductos();
        }

        public bool EliminarProducto(int id)
        {
            bool eliminado = productoDAL.DeleteProducto(id);
            if(!eliminado)
            {
                throw new Exception("Producto no fue eliminado");
            }
            return eliminado;
        }

        public bool EditarProducto(Producto productoEditado)
        {
            return false;
        }
    }
}

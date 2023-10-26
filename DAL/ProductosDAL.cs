using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductosDAL
    {
        private const string tableName = "Productos";
        private const string nombreColumnName = "Productos";
        private const string precioColumnName = "Productos";
        private const string cantidadColumnName = "Productos";
        private const string descripcionColumnName = "Productos";

        public bool SaveProducto(Producto producto)
        {
            string query = $"INSERT INTO {tableName}({nombreColumnName}, {precioColumnName},{cantidadColumnName},{descripcionColumnName})VALUES ('{producto.Nombre},{producto.Precio},{producto.Cantidad},'{producto.Descripcion}'";
            int rows = DatabaseHelper.Instance.ExecuteNonQuery(query);
            if(rows == 0)
            {
                return false;
            }
            return true;
        }

        public List<Producto> ObtenerProductos()
        {
            string query = $"SELECT * FROM {tableName}";
            DataTable dt = (DataTable)DatabaseHelper.Instance.ExecuteQuery(query);
            List<Producto> productos = new List<Producto>();
            foreach (DataRow dr in dt.Rows)
            {
                Producto p = new Producto();
                p.Id = int.Parse(dr["id"].ToString());
                p.Nombre = dr["nombre"].ToString();
                p.Precio = double.Parse(dr["precio"].ToString());
                p.Cantidad = double.Parse(dr["cantidad"].ToString());
                p.Descripcion = dr["descripcion"].ToString();
                productos.Add(p);
            }

            return productos;
        }

        public bool DeleteProducto(int id)
        {
            string query = $"DELETE FROM {tableName} WHERE id={id}";
            int rows =  DatabaseHelper.Instance.ExecuteNonQuery(query);
            if (rows == 0)
            {
                return false;
            }
            return true;

        }

        public bool EditarProducto(int id, Producto producto)
        {
            string query = $"UPDATE {tableName} SET {nombreColumnName} = '{producto.Nombre}', {cantidadColumnName} = {producto.Cantidad}, {precioColumnName} = {producto.Precio}, {descripcionColumnName} = '{producto.Descripcion}' WHERE id = {id}";
            DataTable dt = (DataTable)DatabaseHelper.Instance.ExecuteQuery(query);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}

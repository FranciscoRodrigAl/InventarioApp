﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Producto
    {
        public Producto() { }

        public Producto(int id, string nombre,double precio, int cantidad, string descripcion) {
            this.Id = id;
            this.Cantidad = cantidad;
            this.Precio= precio;
            this.Nombre= nombre;
            this.Descripcion= descripcion;
        }

        public Producto(string nombre, double precio, int cantidad, string descripcion)
        {
            this.Cantidad = cantidad;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Descripcion = descripcion;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace UV_Eats_Client.Models
{
    public class CarroCompraProductos
    {
        public CarroCompraProductos(int idProducto, string producto, int cantidad, int precio, string imagen)
        {
            this.idProducto = idProducto;
            this.producto = producto;
            this.cantidad = cantidad;
            this.precio = precio;
            this.imagenProducto=imagen;
        }
        public CarroCompraProductos()
        {

        }
        public int idProducto {get; set; }
        public string producto {get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }
        public string imagenProducto { get; set; }
    }
}

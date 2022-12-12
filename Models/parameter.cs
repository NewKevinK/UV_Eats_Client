using System;
using System.Collections.Generic;
using System.Text;

namespace UV_Eats_Client.Models
{
    public class parameter
    {
        public parameter(int idProducto, int cantidad, int precio, int idCarro)
        {
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.precio = precio;
            this.idCarro = idCarro;
        }
        public parameter()
        {

        }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }
        public int idCarro { get; set; }

    }
}

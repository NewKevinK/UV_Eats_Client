using System;
using System.Collections.Generic;
using System.Text;

namespace UV_Eats_Client.Models
{
    public class Producto
    {
        public string idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public int unidades {get; set;}


        public Producto(string idProducto, string nombre, string descripcion, float precio, int unidades  )
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.unidades = unidades;
        }
        public Producto()
        {

        }
    }
}

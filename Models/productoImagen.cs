using System;
using System.Collections.Generic;
using System.Text;

namespace UV_Eats_Client.Models
{
    public class ProductoImagen
    {

        public int IdProducto { get; set; }
        public string url { get; set; }

        public ProductoImagen(int idCategoria, string url)
        {
            this.IdProducto = idCategoria;
            this.url = url;
        }
        public ProductoImagen()
        {

        }
    }
}

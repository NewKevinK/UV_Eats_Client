using System;
using System.Collections.Generic;
using System.Text;

namespace UV_Eats_Client.Models
{
    public class categoriaImagen
    {

        public int IdCategoria { get; set; }
        public string url { get; set; }

        public categoriaImagen(int idCategoria, string url)
        {
            this.IdCategoria = idCategoria;
            this.url = url;
        }
        public categoriaImagen()
        {

        }
    }
}

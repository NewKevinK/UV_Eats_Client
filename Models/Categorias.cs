using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace UV_Eats_Client.Models
{
    public class Categorias
    {
        public int IdCategoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string estatus { get; set; }
        public string imagenCategoria { get; set; }
        public Categorias(int idCategoria, string nombre, string descripcion, string estatus, string imagen)
        {
            this.IdCategoria = idCategoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.estatus = estatus;
            this.imagenCategoria = imagen;
        }
        public Categorias()
        {

        }
    }
}

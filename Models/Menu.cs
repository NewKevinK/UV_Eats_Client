using System;
using System.Collections.Generic;
using System.Text;

namespace UV_Eats_Client.Models
{
    public class Menu
    {
        public string idMenu { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string imagenMenu { get; set; }
        

        public Menu(string idMenu, string nombre, string descripcion, string imagenMenu)
        {
            this.idMenu = idMenu;
            this.nombre = nombre;
            this.imagenMenu = imagenMenu;
            this.descripcion = descripcion;
        }
        public Menu()
        {

        }
    }
}

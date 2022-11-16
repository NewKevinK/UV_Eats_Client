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
        

        public Menu(string idMenu, string nombre, string descripcion)
        {
            this.idMenu = idMenu;
            this.nombre = nombre;
            
            this.descripcion = descripcion;
        }
        public Menu()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UV_Eats_Client.Models
{
    public class MenuImagen
    {


        public int idMenu { get; set; }
        public string imagenMenu { get; set; }

        public MenuImagen(int idMenu, string imagenMenu)
        {
            this.idMenu = idMenu;
            this.imagenMenu = imagenMenu;
        }
        public MenuImagen()
        {

        }
    }
}

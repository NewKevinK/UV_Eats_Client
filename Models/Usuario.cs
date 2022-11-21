using System;
using System.Collections.Generic;
using System.Text;

namespace UV_Eats_Client.Models
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public Usuario(string nombre, string apellido, string email, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.password = password;
        }
        public Usuario()
        {

        }
    }
}

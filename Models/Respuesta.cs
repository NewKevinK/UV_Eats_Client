using System;
using System.Collections.Generic;
using System.Text;

namespace UV_Eats_Client.Models
{
    class Respuesta
    {
        public string message { get; set; }


        public Respuesta(string message)
        {
            this.message = message;
        }
        public Respuesta()
        {

        }
    }
}

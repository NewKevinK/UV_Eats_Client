using System;
using System.Collections.Generic;
using System.Text;

namespace UV_Eats_Client.Models
{
    public class Auth
    {
        public string message { get;  set; }
        public string token { get; set; }
        public string id { get; set; }

        public Auth(string message, string token, string id)
        {
            this.message = message;
            this.token = token;
            this.id = id;
        }
        public Auth()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UV_Eats_Client.Models
{
    public class Orden
    {
        public Orden(int idOrden, string fecha, int total, string estado, int idUsuario, int idCarro)
        {
            this.idOrden = idOrden;
            this.fecha = fecha;
            this.total = total;
            this.estado = estado;
            this.idUsuario = idUsuario;
            this.idCarro = idCarro;
        }

        public int idOrden{ get; set; }
        public string fecha { get; set; }
        public int total { get; set; }
        public string estado { get; set; }
        public int idUsuario { get; set; }
        public int idCarro { get; set; }


        public Orden()
        {

        }
    }
}

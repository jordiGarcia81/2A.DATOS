using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class Evento
    {
        public Evento(int idEvento, string visitante, DateTime fecha, string local)
        {
            this.idEvento = idEvento;
            this.visitante = visitante;
            this.fecha = fecha;
            this.local = local;
        }

        public int idEvento { get; set; }
        public string visitante { get; set; }
        public DateTime fecha { get; set; }
        public string local { get; set; }

    }
}
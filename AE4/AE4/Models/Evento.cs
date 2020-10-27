using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE4.Models
{
    public class Evento
    {
        public Evento(int idEvento, string visitante, string local, DateTime fecha)
        {
            this.idEvento = idEvento;
            this.visitante = visitante;
            this.local = local;
            this.fecha = fecha;

        }

        public int idEvento { get; set; }
        public string visitante { get; set; }
        public string local { get; set; }
        public DateTime fecha { get; set; }

    }

    public class EventoDTO
    {
        public EventoDTO(string visitante, string local, DateTime fecha)
        {

            this.visitante = visitante;
            this.local = local;
            this.fecha = fecha;
        }


        public string visitante { get; set; }
        public string local { get; set; }
        public DateTime fecha { get; set; }
    }
}
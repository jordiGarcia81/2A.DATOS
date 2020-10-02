using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class Mercado
    {
        public Mercado(double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder, double overUnder, int eventosIdEvento, int idMercado)
        {
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
            this.dineroOver = dineroOver;
            this.dineroUnder = dineroUnder;
            this.overUnder = overUnder;
            this.eventosIdEvento = eventosIdEvento;
            this.idMercado = idMercado;
        }

        public double cuotaOver { get; set; }
        public double cuotaUnder { get; set; }
        public double dineroOver { get; set; }
        public double dineroUnder { get; set; }
        public double overUnder { get; set; }
        public int eventosIdEvento { get; set; }
        public int idMercado { get; set; }

    }
}
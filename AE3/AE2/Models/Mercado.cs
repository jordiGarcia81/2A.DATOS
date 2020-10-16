﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class Mercado
    {
        public Mercado(int idMercado, double overUnder, double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder, int eventosIdEvento)
        {
            this.idMercado = idMercado;
            this.overUnder = overUnder;
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
            this.dineroOver = dineroOver;
            this.dineroUnder = dineroUnder;
            this.eventosIdEvento = eventosIdEvento;
        }

        public int idMercado { get; set; }
        public double overUnder { get; set; }
        public double cuotaOver { get; set; }
        public double cuotaUnder { get; set; }
        public double dineroOver { get; set; }
        public double dineroUnder { get; set; }
        public int eventosIdEvento { get; set; }
        

    }

    public class MercadoDTO
    {
        public MercadoDTO(double overUnder, double cuotaOver, double cuotaUnder)
        {
            this.overUnder = overUnder;
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
        }

        public double overUnder { get; set; }
        public double cuotaOver { get; set; }
        public double cuotaUnder { get; set; }
        
        
        
    }

}
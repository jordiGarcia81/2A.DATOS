using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class Cuenta

    {
        public Cuenta(long numTarjeta, int numeroBanco, double saldo, string usuariosEmailUsuarios)
        {
            this.numTarjeta = numTarjeta;
            this.numeroBanco = numeroBanco;
            this.saldo = saldo;
            this.usuariosEmailUsuarios = usuariosEmailUsuarios;
        }

        public Int64 numTarjeta { get; set; } 
        public int  numeroBanco { get; set; }
        public double saldo { get; set; }
        public string usuariosEmailUsuarios { get; set; }

    }
}
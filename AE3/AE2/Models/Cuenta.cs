using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class Cuenta

    {
        public Cuenta(Int64 numTarjeta, string nombreBanco, double saldo, string usuariosEmail)
        {
            this.numTarjeta = numTarjeta;
            this.nombreBanco = nombreBanco;
            this.saldo = saldo;
            this.usuariosEmail = usuariosEmail;
        }

        public long numTarjeta { get; set; }
        public string nombreBanco { get; set; }
        public double saldo { get; set; }
        public string usuariosEmail { get; set; }
    }
}

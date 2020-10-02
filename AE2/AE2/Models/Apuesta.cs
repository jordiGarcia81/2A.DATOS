using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class Apuesta
    {
        public Apuesta(string tipoApuesta, double cuota, double dinero, DateTime fecha, string usuariosEmailUsuarios, int idApuesta, int mercadosIdMercado)
        {
            this.tipoApuesta = tipoApuesta;
            this.cuota = cuota;
            this.dinero = dinero;
            this.fecha = fecha;
            this.usuariosEmailUsuarios = usuariosEmailUsuarios;
            this.idApuesta = idApuesta;
            this.mercadosIdMercado = mercadosIdMercado;
        }

        public string tipoApuesta { get; set; }
        public double cuota { get; set; }
        public double dinero { get; set; }
        public DateTime fecha { get; set; }
        public string usuariosEmailUsuarios { get; set; }
        public int idApuesta { get; set; }
        public int mercadosIdMercado { get; set; }

    }
}
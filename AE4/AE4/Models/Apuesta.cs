using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE4.Models
{
    public class Apuesta
    {
        public Apuesta()
        {
        }

        public Apuesta(int idApuesta, string tipoApuesta, double tipoMercado, double cuota, double dinero, DateTime fecha, int mercadosIdMercado, string usariosEmail)
        {
            this.idApuesta = idApuesta;
            this.tipoApuesta = tipoApuesta;
            this.tipoMercado = tipoMercado;
            this.cuota = cuota;
            this.dinero = dinero;
            this.fecha = fecha;
            this.mercadosIdMercado = mercadosIdMercado;
            this.usariosEmail = usariosEmail;
        }

        public int idApuesta { get; set; }
        public string tipoApuesta { get; set; }
        public double tipoMercado { get; set; }
        public double cuota { get; set; }
        public double dinero { get; set; }
        public DateTime fecha { get; set; }
        public int mercadosIdMercado { get; set; }
        public string usariosEmail { get; set; }



    }

    public class ApuestaDTO
    {
        public ApuestaDTO(string tipoApuesta, double tipoMercado, double cuota, double dinero, DateTime fecha, string usuariosEmail)
        {
            this.tipoApuesta = tipoApuesta;
            this.tipoMercado = tipoMercado;
            this.cuota = cuota;
            this.dinero = dinero;
            this.fecha = fecha;
            this.usuariosEmail = usuariosEmail;
        }

        public string tipoApuesta { get; set; }
        public double tipoMercado { get; set; }
        public double cuota { get; set; }
        public double dinero { get; set; }
        public DateTime fecha { get; set; }
        public string usuariosEmail { get; set; }


    }

}

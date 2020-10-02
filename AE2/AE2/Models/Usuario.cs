using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class Usuario
    {
        public Usuario(string emailUsuarios, string nombre, string apellidos, int edad)
        {
            EmailUsuarios = emailUsuarios;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        public string EmailUsuarios { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }

    }
}
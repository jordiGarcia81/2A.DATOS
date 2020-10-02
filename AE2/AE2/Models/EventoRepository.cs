using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class EventoRepository
    {
        private MySqlConnection conexion() 
        {
            string conectString = ("server=127.0.0.1;port=3306;database=mydb;uid=root;pwd=;Convert Zero Datetime =True;");
            MySqlConnection con = new MySqlConnection(conectString);
            return con;
        }
        internal List<Evento> Retrieve()
        {
            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM eventos";

            try { 
            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Evento e = null;
                List<Evento> eventos = new List<Evento>();
            while (res.Read())
            {
                Debug.WriteLine("Recuperando " + res.GetInt16(0) + " " + res.GetString(1) + " " + res.GetDateTime(2) + " " + res.GetString(3));
                e = new Evento(res.GetInt16(0), res.GetString(1), res.GetDateTime(2), res.GetString(3));
                    eventos.Add(e);

            }
            con.Close();
            return eventos;
            }
            catch(MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }
    }
}
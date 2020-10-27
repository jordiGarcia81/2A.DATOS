using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace AE4NUEVO.Models
{
    public class EventoRepository
    {
        private MySqlConnection conexion()
        {

            string conectString = "server=127.0.0.1;port=3306;database=placemybet;uid=root;pwd=;Convert Zero Datetime =True;SslMode=none;";
            MySqlConnection con = new MySqlConnection(conectString);
            return con;
        }
        internal List<Evento> Retrieve()
        {
            MySqlConnection con = conexion();
            con.Open();

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM eventos";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Evento e = null;
                List<Evento> eventos = new List<Evento>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperando " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetDateTime(3));
                    e = new Evento(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetDateTime(3));
                    eventos.Add(e);

                }
                con.Close();
                return eventos;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }

        internal List<EventoDTO> RetrieveDTO()
        {
            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM eventos";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                EventoDTO e = null;
                List<EventoDTO> eventos = new List<EventoDTO>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperando " + res.GetString(0) + " " + res.GetString(1) + " " + res.GetDateTime(2));
                    e = new EventoDTO(res.GetString(0), res.GetString(1), res.GetDateTime(2));
                    eventos.Add(e);

                }
                con.Close();
                return eventos;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }
    }
}
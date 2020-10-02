using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class ApuestaRepository
    {
        private MySqlConnection conexion()
        {
            string conectString = ("server=127.0.0.1;port=3306;database=mydb;uid=root;pwd=;Convert Zero Datetime =True;");
           MySqlConnection con = new MySqlConnection(conectString);
            return con;
        }
        internal List<Apuesta> Retrieve()
        {
            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM apuesta";

            try { 
            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Apuesta a= null;
                List<Apuesta> apuestas = new List<Apuesta>();
                while (res.Read())
            {
                Debug.WriteLine("Recuperando " + res.GetString(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDateTime(3) + " " + res.GetString(4) + " " + res.GetInt16(5) + " " + res.GetInt16(6));
                a= new Apuesta(res.GetString(0), res.GetDouble(1), res.GetDouble(2), res.GetDateTime(3), res.GetString(4), res.GetInt16(5), res.GetInt16(6));
                    apuestas.Add(a);
            }
            con.Close();
            return apuestas;
            }
            catch (MySqlException a)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }
    }
}


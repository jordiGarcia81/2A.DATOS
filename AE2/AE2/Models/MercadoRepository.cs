using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class MercadoRepository
    {
        private MySqlConnection conexion()
        {
            string conectString = ("server=127.0.0.1;port=3306;database=mydb;uid=root;pwd=;Convert Zero Datetime =True;");
            MySqlConnection con = new MySqlConnection(conectString);
            return con;
        }
        internal List<Mercado> Retrieve()
        {
            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM mercados";
            try { 
            con.Open();
            MySqlDataReader res = command.ExecuteReader(); 

            Mercado m=null;
                List<Mercado> mercados = new List<Mercado>();
                while (res.Read())
            {
                Debug.WriteLine("Recuperando " + res.GetDouble(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4) + " " + res.GetInt16(5) + " " + res.GetInt16(6));
               m = new Mercado(res.GetDouble(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3),res.GetDouble(4),res.GetInt16(5),res.GetInt16(6));
                    mercados.Add(m);
            }
            con.Close();
            return mercados;
            }
            catch (MySqlException m)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }
    }
}
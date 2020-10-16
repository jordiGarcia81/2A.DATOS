using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class ApuestaRepository
    {
        private MySqlConnection conexion()
        {
           string conectString = ("server=127.0.0.1;port=3306;database=placemybet;uid=root;pwd=;Convert Zero Datetime =True;SslMode=none;");
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
                Debug.WriteLine("Recuperando "+res.GetInt32(0) + res.GetString(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4) + " " + res.GetDateTime(5) + " " + res.GetInt32(6) + " " + res.GetString(7));
                a= new Apuesta(res.GetInt32(0),res.GetString(1) , res.GetDouble(2) , res.GetDouble(3) , res.GetDouble(4) , res.GetDateTime(5) , res.GetInt32(6), res.GetString(7));
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

        internal List<ApuestaDTO> RetrieveDTO()
        {
            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM apuesta";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                ApuestaDTO a = null;
                List<ApuestaDTO> apuestas = new List<ApuestaDTO>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperando " + res.GetString(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " +res.GetDouble(3) + " " + res.GetDateTime(4) + " " + res.GetString(5));
                    a = new ApuestaDTO(res.GetString(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3) ,res.GetDateTime(4),res.GetString(5));
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

        internal void Save(Apuesta a)
        {
            CultureInfo culInfo = new System.Globalization.CultureInfo("es-ES");
            culInfo.NumberFormat.NumberDecimalSeparator = ".";
            culInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            culInfo.NumberFormat.PercentDecimalSeparator = ".";
            culInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = culInfo;

            DateTime date = DateTime.Now;
            string fecha;
            fecha = date.ToString("yyyy-MM-dd HH:mm:ss");

            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();

            if(a.tipoApuesta == "under")
            {
                command.CommandText = "insert into apuestas (tipo_apuesta,tipo_mercado,cuota,dinero,fecha,Mercados_id_mercado,Usuarios_email) values ('" + a.tipoApuesta + "','" + a.tipoMercado + "'," + "(SELECT cuota_under FROM mercados WHERE id_mercado= " + a.mercadosIdMercado + ")" + ",'" + a.dinero + "','" + fecha + "','" + a.mercadosIdMercado + "','" + a.usariosEmail + "');";
            }
           else if (a.tipoApuesta == "over")
            {
                command.CommandText = "insert into apuestas (tipo_apuesta,tipo_mercado,cuota,dinero,fecha,Mercados_id_mercado,Usuarios_email) values ('" + a.tipoApuesta + "','" + a.tipoMercado + "'," + "(SELECT cuota_over FROM mercados WHERE id_mercado= " + a.mercadosIdMercado + ")" + ",'" + a.dinero + "','" + fecha + "','" + a.mercadosIdMercado + "','" + a.usariosEmail + "');";
            }



            try { 
                
                con.Open();
                command.ExecuteNonQuery();
                MercadoRepository mercado = new MercadoRepository();
                mercado.aumentoDinero(a);
                Mercado m = mercado.objetoMercado(a);
                mercado.probabilidad(m,a);
                con.Close();

            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
            }


        }
    }
}


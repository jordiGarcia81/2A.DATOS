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
            string conectString = ("server=127.0.0.1;port=3306;database=placemybet;uid=root;pwd=;Convert Zero Datetime =True;SslMode=none;");
            MySqlConnection con = new MySqlConnection(conectString);
            return con;
        }
        internal List<Mercado> Retrieve()
        {
            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM mercados";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Mercado m = null;
                List<Mercado> mercados = new List<Mercado>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperando " + res.GetInt32(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4) + " " + res.GetInt32(5));
                    m = new Mercado(res.GetInt32(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4), res.GetDouble(5),res.GetInt32(6));
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

        internal List<MercadoDTO> RetrieveDTO()
        {
            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM mercados";
            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                MercadoDTO m = null;
                List<MercadoDTO> mercados = new List<MercadoDTO>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperando " + res.GetDouble(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2));
                    m = new MercadoDTO(res.GetDouble(0), res.GetDouble(1), res.GetDouble(2));
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

        public void aumentoDinero(Apuesta a)
        {
            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();


            if (a.tipoApuesta == "over")
            {
                command.CommandText = "update mercados set dinero_over=dinero_over + " + a.dinero + " WHERE id_mercado = " + a.mercadosIdMercado + ";";
            }
            else if (a.tipoApuesta == "under")
            {
                command.CommandText = "update mercados set dinero_under=dinero_under + " + a.dinero + " WHERE id_mercado = " + a.mercadosIdMercado + ";";
            }

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        public Mercado objetoMercado(Apuesta a)
        {

            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM mercados WHERE id_mercado=" + a.mercadosIdMercado + ";";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Mercado m = null;

                while (res.Read())
                {
                    Debug.WriteLine("Recuperando "+res.GetInt32(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4) + " " + res.GetDouble(5) + " " + res.GetInt32(6));
                    m = new Mercado(res.GetInt32(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4), res.GetDouble(5), res.GetInt32(6));

                }
                con.Close();
                return m;
            }
            catch (MySqlException m)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }


        public void probabilidad(Mercado m, Apuesta a)
        {
            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();

            command.CommandText = "update mercados set cuota_over=" + calcularCuotaOver(m) + "," + " cuota_under= " + calcularCuotaUnder(m) + " WHERE id_mercado= " + a.mercadosIdMercado + ";";
            
            try
            {
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                Debug.WriteLine("Se ha producido un error en la conexion");
            }
        }

        public double calcularCuotaOver(Mercado m)
        {
            double probabilidadOver = m.dineroOver / (m.dineroOver + m.dineroUnder);
            double cuotaOver = (1 / probabilidadOver) * 0.95;
            return cuotaOver;
        }

        public double calcularCuotaUnder(Mercado m)
        {
            double probabilidadUnder = m.dineroUnder / (m.dineroOver + m.dineroUnder);
            double cuotaUnder = (1 / probabilidadUnder) * 0.95;
            return cuotaUnder;
        }



    }
}


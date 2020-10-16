using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace AE2.Models
{
    public class CuentaRepository
    {
        private MySqlConnection conexion()
        {
            string conectString = ("server=127.0.0.1;port=3306;database=placemybet;uid=root;pwd=;Convert Zero Datetime =True;Convert Zero Datetime =True;SslMode=none;");
            MySqlConnection con = new MySqlConnection(conectString);
            return con;
        }
        internal List<Cuenta> Retrieve()
        {
            MySqlConnection con = conexion();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM cuenta";
            try { 
            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Cuenta c= null;
                List<Cuenta> cuentas = new List<Cuenta>();
                while (res.Read())
            {
                Debug.WriteLine("Recuperando " + res.GetInt64(0) + " " + res.GetString(1) + " " + res.GetDouble(2) + " " + res.GetString(3));
                c = new Cuenta(res.GetInt64(0), res.GetString(1), res.GetDouble(2), res.GetString(3));
                    cuentas.Add(c);
            }
            con.Close();
            return cuentas;
            }
            catch (MySqlException c)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }

        //internal List<CuentaDTO> RetrieveDTO()
        //{
        //    MySqlConnection con = conexion();
        //    MySqlCommand command = con.CreateCommand();
        //    command.CommandText = "SELECT * FROM cuenta";
        //    try
        //    {
        //        con.Open();
        //        MySqlDataReader res = command.ExecuteReader();

        //        CuentaDTO c = null;
        //        List<CuentaDTO> cuentas = new List<CuentaDTO>();
        //        while (res.Read())
        //        {
        //            Debug.WriteLine("Recuperando " + res.GetInt64(0) + " " + res.GetInt16(1) + " " + res.GetDouble(2) + " " + res.GetString(3));
        //            c = new CuentaDTO( res.GetDouble(2));
        //            cuentas.Add(c);
        //        }
        //        con.Close();
        //        return cuentas;
        //    }
        //    catch (MySqlException c)
        //    {
        //        Debug.WriteLine("Se ha producido un error de conexión");
        //        return null;
        //    }
        //}

       


    }
}
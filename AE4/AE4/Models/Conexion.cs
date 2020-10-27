using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE4.Models
{
    public class Conexion
    {




        public MySqlConnection conexion;

       

        public Conexion()
        {
           
            string server = "server=127.0.0.1;";
            string port = "port=3306;";
            string database = "database=placemybet;";
            string usuario = "uid=jordi;";
            string password = "pwd=123456;";
            string convert = "Convert Zero Datetime =True;";
            string connectionstring = server + port + database + usuario + password + convert;

            conexion = new MySqlConnection(connectionstring);
        }

       
        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)  
            {
                return false;
            }
        }

        
        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex) 
            {
                return false;
            }
        }
    }
}
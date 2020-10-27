﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace AE4NUEVO.Models
{
    public class UsuarioRepository
    {
        private MySqlConnection conexion()
        {

            string conectString = "server=127.0.0.1;port=3306;database=placemybet;uid=root;pwd=;Convert Zero Datetime =True;SslMode=none;";
            MySqlConnection con = new MySqlConnection(conectString);
            return con;
        }
        internal List<Usuario> Retrieve()
        {
            MySqlConnection con = conexion();
            con.Open();

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM usuarios";
            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Usuario u = null;
                List<Usuario> usuarios = new List<Usuario>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperando " + res.GetString(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetInt32(3));
                    u = new Usuario(res.GetString(0), res.GetString(1), res.GetString(2), res.GetInt32(3));
                    usuarios.Add(u);
                }
                con.Close();
                return usuarios;
            }
            catch (MySqlException u)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }

    }
}

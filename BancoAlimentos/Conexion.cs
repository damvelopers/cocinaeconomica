using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAlimentos
{
    class Conexion
    {
        private static string BASE_DATOS = "BancoAlimentos";
        /// <summary>
        /// Establece la configuración de conexión con la base de datos
        /// </summary>
        /// <param name="server">El servidor</param>
        /// <param name="user">El usuario</param>
        /// <param name="password">La contraseña</param>
        public static void setConnectionConfig(string server, string user, string password)
        {
            Properties.Settings.Default.Server = server;
            Properties.Settings.Default.User = user;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.ConnectionString =
                "Data Source='" + server + "';Initial Catalog='" + BASE_DATOS +"';User ID='" + user + "';Password='" + password + "'";
            Properties.Settings.Default.Save(); // Guarda los cambios realizados de forma permanente
        }

        /// <summary>
        /// Comprueba el estado de la conexión
        /// </summary>
        /// <param name="server">El servidor</param>
        /// <param name="user">El usuario</param>
        /// <param name="password">La contraseña</param>
        /// <returns>Si la conexión es correcta o no</returns>
        public static bool testConnection(string server, string user, string password)
        {
            string connectionString = "Data Source='" + server + "';Initial Catalog='" + BASE_DATOS + "';User ID='" + user + "';Password='" + password + "'";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();
                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (SqlException)
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
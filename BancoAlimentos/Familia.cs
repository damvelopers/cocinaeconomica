using System;
using System.Collections;
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
    class Familia
    {
        public int Id;
        public string Nombre;

        public Familia()
        {
            this.Nombre = "";
        }

        public Familia(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public static ArrayList GetFamilias()
        {
            ArrayList familias = new ArrayList();
            // selects
            return familias;
        }
        
        public static Familia GetFamilia(int Id)
        {
            SqlDataReader reader;
            Familia f = new Familia();
            SqlConnection conn = new SqlConnection(Constantes.CONNECTION_STRING);
            string selectString = "select * from Familia where Id = @id";
            SqlCommand selectCommand = new SqlCommand(selectString, conn);
            selectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            conn.Open();
            reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                f.Id = reader.GetInt32(0);
                f.Nombre = reader.GetString(1);
            }
            conn.Close();
            return f;
        }
        
        public static Familia GetFamilia(string Nombre)
        {
            SqlDataReader reader;
            Familia f = new Familia();
            SqlConnection conn = new SqlConnection(Constantes.CONNECTION_STRING);
            string selectString = "select * from Familia where Nombre like @nombre";
            SqlCommand selectCommand = new SqlCommand(selectString, conn);
            selectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = Nombre;
            conn.Open();
            reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                f.Id = reader.GetInt32(0);
                f.Nombre = reader.GetString(1);
            }
            conn.Close();
            return f;
        }
        
        public static void InsertarFamilia(Familia f)
        {
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert = "INSERT into dbo.Familia(Nombre) VALUES (@nombre)";

                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = f.Nombre;
                    query.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }
    }
}
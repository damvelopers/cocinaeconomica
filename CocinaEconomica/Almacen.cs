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

namespace CocinaEconomica
{
    public class Almacen
    {
        public int Id;
        public string Nombre;
        public string Descripcion;

        public Almacen()
        {
            this.Id = -1;
            this.Nombre = "";
            this.Descripcion = "";
        }

        public Almacen(int Id, string Nombre, string Descripcion)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
        }

        /// <summary>
        /// Borra el Almacen de la base de datos
        /// </summary>
        /// <returns>
        /// Si se ha borrado o no correctamente
        /// </returns>
        public bool Delete()
        {
            int rows = 0;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert = "DELETE FROM dbo.Almacen WHERE Id = @id";

                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@id", SqlDbType.Int).Value = this.Id;
                    rows = query.ExecuteNonQuery();
                }
                conexion.Close();
            }
            return rows > 0;
        }

        /// <summary>
        /// Actualiza el Almacen en la base de datos
        /// </summary>
        /// <returns>
        /// Si se ha actualizado o no correctamente
        /// </returns>
        public bool Update()
        {
            int rows = 0;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert = "UPDATE dbo.Almacen (Nombre, Descripcion)" +
                    " VALUES (@nombre, @descripcion)";

                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = this.Nombre;
                    query.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = this.Descripcion;
                    rows = query.ExecuteNonQuery();
                }
                conexion.Close();
            }
            return rows > 0;
        }

        #region SELECTS

        /// <summary>
        /// Devuelve un ArrayList con los almacenes
        /// </summary>
        /// <returns>
        /// Todos los almacenes
        /// </returns>
        public static ArrayList SelectAll()
        {
            ArrayList almacenes = new ArrayList();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Almacen";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    conn.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Almacen a = new Almacen();
                        a.Id = reader.GetInt32(0);
                        a.Nombre = reader.GetString(1);
                        a.Descripcion = reader.GetString(2);
                        almacenes.Add(a);
                    }
                }
            }
            return almacenes;
        }

        /// <summary>
        /// Devuelve un Almacen dado su Id
        /// </summary>
        /// <param name="Id">Id del almacén</param>
        /// <returns>El almacén</returns>
        public static Almacen Select(int Id)
        {
            Almacen a = null;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string selectString = "select * from Almacen where Id = @id";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    conn.Open();
                    selectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        a.Id = reader.GetInt32(0);
                        a.Nombre = reader.GetString(1);
                        a.Descripcion = reader.GetString(2);
                    }
                }
            }
            return a;
        }

        #endregion

        #region INSERTS

        /// <summary>
        /// Inserta un almacén en la base de datos
        /// </summary>
        /// <param name="a">El almacén</param>
        /// <returns>Si se ha insertado correctamente o no</returns>
        public bool Insert()
        {
            bool inserted = false;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert = "INSERT into dbo.Almacen(Nombre, Descripcion)" +
                    " VALUES (@nombre, @descripcion)";

                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = this.Nombre;
                    query.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = this.Descripcion;
                    query.ExecuteNonQuery();
                }
                conexion.Close();
                inserted = true;
            }
            return inserted;
        }

        #endregion
    }
}
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
    public class Familia
    {
        public int Id;
        public string Nombre;

        public Familia()
        {
            this.Id = -1;
            this.Nombre = "";
        }

        public Familia(string Nombre)
        {
            this.Id = -1;
            this.Nombre = Nombre;
        }
        
        #region MODIFICACIONES

        /// <summary>
        /// Modifica o inserta la Familia en la base de datos dependiendo de si está creado o no
        /// </summary>
        public void Save()
        {
            if (this.Id > 0)
            {
                this.Update();
            }
            else
            {
                this.Insert();
            }
        }

        /// <summary>
        /// Borra la Familia de la base de datos
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
                string insert = "DELETE FROM dbo.Familia WHERE Id = @id";

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
        /// Actualiza el Familia en la base de datos
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

                string update = "UPDATE dbo.Familia set Nombre = @nombre WHERE Id = @Id";

                using (SqlCommand query = new SqlCommand(update))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@Id", SqlDbType.Int).Value = this.Id;
                    query.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = this.Nombre;
                    rows = query.ExecuteNonQuery();
                }
                conexion.Close();
            }
            return rows > 0;
        }

        #endregion

        #region SELECTS

        /// <summary>
        /// Devuelve un ArrayList de todas las familias
        /// </summary>
        /// <returns></returns>
        public static ArrayList SelectAll()
        {
            ArrayList familias = new ArrayList();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Familia";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Familia f = new Familia();
                        f.Id = reader.GetInt32(0);
                        f.Nombre = reader.GetString(1);
                        familias.Add(f);
                    }
                }
            }
            return familias;
        }

        /// <summary>
        /// Devuelve una Familia dado su Id
        /// </summary>
        /// <param name="Id">Id de la familia</param>
        /// <returns>La familia</returns>
        public static Familia Select(int Id)
        {
            Familia f = new Familia();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Familia where Id = @id";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        f.Id = reader.GetInt32(0);
                        f.Nombre = reader.GetString(1);
                    }
                }
            }
            return f;
        }

        /// <summary>
        /// Devuelve una Familia dado su Nombre
        /// </summary>
        /// <param name="Nombre">Nombre de la familia</param>
        /// <returns>La familia</returns>
        public static Familia SelectWhereNombreIs(string Nombre)
        {
            Familia f = new Familia();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Familia where Nombre like @nombre";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = Nombre;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        f.Id = reader.GetInt32(0);
                        f.Nombre = reader.GetString(1);
                    }
                }
            }
            return f;
        }

        #endregion

        #region INSERTS

        /// <summary>
        /// Inserta una nueva familia
        /// </summary>
        /// <returns>Si se ha insertado correctamente</returns>
        public bool Insert()
        {
            bool inserted = false;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert = "INSERT into dbo.Familia(Nombre) VALUES (@nombre)";
                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = this.Nombre;
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
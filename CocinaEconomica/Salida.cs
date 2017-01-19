using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocinaEconomica
{
    class Salida
    {
        public int Id;
        public DateTime FechaSalida;
        public Alimento Alimento;
        
        public Salida()
        {
            this.Id = -1;
            this.FechaSalida = DateTime.Now;
            this.Alimento = null;
        }

        public Salida(int Id, DateTime FechaSalida, Alimento Alimento)
        {
            this.Id = Id;
            this.FechaSalida = FechaSalida;
            this.Alimento = Alimento;
        }

        #region DELETE

        /// <summary>
        /// Borra la salida de la base de datos
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
                string insert = "DELETE FROM dbo.Salida WHERE Id = @id";

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

        #endregion

        #region SELECTS

        /// <summary>
        /// Devuelve un ArrayList con las salidas
        /// </summary>
        /// <returns>
        /// Todos las salidas
        /// </returns>
        public static ArrayList SelectAll()
        {
            ArrayList salidas = new ArrayList();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Salida";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    conn.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Salida s = new Salida();
                        s.Id = reader.GetInt32(0);
                        s.FechaSalida = reader.GetDateTime(1);
                        s.Alimento = Alimento.Select(reader.GetInt32(2));
                        salidas.Add(s);
                    }
                }
            }
            return salidas;
        }

        /// <summary>
        /// Devuelve una Salida dado su Id
        /// </summary>
        /// <param name="Id">Id de la salida</param>
        /// <returns>
        /// La salida
        /// </returns>
        public static Salida Select(int Id)
        {
            Salida s = new Salida();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Salida";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    conn.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        s.Id = reader.GetInt32(0);
                        s.FechaSalida = reader.GetDateTime(1);
                        s.Alimento = Alimento.Select(reader.GetInt32(2));
                    }
                }
            }
            return s;
        }

        #endregion

        #region INSERTS

        /// <summary>
        /// Inserta un registro de salida en la base de datos
        /// </summary>
        /// <returns>Si se ha insertado correctamente o no</returns>
        public bool Insert()
        {
            bool inserted = false;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert = "INSERT into dbo.Salida(FechaSalida, Alimento)" +
                    " VALUES (@fechasalida, @alimento)";

                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@fechasalida", SqlDbType.VarChar, 50).Value = this.FechaSalida;
                    query.Parameters.Add("@alimento", SqlDbType.VarChar, 200).Value = this.Alimento.Id;
                    query.ExecuteNonQuery();
                }
                conexion.Close();
                inserted = true;
            }
            return inserted;
        }

        public bool Insert(int cantidad)
        {
            if (this.Alimento == null || this.Alimento.Id < 0)
                return false;

            bool inserted = false;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                // Hay que realizar una transacción para asegurarnos de que entran todos bien
                using (SqlTransaction tx = conexion.BeginTransaction())
                {
                    try
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            string insert = "INSERT into dbo.Salida(FechaSalida, Alimento) " +
                                "VALUES (@fechasalida, @alimento)";
                            using (SqlCommand query = new SqlCommand(insert))
                            {
                                query.Connection = conexion;
                                query.Transaction = tx;
                                query.Parameters.Add("@fechasalida", SqlDbType.VarChar, 50).Value = this.FechaSalida;
                                query.Parameters.Add("@alimento", SqlDbType.VarChar, 200).Value = this.Alimento.Id;
                                query.ExecuteNonQuery();
                            }
                        }
                        tx.Commit();
                        inserted = true;
                    }
                    catch
                    {
                        tx.Rollback();
                        inserted = false;
                    }
                }
            }
            return inserted;
        }

        #endregion
    }
}
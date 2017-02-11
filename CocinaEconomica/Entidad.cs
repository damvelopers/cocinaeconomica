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
    public class Entidad
    {
        public int Id;
        public string Nombre;
        public string Direccion;
        public string Email;
        public string Telefono;
        public string Descripcion;
        public string Web;
        public string DNI;
        public string CIF;

        public Entidad()
        {
            this.Id = -1;
            this.Nombre = "";
            this.Direccion = "";
            this.Email = "";
            this.Telefono = "";
            this.Descripcion = "";
            this.Web = "";
            this.DNI = "";
            this.CIF = "";
        }

        public Entidad(int Id, string Nombre, string Direccion, string Email, string Telefono, string Descripcion,
                       string Web, string DNI, string CIF)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Descripcion = Descripcion;
            this.Web = Web;
            this.DNI = DNI;
            this.CIF = CIF;
        }

        /// <summary>
        /// Modifica o inserta el producto en la base de datos dependiendo de si está creado o no
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
        /// Inserta la entidad en la base de datos
        /// </summary>
        /// <returns>Si se ha insertado correctamente o no</returns>
        public bool Insert()
        {
            bool inserted;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert = "INSERT into dbo.Entidad(Nombre, Direccion, Email, Telefono, Descripcion, Web, DNI, CIF) " +
                                "VALUES (@nombre, @direccion, @email, @telefono, @descripcion, @web, @dni, @cif)";

                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = this.Nombre;
                    query.Parameters.Add("@direccion", SqlDbType.VarChar, 200).Value = this.Direccion;
                    query.Parameters.Add("@email", SqlDbType.VarChar, 80).Value = this.Email;
                    query.Parameters.Add("@telefono", SqlDbType.VarChar, 11).Value = this.Telefono;
                    query.Parameters.Add("@descripcion", SqlDbType.VarChar, 300).Value = this.Descripcion;
                    query.Parameters.Add("@web", SqlDbType.VarChar, 50).Value = this.Web;
                    query.Parameters.Add("@dni", SqlDbType.VarChar, 10).Value = this.DNI;
                    query.Parameters.Add("@cif", SqlDbType.VarChar, 50).Value = this.CIF;
                    inserted = query.ExecuteNonQuery() > 0;
                }
                conexion.Close();
            }
            return inserted;
        }

        /// <summary>
        /// Actualiza la entidad en la base de datos
        /// </summary>
        /// <returns>Si se ha actualizado correctamente o no</returns>
        public bool Update()
        {
            int rows = 0;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string update = "UPDATE dbo.Entidad set Nombre = @nombre, Direccion = @direccion, Email = @email, Telefono = @telefono, " +
                    "Descripcion = @descripcion, Web = @web, DNI = @dni, CIF = @cif " +
                    "WHERE Id = @Id";

                using (SqlCommand query = new SqlCommand(update))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@Id", SqlDbType.Int).Value = this.Id;
                    query.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = this.Nombre;
                    query.Parameters.Add("@direccion", SqlDbType.VarChar, 200).Value = this.Direccion;
                    query.Parameters.Add("@email", SqlDbType.VarChar, 80).Value = this.Email;
                    query.Parameters.Add("@telefono", SqlDbType.VarChar, 11).Value = this.Telefono;
                    query.Parameters.Add("@descripcion", SqlDbType.VarChar, 300).Value = this.Descripcion;
                    query.Parameters.Add("@web", SqlDbType.VarChar, 50).Value = this.Web;
                    query.Parameters.Add("@dni", SqlDbType.VarChar, 10).Value = this.DNI;
                    query.Parameters.Add("@cif", SqlDbType.VarChar, 50).Value = this.CIF;
                    
                    rows = query.ExecuteNonQuery();
                }
                conexion.Close();
            }
            return rows > 0;
        }

        /// <summary>
        /// Borra la entidad de la base de datos
        /// </summary>
        /// <returns>Si se ha borrado correctamente o no</returns>
        public bool Delete()
        {
            int rows = 0;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert = "DELETE FROM dbo.Entidad WHERE Id = @id";

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
        /// Devuelve un ArrayList con todas las entidades
        /// </summary>
        /// <returns>Todas las entidades</returns>
        public static ArrayList SelectAll()
        {
            ArrayList entidades = new ArrayList();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Entidad";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Entidad e = new Entidad();
                        e.Id = reader.GetInt32(0);
                        e.Nombre = reader.GetString(1);
                        e.Direccion = reader.GetString(2);
                        e.Email = reader.GetString(3);
                        e.Telefono = reader.GetString(4);
                        e.Descripcion = reader.GetString(5);
                        e.Web = reader.GetString(6);
                        e.DNI = reader.GetString(7);
                        e.CIF = reader.GetString(8);
                        entidades.Add(e);
                    }
                    conn.Close();
                }
            }
            return entidades;
        }

        /// <summary>
        /// Devuelve una entidad dado su Id
        /// </summary>
        /// <returns>La entidad</returns>
        public static Entidad Select(int Id)
        {
            Entidad e = null;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "SELECT * " + 
                                      "FROM Entidad " + 
                                      "WHERE Id = @id" ;
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        e = new Entidad();
                        e.Id = reader.GetInt32(0);
                        e.Nombre = reader.GetString(1);
                        e.Direccion = reader.GetString(2);
                        e.Email = reader.GetString(3);
                        e.Telefono = reader.GetString(4);
                        e.Descripcion = reader.GetString(5);
                        e.Web = reader.GetString(6);
                        e.DNI = reader.GetString(7);
                        e.CIF = reader.GetString(8);
                    }
                    conn.Close();
                }
            }
            return e;
        }

        /// <summary>
        /// Devuelve una entidad dado su Id
        /// </summary>
        /// <returns>La entidad</returns>
        public static Entidad SelectByName(string name, string direccion)
        {
            Entidad e = null;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "SELECT * " +
                                      "FROM Entidad " +
                                      "WHERE Nombre = @nombre AND Direccion = @direccion";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = name;
                    selectCommand.Parameters.Add("@direccion", SqlDbType.VarChar).Value = direccion;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        e = new Entidad();
                        e.Id = reader.GetInt32(0);
                        e.Nombre = reader.GetString(1);
                        e.Direccion = reader.GetString(2);
                        e.Email = reader.GetString(3);
                        e.Telefono = reader.GetString(4);
                        e.Descripcion = reader.GetString(5);
                        e.Web = reader.GetString(6);
                        e.DNI = reader.GetString(7);
                        e.CIF = reader.GetString(8);
                    }
                    conn.Close();
                }
            }
            return e;
        }

        /// <summary>
        /// Devuelve una entidad dado su DNI
        /// </summary>
        /// <returns>La entidad</returns>
        public static Entidad SelectByDNI(string dni)
        {
            Entidad e = null;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "SELECT * " +
                                      "FROM Entidad " +
                                      "WHERE DNI = @dni";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@dni", SqlDbType.VarChar, 10).Value = dni;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        e = new Entidad();
                        e.Id = reader.GetInt32(0);
                        e.Nombre = reader.GetString(1);
                        e.Direccion = reader.GetString(2);
                        e.Email = reader.GetString(3);
                        e.Telefono = reader.GetString(4);
                        e.Descripcion = reader.GetString(5);
                        e.Web = reader.GetString(6);
                        e.DNI = reader.GetString(7);
                        e.CIF = reader.GetString(8);
                    }
                    conn.Close();
                }
            }
            return e;
        }

        /// <summary>
        /// Devuelve una entidad dado su CIF
        /// </summary>
        /// <returns>La entidad</returns>
        public static Entidad SelectByCIF(string cif)
        {
            Entidad e = null;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "SELECT * " +
                                      "FROM Entidad " +
                                      "WHERE CIF = @cif";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@cif", SqlDbType.VarChar, 50).Value = cif;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        e = new Entidad();
                        e.Id = reader.GetInt32(0);
                        e.Nombre = reader.GetString(1);
                        e.Direccion = reader.GetString(2);
                        e.Email = reader.GetString(3);
                        e.Telefono = reader.GetString(4);
                        e.Descripcion = reader.GetString(5);
                        e.Web = reader.GetString(6);
                        e.DNI = reader.GetString(7);
                        e.CIF = reader.GetString(8);
                    }
                    conn.Close();
                }
            }
            return e;
        }
    }
}

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
    public class Alimento
    {
        public int Id;
        public string Nombre;
        public Familia Familia;
        public int idFamilia;
        public string Descripcion;
        public Image Imagen;

        public Alimento()
        {
            this.Nombre = "";
            this.Familia = null;
            this.Imagen = null;
            this.Descripcion = "";
            this.Id = -1;
        }

        public Alimento(int Id, string Nombre, Familia Familia, string Descripcion, Image Imagen)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Imagen = Imagen;
            this.Familia = Familia;
            this.Descripcion = Descripcion;
        }

        public Alimento(int Id, string Nombre, int Familia, string Descripcion, Image Imagen)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Imagen = Imagen;
            this.idFamilia = Familia;
            this.Descripcion = Descripcion;
        }

        #region MODIFICACIONES

        /// <summary>
        /// Modifica o inserta el alimento en la base de datos dependiendo de si está creado o no
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
                string insert = "DELETE FROM dbo.Alimento WHERE Id = @id";
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
        /// Actualiza el Alimento en la base de datos
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
                string insert = "UPDATE dbo.Alimento set Nombre = @nombre, Familia = @familia, Descripcion = @descripcion " +
                    "WHERE Id = @Id";

                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@Id", SqlDbType.Int).Value = this.Id;
                    if (this.Familia != null)
                        query.Parameters.Add("@familia", SqlDbType.Int).Value = this.Familia.Id;
                    else
                        query.Parameters.Add("@familia", SqlDbType.Int).Value = DBNull.Value;
                    query.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = this.Nombre;
                    query.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = this.Descripcion;
                    rows = query.ExecuteNonQuery();
                }
                conexion.Close();
            }
            return rows > 0;
        }

        #endregion

        #region SELECTS

        /// <summary>
        /// Devuelve un ArrayList con todos los alimentos
        /// </summary>
        /// <returns>ArrayList de todos los alimentos</returns>
        public static ArrayList SelectAll()
        {
            ArrayList alimentos = new ArrayList();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Alimento";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Alimento a = new Alimento();
                        a.Id = reader.GetInt32(0);
                        a.Nombre = reader.GetString(1);
                        try
                        {
                            a.Imagen = Alimento.GetImagen(reader.GetInt32(2));
                            a.Familia = Familia.Select(reader.GetInt32(3));
                        }
                        catch(System.Data.SqlTypes.SqlNullValueException ex) {}
                        
                        
                        a.Descripcion = reader.GetString(4);
                        alimentos.Add(a);
                    }
                }
            }
            return alimentos;
        }

        /// <summary>
        /// Devuelve un alimento dado su id
        /// </summary>
        /// <param name="Id">Id del alimento</param>
        /// <returns>El alimento</returns>
        public static Alimento Select(int Id)
        {
            Alimento a = null;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string selectString = "select * from Alimento where Id = @id";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    conn.Open();
                    selectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        a = new Alimento();
                        a.Id = reader.GetInt32(0);
                        a.Nombre = reader.GetString(1);
                        try
                        {
                            a.Imagen = Alimento.GetImagen(reader.GetInt32(2));
                        }catch(Exception e)
                        {
                            a.Imagen = null;
                        }
                       try
                        {
                            a.Familia = Familia.Select(reader.GetInt32(3));
                        }
                        catch(Exception e) { a.Familia = null; }
                                  
                        a.Descripcion = reader.GetString(4);
                    }
                }
            }
            return a;
        }
        
        /// <summary>
        /// Devuelve un Alimento dado su nombre
        /// </summary>
        /// <param name="Nombre">Nombre del alimento</param>
        /// <returns>El alimento</returns>
        public static Alimento SelectWhereNombreIs(string Nombre)
        {
            Alimento a = new Alimento();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Alimento where Nombre like @nombre";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = Nombre;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        a.Id = reader.GetInt32(0);
                        a.Nombre = reader.GetString(1);
                    }
                }
            }
            return a;
        }

        #endregion

        #region INSERT

        /// <summary>
        /// Inserta un alimento en la base de datos
        /// </summary>
        /// <returns>Si se ha insertado o no correctamente</returns>
        public bool Insert()
        {
            int idAlimento = Alimento.InsertarImagen(this.Imagen);
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                int rows = 0;
                string insert;

                if (idAlimento > 0)
                    insert = "INSERT into dbo.Alimento(Nombre, Familia, Imagen, Descripcion) VALUES (@nombre, @familia, @imagen, @descripcion)";
                else
                    insert = "INSERT into dbo.Alimento(Nombre, Familia, Descripcion) VALUES (@nombre, @familia, @descripcion)";

                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = this.Nombre;
                    if (this.Familia != null)
                        query.Parameters.Add("@familia", SqlDbType.Int).Value = this.Familia.Id;
                    else
                        query.Parameters.Add("@familia", SqlDbType.Int).Value = DBNull.Value;
                    query.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = this.Descripcion;

                    if (idAlimento > 0)
                        query.Parameters.Add("@imagen", SqlDbType.Int).Value = idAlimento;
                    rows = query.ExecuteNonQuery();
                }
                conexion.Close();
                return rows > 0;
            }
        }

        #endregion

        #region IMAGENES

        /// <summary>
        /// Inserta una imagen y devuelve el valor del id que se le ha asignado
        /// </summary>
        /// <param name="imagen">La imagen que se va a insertar</param>
        /// <returns>Id de la imagen que se ha añadido</returns>
        public static int InsertarImagen(Image imagen)
        {
            int id = -1;
            if (imagen != null)
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    conexion.Open();
                    byte[] arr;
                    // Convertimos la imagen en un array de bytes que insertaremos en la base de datos
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(imagen, typeof(byte[]));
                    // Añadimos una salida en la consulta para el Id del producto recién insertado
                    string insertImagen = "INSERT INTO dbo.Imagen(imagen) OUTPUT INSERTED.Id VALUES(@imagen)";
                    using (SqlCommand query = new SqlCommand(insertImagen))
                    {
                        query.Connection = conexion;
                        query.Parameters.Add("@imagen", SqlDbType.VarBinary).Value = arr;
                        query.CommandType = CommandType.Text;
                        id = (int)query.ExecuteScalar();
                    }
                    conexion.Close();
                    return id;
                }
            }
            else
                return id;
        }

        /// <summary>
        /// Inserta una imagen y devuelve el valor del id que se le ha asignado
        /// </summary>
        /// <param name="imagen">La imagen que se va a insertar</param>
        /// <returns>Id de la imagen que se ha añadido</returns>
        public static bool ActualizarImagen(Image imagen, int IdImagen)
        {
            int rows = 0;
            if (imagen != null)
            {
                using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    conexion.Open();
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(imagen, typeof(byte[]));
                    string insertImagen = "UPDATE dbo.Imagen set Imagen = @imagen WHERE Id = @Id";
                    using (SqlCommand query = new SqlCommand(insertImagen))
                    {
                        query.Connection = conexion;
                        query.Parameters.Add("@Id", SqlDbType.Int).Value = IdImagen;
                        query.Parameters.Add("@imagen", SqlDbType.VarBinary).Value = arr;
                        query.CommandType = CommandType.Text;
                        rows = query.ExecuteNonQuery();
                    }
                    conexion.Close();
                    return rows > 0;
                }
            }
            else
                return false;
        }

        /// <summary>
        /// Devuelve la imagen de un Alimento dado su id
        /// </summary>
        /// <param name="id">Id del alimento</param>
        /// <returns>Imagen del Alimento</returns>
        public static Image GetImagen(int id)
        {
            Image result = null;
            SqlDataReader imageReader;

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            string selectString = "select Imagen from Imagen where Id = @id";
            SqlCommand selectCommand = new SqlCommand(selectString, conn);
            selectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            conn.Open();
            imageReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
            while (imageReader.Read())
            {
                // Lee la imagen de un MemoryStream creado a partir del array de bytes
                result = Image.FromStream(new MemoryStream((byte[])imageReader.GetValue(0)));
            }
            conn.Close();
            return result;
        }

        /// <summary>
        /// Devuelve el Id de la imagen del alimento
        /// </summary>
        /// <returns>Id de la imagen del alimento</returns>
        public int GetIdImagen()
        {
            int id = -1;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string selectString = "select Imagen from Alimento where Id = @id";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                    conn.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }
            }
            return id;
        }

        #endregion
    }
}
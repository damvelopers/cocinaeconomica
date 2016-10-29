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
    class Alimento
    {
        public int Id;
        public string Nombre;
        public Familia Familia;
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

        public Alimento(int Id,string Nombre,Familia Familia,string Descripcion,Image Imagen)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Imagen = Imagen;
            this.Familia = Familia;
            this.Descripcion = Descripcion;
        }

        #region SELECTS
        public static ArrayList GetAlimentos()
        {
            ArrayList alimentos = new ArrayList();
            SqlDataReader reader;

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            string selectString = "select * from Alimento ";
            SqlCommand selectCommand = new SqlCommand(selectString, conn);
            conn.Open();
            reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                Alimento a = new Alimento();
                a.Id = reader.GetInt32(0);
                a.Nombre = reader.GetString(1);
                a.Familia = Familia.GetFamilia(reader.GetInt32(2));
                a.Imagen = Alimento.GetImagen(reader.GetInt32(3));
                a.Descripcion = reader.GetString(4);
                alimentos.Add(a);
            }
            conn.Close();
            return alimentos;
        }

        public static Alimento GetAlimento(int Id)
        {
            SqlDataReader reader;
            Alimento a = new Alimento();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            string selectString = "select * from Alimento where Id = @id  ";
            SqlCommand selectCommand = new SqlCommand(selectString, conn);
            selectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            conn.Open();
            reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                a.Id = reader.GetInt32(0);
                a.Nombre = reader.GetString(1);
                a.Familia = Familia.GetFamilia(reader.GetInt32(2));
                a.Imagen = Alimento.GetImagen(reader.GetInt32(3));
                a.Descripcion = reader.GetString(4);
            }
            conn.Close();
            return a;
        }

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

        #endregion

        #region INSERT
        
        public static bool InsertarAlimento(Alimento a)
        {
            int idAlimento = InsertarImagen(a.Imagen);
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
                    query.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = a.Nombre;
                    query.Parameters.Add("@familia", SqlDbType.Int).Value = a.Familia.Id;
                    query.Parameters.Add("@descripcion", SqlDbType.VarChar, 200).Value = a.Descripcion;

                    if (idAlimento > 0)
                        query.Parameters.Add("@imagen", SqlDbType.Int).Value = idAlimento;
                    rows = query.ExecuteNonQuery();
                }
                conexion.Close();
                return rows > 0;
            }
        }

        public static int InsertarImagen(Image imagen)
        {
            int idProducto = -1;
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
                        idProducto = (int)query.ExecuteScalar(); 
                    }
                    conexion.Close();
                    return idProducto;
                }
            }
            else
                return idProducto;
        }

        #endregion

    }
}

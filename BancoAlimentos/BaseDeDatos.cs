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
    class BaseDeDatos
    {


        /// <summary>
        /// Inserta el producto
        /// </summary>
        /// <param name="nombre">El nombre del producto</param>
        /// <param name="fehaEntrada">La fecha de entrada del producto</param>
        /// <param name="fechaCaducidad">La fecha de caducidad del producto</param>
        /// <param name="fechaConsumir">La fecha de comsumir preferente del producto</param>
        /// <param name="Imagen">La imagen del producto</param>
        /// <param name="ubicacion">Ubicación del producto</param>
        /// <param name="familia">Familia del producto</param>
        public static void insertarProducto(string nombre, DateTime fehaEntrada, DateTime fechaCaducidad, DateTime fechaConsumir, Image imagen, string ubicacion, string familia)
        {
            int idProducto = insertarImagen(imagen);
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert;
                if (idProducto > 0)
                    insert = "INSERT into dbo.Equipo(Nombre,Ciudad,Estadio,IdEscudo,IdEntrenador) VALUES (@nombre, @ciudad, @estadio, @escudo, @identrenador)";
                else
                    insert = "INSERT into dbo.Equipo(Nombre,Ciudad,Estadio,IdEntrenador) VALUES (@nombre, @ciudad, @estadio, @identrenador)";

                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@nombre", SqlDbType.VarChar, 25).Value = nombre;
                    query.Parameters.Add("@fechaentrada", SqlDbType.Date, 25).Value = fehaEntrada;
                    query.Parameters.Add("@fechacaducidad", SqlDbType.Date, 25).Value = fechaCaducidad;
                    query.Parameters.Add("@fechaconspref", SqlDbType.Date).Value = fechaConsumir;
                    query.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = ubicacion;
                    query.Parameters.Add("@familia", SqlDbType.VarChar).Value = familia;

                    if (idProducto > 0)
                        query.Parameters.Add("@Id", SqlDbType.Int).Value = idProducto;
                    query.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }



        /// <summary>
        /// Inserta una imagen.
        /// </summary>
        /// <param name="imagen">La imagen</param>
        /// <returns>Id de la imagen</returns>
        public static int insertarImagen(Image imagen)
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
                    string insertImagen = "INSERT INTO dbo.Imagen(imagen) OUTPUT INSERTED.IdProducto VALUES(@imagen)";
                    using (SqlCommand query = new SqlCommand(insertImagen))
                    {
                        query.Connection = conexion;
                        query.Parameters.Add("@imagen", SqlDbType.VarBinary).Value = arr;
                        query.CommandType = CommandType.Text;
                        idProducto = (int)query.ExecuteScalar();  // Obtenemos el ID del producto insertado para
                    }                                           // poder trabajar con él posteriormente
                    conexion.Close();
                    return idProducto;
                }
            }
            else
                return idProducto;
        }


        /// <summary>
        /// Borra el producto especificado de la base de datos
        /// </summary>
        /// <param name="id">Id del producto</param>
        public static void borrarProducto(int id)
        {
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();

                string delete = "DELETE from Producto where Id = @id";
                using (SqlCommand borrarProducto = new SqlCommand(delete))
                {
                    borrarProducto.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    borrarProducto.Connection = conexion;
                    borrarProducto.ExecuteNonQuery();
                }

                delete = "DELETE from Imagen where Id = @id";
                using (SqlCommand borrarImagen = new SqlCommand(delete))
                {
                    borrarImagen.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    borrarImagen.Connection = conexion;
                    borrarImagen.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }


    }
}

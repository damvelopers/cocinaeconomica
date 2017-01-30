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
    public class Producto
    {
        public int Id;
        public Alimento Alimento;
        public DateTime FechaEntrada;
        public DateTime FechaCaducidad;
        public DateTime FechaConsumirPreferente;
        public string Proveedor;
        public Almacen Almacen;
        public string Ubicacion;
        public Entidad Entidad;

        public Producto()
        {
            this.Alimento = null;
            this.FechaEntrada = DateTime.Today;
            this.FechaCaducidad = DateTime.Today;
            this.FechaConsumirPreferente = DateTime.Today;
            this.Proveedor = null;
            this.Almacen = null;
            this.Ubicacion = "";
            this.Entidad = null;
        }
        
        public Producto(int Id, Alimento Alimento, DateTime FechaEntrada, 
            DateTime FechaCaducidad, DateTime FechaConsumirPreferente, 
            string Proveedor, Almacen Almacen, string Ubicacion, Entidad entidad)
        {
            this.Id = Id;
            this.Alimento = Alimento;
            this.FechaEntrada = FechaEntrada;
            this.FechaCaducidad = FechaCaducidad;
            this.FechaConsumirPreferente = FechaConsumirPreferente;
            this.Proveedor = Proveedor;
            this.Almacen = Almacen;
            this.Ubicacion = Ubicacion;
            this.Entidad = entidad;
        }

        #region MODIFICACIONES

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
        /// Actualiza el Producto en la base de datos
        /// </summary>
        /// <returns>Si se ha actualizado correctamente o no</returns>
        public bool Update()
        {
            int rows = 0;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string update = "UPDATE dbo.Producto set Alimento = @Alimento, FechaEntrada = @FechaEntrada, FechaCaducidad = @FechaCaducidad, " +
                    "FechaConsPref = @FechaConsPref, Proveedor = @Proveedor, Ubicacion = @Ubicacion, Almacen = @Almacen, Entidad = @Entidad " +
                    "WHERE Id = @Id";

                using (SqlCommand query = new SqlCommand(update))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@Id", SqlDbType.Int).Value = this.Id;
                    query.Parameters.Add("@Alimento", SqlDbType.Int).Value = this.Alimento.Id;
                    query.Parameters.Add("@FechaEntrada", SqlDbType.Date, 200).Value = this.FechaEntrada;
                    query.Parameters.Add("@FechaCaducidad", SqlDbType.Date, 200).Value = this.FechaCaducidad;
                    query.Parameters.Add("@FechaConsPref", SqlDbType.Date, 200).Value = this.FechaConsumirPreferente;
                    query.Parameters.Add("@Proveedor", SqlDbType.VarChar, 50).Value = this.Proveedor;
                    query.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 50).Value = this.Ubicacion;
                    if (this.Almacen != null)
                        query.Parameters.Add("@Almacen", SqlDbType.Int).Value = this.Almacen.Id;
                    else
                        query.Parameters.Add("@Almacen", SqlDbType.Int).Value = DBNull.Value;
                    if (this.Entidad != null)
                    {
                        query.Parameters.Add("@Entidad", SqlDbType.VarChar, 200).Value = this.Entidad.Id;
                    }
                    else
                    {
                        query.Parameters.Add("@Entidad", SqlDbType.VarChar, 200).Value = DBNull.Value;
                    }
                    rows = query.ExecuteNonQuery();
                }
                conexion.Close();
            }
            return rows > 0;
        }

        /// <summary>
        /// Borra el Producto de la base de datos
        /// </summary>
        /// <returns>Si se ha borrado correctamente</returns>
        public bool Delete()
        {
            int rows = 0;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert = "DELETE FROM dbo.Producto WHERE Id = @id";

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
        
        #region SELECT

        /// <summary>
        /// Devuelve un ArrayList con todos los productos
        /// </summary>
        /// <returns>Todos los productos</returns>
        public static ArrayList SelectAll()
        {
            ArrayList productos = new ArrayList();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Producto";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Producto p = new Producto();
                        p.Id = reader.GetInt32(0);
                        p.Alimento = Alimento.Select(reader.GetInt32(1));
                        p.FechaEntrada = reader.GetDateTime(2);
                        p.FechaCaducidad = reader.GetDateTime(3);
                        p.FechaConsumirPreferente = reader.GetDateTime(4);
                        p.Proveedor = reader.GetString(5);
                        p.Ubicacion = reader.GetString(6);
                        p.Almacen = Almacen.Select(reader.GetInt32(7));
                        p.Entidad = Entidad.Select(reader.GetInt32(8));
                        productos.Add(p);
                    }
                    conn.Close();
                }
            }
            return productos;
        }

        /// <summary>
        /// Devuelve un Producto dado su Id
        /// </summary>
        /// <param name="Id">Id del producto</param>
        /// <returns>El producto</returns>
        public static Producto Select(int Id)
        {
            Producto p = null;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Producto where Id = @id";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        p = new Producto();
                        p.Id = reader.GetInt32(0);
                        p.Alimento = Alimento.Select(reader.GetInt32(1));
                        p.FechaEntrada = reader.GetDateTime(2);
                        p.FechaCaducidad = reader.GetDateTime(3);
                        p.FechaConsumirPreferente = reader.GetDateTime(4);
                        p.Proveedor = reader.GetString(5);
                        p.Ubicacion = reader.GetString(6);
                        try
                        {
                            p.Almacen = Almacen.Select(reader.GetInt32(7));
                        }catch(Exception ex)
                        {
                            p.Almacen = null;
                        }
                        try
                        {
                            p.Entidad = Entidad.Select(reader.GetInt32(8));
                        }
                        catch (Exception ex)
                        {
                            p.Entidad = null;
                        }
                    }
                    conn.Close();
                }
            }
            return p;
        }

        /// <summary>
        /// Devuelve un ArrayList de los productos que son de un determinado alimento
        /// </summary>
        /// <param name="a">El alimento</param>
        /// <returns>La lista de Productos</returns>
        public static ArrayList SelectWhereAlimentoIs(Alimento a)
        {
            ArrayList productos = new ArrayList();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Producto where Alimento = @alimento";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@alimento", SqlDbType.Int).Value = a.Id;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Producto p = new Producto();
                        p.Id = reader.GetInt32(0);
                        p.Alimento = Alimento.Select(reader.GetInt32(1));
                        p.FechaEntrada = reader.GetDateTime(2);
                        p.FechaCaducidad = reader.GetDateTime(3);
                        p.FechaConsumirPreferente = reader.GetDateTime(4);
                        p.Proveedor = reader.GetString(5);
                        p.Ubicacion = reader.GetString(6);
                        try
                        {
                            p.Almacen = Almacen.Select(reader.GetInt32(7));
                        }
                        catch (Exception ex)
                        {
                            p.Almacen = null;
                        }
                        try
                        {
                            p.Entidad = Entidad.Select(reader.GetInt32(8));
                        }
                        catch (Exception ex)
                        {
                            p.Entidad = null;
                        }
                        productos.Add(p);
                    }
                    conn.Close();
                }
            }
            return productos;
        }

        /// <summary>
        /// Devuelve un ArrayList de los productos que son de un determinado alimento
        /// </summary>
        /// <param name="a">El alimento</param>
        /// <returns>La lista de Productos</returns>
        public static ArrayList SelectWhereFechaCaducidadMaximaIs(DateTime fechaCaducidad)
        {
            ArrayList productos = new ArrayList();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Producto where FechaCaducidad < @fechacaducidad";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@fechacaducidad", SqlDbType.DateTime).Value = fechaCaducidad;
                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Producto p = new Producto();
                        p.Id = reader.GetInt32(0);
                        p.Alimento = Alimento.Select(reader.GetInt32(1));
                        p.FechaEntrada = reader.GetDateTime(2);
                        p.FechaCaducidad = reader.GetDateTime(3);
                        p.FechaConsumirPreferente = reader.GetDateTime(4);
                        p.Proveedor = reader.GetString(5);
                        p.Ubicacion = reader.GetString(6);
                        p.Almacen = Almacen.Select(reader.GetInt32(7));
                        try
                        {
                            p.Entidad = Entidad.Select(reader.GetInt32(8));
                        }
                        catch (Exception ex)
                        {
                            p.Entidad = null;
                        }
                        productos.Add(p);
                    }
                    conn.Close();
                }
            }
            return productos;
        }

        /// <summary>
        /// Devuelve un ArrayList con los Productos que tienen una misma fecha de caducidad y almacén
        /// </summary>
        /// <param name="fechaCaducidad">La fecha de caducidad</param>
        /// <param name="almacen">El almacén</param>
        /// <returns></returns>
        public static ArrayList SelectGroupByFechaCadAlmacen(Alimento alimento, DateTime fechaCaducidad, Almacen almacen)
        {
            ArrayList productos = new ArrayList();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conn.Open();
                string selectString = "select * from Producto where Alimento = @alimento and FechaCaducidad = @fechacaducidad and Almacen =  @almacen";
                using (SqlCommand selectCommand = new SqlCommand(selectString, conn))
                {
                    selectCommand.Parameters.Add("@alimento", SqlDbType.Int).Value = alimento.Id;
                    selectCommand.Parameters.Add("@fechacaducidad", SqlDbType.DateTime).Value = fechaCaducidad;
                    selectCommand.Parameters.Add("@almacen", SqlDbType.Int).Value = almacen.Id;
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Producto p = new Producto();
                        p.Id = reader.GetInt32(0);
                        p.Alimento = Alimento.Select(reader.GetInt32(1));
                        p.FechaEntrada = reader.GetDateTime(2);
                        p.FechaCaducidad = reader.GetDateTime(3);
                        p.FechaConsumirPreferente = reader.GetDateTime(4);
                        p.Proveedor = reader.GetString(5);
                        p.Ubicacion = reader.GetString(6);
                        p.Almacen = Almacen.Select(reader.GetInt32(7));
                        try
                        {
                            p.Entidad = Entidad.Select(reader.GetInt32(8));
                        }
                        catch (Exception ex)
                        {
                            p.Entidad = null;
                        }
                        productos.Add(p);
                    }
                    conn.Close();
                }
            }
            return productos;
        }

        #endregion

        #region INSERTS

        /// <summary>
        /// Inserta el producto en la base de datos
        /// </summary>
        /// <returns>Si se ha insertado correctamente o no</returns>
        public bool Insert()
        {
            // El alimento no puede ser nulo de ninguna forma
            if (this.Alimento == null)
                return false;

            bool inserted;
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert = "INSERT into dbo.Producto(Alimento, FechaCaducidad, FechaConsPref, Ubicacion, Proveedor, FechaEntrada, Almacen, Entidad)" +
                    " VALUES (@alimento, @fechacaducidad, @fechaconspref, @ubicacion, @proveedor, @fechaentrada, @almacen, @entidad)";

                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@alimento", SqlDbType.Int, 50).Value = this.Alimento.Id;
                    query.Parameters.Add("@fechacaducidad", SqlDbType.Date).Value = this.FechaCaducidad;
                    query.Parameters.Add("@fechaconspref", SqlDbType.Date).Value = this.FechaConsumirPreferente;
                    query.Parameters.Add("@ubicacion", SqlDbType.VarChar, 200).Value = this.Ubicacion;
                    query.Parameters.Add("@proveedor", SqlDbType.VarChar, 200).Value = this.Proveedor;
                    query.Parameters.Add("@fechaentrada", SqlDbType.Date).Value = this.FechaEntrada;
                    if (this.Entidad != null)
                    {
                        query.Parameters.Add("@entidad", SqlDbType.VarChar, 200).Value = this.Entidad.Id;
                    }else
                    {
                        query.Parameters.Add("@entidad", SqlDbType.VarChar, 200).Value = DBNull.Value;
                    }
                    if (this.Almacen != null)
                        query.Parameters.Add("@almacen", SqlDbType.Int, 50).Value = this.Almacen.Id;
                    else
                        query.Parameters.Add("@almacen", SqlDbType.Int, 50).Value = DBNull.Value;
                    inserted = query.ExecuteNonQuery() > 0;
                }
                conexion.Close();
            }
            return inserted;
        }

        /// <summary>
        /// Inserta el producto un determinado número de veces en la base de datos
        /// </summary>
        /// <returns>Si se ha insertado correctamente o no</returns>
        public bool Insert(int numero)
        {
            
            // Este método sirve para optimizar el insert de muchos productos a la vez.
            // En vez de conectarnos N veces a la BD y ejecutar una consulta cada vez, 
            // nos conectamos una vez y ejecutamos todas las consultas bajo la misma conexión
            // y con una transacción que nos asegure que si falla algún insert se reviertan los cambios

            // El alimento no puede ser nulo de ninguna forma y tiene que tener un Id válido
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
                        for (int i = 0; i < numero; i++)
                        {
                            string insert = "INSERT into dbo.Producto(Alimento, FechaCaducidad, FechaConsPref, Ubicacion, Proveedor, FechaEntrada, Almacen, Entidad)" +
                                            " VALUES (@alimento, @fechacaducidad, @fechaconspref, @ubicacion, @proveedor, @fechaentrada, @almacen, @entidad)";

                            using (SqlCommand query = new SqlCommand(insert))
                            {
                                query.Transaction = tx;
                                query.Connection = conexion;
                                query.Parameters.Add("@alimento", SqlDbType.Int, 50).Value = this.Alimento.Id;
                                query.Parameters.Add("@fechacaducidad", SqlDbType.Date).Value = this.FechaCaducidad;
                                query.Parameters.Add("@fechaconspref", SqlDbType.Date).Value = this.FechaConsumirPreferente;
                                query.Parameters.Add("@ubicacion", SqlDbType.VarChar, 200).Value = this.Ubicacion;
                                query.Parameters.Add("@proveedor", SqlDbType.VarChar, 200).Value = this.Proveedor;
                                query.Parameters.Add("@fechaentrada", SqlDbType.Date).Value = this.FechaEntrada;
                                if (this.Entidad != null)
                                {
                                    query.Parameters.Add("@entidad", SqlDbType.VarChar, 200).Value = this.Entidad.Id;
                                }
                                else
                                {
                                    query.Parameters.Add("@entidad", SqlDbType.VarChar, 200).Value = DBNull.Value;
                                }
                                if (this.Almacen != null)
                                    query.Parameters.Add("@almacen", SqlDbType.Int, 50).Value = this.Almacen.Id;
                                else
                                    query.Parameters.Add("@almacen", SqlDbType.Int, 50).Value = DBNull.Value;
                                query.ExecuteNonQuery();
                            }
                        }
                        tx.Commit();    // Si todo ha ido bien, confirma las entradas
                        inserted = true;
                    }
                    catch
                    {
                        tx.Rollback();  // Si no, revierte los cambios
                        inserted = false;
                    }
                }
                conexion.Close();
            }
            
            
            return inserted;
        }

        #endregion
    }
}
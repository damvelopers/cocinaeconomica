﻿using System;
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
    class Producto
    {
        private static int Cantidad;
        public int Id;
        public Alimento Alimento;
        public DateTime FechaEntrada;
        public DateTime FechaCaducidad;
        public DateTime FechaConsumirPreferente;
        public Proveedor Proveedor;
        public string Ubicacion;

        public Producto()
        {
            Alimento = null;
            FechaEntrada = DateTime.Today;
            FechaCaducidad = DateTime.Today;
            Ubicacion = "";
        }

        public Producto(int Id, Alimento Alimento, DateTime FechaEntrada, 
            DateTime FechaCaducidad, string Ubicacion)
        {
            this.Id = Id;
            this.Alimento = Alimento;
            this.FechaEntrada = FechaEntrada;
            this.FechaCaducidad = FechaCaducidad;
            this.Ubicacion = Ubicacion;
        }

        #region SELECT

        public static ArrayList GetProductos()
        {
            ArrayList productos = new ArrayList();
            SqlDataReader reader;

            SqlConnection conn = new SqlConnection(Constantes.CONNECTION_STRING);
            string selectString = "select * from Producto ";
            SqlCommand selectCommand = new SqlCommand(selectString, conn);
            conn.Open();
            reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                Producto p = new Producto();
                p.Id = reader.GetInt32(0);
                p.Alimento = Alimento.GetAlimento(p.Id);
                p.FechaEntrada = reader.GetDateTime(2);
                p.FechaCaducidad = reader.GetDateTime(3);
                p.Ubicacion = reader.GetString(6);
                productos.Add(p);
            }
            conn.Close();
            return productos;
        }

        #endregion

        #region INSERT

        public static void InsertarProducto(Producto p)
        {
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                conexion.Open();
                string insert = "INSERT into dbo.Producto(Alimento, FechaCaducidad, FechaConsPref, Ubicacion, Proveedor, FechaEntrada)" +
                    " VALUES (@alimento, @fechacaducidad, @fechaconspref, @ubicacion, @proveedor, @fechaentrada)";

                using (SqlCommand query = new SqlCommand(insert))
                {
                    query.Connection = conexion;
                    query.Parameters.Add("@alimento", SqlDbType.VarChar, 50).Value = p.Alimento.Id;
                    query.Parameters.Add("@fechacaducidad", SqlDbType.Date).Value = p.FechaCaducidad;
                    query.Parameters.Add("@fechaconspref", SqlDbType.Date).Value = p.FechaConsumirPreferente;
                    query.Parameters.Add("@ubicacion", SqlDbType.VarChar, 200).Value = p.Ubicacion;
                    query.Parameters.Add("@proveedor", SqlDbType.VarChar, 200).Value = p.Proveedor;
                    query.Parameters.Add("@fechaentrada", SqlDbType.Date).Value = p.FechaEntrada;

                    query.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        #endregion

    }
}
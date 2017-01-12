using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CocinaEconomica
{
    public partial class Salidas : Form
    {
        private MDISalidas fSalidas;

        public Salidas(MDISalidas fSalidas)
        {
            this.fSalidas = fSalidas;
            InitializeComponent();
        }

        private void cargarDataGridViewSalidas()
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT * from Salida";
                using (SqlCommand cmd = new SqlCommand(select, conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridSalidas.DataSource = result;
            }
        }

        private void cargarDataGridViewProductos()
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT a.Nombre, p.FechaCaducidad, al.Nombre as 'Almacén', " +
                                "p.FechaConsPref as 'Consumo preferente antes de', COUNT(p.Id) as 'Cantidad' " +
                                "FROM Producto p join Alimento a on p.Alimento = a.Id join Almacen al on p.Almacen = al.Id " +
                                "GROUP BY a.Nombre, p.FechaCaducidad, p.FechaEntrada, p.FechaConsPref, al.Nombre ";
                using (SqlCommand cmd = new SqlCommand(select, conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridProductos.DataSource = result;
            }
        }

        private void filtrarDataGridView(string nombre)
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT a.Nombre, p.FechaCaducidad, al.Nombre as 'Almacén', " +
                                "p.FechaConsPref as 'Consumo preferente antes de', COUNT(p.Id) as 'Cantidad' " +
                                "FROM Producto p join Alimento a on p.Alimento = a.Id join Almacen al on p.Almacen = al.Id " +
                                 "WHERE a.Nombre like @nombre " +
                                "GROUP BY a.Nombre, p.FechaCaducidad, p.FechaEntrada, p.FechaConsPref, al.Nombre ";
                //"WHERE a.Nombre like '%" + nombre +"%'";  // ES PELIGROSO
                using (SqlCommand cmd = new SqlCommand(select, conexion))
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = "%" + nombre + "%";
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridProductos.DataSource = result;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.fSalidas.cargarDataGridView();
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                filtrarDataGridView(txtBuscar.Text);
            else
                cargarDataGridViewProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                filtrarDataGridView(txtBuscar.Text);
            else
                cargarDataGridViewProductos();
        }

        private void Salidas_Load(object sender, EventArgs e)
        {
            cargarDataGridViewProductos();
            cargarDataGridViewSalidas();
        }

        private void btnAñadirSalida_Click(object sender, EventArgs e)
        {
            try { 
                int id = (int)dataGridProductos.CurrentRow.Cells["Id"].Value;
                Producto p = Producto.Select(id);
                Alimento a = p.Alimento;
                Salida s = new Salida();
                s.FechaSalida = dtpSalida.Value;
                s.Alimento = a;
                if (s.Insert())
                {
                    MessageBox.Show(this, "Se ha insertado una salida correctamente", "Salida insertada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show(this, "Se ha producido un error insertando la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar un producto", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}
    }
}

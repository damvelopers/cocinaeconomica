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
    public partial class ModificarUbicacionProducto : Form
    {
        public ModificarUbicacionProducto()
        {
            InitializeComponent();
        }

        private void cargarDataGridView()
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT p.Id, a.Nombre as 'Alimento', FechaEntrada as 'Fecha de entrada', " +
                    "FechaCaducidad as 'Fecha de caducidad', FechaConsPref as 'Consumo preferente antes de', " +
                    "al.Nombre as 'Almacén', Ubicacion as 'Ubicación', Proveedor " +
                    "FROM Producto p join Alimento a on a.Id = p.Alimento left outer join Almacen al on al.Id = p.Almacen ";
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
                string select = "SELECT p.Id, a.Nombre as 'Alimento', FechaEntrada as 'Fecha de entrada', " +
                    "FechaCaducidad as 'Fecha de caducidad', FechaConsPref as 'Consumo preferente antes de', " +
                    "al.Nombre as 'Almacén', Ubicacion as 'Ubicación', Proveedor " +
                    "FROM Producto p join Alimento a on a.Id = p.Alimento left outer join Almacen al on al.Id = p.Almacen " +
                    "WHERE a.Nombre like @nombre";
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

        private void ModificarUbicacionProducto_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                filtrarDataGridView(txtBuscar.Text);
            else
                cargarDataGridView();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                filtrarDataGridView(txtBuscar.Text);
            else
                cargarDataGridView();
        }
    }
}

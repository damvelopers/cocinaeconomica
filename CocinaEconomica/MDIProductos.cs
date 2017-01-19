using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocinaEconomica
{
    public partial class MDIProductos : Form
    {
        public MDIProductos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            crearProducto f = new crearProducto(this);
            f.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridProductos.CurrentRow.Cells["Id"].Value;
                Producto a = Producto.Select(id);
                ModificarProducto f = new ModificarProducto(a,this);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar un producto", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void cargarDataGridView()
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT a.Nombre, p.FechaCaducidad, al.Nombre as 'Almacén', " +
                                "p.FechaConsPref as 'Consumo preferente antes de', COUNT(p.Id) as 'Cantidad' "+
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
                //dataGridProductos.Columns[0].Visible = false;
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
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = "%" + nombre +"%";
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridProductos.DataSource = result;
                //dataGridProductos.Columns[0].Visible = false;
            }
        }

        private void MDIProductos_Load(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                filtrarDataGridView(txtBuscar.Text);
            else
                cargarDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridProductos.CurrentRow.Cells["Id"].Value;
                Producto p = Producto.Select(id);
               
                if (p.Delete())
                {
                    MessageBox.Show(this, "Se eliminado el producto correctamente.", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGridView();
                    Salida s = new Salida();
                    s.Alimento = p.Alimento;
                    s.Insert();
                }
                else
                {
                    MessageBox.Show(this, "No se ha eliminado el producto.", "Producto no eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar un producto", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

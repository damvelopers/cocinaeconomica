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
    public partial class MDISalidas : Form
    {
        public MDISalidas()
        {
            InitializeComponent();
            cargarDataGridView();
        }

        public void cargarDataGridView()
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT a.Nombre, FechaSalida, count(*) as Cantidad " +
                                "FROM Salida s join Alimento a on s.Alimento = a.Id " +
                                "GROUP BY a.Nombre, FechaSalida";
                using (SqlCommand cmd = new SqlCommand(select, conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridSalidas.DataSource = result;
                //dataGridSalidas.Columns[0].Visible = false;
            }
        }

        private void filtrarDataGridView(string nombre)
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT s.Id, a.Nombre as 'Alimento', s.FechaSalida as 'Fecha de salida' " +
                    "FROM Salida s join Alimento a on a.Id = s.Alimento " +
                    "WHERE a.Nombre like @nombre";
                using (SqlCommand cmd = new SqlCommand(select, conexion))
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = "%" + nombre + "%";
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridSalidas.DataSource = result;
                dataGridSalidas.Columns[0].Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Salidas f = new Salidas(this);
            f.ShowDialog();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridSalidas.CurrentRow.Cells["Id"].Value;
                Salida s = Salida.Select(id);
                if (s.Delete())
                {
                    MessageBox.Show(this, "Se eliminado la salida correctamente.", "Salida eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Se ha modificado la salida correctamente.", "Salida modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar una salida", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

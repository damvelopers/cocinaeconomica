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
    public partial class MDIEntidad : Form
    {
        public MDIEntidad()
        {
            InitializeComponent();
            cargarDataGridView();
        }

        public void cargarDataGridView()
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT * from Entidad";
                using (SqlCommand cmd = new SqlCommand(select, conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridEntidades.DataSource = result;
                dataGridEntidades.Columns[0].Visible = false;
            }
        }

        private void filtrarDataGridView(string nombre)
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT * FROM Entidad" +
                    " WHERE Nombre like @nombre";
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
                dataGridEntidades.DataSource = result;
                dataGridEntidades.Columns[0].Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearEntidad f = new CrearEntidad(this);
            f.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridEntidades.CurrentRow.Cells["Id"].Value;
                Entidad en = Entidad.Select(id);
                ModificarEntidad f = new ModificarEntidad(en, this);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar un cliente/proveedor", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridEntidades.CurrentRow.Cells["Id"].Value;
                Entidad en = Entidad.Select(id);
                if (MessageBox.Show(this, String.Format("Se va ha eliminar el cliente/proveedor '{0}' ¿Está seguro?", en.Nombre), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
                {
                    return;
                }
                if (en.Delete())
                {
                    MessageBox.Show(this, "Se eliminado el cliente/proveedor correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "No se ha eliminado el cliente/proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar un almacén", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}

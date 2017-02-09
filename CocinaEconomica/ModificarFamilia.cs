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
    public partial class ModificarFamilia : Form
    {
        private Familia familia;
        private MDIFamilias fFamilias;

        public ModificarFamilia(Familia familia,MDIFamilias fFamilias)
        {
            this.familia = familia;
            this.fFamilias = fFamilias;
            InitializeComponent();
            txtNombre.Text = this.familia.Nombre;
        }

        private void cargarDataGridView()
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT * from Familia";
                using (SqlCommand cmd = new SqlCommand(select, conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridFamilia.DataSource = result;
                dataGridFamilia.Columns[0].Visible = false;
            }
        }

        private void filtrarDataGridView(string nombre)
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT * FROM Familia" +
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
                dataGridFamilia.DataSource = result;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.fFamilias.cargarDataGridView();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(this, "El campo Nombre es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
            this.familia.Nombre = txtNombre.Text;
            if (this.familia.Nombre != "")
            {
                bool ok = this.familia.Update();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error modificando la familia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Se ha modificado una familia correctamente.", "Familia modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGridView();
                    this.fFamilias.cargarDataGridView();
                }
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                filtrarDataGridView(txtBuscar.Text);
            else
                cargarDataGridView();
        }

        private void btnBuscarFamilia_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                filtrarDataGridView(txtBuscar.Text);
            else
                cargarDataGridView();
        }

        private void ModificarFamilia_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
        }

        private void dataGridFamilia_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dataGridFamilia.CurrentRow.Cells["Id"].Value;
                this.familia = Familia.Select(id);
                txtNombre.Text = this.familia.Nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar una familia", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

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
    public partial class ModificarAlimento : Form
    {
        private Alimento alimento;
        private MDIAlimentos fAlimentos;
        public ModificarAlimento(Alimento alimento,MDIAlimentos fAlimentos)
        {
            this.alimento = alimento;
            this.fAlimentos = fAlimentos;
            InitializeComponent();
            txtNombre.Text = this.alimento.Nombre;
            txtFamilia.Text = this.alimento.Familia.Nombre;
            txtDescripcion.Text = this.alimento.Descripcion;
        }

        private void filtrarDataGridView(string nombre)
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT * FROM Alimento a" +
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
                dataGridAlimentos.DataSource = result;
            }
        }

        private void cargarDataGridView()
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT * from Alimento";
                using (SqlCommand cmd = new SqlCommand(select, conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridAlimentos.DataSource = result;
                dataGridAlimentos.Columns[0].Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.fAlimentos.cargarDataGridView();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(this, "El campo NOMBRE es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (txtFamilia.Text == "")
            {
                MessageBox.Show(this, "El campo FAMILIA es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
            this.alimento.Nombre = txtNombre.Text;
            this.alimento.Descripcion = txtDescripcion.Text;
            this.alimento.Familia = Familia.SelectWhereNombreIs(txtFamilia.Text);
            if (this.alimento.Nombre != "")
            {
                bool ok = this.alimento.Update();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error modificando el alimento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cargarDataGridView();
                    MessageBox.Show(this, "Se ha modificado un alimento correctamente.", "Alimento modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

        private void ModificarAlimento_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
        }

        private void dataGridAlimentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dataGridAlimentos.CurrentRow.Cells["Id"].Value;
                this.alimento = Alimento.Select(id);
                txtNombre.Text = this.alimento.Nombre;
                txtFamilia.Text = this.alimento.Familia.Nombre;
                txtDescripcion.Text = this.alimento.Descripcion;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar un alimento", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

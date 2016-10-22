using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoAlimentos
{
    public partial class FormularioPrincipal : Form
    {
        /// "Data Source='localhost';Initial Catalog='BancoAlimentos';User ID='sa';Password='elite'";
        /// <summary>
        /// En este formulario se muestran todos los nombres de productos distintos para que
        /// el usuario clique y acceda a otro formulario en el que salen todos los productos 
        /// con el mismo nombre
        /// </summary>
        public FormularioPrincipal()
        {
            InitializeComponent();
            if (!Conexion.testConnection(Properties.Settings.Default.Server,
                Properties.Settings.Default.User, Properties.Settings.Default.Password))
            {
                MostrarDialogoConexion();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            CargarAlimentos();
        }

        private void CargarAlimentos()
        {
            string select = "SELECT * FROM Alimento";
            SqlConnection c = new SqlConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select,
                Properties.Settings.Default.ConnectionString);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dtGrVwAlimentos.ReadOnly = true;
            dtGrVwAlimentos.DataSource = ds.Tables[0];
            c.Close();
        }

        private void CargarAlimentos(string busqueda)
        {
            string select = "SELECT * FROM Alimento WHERE Nombre like @busqueda";
            using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            using (var command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda + "%";
                using (var adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    var table = new DataTable();
                    adapter.Fill(table);
                    dtGrVwAlimentos.DataSource = table;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                CargarAlimentos();
            }
            else
            {
                CargarAlimentos(textBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioInsertar f = new FormularioInsertar();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarAlimentos();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarDialogoConexion();
        }

        private void MostrarDialogoConexion()
        {
            FormConexion f = new FormConexion();
            f.ShowDialog();
        }
    }
}
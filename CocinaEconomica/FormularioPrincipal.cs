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

namespace CocinaEconomica
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



        private void button1_Click(object sender, EventArgs e)
        {
            CrearAlimento f = new CrearAlimento();
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

        private void crearProducto(object sender, EventArgs e)
        {
            //crearProducto crearProducto = new crearProducto();
            //crearProducto.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CrearFamilia crearAlimento = new CrearFamilia();
            crearAlimento.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //crearProducto crearProducto = new crearProducto();
            //crearProducto.ShowDialog();
        }

        private void alimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearAlimento crearAlimento = new CrearAlimento();
            crearAlimento.ShowDialog();
        }

        private void familiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFamilia crearFamilia= new CrearFamilia();
            crearFamilia.ShowDialog();
        }

        private void alimentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ModificarAlimento modificarAlimento = new ModificarAlimento();
            //modificarAlimento.ShowDialog();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ModificarProducto modificarProducto = new ModificarProducto();
            //modificarProducto.ShowDialog();
        }

        private void familiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ModificarFamilia modificarFamilia = new ModificarFamilia();
            //modificarFamilia.ShowDialog();
        }

        private void ubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUbicacionProducto modificarUbicacionProducto = new ModificarUbicacionProducto();
            modificarUbicacionProducto.ShowDialog();
        }

        private void crearAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CrearAlmacen crearAlmacen = new CrearAlmacen();
            //crearAlmacen.ShowDialog();
        }

        private void modificarAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ModificarAlmacen modificarAlmacen = new ModificarAlmacen();
            //modificarAlmacen.ShowDialog();
        }

        private void eliminarAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarAlmacen eliminarAlmacen = new EliminarAlmacen();
            eliminarAlmacen.ShowDialog();
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConexion conexion = new FormConexion();
            conexion.ShowDialog();
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Salidas salidas = new Salidas();
            //salidas.ShowDialog();
        }

        private void listadoDeProductos2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductosNombre productosNombre = new FormProductosNombre();
            productosNombre.ShowDialog();
        }

        private void listadoDeProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listado listado = new Listado();
            listado.ShowDialog();
        }

        private void insertarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
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
using System.Collections;

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
            ArrayList entidades = Entidad.SelectAll();
            for (int i = 0; i < entidades.Count; i++)
            {
                Entidad en = (Entidad)entidades[i];
                cbxEntidades.Items.Add(en.Nombre + "#" + en.DNI);
            }
        }

        private void btnAñadirSalida_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numericCantidad.Value;
            if (cantidad == 0)
            {
                MessageBox.Show(this, "Se debe introducir una cantidad mayor de cero", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if(MessageBox.Show(this, "Se va" + (cantidad == 1 ? "" : "n") + " a registrar " + cantidad + " salida"+ (cantidad == 1 ? "" : "s") +". ¿Está seguro?", "Añadir salidas", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                return;
            }
            try
            {
                string alimento = (string) dataGridProductos.CurrentRow.Cells[0].Value;
                DateTime fechaCad = (DateTime) dataGridProductos.CurrentRow.Cells[1].Value;
                string almacen = (string) dataGridProductos.CurrentRow.Cells[2].Value;
                Alimento ali = Alimento.SelectWhereNombreIs(alimento);
                Almacen a = Almacen.Select(almacen);
                ArrayList productos = Producto.SelectGroupByFechaCadAlmacen(ali, fechaCad, a);

                Salida s = new Salida();
                s.FechaSalida = dtpSalida.Value;
                s.Alimento = ali;
                s.entidad = Entidad.SelectByDNI((cbxEntidades.SelectedItem.ToString()).Split('#')[1]);


                for (int i = 0; i < cantidad; i++)
                {
                    ((Producto)productos[i]).Delete();
                }

                if (s.Insert(cantidad))
                {
                    MessageBox.Show(this, "Se ha insertado una salida correctamente", "Salida insertada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Se ha producido un error insertando la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show(this, "Se debe seleccionar un producto", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            cargarDataGridViewProductos();
            cargarDataGridViewSalidas();
        }

        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int max = (int)dataGridProductos.CurrentRow.Cells["Cantidad"].Value;
            numericCantidad.Maximum = max;
            lblNombreProducto.Text = (string)dataGridProductos.CurrentRow.Cells[0].Value;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

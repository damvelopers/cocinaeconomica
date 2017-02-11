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
using System.Collections;

namespace CocinaEconomica
{
    public partial class MDIProductos : Form
    {
        Form frmAbout;
        TextBox cantidad;
        DataGridViewCellCollection celdas;

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
                ModificarProducto f = new ModificarProducto(a, this);
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
                string select = "SELECT p.Id, a.Nombre, p.FechaCaducidad, al.Nombre as 'Almacén', " +
                                "p.FechaConsPref as 'Consumo preferente antes de', Cantidad " +
                                "FROM Producto p join Alimento a on p.Alimento = a.Id join Almacen al on p.Almacen = al.Id ";
                using (SqlCommand cmd = new SqlCommand(select, conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridProductos.DataSource = result;
                dataGridProductos.Columns[0].Visible = false;
            }
        }

        private void filtrarDataGridView(string nombre)
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT p.Id, a.Nombre, p.FechaCaducidad, al.Nombre as 'Almacén', " +
                                "p.FechaConsPref as 'Consumo preferente antes de', Cantidad " +
                                "FROM Producto p join Alimento a on p.Alimento = a.Id join Almacen al on p.Almacen = al.Id " +
                                 "WHERE a.Nombre like @nombre ";

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
                dataGridProductos.Columns[0].Visible = false;
            }
        }

        private void MDIProductos_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
            rbNoCaducados.Text = "Productos proximos a caducar en " + Properties.Settings.Default.DiasCaducidad + " días";
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
            //Obtengo las celdas de la columna seleccionada para acceder a ellas más adelante, 
            //ya que se pierde el foco el método eliminar.
            celdas =  dataGridProductos.CurrentRow.Cells;
            popUpEliminar();
        }


        private void popUpEliminar()
        {
            frmAbout = new Form();
            frmAbout.FormBorderStyle = FormBorderStyle.None;
            frmAbout.BackColor = Color.LightGray;
            frmAbout.Width = 300;
            frmAbout.Height = 120;
            frmAbout.StartPosition = FormStartPosition.CenterParent;
            Label texto = new Label();
            texto.Text = "Cantidad a eliminar:";
            texto.Left = 10;
            texto.Top = 20;
            cantidad = new TextBox();
            cantidad.Left = 150;
            cantidad.Top = 20;
            cantidad.Text = "0";
            Button aceptar = new Button();
            aceptar.Text = "Aceptar";
            aceptar.Left = 100;
            aceptar.Top = 80;
            aceptar.BackColor = Color.White;
            aceptar.Click += new EventHandler(eliminar);
            Button cerrar = new Button();
            cerrar.Text = "Cerrar";
            cerrar.Left = 200;
            cerrar.Top = 80;
            cerrar.BackColor = Color.White;
            cerrar.Click += new EventHandler(cerrarDialog);

            frmAbout.Controls.Add(cantidad);
            frmAbout.Controls.Add(texto);
            frmAbout.Controls.Add(aceptar);
            frmAbout.Controls.Add(cerrar);
            frmAbout.ShowDialog();
        }

        private void cerrarDialog(object sender, EventArgs e)
        {
            frmAbout.Close();
        }

        private void eliminar(object sender, EventArgs e)
        {
            try
            {
                decimal cantidadProducto = (decimal)celdas[5].Value;
                decimal cant = 0;
                try
                {
                    cant = decimal.Parse(cantidad.Text);
                }catch(Exception ex)
                {
                    //MessageBox.Show(this, "Indique correctamente la cantidad a eliminar.", "Cantidad invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bool todoOk = true;
                if (cant <= cantidadProducto && cant > 0)
                {
                    Producto producto = Producto.Select((int)celdas[0].Value);
                    producto.Cantidad -= (float)cant;
                        if (!((Producto)producto).Update())
                        {
                            todoOk = false;
                        }
                    
                    if (todoOk)
                    {
                        MessageBox.Show(this, "Se modificado la cantidad del producto correctamente.", "Producto rebajado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(producto.Cantidad == 0)
                        {
                            todoOk = producto.Delete();
                            if (todoOk)
                            {
                                MessageBox.Show(this, "Se ha eliminado el producto correctamente al llegar su cantidad a 0.", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cargarDataGridView();
                                frmAbout.Close();
                            }
                            else
                            {
                                MessageBox.Show(this, "No se ha eliminado el producto.", "Producto no eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        cargarDataGridView();
                        frmAbout.Close();

                    }
                    else
                    {
                        MessageBox.Show(this, "No se ha eliminado la cantidad del producto.", "Producto no rebajado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }else
                {
                    MessageBox.Show(this, "Indique correctamente la cantidad a eliminar.", "Cantidad invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar un producto", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rBCaducados_CheckedChanged(object sender, EventArgs e)
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT p.Id, a.Nombre, p.FechaCaducidad, al.Nombre as 'Almacén', " +
                                "p.FechaConsPref as 'Consumo preferente antes de', Cantidad " +
                                "FROM Producto p join Alimento a on p.Alimento = a.Id join Almacen al on p.Almacen = al.Id " +
                                 "WHERE p.FechaCaducidad < @fecha ";

                //"WHERE a.Nombre like '%" + nombre +"%'";  // ES PELIGROSO
                using (SqlCommand cmd = new SqlCommand(select, conexion))
                {
                    DateTime fecha = DateTime.Now;
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridProductos.DataSource = result;
                dataGridProductos.Columns[0].Visible = false;
            }
        }

        private void rbNoCaducados_CheckedChanged(object sender, EventArgs e)
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT p.Id, a.Nombre, p.FechaCaducidad, al.Nombre as 'Almacén', " +
                                "p.FechaConsPref as 'Consumo preferente antes de', Cantidad " +
                                "FROM Producto p join Alimento a on p.Alimento = a.Id join Almacen al on p.Almacen = al.Id " +
                                 "WHERE p.FechaCaducidad >= @today and p.FechaCaducidad < @fecha ";

                //"WHERE a.Nombre like '%" + nombre +"%'";  // ES PELIGROSO
                using (SqlCommand cmd = new SqlCommand(select, conexion))
                {
                    DateTime fecha = DateTime.Now;
                    DateTime today = DateTime.Now;
                    fecha = fecha.AddDays(Properties.Settings.Default.DiasCaducidad);
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                    cmd.Parameters.Add("@today", SqlDbType.Date).Value = today;
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        result.Load(reader);
                    }
                }
                dataGridProductos.DataSource = result;
                dataGridProductos.Columns[0].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rbNoCaducados.Checked = false;
            rBCaducados.Checked = false;
            cargarDataGridView();
        }
    }
}

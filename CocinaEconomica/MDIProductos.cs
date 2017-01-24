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
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = "%" + nombre + "%";
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
                //int id = (int)celdas["Id"].Value;
                //Producto p = Producto.Select(id);
                int cantidadProducto = (Int32)celdas[4].Value;
                int cant = 0;
                try
                {
                    cant = Int32.Parse(cantidad.Text);
                }catch(Exception ex)
                {
                    //MessageBox.Show(this, "Indique correctamente la cantidad a eliminar.", "Cantidad invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bool todoOk = true;
                if (cant <= cantidadProducto && cant > 0)
                {
                    string alimento = (string)celdas[0].Value;
                    DateTime fechaCad = (DateTime)celdas[1].Value;
                    string almacen = (string)celdas[2].Value;
                    Alimento ali = Alimento.SelectWhereNombreIs(alimento);
                    Almacen a = Almacen.Select(almacen);
                    ArrayList productos = Producto.SelectGroupByFechaCadAlmacen(ali, fechaCad, a);
                    for (int i = 0; i < cant; i++)
                    {
                        if (!((Producto)productos[i]).Delete())
                        {
                            todoOk = false;
                        }
                    }
                    if (todoOk)
                    {
                        MessageBox.Show(this, "Se eliminado el producto correctamente.", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDataGridView();
                        /*Salida s = new Salida();
                        s.Alimento = p.Alimento;
                        s.Insert();*/
                        frmAbout.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "No se ha eliminado el producto.", "Producto no eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}

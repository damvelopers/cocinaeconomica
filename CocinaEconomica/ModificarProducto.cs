﻿using System;
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
    public partial class ModificarProducto : Form
    {
        private Producto producto;
        private MDIProductos fProductos;

        public ModificarProducto(Producto producto,MDIProductos fProductos)
        {
            this.producto = producto;
            this.fProductos = fProductos;
            InitializeComponent();
            cmb_alimentos.Text = this.producto.Alimento.Nombre;
            cbOrigen.SelectedItem = this.producto.Proveedor;
            tbCantidad.Text = Producto.SelectWhereAlimentoIs(this.producto.Alimento).Count + "";
            fechCaducidad.Value = Convert.ToDateTime(this.producto.FechaCaducidad);
            fechConsPref.Value = Convert.ToDateTime(this.producto.FechaConsumirPreferente);
            fechEntrada.Value = Convert.ToDateTime(this.producto.FechaEntrada);
        }

        private void cargarDataGridView()
        {
            DataTable result = new DataTable();
            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string select = "SELECT p.Id, a.Nombre as 'Alimento', FechaEntrada as 'Fecha de entrada', " +
                    "FechaCaducidad as 'Fecha de caducidad', Cantidad, FechaConsPref as 'Consumo preferente antes de', " +
                    "al.Nombre as 'Almacén', Ubicacion as 'Ubicación', Proveedor as 'Origen' " +
                    "FROM Producto p join Alimento a on a.Id = p.Alimento left outer join Almacen al on al.Id = p.Almacen ";
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
                string select = "SELECT p.Id, a.Nombre as 'Alimento', FechaEntrada as 'Fecha de entrada', " +
                    "FechaCaducidad as 'Fecha de caducidad', Cantidad, FechaConsPref as 'Consumo preferente antes de', " +
                    "al.Nombre as 'Almacén', Ubicacion as 'Ubicación', Proveedor as 'Origen' " +
                    "FROM Producto p join Alimento a on a.Id = p.Alimento left outer join Almacen al on al.Id = p.Almacen " +
                    "WHERE a.Nombre like @nombre";
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

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            cargarDataGridView();

            ArrayList alimentos = Alimento.SelectAll();
            cmb_alimentos.Items.Clear();
            for (int i = 0; i < alimentos.Count; i++)
            {
                Alimento a = (Alimento)alimentos[i];
                cmb_alimentos.Items.Add(a.Nombre);
            }

            ArrayList almacenes = Almacen.SelectAll();
            for (int i = 0; i < almacenes.Count; i++)
            {
                Almacen a = (Almacen)almacenes[i];
                cbxAlmacen.Items.Add(a.Nombre);
                try
                {
                    if (a.Nombre == producto.Almacen.Nombre)
                    {
                        cbxAlmacen.SelectedItem = a.Nombre;
                    }
                }catch(Exception ex) { }
            }

            ArrayList entidades = Entidad.SelectAll();
            for (int i = 0; i < entidades.Count; i++)
            {
                Entidad en = (Entidad)entidades[i];
                if(en.Direccion == "")
                {
                    cbxEntidades.Items.Add(en.Nombre);
                }
                else
                {
                    cbxEntidades.Items.Add(en.Nombre + "-" + en.Direccion);
                }
                
                try
                {
                    if (en.Nombre == producto.Entidad.Nombre)
                    {
                        cbxEntidades.SelectedItem = en.Nombre + "-" + en.Direccion;
                    }
                }
                catch (Exception ex) { }
            }
            cbOrigen.SelectedValue = producto.Proveedor;
            tbCantidad.Value = (decimal)producto.Cantidad;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.fProductos.cargarDataGridView();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmb_alimentos.Text == "")
            {
                MessageBox.Show(this, "El campo Alimento es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (cbxAlmacen.Text == "")
            {
                MessageBox.Show(this, "El campo Almacen es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (cbxEntidades.Text == "")
            {
                MessageBox.Show(this, "El campo Proveedor es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (cbOrigen.Text == "")
            {
                MessageBox.Show(this, "El campo Origen es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            this.producto.Alimento = Alimento.SelectWhereNombreIs(cmb_alimentos.Text);
            this.producto.FechaEntrada = fechEntrada.Value;
            this.producto.FechaCaducidad = fechCaducidad.Value;
            this.producto.FechaConsumirPreferente = fechConsPref.Value;
            this.producto.Proveedor = cbOrigen.SelectedItem.ToString();
            this.producto.Almacen = Almacen.Select(cbxAlmacen.SelectedItem.ToString());
            try
            {
                this.producto.Entidad = Entidad.SelectByName((cbxEntidades.SelectedItem.ToString()).Split('-')[0], (cbxEntidades.SelectedItem.ToString()).Split('-')[1]);
            }
            catch(Exception ex)
            {
                this.producto.Entidad = Entidad.SelectByName((cbxEntidades.SelectedItem.ToString()), "");
            }
            
            this.producto.Cantidad = (float)tbCantidad.Value;

            if (producto.Alimento != null)
            {
                bool ok = producto.Update();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error modificando el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Se ha modificado un producto correctamente.", "Producto modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.fProductos.cargarDataGridView();
                    cargarDataGridView();
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

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                filtrarDataGridView(txtBuscar.Text);
            else
                cargarDataGridView();
        }

        private void dataGridProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dataGridProductos.CurrentRow.Cells["Id"].Value;
                this.producto = Producto.Select(id);
                cmb_alimentos.Text = this.producto.Alimento.Nombre;
                cbOrigen.SelectedItem = this.producto.Proveedor;
                tbCantidad.Text = Producto.SelectWhereAlimentoIs(this.producto.Alimento).Count + "";
                fechCaducidad.Value = Convert.ToDateTime(this.producto.FechaCaducidad);
                fechConsPref.Value = Convert.ToDateTime(this.producto.FechaConsumirPreferente);
                fechEntrada.Value = Convert.ToDateTime(this.producto.FechaEntrada);
                cbxAlmacen.SelectedItem = this.producto.Almacen;
                cbxEntidades.SelectedItem = this.producto.Entidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar un alimento", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

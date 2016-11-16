﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace CocinaEconomica
{
    public partial class MDIAlimentos : Form
    {
        public MDIAlimentos()
        {
            InitializeComponent();
            cargarDataGridView();
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearAlimento f = new CrearAlimento();
            f.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridAlimentos.CurrentRow.Cells["Id"].Value;
                Alimento a = Alimento.Select(id);
                ModificarAlimento f = new ModificarAlimento(a);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar un alimento", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MDIAlimentos_Load(object sender, EventArgs e)
        {
            
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridAlimentos.CurrentRow.Cells["Id"].Value;
                Alimento a = Alimento.Select(id);
                if (a.Delete())
                {
                    MessageBox.Show(this, "Se eliminado el alimento correctamente.", "Alimento eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Se ha modificado el alimento correctamente.", "Alimento modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(this, "Se debe seleccionar un alimento", "Seleccione uno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

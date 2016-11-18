using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocinaEconomica
{
    public partial class ModificarAlmacen : Form
    {
        private Almacen almacen;
        private MDIAlmacenes fAlmacenes;
        public ModificarAlmacen(Almacen almacen,MDIAlmacenes fAlmacenes)
        {
            this.almacen = almacen;
            this.fAlmacenes = fAlmacenes;
            InitializeComponent();
            txtNombre.Text = this.almacen.Nombre;
            txtUbicacion.Text = "";
            txtDescripcion.Text = this.almacen.Descripcion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.fAlmacenes.cargarDataGridView();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(this, "El campo NOMBRE es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            this.almacen.Nombre = txtNombre.Text;
            this.almacen.Descripcion = txtDescripcion.Text;
            if (this.almacen.Nombre != "")
            {
                bool ok = this.almacen.Update();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error modificando el almacén", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Se ha modificado un almacén correctamente.", "Almacén modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.fAlmacenes.cargarDataGridView();
                }
            }
        }

        private void ModificarAlmacen_Load(object sender, EventArgs e)
        {
            txtNombre.Text = this.almacen.Nombre;
            txtDescripcion.Text = this.almacen.Descripcion;
        }
    }
}

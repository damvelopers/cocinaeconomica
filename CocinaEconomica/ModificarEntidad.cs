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
    public partial class ModificarEntidad : Form
    {
        private Entidad entidad;
        private MDIEntidad fEntidad;
        public ModificarEntidad(Entidad entidad, MDIEntidad fEntidad)
        {
            InitializeComponent();
            this.entidad = entidad;
            this.fEntidad = fEntidad;
            txtNombre.Text = entidad.Nombre;
            txtDireccion.Text = entidad.Direccion;
            txtEmail.Text = entidad.Email;
            txtTelefono.Text = entidad.Telefono;
            txtDNI.Text = entidad.DNI;
            txtCIF.Text = entidad.CIF;
            txtDescripcion.Text = entidad.Descripcion;
            txtWeb.Text = entidad.Web;

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(this, "El campo NOMBRE es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            this.entidad.Nombre = txtNombre.Text;
            this.entidad.Descripcion = txtDescripcion.Text;
            this.entidad.Direccion = txtDireccion.Text;
            this.entidad.Email = txtEmail.Text;
            this.entidad.Telefono = txtTelefono.Text;
            this.entidad.DNI = txtDNI.Text;
            this.entidad.CIF = txtCIF.Text;
            this.entidad.Web = txtWeb.Text;
  
            if (this.entidad.Nombre != "")
            {
                bool ok = this.entidad.Update();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error modificando el cliente/proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Se ha modificado un cliente/proveedor correctamente.", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.fEntidad.cargarDataGridView();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.fEntidad.cargarDataGridView();
            this.Close();
        }
    }
}

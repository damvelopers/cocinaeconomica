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
    public partial class CrearEntidad : Form
    {
        private MDIEntidad fEntidad;
        public CrearEntidad(MDIEntidad fEntidad)
        {
            InitializeComponent();
            this.fEntidad = fEntidad;
        }

        public CrearEntidad()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(this, "El campo NOMBRE es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Entidad en = new Entidad();
            en.Nombre = txtNombre.Text;
            en.Descripcion = txtDescripcion.Text;
            en.Direccion = txtDireccion.Text;
            en.Web = txtWeb.Text;
            en.Email = txtEmail.Text;
            if(txtDNI.Text != "")
            {
                en.DNI = txtDNI.Text;
            }
            if (txtCIF.Text != "")
            {
                en.CIF = txtCIF.Text;
            }
            en.Telefono = txtTelefono.Text;
            if (en.Nombre != "")
            {
                bool ok = en.Insert();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error insertando el cliente/proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Se añadido un nuevo cliente/proveedor correctamente.", "Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = "";
                    txtDireccion.Text = "";
                    txtDescripcion.Text = "";
                    txtDNI.Text = "";
                    txtEmail.Text = "";
                    txtCIF.Text = "";
                    txtTelefono.Text = "";
                    txtWeb.Text = "";
                    try
                    {
                        this.fEntidad.cargarDataGridView();
                    }catch(Exception ex) { }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.fEntidad.cargarDataGridView();
            }catch(Exception ex) { }
            this.Close();
        }
    }
}

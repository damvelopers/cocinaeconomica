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
    public partial class FormConexion : Form
    {
        public FormConexion()
        {
            InitializeComponent();
        }

        private void FormConexion_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void loadSettings()
        {
            if (Properties.Settings.Default.Server != "")
            {
                txtServer.Text = Properties.Settings.Default.Server;
            }
            if (Properties.Settings.Default.User != "")
            {
                txtUser.Text = Properties.Settings.Default.User;
            }
            if (Properties.Settings.Default.Password != "")
            {
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtServer.Text != "" && 
                txtUser.Text != "" && 
                txtPassword.Text != "" &&
                Conexion.testConnection(txtServer.Text, txtUser.Text, txtPassword.Text))
            {
                Conexion.setConnectionConfig(txtServer.Text, txtUser.Text, txtPassword.Text);
                this.Close();
            }
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            if (txtServer.Text != "" &&
                txtUser.Text != "" &&
                txtPassword.Text != "")
            {
                if (Conexion.testConnection(txtServer.Text, txtUser.Text, txtPassword.Text))
                {
                    btnGuardar.Enabled = true;
                    MessageBox.Show(this, "Se ha establecido la conexión de manera satisfactoria", "Conexión correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnGuardar.Enabled = false;
                    MessageBox.Show(this, "Se ha producido un error de conexión con la base de datos. ", "Fallo de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
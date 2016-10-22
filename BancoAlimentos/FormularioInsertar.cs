using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoAlimentos
{
    public partial class FormularioInsertar : Form
    {
        public FormularioInsertar()
        {
            string Server, User, Password;
            Server = "127.0.0.1";
            User = "bancoalimentos";
            Password = "elite";
            Properties.Settings.Default.ConnectionString = "Data Source='" + Server + "';Initial Catalog='BancoAlimentos';User ID='" + User + "';Password='" + Password + "'";
            InitializeComponent();
            SetNombresFamilias();
        }

        private void FormularioInsertar_Load(object sender, EventArgs e)
        {
     

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void SetNombresFamilias()
        {
            ArrayList familias = Familia.GetFamilias();
            foreach (Familia familia in familias)
            {
                cbxFamilia.Items.Add(familia.Nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alimento a = new Alimento();
            a.Nombre = txtNombre.Text;
            a.Imagen = pictureBox1.Image;
            //a.Familia = Familia.GetFamilia(cbxFamilia.Value);
            if (a.Nombre != "")
            {
                bool ok = Alimento.InsertarAlimento(a);
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Error", "Se ha producido un error insertando el alimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    MessageBox.Show(this, "Alimento añadido", "Se añadido un nuevo alimento correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                filename = ofd.FileName;
                pictureBox1.Image = Image.FromFile(filename);
            }
        }
    }
}

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

namespace CocinaEconomica
{
    public partial class CrearAlimento : Form
    {
        public CrearAlimento()
        {
            InitializeComponent();
            SetNombresFamilias();
        }

        private void FormularioInsertar_Load(object sender, EventArgs e)
        {
            
        }

        private void SetNombresFamilias()
        {
            ArrayList familias = Familia.GetFamilias();
            foreach (Familia familia in familias)
            {
                txt_familia.Text = familia.Nombre;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(this, "El campo NOMBRE es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
                
            if (txt_familia.Text == "")
            {
                MessageBox.Show(this, "El campo FAMILIA es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Alimento a = new Alimento();
            a.Nombre = txtNombre.Text;
            a.Imagen = imagenAlimento.Image;
            a.Familia = Familia.GetFamilia(txt_familia.Text);
            if (a.Nombre != "")
            {
                bool ok = a.Insert();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error insertando el alimento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    MessageBox.Show(this, "Se añadido un nuevo alimento correctamente.", "Alimento añadido",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void imagenAlimento_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                filename = ofd.FileName;
                imagenAlimento.Image = Image.FromFile(filename);
            }
        }

        private void btnAddFamilia_Click(object sender, EventArgs e)
        {
            /// TODO
        }
    }
}

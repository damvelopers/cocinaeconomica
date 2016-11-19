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
        private MDIAlimentos fAlimentos;
        public CrearAlimento(MDIAlimentos fAlimentos)
        {
            this.fAlimentos = fAlimentos;
            InitializeComponent();
            SetNombresFamilias();
        }

        public CrearAlimento()
        {
            InitializeComponent();
        }

        private void FormularioInsertar_Load(object sender, EventArgs e)
        {       
            ArrayList familias = Familia.SelectAll(); 
            for (int i = 0; i < familias.Count; i++)
            {
 
                Familia f = (Familia)familias[i];
                cmb_familias.Items.Add(f.Nombre);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(this, "El campo NOMBRE es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
                
            if (cmb_familias.Text == "")
            {
                MessageBox.Show(this, "El campo FAMILIA es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (!cmb_familias.Items.Contains(cmb_familias.Text))
            {
                MessageBox.Show(this, "La familia no existe", "Eliga una Familia ya creada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Alimento a = new Alimento();
            a.Nombre = txtNombre.Text;
            a.Imagen = imagenAlimento.Image;
            a.Descripcion = txtDescripcion.Text;
            a.Familia = Familia.SelectWhereNombreIs(cmb_familias.Text);
            if (a.Nombre != "")
            {
                bool ok = a.Insert();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error insertando el alimento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    MessageBox.Show(this, "Se añadido un nuevo alimento correctamente.", "Alimento añadido",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                    try
                    {
                        this.fAlimentos.cargarDataGridView();
                    }catch(Exception ex) { }
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
            CrearFamilia f = new CrearFamilia();
            f.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.fAlimentos.cargarDataGridView();
            }catch(Exception ex) { }
            this.Close();
        }
    }
}

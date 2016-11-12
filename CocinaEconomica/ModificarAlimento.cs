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
    public partial class ModificarAlimento : Form
    {
        private Alimento alimento;
        public ModificarAlimento(Alimento alimento)
        {
            this.alimento = alimento;
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(this, "El campo NOMBRE es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (txtFamilia.Text == "")
            {
                MessageBox.Show(this, "El campo FAMILIA es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
            this.alimento.Nombre = txtNombre.Text;
            this.alimento.Descripcion = txtDescripcion.Text;
            this.alimento.Familia = Familia.SelectWhereNombreIs(txtFamilia.Text);
            if (this.alimento.Nombre != "")
            {
                bool ok = this.alimento.Update();
                // Feedback!
                if (!ok)
                {
                    MessageBox.Show(this, "Se ha producido un error modificando el alimento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Se ha modificado un alimento correctamente.", "Alimento modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

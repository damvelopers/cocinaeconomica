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
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
            if (Properties.Settings.Default.ConnectionString == "")
            {
                FormConexion f = new FormConexion();
                f.ShowDialog();
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            //comprueba si ya esta abierto el formulario de alimentos
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "MDIAlimentos").SingleOrDefault<Form>();
            if (existe == null)
            {
                if (ActiveMdiChild != null) { ActiveMdiChild.Close(); }

                this.LayoutMdi(MdiLayout.TileHorizontal);
                Form f = new MDIAlimentos();
                f.MdiParent = this;
                f.Show();
                f.WindowState = FormWindowState.Minimized;
                f.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnFamilias_Click(object sender, EventArgs e)
        {
            //comprueba si ya esta abierto el formulario de familias
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "MDIFamilias").SingleOrDefault<Form>();
            if (existe == null)
            {
                if (ActiveMdiChild != null)
                {
                        ActiveMdiChild.Close();
                }

                this.LayoutMdi(MdiLayout.TileHorizontal);
                Form f = new MDIFamilias();
                f.MdiParent = this;
                f.Show();
                f.WindowState = FormWindowState.Minimized;
                f.WindowState = FormWindowState.Maximized;
            }
        }



        private void btnProductos_Click(object sender, EventArgs e)
        {
            //comprueba si ya esta abierto el formulario de productos
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "MDIProductos").SingleOrDefault<Form>();
            if (existe == null)
            {
                if (ActiveMdiChild != null) { ActiveMdiChild.Close(); }

                this.LayoutMdi(MdiLayout.TileHorizontal);
                Form f = new MDIProductos();
                f.MdiParent = this;
                f.Show();
                f.WindowState = FormWindowState.Minimized;
                f.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnAlmacenes_Click(object sender, EventArgs e)
        {
            //comprueba si ya esta abierto el formulario de almacenes
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "MDIAlmacenes").SingleOrDefault<Form>();
            if (existe == null)
            {
                if (ActiveMdiChild != null) { ActiveMdiChild.Close(); }

                this.LayoutMdi(MdiLayout.TileHorizontal);
                Form f = new MDIAlmacenes();
                f.MdiParent = this;
                f.Show();
                f.WindowState = FormWindowState.Minimized;
                f.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            //comprueba si ya esta abierto el formulario de salidas
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "MDISalidas").SingleOrDefault<Form>();
            if (existe == null)
            {
                if (ActiveMdiChild != null) { ActiveMdiChild.Close(); }

                this.LayoutMdi(MdiLayout.TileHorizontal);
                Form f = new MDISalidas();
                f.MdiParent = this;
                f.Show();
                f.WindowState = FormWindowState.Minimized;
                f.WindowState = FormWindowState.Maximized;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConexion conexion = new FormConexion();
            conexion.ShowDialog();
        }

        private void configurarVistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

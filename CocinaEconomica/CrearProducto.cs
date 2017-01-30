using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CocinaEconomica
{
    public partial class crearProducto : Form
    {
        private MDIProductos fProductos;

        public crearProducto(MDIProductos fProductos)
        {
            this.fProductos = fProductos;
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void crearProducto_Load(object sender, EventArgs e)
        {
            ArrayList alimentos = Alimento.SelectAll();
            for (int i = 0; i < alimentos.Count; i++)
            {
                Alimento a = (Alimento)alimentos[i];
                cmb_alimentos.Items.Add(a.Nombre);
            }

            ArrayList almacenes = Almacen.SelectAll();
            for (int i = 0; i < almacenes.Count; i++)
            {
                Almacen a = (Almacen)almacenes[i];
                cbxAlmacen.Items.Add(a.Nombre);
            }

            ArrayList entidades = Entidad.SelectAll();
            for (int i = 0; i < entidades.Count; i++)
            {
                Entidad en = (Entidad)entidades[i];
                cbxEntidades.Items.Add(en.Nombre + "#" + en.DNI);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CrearAlimento f = new CrearAlimento();
            f.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.fProductos.cargarDataGridView();
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (cmb_alimentos.Text == "")
            {
                MessageBox.Show(this, "El campo Alimento es obligatorio", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (!cmb_alimentos.Items.Contains(cmb_alimentos.Text)){
                MessageBox.Show(this, "El Alimento no existe", "Eliga un Alimento ya creado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            int cant = Int32.Parse(txtCantidad.Text);
            if (MessageBox.Show(this, "Se va" + (cant == 1 ? "" : "n") + " a registrar " + cant + " producto" + (cant == 1 ? "" : "s") +" del alimento " +  cmb_alimentos.Text + ". ¿Está seguro?", "Añadir Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                return;
            }

            Producto p = new Producto();
            p.Alimento = Alimento.SelectWhereNombreIs(cmb_alimentos.Text);
            p.Almacen = Almacen.Select(cbxAlmacen.SelectedItem.ToString());
            p.FechaEntrada = dateTimeFechaEn.Value;
            p.FechaCaducidad = dateTimeFechaCad.Value;
            p.FechaConsumirPreferente = dateTimeFechaPref.Value;
            p.Proveedor = comboBoxOrigen.SelectedItem.ToString();
            p.Entidad = Entidad.SelectByDNI((cbxEntidades.SelectedItem.ToString()).Split('#')[1]);
            bool ok = false;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (txtCantidad.Text != "")
                ok = p.Insert(cant);
            else
                ok = p.Insert();

            watch.Stop();
            System.Diagnostics.Debug.WriteLine(watch.ElapsedMilliseconds);
            // Feedback!
            if (!ok)
            {
                MessageBox.Show(this, "Se ha producido un error insertando el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show(this, "Se añadido un nuevo producto correctamente.", "Producto añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_alimentos.Text = "";
                txtCantidad.Text = "";
                this.fProductos.cargarDataGridView();
            }
        }

        private void cbxAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
            cmb_alimentos.Items.Clear();
            for (int i = 0; i < alimentos.Count; i++)
            {
                Alimento a = (Alimento)alimentos[i];
                cmb_alimentos.Items.Add(a.Nombre);
            }

            ArrayList almacenes = Almacen.SelectAll();
            cbxAlmacen.Items.Clear();
            for (int i = 0; i < almacenes.Count; i++)
            {
                Almacen a = (Almacen)almacenes[i];
                cbxAlmacen.Items.Add(a.Nombre);
            }

            ArrayList entidades = Entidad.SelectAll();
            cbxEntidades.Items.Clear();
            for (int i = 0; i < entidades.Count; i++)
            {
                Entidad en = (Entidad)entidades[i];
                if (en.Direccion != "")
                {
                    cbxEntidades.Items.Add(en.Nombre + "-" + en.Direccion);
                }
                else
                {
                    cbxEntidades.Items.Add(en.Nombre);
                }
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

            if (comboBoxOrigen.Text == "")
            {
                MessageBox.Show(this, "El Origen no existe", "Eliga un Origen ya creado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (cbxAlmacen.Text == "")
            {
                MessageBox.Show(this, "El Almacen no existe", "Eliga un Almacen ya creado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (cbxEntidades.Text == "")
            {
                MessageBox.Show(this, "El Proveedor no existe", "Eliga un Proveedor ya creado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            float cant = float.Parse(txtCantidad.Text);
            if (cant == 0)
            {
                MessageBox.Show(this, "Seleccione una cantidad superior a 0", "Escriba una cantidad", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
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
            p.Entidad = Entidad.SelectByName((cbxEntidades.SelectedItem.ToString()).Split('-')[0], (cbxEntidades.SelectedItem.ToString()).Split('-')[1]);
            p.Cantidad = cant;
            bool ok = false;
            if (txtCantidad.Text != "")
                ok = p.Insert();

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

        private void button1_Click(object sender, EventArgs e)
        {
            CrearAlmacen ca = new CrearAlmacen();
            ca.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_crearProveedor_Click(object sender, EventArgs e)
        {
            CrearEntidad ce = new CrearEntidad();
            ce.ShowDialog();
        }
    }
}

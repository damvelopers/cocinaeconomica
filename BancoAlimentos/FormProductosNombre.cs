using System;
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
    public partial class FormProductosNombre : Form
    {
        /// <summary>
        /// En este formulario se muestran todos los productos individuales con el mismo nombre
        /// </summary>
        public FormProductosNombre()
        {
            InitializeComponent();
        }

        private void FormProductosNombre_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoAlimentosDataSet.Imagen' Puede moverla o quitarla según sea necesario.
            this.imagenTableAdapter.Fill(this.bancoAlimentosDataSet.Imagen);
            // TODO: esta línea de código carga datos en la tabla 'bancoAlimentosDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.bancoAlimentosDataSet.Producto);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
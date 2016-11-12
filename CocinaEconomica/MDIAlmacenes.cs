﻿using System;
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
    public partial class MDIAlmacenes : Form
    {
        public MDIAlmacenes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearAlmacen f = new CrearAlmacen();
            f.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Lo mismo xD
            Almacen a = new Almacen();
            ModificarAlmacen f = new ModificarAlmacen(a);
            f.ShowDialog();
        }
    }
}

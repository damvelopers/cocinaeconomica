namespace CocinaEconomica
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoAlimentosDataSet = new CocinaEconomica.BancoAlimentosDataSet();
            this.imagenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new CocinaEconomica.BancoAlimentosDataSetTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new CocinaEconomica.BancoAlimentosDataSetTableAdapters.TableAdapterManager();
            this.imagenTableAdapter = new CocinaEconomica.BancoAlimentosDataSetTableAdapters.ImagenTableAdapter();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.insertarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.familiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductos2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtGrVwAlimentos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoAlimentosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrVwAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // conexiónToolStripMenuItem
            // 
            this.conexiónToolStripMenuItem.Name = "conexiónToolStripMenuItem";
            this.conexiónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conexiónToolStripMenuItem.Text = "Conexión";
            this.conexiónToolStripMenuItem.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.añadirToolStripMenuItem.Text = "Añadir";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.bancoAlimentosDataSet;
            // 
            // bancoAlimentosDataSet
            // 
            this.bancoAlimentosDataSet.DataSetName = "BancoAlimentosDataSet";
            this.bancoAlimentosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imagenBindingSource
            // 
            this.imagenBindingSource.DataMember = "Imagen";
            this.imagenBindingSource.DataSource = this.bancoAlimentosDataSet;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FamiliaTableAdapter = null;
            this.tableAdapterManager.ImagenTableAdapter = this.imagenTableAdapter;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CocinaEconomica.BancoAlimentosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imagenTableAdapter
            // 
            this.imagenTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarProductoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.listadoDeProductosToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(924, 24);
            this.menuStrip2.TabIndex = 14;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // insertarProductoToolStripMenuItem
            // 
            this.insertarProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alimentoToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.familiaToolStripMenuItem});
            this.insertarProductoToolStripMenuItem.Name = "insertarProductoToolStripMenuItem";
            this.insertarProductoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.insertarProductoToolStripMenuItem.Text = "Insertar";
            this.insertarProductoToolStripMenuItem.Click += new System.EventHandler(this.insertarProductoToolStripMenuItem_Click);
            // 
            // alimentoToolStripMenuItem
            // 
            this.alimentoToolStripMenuItem.Name = "alimentoToolStripMenuItem";
            this.alimentoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alimentoToolStripMenuItem.Text = "Alimento";
            this.alimentoToolStripMenuItem.Click += new System.EventHandler(this.alimentoToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // familiaToolStripMenuItem
            // 
            this.familiaToolStripMenuItem.Name = "familiaToolStripMenuItem";
            this.familiaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.familiaToolStripMenuItem.Text = "Familia";
            this.familiaToolStripMenuItem.Click += new System.EventHandler(this.familiaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alimentoToolStripMenuItem1,
            this.productoToolStripMenuItem1,
            this.familiaToolStripMenuItem1,
            this.ubToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // alimentoToolStripMenuItem1
            // 
            this.alimentoToolStripMenuItem1.Name = "alimentoToolStripMenuItem1";
            this.alimentoToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.alimentoToolStripMenuItem1.Text = "Alimento";
            this.alimentoToolStripMenuItem1.Click += new System.EventHandler(this.alimentoToolStripMenuItem1_Click);
            // 
            // productoToolStripMenuItem1
            // 
            this.productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            this.productoToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.productoToolStripMenuItem1.Text = "Producto";
            this.productoToolStripMenuItem1.Click += new System.EventHandler(this.productoToolStripMenuItem1_Click);
            // 
            // familiaToolStripMenuItem1
            // 
            this.familiaToolStripMenuItem1.Name = "familiaToolStripMenuItem1";
            this.familiaToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.familiaToolStripMenuItem1.Text = "Familia";
            this.familiaToolStripMenuItem1.Click += new System.EventHandler(this.familiaToolStripMenuItem1_Click);
            // 
            // ubToolStripMenuItem
            // 
            this.ubToolStripMenuItem.Name = "ubToolStripMenuItem";
            this.ubToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ubToolStripMenuItem.Text = "Ubicación Productos";
            this.ubToolStripMenuItem.Click += new System.EventHandler(this.ubToolStripMenuItem_Click);
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeProductosToolStripMenuItem1,
            this.listadoDeProductos2ToolStripMenuItem,
            this.salidasToolStripMenuItem});
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadoDeProductosToolStripMenuItem.Text = "Listados";
            this.listadoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem_Click);
            // 
            // listadoDeProductosToolStripMenuItem1
            // 
            this.listadoDeProductosToolStripMenuItem1.Name = "listadoDeProductosToolStripMenuItem1";
            this.listadoDeProductosToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.listadoDeProductosToolStripMenuItem1.Text = "Listado de productos";
            this.listadoDeProductosToolStripMenuItem1.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem1_Click);
            // 
            // listadoDeProductos2ToolStripMenuItem
            // 
            this.listadoDeProductos2ToolStripMenuItem.Name = "listadoDeProductos2ToolStripMenuItem";
            this.listadoDeProductos2ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.listadoDeProductos2ToolStripMenuItem.Text = "Listado de Productos Nombre";
            this.listadoDeProductos2ToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductos2ToolStripMenuItem_Click);
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.salidasToolStripMenuItem.Text = "Salidas";
            this.salidasToolStripMenuItem.Click += new System.EventHandler(this.salidasToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenesToolStripMenuItem,
            this.conexionToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuración";
            // 
            // almacenesToolStripMenuItem
            // 
            this.almacenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAlmacenToolStripMenuItem,
            this.modificarAlmacenToolStripMenuItem,
            this.eliminarAlmacenToolStripMenuItem});
            this.almacenesToolStripMenuItem.Name = "almacenesToolStripMenuItem";
            this.almacenesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.almacenesToolStripMenuItem.Text = "Almacenes";
            // 
            // crearAlmacenToolStripMenuItem
            // 
            this.crearAlmacenToolStripMenuItem.Name = "crearAlmacenToolStripMenuItem";
            this.crearAlmacenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.crearAlmacenToolStripMenuItem.Text = "Crear Almacén";
            this.crearAlmacenToolStripMenuItem.Click += new System.EventHandler(this.crearAlmacenToolStripMenuItem_Click);
            // 
            // modificarAlmacenToolStripMenuItem
            // 
            this.modificarAlmacenToolStripMenuItem.Name = "modificarAlmacenToolStripMenuItem";
            this.modificarAlmacenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.modificarAlmacenToolStripMenuItem.Text = "Modificar Almacén";
            this.modificarAlmacenToolStripMenuItem.Click += new System.EventHandler(this.modificarAlmacenToolStripMenuItem_Click);
            // 
            // eliminarAlmacenToolStripMenuItem
            // 
            this.eliminarAlmacenToolStripMenuItem.Name = "eliminarAlmacenToolStripMenuItem";
            this.eliminarAlmacenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.eliminarAlmacenToolStripMenuItem.Text = "Eliminar Almacén";
            this.eliminarAlmacenToolStripMenuItem.Click += new System.EventHandler(this.eliminarAlmacenToolStripMenuItem_Click);
            // 
            // conexionToolStripMenuItem
            // 
            this.conexionToolStripMenuItem.Name = "conexionToolStripMenuItem";
            this.conexionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conexionToolStripMenuItem.Text = "Conexión";
            this.conexionToolStripMenuItem.Click += new System.EventHandler(this.conexionToolStripMenuItem_Click);
            // 
            // dtGrVwAlimentos
            // 
            this.dtGrVwAlimentos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGrVwAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrVwAlimentos.Location = new System.Drawing.Point(651, 38);
            this.dtGrVwAlimentos.Name = "dtGrVwAlimentos";
            this.dtGrVwAlimentos.Size = new System.Drawing.Size(261, 440);
            this.dtGrVwAlimentos.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CocinaEconomica.Properties.Resources.cocina_economica;
            this.pictureBox1.Location = new System.Drawing.Point(248, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 302);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtGrVwAlimentos);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioPrincipal";
            this.Text = "FormularioPrincipal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoAlimentosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrVwAlimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private BancoAlimentosDataSet bancoAlimentosDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private BancoAlimentosDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private BancoAlimentosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BancoAlimentosDataSetTableAdapters.ImagenTableAdapter imagenTableAdapter;
        private System.Windows.Forms.BindingSource imagenBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem insertarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtGrVwAlimentos;
        private System.Windows.Forms.ToolStripMenuItem alimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem familiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductos2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
    }
}
namespace BancoAlimentos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCaducidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaConsPrefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoAlimentosDataSet = new BancoAlimentos.BancoAlimentosDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.imagenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new BancoAlimentos.BancoAlimentosDataSetTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new BancoAlimentos.BancoAlimentosDataSetTableAdapters.TableAdapterManager();
            this.imagenTableAdapter = new BancoAlimentos.BancoAlimentosDataSetTableAdapters.ImagenTableAdapter();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoAlimentosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1270, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.codigoBarrasDataGridViewTextBoxColumn,
            this.fechaEntradaDataGridViewTextBoxColumn,
            this.fechaCaducidadDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn,
            this.fechaConsPrefDataGridViewTextBoxColumn,
            this.familiaDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 306);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // codigoBarrasDataGridViewTextBoxColumn
            // 
            this.codigoBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarras";
            this.codigoBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoBarras";
            this.codigoBarrasDataGridViewTextBoxColumn.Name = "codigoBarrasDataGridViewTextBoxColumn";
            // 
            // fechaEntradaDataGridViewTextBoxColumn
            // 
            this.fechaEntradaDataGridViewTextBoxColumn.DataPropertyName = "FechaEntrada";
            this.fechaEntradaDataGridViewTextBoxColumn.HeaderText = "FechaEntrada";
            this.fechaEntradaDataGridViewTextBoxColumn.Name = "fechaEntradaDataGridViewTextBoxColumn";
            this.fechaEntradaDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaCaducidadDataGridViewTextBoxColumn
            // 
            this.fechaCaducidadDataGridViewTextBoxColumn.DataPropertyName = "FechaCaducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.HeaderText = "FechaCaducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.Name = "fechaCaducidadDataGridViewTextBoxColumn";
            this.fechaCaducidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            this.ubicacionDataGridViewTextBoxColumn.Width = 200;
            // 
            // fechaConsPrefDataGridViewTextBoxColumn
            // 
            this.fechaConsPrefDataGridViewTextBoxColumn.DataPropertyName = "FechaConsPref";
            this.fechaConsPrefDataGridViewTextBoxColumn.HeaderText = "FechaConsPref";
            this.fechaConsPrefDataGridViewTextBoxColumn.Name = "fechaConsPrefDataGridViewTextBoxColumn";
            this.fechaConsPrefDataGridViewTextBoxColumn.Width = 150;
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "Familia";
            this.familiaDataGridViewTextBoxColumn.HeaderText = "Familia";
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad: ";
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.imagenBindingSource, "Imagen", true));
            this.imagenPictureBox.Location = new System.Drawing.Point(6, 27);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(138, 150);
            this.imagenPictureBox.TabIndex = 13;
            this.imagenPictureBox.TabStop = false;
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
            this.tableAdapterManager.UpdateOrder = BancoAlimentos.BancoAlimentosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imagenTableAdapter
            // 
            this.imagenTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.insertarProductoToolStripMenuItem,
            this.listadoDeProductosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1270, 24);
            this.menuStrip2.TabIndex = 14;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // insertarProductoToolStripMenuItem
            // 
            this.insertarProductoToolStripMenuItem.Name = "insertarProductoToolStripMenuItem";
            this.insertarProductoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.insertarProductoToolStripMenuItem.Text = "Insertar producto";
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.listadoDeProductosToolStripMenuItem.Text = "Listado de productos";
            // 
            // nombreLabel1
            // 
            this.nombreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Nombre", true));
            this.nombreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel1.Location = new System.Drawing.Point(150, 27);
            this.nombreLabel1.Name = "nombreLabel1";
            this.nombreLabel1.Size = new System.Drawing.Size(195, 23);
            this.nombreLabel1.TabIndex = 15;
            this.nombreLabel1.Text = "label1";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 509);
            this.Controls.Add(this.nombreLabel1);
            this.Controls.Add(this.imagenPictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "FormularioPrincipal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoAlimentosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private BancoAlimentosDataSet bancoAlimentosDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private BancoAlimentosDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCaducidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaConsPrefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private BancoAlimentosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BancoAlimentosDataSetTableAdapters.ImagenTableAdapter imagenTableAdapter;
        private System.Windows.Forms.BindingSource imagenBindingSource;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private System.Windows.Forms.Label nombreLabel1;
    }
}
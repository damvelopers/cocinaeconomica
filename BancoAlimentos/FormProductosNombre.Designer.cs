namespace CocinaEconomica
{
    partial class FormProductosNombre
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bancoAlimentosDataSet = new CocinaEconomica.BancoAlimentosDataSet();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new CocinaEconomica.BancoAlimentosDataSetTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new CocinaEconomica.BancoAlimentosDataSetTableAdapters.TableAdapterManager();
            this.fechaConsPrefDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaCaducidadDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imagenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imagenTableAdapter = new CocinaEconomica.BancoAlimentosDataSetTableAdapters.ImagenTableAdapter();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCaducidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaConsPrefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoAlimentosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha de entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha de caducidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Consumir preferentemente antes de:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1245, 231);
            this.dataGridView1.TabIndex = 21;
            // 
            // bancoAlimentosDataSet
            // 
            this.bancoAlimentosDataSet.DataSetName = "BancoAlimentosDataSet";
            this.bancoAlimentosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.bancoAlimentosDataSet;
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
            // fechaConsPrefDateTimePicker
            // 
            this.fechaConsPrefDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productoBindingSource, "FechaConsPref", true));
            this.fechaConsPrefDateTimePicker.Location = new System.Drawing.Point(149, 54);
            this.fechaConsPrefDateTimePicker.Name = "fechaConsPrefDateTimePicker";
            this.fechaConsPrefDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaConsPrefDateTimePicker.TabIndex = 22;
            // 
            // fechaCaducidadDateTimePicker
            // 
            this.fechaCaducidadDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productoBindingSource, "FechaCaducidad", true));
            this.fechaCaducidadDateTimePicker.Location = new System.Drawing.Point(149, 97);
            this.fechaCaducidadDateTimePicker.Name = "fechaCaducidadDateTimePicker";
            this.fechaCaducidadDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaCaducidadDateTimePicker.TabIndex = 23;
            // 
            // fechaEntradaDateTimePicker
            // 
            this.fechaEntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productoBindingSource, "FechaEntrada", true));
            this.fechaEntradaDateTimePicker.Location = new System.Drawing.Point(149, 142);
            this.fechaEntradaDateTimePicker.Name = "fechaEntradaDateTimePicker";
            this.fechaEntradaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaEntradaDateTimePicker.TabIndex = 24;
            // 
            // imagenBindingSource
            // 
            this.imagenBindingSource.DataMember = "Imagen";
            this.imagenBindingSource.DataSource = this.bancoAlimentosDataSet;
            // 
            // imagenTableAdapter
            // 
            this.imagenTableAdapter.ClearBeforeFill = true;
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.imagenBindingSource, "Imagen", true));
            this.imagenPictureBox.Location = new System.Drawing.Point(12, 12);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(131, 150);
            this.imagenPictureBox.TabIndex = 25;
            this.imagenPictureBox.TabStop = false;
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
            // FormProductosNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 411);
            this.Controls.Add(this.imagenPictureBox);
            this.Controls.Add(this.fechaEntradaDateTimePicker);
            this.Controls.Add(this.fechaCaducidadDateTimePicker);
            this.Controls.Add(this.fechaConsPrefDateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormProductosNombre";
            this.Text = "FormProductosNombre";
            this.Load += new System.EventHandler(this.FormProductosNombre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoAlimentosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BancoAlimentosDataSet bancoAlimentosDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private BancoAlimentosDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private BancoAlimentosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fechaConsPrefDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaCaducidadDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaEntradaDateTimePicker;
        private BancoAlimentosDataSetTableAdapters.ImagenTableAdapter imagenTableAdapter;
        private System.Windows.Forms.BindingSource imagenBindingSource;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCaducidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaConsPrefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
    }
}
namespace CocinaEconomica
{
    partial class crearProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearProducto));
            this.lblAlimento = new System.Windows.Forms.Label();
            this.lblFechaEn = new System.Windows.Forms.Label();
            this.fechaCad = new System.Windows.Forms.Label();
            this.fechaPref = new System.Windows.Forms.Label();
            this.dateTimeFechaEn = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaCad = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaPref = new System.Windows.Forms.DateTimePicker();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCrearAlimento = new System.Windows.Forms.Button();
            this.origen = new System.Windows.Forms.Label();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.cmb_alimentos = new System.Windows.Forms.ComboBox();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEntidades = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.btn_crearAlmacen = new System.Windows.Forms.Button();
            this.btn_crearProveedor = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.BackColor = System.Drawing.Color.Transparent;
            this.lblAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimento.Location = new System.Drawing.Point(13, 108);
            this.lblAlimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(85, 17);
            this.lblAlimento.TabIndex = 6;
            this.lblAlimento.Text = "Alimento: (*)";
            this.lblAlimento.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFechaEn
            // 
            this.lblFechaEn.AutoSize = true;
            this.lblFechaEn.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEn.Location = new System.Drawing.Point(13, 153);
            this.lblFechaEn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEn.Name = "lblFechaEn";
            this.lblFechaEn.Size = new System.Drawing.Size(104, 17);
            this.lblFechaEn.TabIndex = 7;
            this.lblFechaEn.Text = "Fecha entrada:";
            // 
            // fechaCad
            // 
            this.fechaCad.AutoSize = true;
            this.fechaCad.BackColor = System.Drawing.Color.Transparent;
            this.fechaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCad.Location = new System.Drawing.Point(13, 197);
            this.fechaCad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaCad.Name = "fechaCad";
            this.fechaCad.Size = new System.Drawing.Size(139, 17);
            this.fechaCad.TabIndex = 8;
            this.fechaCad.Text = "Fecha caducidad: (*)";
            // 
            // fechaPref
            // 
            this.fechaPref.AutoSize = true;
            this.fechaPref.BackColor = System.Drawing.Color.Transparent;
            this.fechaPref.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaPref.Location = new System.Drawing.Point(13, 242);
            this.fechaPref.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaPref.Name = "fechaPref";
            this.fechaPref.Size = new System.Drawing.Size(182, 17);
            this.fechaPref.TabIndex = 9;
            this.fechaPref.Text = "Fecha consumo preferente:";
            // 
            // dateTimeFechaEn
            // 
            this.dateTimeFechaEn.Location = new System.Drawing.Point(229, 147);
            this.dateTimeFechaEn.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFechaEn.Name = "dateTimeFechaEn";
            this.dateTimeFechaEn.Size = new System.Drawing.Size(354, 23);
            this.dateTimeFechaEn.TabIndex = 2;
            // 
            // dateTimeFechaCad
            // 
            this.dateTimeFechaCad.Location = new System.Drawing.Point(229, 192);
            this.dateTimeFechaCad.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFechaCad.Name = "dateTimeFechaCad";
            this.dateTimeFechaCad.Size = new System.Drawing.Size(354, 23);
            this.dateTimeFechaCad.TabIndex = 3;
            // 
            // dateTimeFechaPref
            // 
            this.dateTimeFechaPref.Location = new System.Drawing.Point(229, 237);
            this.dateTimeFechaPref.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFechaPref.Name = "dateTimeFechaPref";
            this.dateTimeFechaPref.Size = new System.Drawing.Size(354, 23);
            this.dateTimeFechaPref.TabIndex = 4;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(13, 454);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(100, 28);
            this.btnAnadir.TabIndex = 9;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.BackColor = System.Drawing.Color.Transparent;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(13, 410);
            this.cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(68, 17);
            this.cantidad.TabIndex = 16;
            this.cantidad.Text = "Cantidad:";
            this.cantidad.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(591, 454);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(42)))), ((int)(((byte)(126)))));
            this.lblTitulo.Location = new System.Drawing.Point(225, 37);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 20);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "AÑADIR NUEVO PRODUCTO";
            // 
            // btnCrearAlimento
            // 
            this.btnCrearAlimento.Location = new System.Drawing.Point(591, 102);
            this.btnCrearAlimento.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearAlimento.Name = "btnCrearAlimento";
            this.btnCrearAlimento.Size = new System.Drawing.Size(100, 28);
            this.btnCrearAlimento.TabIndex = 23;
            this.btnCrearAlimento.Text = "Crear";
            this.btnCrearAlimento.UseVisualStyleBackColor = true;
            this.btnCrearAlimento.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // origen
            // 
            this.origen.AutoSize = true;
            this.origen.BackColor = System.Drawing.Color.Transparent;
            this.origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origen.Location = new System.Drawing.Point(13, 284);
            this.origen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(55, 17);
            this.origen.TabIndex = 24;
            this.origen.Text = "Origen:";
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Items.AddRange(new object[] {
            "Donado",
            "Comprado",
            "Banco de alimentos"});
            this.comboBoxOrigen.Location = new System.Drawing.Point(229, 281);
            this.comboBoxOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(243, 24);
            this.comboBoxOrigen.TabIndex = 5;
            // 
            // cmb_alimentos
            // 
            this.cmb_alimentos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_alimentos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_alimentos.FormattingEnabled = true;
            this.cmb_alimentos.Location = new System.Drawing.Point(229, 102);
            this.cmb_alimentos.Name = "cmb_alimentos";
            this.cmb_alimentos.Size = new System.Drawing.Size(354, 24);
            this.cmb_alimentos.TabIndex = 1;
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(229, 323);
            this.cbxAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(243, 24);
            this.cbxAlmacen.TabIndex = 6;
            this.cbxAlmacen.SelectedIndexChanged += new System.EventHandler(this.cbxAlmacen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Almacén:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Proveedor:";
            // 
            // cbxEntidades
            // 
            this.cbxEntidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEntidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEntidades.FormattingEnabled = true;
            this.cbxEntidades.Location = new System.Drawing.Point(229, 367);
            this.cbxEntidades.Name = "cbxEntidades";
            this.cbxEntidades.Size = new System.Drawing.Size(243, 24);
            this.cbxEntidades.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.DecimalPlaces = 2;
            this.txtCantidad.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.txtCantidad.Location = new System.Drawing.Point(229, 410);
            this.txtCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(243, 23);
            this.txtCantidad.TabIndex = 8;
            // 
            // btn_crearAlmacen
            // 
            this.btn_crearAlmacen.Location = new System.Drawing.Point(483, 323);
            this.btn_crearAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crearAlmacen.Name = "btn_crearAlmacen";
            this.btn_crearAlmacen.Size = new System.Drawing.Size(100, 25);
            this.btn_crearAlmacen.TabIndex = 30;
            this.btn_crearAlmacen.Text = "Crear";
            this.btn_crearAlmacen.UseVisualStyleBackColor = true;
            this.btn_crearAlmacen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_crearProveedor
            // 
            this.btn_crearProveedor.Location = new System.Drawing.Point(483, 367);
            this.btn_crearProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crearProveedor.Name = "btn_crearProveedor";
            this.btn_crearProveedor.Size = new System.Drawing.Size(100, 25);
            this.btn_crearProveedor.TabIndex = 32;
            this.btn_crearProveedor.Text = "Crear";
            this.btn_crearProveedor.UseVisualStyleBackColor = true;
            this.btn_crearProveedor.Click += new System.EventHandler(this.btn_crearProveedor_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = global::CocinaEconomica.Properties.Resources.reload;
            this.btn_actualizar.Location = new System.Drawing.Point(651, 18);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(41, 39);
            this.btn_actualizar.TabIndex = 33;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.crearProducto_Load);
            // 
            // crearProducto
            // 
            this.AcceptButton = this.btnAnadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CocinaEconomica.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(704, 497);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_crearProveedor);
            this.Controls.Add(this.btn_crearAlmacen);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbxEntidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxAlmacen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_alimentos);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.origen);
            this.Controls.Add(this.btnCrearAlimento);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.dateTimeFechaPref);
            this.Controls.Add(this.dateTimeFechaCad);
            this.Controls.Add(this.dateTimeFechaEn);
            this.Controls.Add(this.fechaPref);
            this.Controls.Add(this.fechaCad);
            this.Controls.Add(this.lblFechaEn);
            this.Controls.Add(this.lblAlimento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "crearProducto";
            this.Text = "Cantidad:";
            this.Load += new System.EventHandler(this.crearProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAlimento;
        private System.Windows.Forms.Label lblFechaEn;
        private System.Windows.Forms.Label fechaCad;
        private System.Windows.Forms.Label fechaPref;
        private System.Windows.Forms.DateTimePicker dateTimeFechaEn;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCad;
        private System.Windows.Forms.DateTimePicker dateTimeFechaPref;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCrearAlimento;
        private System.Windows.Forms.Label origen;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.ComboBox cmb_alimentos;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEntidades;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Button btn_crearAlmacen;
        private System.Windows.Forms.Button btn_crearProveedor;
        private System.Windows.Forms.Button btn_actualizar;
    }
}
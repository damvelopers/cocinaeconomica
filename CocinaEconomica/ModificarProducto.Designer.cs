namespace CocinaEconomica
{
    partial class ModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProducto));
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.fechEntrada = new System.Windows.Forms.DateTimePicker();
            this.fechCaducidad = new System.Windows.Forms.DateTimePicker();
            this.fechConsPref = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxEntidades = new System.Windows.Forms.ComboBox();
            this.tbCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(534, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Buscar producto";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(971, 362);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 64;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(848, 362);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 63;
            this.btnAceptar.Text = "Aceptar cambios";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(534, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Fecha entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(534, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Alimento (*)";
            // 
            // txtAlimento
            // 
            this.txtAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAlimento.Location = new System.Drawing.Point(537, 140);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.ReadOnly = true;
            this.txtAlimento.Size = new System.Drawing.Size(259, 23);
            this.txtAlimento.TabIndex = 2;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(697, 86);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarProducto.TabIndex = 56;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(537, 50);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(259, 23);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(9, 51);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.Size = new System.Drawing.Size(505, 340);
            this.dataGridProductos.TabIndex = 54;
            this.dataGridProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductos_CellEnter);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(42)))), ((int)(((byte)(126)))));
            this.lblTitulo.Location = new System.Drawing.Point(5, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 20);
            this.lblTitulo.TabIndex = 53;
            this.lblTitulo.Text = "PRODUCTOS";
            // 
            // fechEntrada
            // 
            this.fechEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fechEntrada.Location = new System.Drawing.Point(538, 225);
            this.fechEntrada.Name = "fechEntrada";
            this.fechEntrada.Size = new System.Drawing.Size(259, 23);
            this.fechEntrada.TabIndex = 3;
            // 
            // fechCaducidad
            // 
            this.fechCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fechCaducidad.Location = new System.Drawing.Point(537, 280);
            this.fechCaducidad.Name = "fechCaducidad";
            this.fechCaducidad.Size = new System.Drawing.Size(259, 23);
            this.fechCaducidad.TabIndex = 4;
            // 
            // fechConsPref
            // 
            this.fechConsPref.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fechConsPref.Location = new System.Drawing.Point(537, 335);
            this.fechConsPref.Name = "fechConsPref";
            this.fechConsPref.Size = new System.Drawing.Size(259, 23);
            this.fechConsPref.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(845, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Origen";
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbOrigen.Items.AddRange(new object[] {
            "Donado",
            "Comprado",
            "Banco de alimentos"});
            this.cbOrigen.Location = new System.Drawing.Point(848, 139);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(223, 24);
            this.cbOrigen.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(845, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(535, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Fecha de caducidad (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(535, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "Fecha de consumición preferente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(847, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 79;
            this.label8.Text = "Proveedor:";
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(850, 52);
            this.cbxAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(221, 21);
            this.cbxAlmacen.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(847, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 77;
            this.label9.Text = "Almacén:";
            // 
            // cbxEntidades
            // 
            this.cbxEntidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEntidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEntidades.FormattingEnabled = true;
            this.cbxEntidades.Location = new System.Drawing.Point(850, 95);
            this.cbxEntidades.Name = "cbxEntidades";
            this.cbxEntidades.Size = new System.Drawing.Size(221, 21);
            this.cbxEntidades.TabIndex = 7;
            // 
            // tbCantidad
            // 
            this.tbCantidad.DecimalPlaces = 2;
            this.tbCantidad.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tbCantidad.Location = new System.Drawing.Point(848, 255);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(223, 20);
            this.tbCantidad.TabIndex = 9;
            // 
            // ModificarProducto
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CocinaEconomica.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1106, 403);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.cbxEntidades);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxAlmacen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fechConsPref);
            this.Controls.Add(this.fechCaducidad);
            this.Controls.Add(this.fechEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridProductos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarProducto";
            this.Text = "ModificarProducto";
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker fechEntrada;
        private System.Windows.Forms.DateTimePicker fechCaducidad;
        private System.Windows.Forms.DateTimePicker fechConsPref;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxAlmacen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxEntidades;
        private System.Windows.Forms.NumericUpDown tbCantidad;
    }
}
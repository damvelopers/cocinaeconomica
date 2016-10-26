namespace BancoAlimentos
{
    partial class CrearAlimento
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
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.origen = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.Label();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.dateTimeFechaPref = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaCad = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaEn = new System.Windows.Forms.DateTimePicker();
            this.fechaPref = new System.Windows.Forms.Label();
            this.fechaCad = new System.Windows.Forms.Label();
            this.lblFechaEn = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Items.AddRange(new object[] {
            "Donado",
            "Comprado",
            "Banco de alimentos"});
            this.comboBoxOrigen.Location = new System.Drawing.Point(275, 280);
            this.comboBoxOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(160, 21);
            this.comboBoxOrigen.TabIndex = 41;
            // 
            // origen
            // 
            this.origen.AutoSize = true;
            this.origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origen.Location = new System.Drawing.Point(55, 290);
            this.origen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(55, 17);
            this.origen.TabIndex = 40;
            this.origen.Text = "Origen:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(550, 100);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(275, 103);
            this.txtAlimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.ReadOnly = true;
            this.txtAlimento.Size = new System.Drawing.Size(252, 20);
            this.txtAlimento.TabIndex = 38;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(42)))), ((int)(((byte)(126)))));
            this.lblTitulo.Location = new System.Drawing.Point(228, 35);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 20);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "AÑADIR NUEVO PRODUCTO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(548, 389);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 36;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(275, 324);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(99, 20);
            this.txtCantidad.TabIndex = 35;
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(55, 328);
            this.cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(68, 17);
            this.cantidad.TabIndex = 34;
            this.cantidad.Text = "Cantidad:";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(58, 389);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(100, 28);
            this.btnAnadir.TabIndex = 33;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            // 
            // dateTimeFechaPref
            // 
            this.dateTimeFechaPref.Location = new System.Drawing.Point(275, 233);
            this.dateTimeFechaPref.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFechaPref.Name = "dateTimeFechaPref";
            this.dateTimeFechaPref.Size = new System.Drawing.Size(373, 20);
            this.dateTimeFechaPref.TabIndex = 32;
            // 
            // dateTimeFechaCad
            // 
            this.dateTimeFechaCad.Location = new System.Drawing.Point(275, 189);
            this.dateTimeFechaCad.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFechaCad.Name = "dateTimeFechaCad";
            this.dateTimeFechaCad.Size = new System.Drawing.Size(373, 20);
            this.dateTimeFechaCad.TabIndex = 31;
            // 
            // dateTimeFechaEn
            // 
            this.dateTimeFechaEn.Location = new System.Drawing.Point(275, 146);
            this.dateTimeFechaEn.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFechaEn.Name = "dateTimeFechaEn";
            this.dateTimeFechaEn.Size = new System.Drawing.Size(373, 20);
            this.dateTimeFechaEn.TabIndex = 30;
            // 
            // fechaPref
            // 
            this.fechaPref.AutoSize = true;
            this.fechaPref.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaPref.Location = new System.Drawing.Point(55, 242);
            this.fechaPref.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaPref.Name = "fechaPref";
            this.fechaPref.Size = new System.Drawing.Size(182, 17);
            this.fechaPref.TabIndex = 29;
            this.fechaPref.Text = "Fecha consumo preferente:";
            // 
            // fechaCad
            // 
            this.fechaCad.AutoSize = true;
            this.fechaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCad.Location = new System.Drawing.Point(55, 197);
            this.fechaCad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaCad.Name = "fechaCad";
            this.fechaCad.Size = new System.Drawing.Size(120, 17);
            this.fechaCad.TabIndex = 28;
            this.fechaCad.Text = "Fecha caducidad:";
            // 
            // lblFechaEn
            // 
            this.lblFechaEn.AutoSize = true;
            this.lblFechaEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEn.Location = new System.Drawing.Point(55, 153);
            this.lblFechaEn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEn.Name = "lblFechaEn";
            this.lblFechaEn.Size = new System.Drawing.Size(104, 17);
            this.lblFechaEn.TabIndex = 27;
            this.lblFechaEn.Text = "Fecha entrada:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(55, 106);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 17);
            this.lbl.TabIndex = 26;
            this.lbl.Text = "Alimento:";
            // 
            // CrearAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 453);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.origen);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.dateTimeFechaPref);
            this.Controls.Add(this.dateTimeFechaCad);
            this.Controls.Add(this.dateTimeFechaEn);
            this.Controls.Add(this.fechaPref);
            this.Controls.Add(this.fechaCad);
            this.Controls.Add(this.lblFechaEn);
            this.Controls.Add(this.lbl);
            this.Name = "CrearAlimento";
            this.Text = "CrearAlimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.Label origen;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.DateTimePicker dateTimeFechaPref;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCad;
        private System.Windows.Forms.DateTimePicker dateTimeFechaEn;
        private System.Windows.Forms.Label fechaPref;
        private System.Windows.Forms.Label fechaCad;
        private System.Windows.Forms.Label lblFechaEn;
        private System.Windows.Forms.Label lbl;
    }
}
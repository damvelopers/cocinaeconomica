﻿namespace CocinaEconomica
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.origen = new System.Windows.Forms.Label();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimento.Location = new System.Drawing.Point(13, 108);
            this.lblAlimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(66, 17);
            this.lblAlimento.TabIndex = 6;
            this.lblAlimento.Text = "Alimento:";
            this.lblAlimento.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFechaEn
            // 
            this.lblFechaEn.AutoSize = true;
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
            this.fechaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCad.Location = new System.Drawing.Point(13, 197);
            this.fechaCad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaCad.Name = "fechaCad";
            this.fechaCad.Size = new System.Drawing.Size(120, 17);
            this.fechaCad.TabIndex = 8;
            this.fechaCad.Text = "Fecha caducidad:";
            // 
            // fechaPref
            // 
            this.fechaPref.AutoSize = true;
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
            this.dateTimeFechaEn.TabIndex = 12;
            // 
            // dateTimeFechaCad
            // 
            this.dateTimeFechaCad.Location = new System.Drawing.Point(229, 192);
            this.dateTimeFechaCad.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFechaCad.Name = "dateTimeFechaCad";
            this.dateTimeFechaCad.Size = new System.Drawing.Size(354, 23);
            this.dateTimeFechaCad.TabIndex = 13;
            // 
            // dateTimeFechaPref
            // 
            this.dateTimeFechaPref.Location = new System.Drawing.Point(229, 237);
            this.dateTimeFechaPref.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFechaPref.Name = "dateTimeFechaPref";
            this.dateTimeFechaPref.Size = new System.Drawing.Size(354, 23);
            this.dateTimeFechaPref.TabIndex = 14;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(13, 372);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(100, 28);
            this.btnAnadir.TabIndex = 15;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(13, 328);
            this.cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(68, 17);
            this.cantidad.TabIndex = 16;
            this.cantidad.Text = "Cantidad:";
            this.cantidad.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(229, 325);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(129, 23);
            this.txtCantidad.TabIndex = 17;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(591, 372);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(42)))), ((int)(((byte)(126)))));
            this.lblTitulo.Location = new System.Drawing.Point(225, 37);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 20);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "AÑADIR NUEVO PRODUCTO";
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(229, 105);
            this.txtAlimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.ReadOnly = true;
            this.txtAlimento.Size = new System.Drawing.Size(354, 23);
            this.txtAlimento.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(591, 102);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // origen
            // 
            this.origen.AutoSize = true;
            this.origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origen.Location = new System.Drawing.Point(13, 290);
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
            this.comboBoxOrigen.Location = new System.Drawing.Point(229, 287);
            this.comboBoxOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(243, 24);
            this.comboBoxOrigen.TabIndex = 25;
            // 
            // crearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CocinaEconomica.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(704, 413);
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
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label origen;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
    }
}
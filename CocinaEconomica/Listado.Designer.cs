namespace CocinaEconomica
{
    partial class Listado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dGVAlimentos = new System.Windows.Forms.DataGridView();
            this.dGVProductos = new System.Windows.Forms.DataGridView();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.rBProxCaducidad = new System.Windows.Forms.RadioButton();
            this.rBCaducados = new System.Windows.Forms.RadioButton();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(42)))), ((int)(((byte)(126)))));
            this.lblTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(110, 20);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "ALIMENTOS";
            // 
            // dGVAlimentos
            // 
            this.dGVAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAlimentos.Location = new System.Drawing.Point(9, 41);
            this.dGVAlimentos.Name = "dGVAlimentos";
            this.dGVAlimentos.Size = new System.Drawing.Size(188, 439);
            this.dGVAlimentos.TabIndex = 40;
            // 
            // dGVProductos
            // 
            this.dGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProductos.Location = new System.Drawing.Point(216, 70);
            this.dGVProductos.Name = "dGVProductos";
            this.dGVProductos.Size = new System.Drawing.Size(699, 372);
            this.dGVProductos.TabIndex = 41;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(42)))), ((int)(((byte)(126)))));
            this.lblTitulo2.Location = new System.Drawing.Point(215, 30);
            this.lblTitulo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(119, 20);
            this.lblTitulo2.TabIndex = 42;
            this.lblTitulo2.Text = "PRODUCTOS";
            // 
            // rBProxCaducidad
            // 
            this.rBProxCaducidad.AutoSize = true;
            this.rBProxCaducidad.Location = new System.Drawing.Point(691, 30);
            this.rBProxCaducidad.Name = "rBProxCaducidad";
            this.rBProxCaducidad.Size = new System.Drawing.Size(115, 17);
            this.rBProxCaducidad.TabIndex = 43;
            this.rBProxCaducidad.TabStop = true;
            this.rBProxCaducidad.Text = "Proxima caducidad";
            this.rBProxCaducidad.UseVisualStyleBackColor = true;
            // 
            // rBCaducados
            // 
            this.rBCaducados.AutoSize = true;
            this.rBCaducados.Location = new System.Drawing.Point(813, 30);
            this.rBCaducados.Name = "rBCaducados";
            this.rBCaducados.Size = new System.Drawing.Size(79, 17);
            this.rBCaducados.TabIndex = 44;
            this.rBCaducados.TabStop = true;
            this.rBCaducados.Text = "Caducados";
            this.rBCaducados.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(813, 456);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 33);
            this.btnCerrar.TabIndex = 45;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CocinaEconomica.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(927, 492);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rBCaducados);
            this.Controls.Add(this.rBProxCaducidad);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.dGVProductos);
            this.Controls.Add(this.dGVAlimentos);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listado";
            this.Text = "Listado";
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dGVAlimentos;
        private System.Windows.Forms.DataGridView dGVProductos;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.RadioButton rBProxCaducidad;
        private System.Windows.Forms.RadioButton rBCaducados;
        private System.Windows.Forms.Button btnCerrar;
    }
}
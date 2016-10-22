namespace BancoAlimentos
{
    partial class FormularioInsertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioInsertar));
            this.imagenAlimento = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxFamilia = new System.Windows.Forms.ComboBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddFamilia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAlimento)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenAlimento
            // 
            this.imagenAlimento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imagenAlimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenAlimento.Location = new System.Drawing.Point(3, 12);
            this.imagenAlimento.Name = "imagenAlimento";
            this.imagenAlimento.Size = new System.Drawing.Size(216, 267);
            this.imagenAlimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenAlimento.TabIndex = 0;
            this.imagenAlimento.TabStop = false;
            this.imagenAlimento.Click += new System.EventHandler(this.imagenAlimento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Familia";
            // 
            // cbxFamilia
            // 
            this.cbxFamilia.FormattingEnabled = true;
            this.cbxFamilia.Location = new System.Drawing.Point(225, 70);
            this.cbxFamilia.Name = "cbxFamilia";
            this.cbxFamilia.Size = new System.Drawing.Size(186, 21);
            this.cbxFamilia.TabIndex = 10;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(385, 285);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(107, 34);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(225, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(225, 123);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(267, 156);
            this.txtDescripcion.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descripción";
            // 
            // btnAddFamilia
            // 
            this.btnAddFamilia.Location = new System.Drawing.Point(417, 70);
            this.btnAddFamilia.Name = "btnAddFamilia";
            this.btnAddFamilia.Size = new System.Drawing.Size(75, 23);
            this.btnAddFamilia.TabIndex = 20;
            this.btnAddFamilia.Text = "Añadir familia";
            this.btnAddFamilia.UseVisualStyleBackColor = true;
            this.btnAddFamilia.Click += new System.EventHandler(this.btnAddFamilia_Click);
            // 
            // FormularioInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 327);
            this.Controls.Add(this.btnAddFamilia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.cbxFamilia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagenAlimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioInsertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar alimento";
            this.Load += new System.EventHandler(this.FormularioInsertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenAlimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenAlimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxFamilia;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFamilia;
    }
}
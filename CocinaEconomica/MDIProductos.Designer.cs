namespace CocinaEconomica
{
    partial class MDIProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablaContenido = new System.Windows.Forms.TableLayoutPanel();
            this.panelBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.tablaDatos = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.panelBuscar = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNoCaducados = new System.Windows.Forms.RadioButton();
            this.rBCaducados = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TablaContenido.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.gbPrincipal.SuspendLayout();
            this.tablaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.panelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaContenido
            // 
            this.TablaContenido.ColumnCount = 2;
            this.TablaContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.TablaContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablaContenido.Controls.Add(this.panelBotones, 0, 0);
            this.TablaContenido.Controls.Add(this.gbPrincipal, 1, 0);
            this.TablaContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaContenido.Location = new System.Drawing.Point(0, 0);
            this.TablaContenido.Name = "TablaContenido";
            this.TablaContenido.RowCount = 1;
            this.TablaContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablaContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 498F));
            this.TablaContenido.Size = new System.Drawing.Size(1196, 498);
            this.TablaContenido.TabIndex = 6;
            // 
            // panelBotones
            // 
            this.panelBotones.BackgroundImage = global::CocinaEconomica.Properties.Resources.fondo;
            this.panelBotones.Controls.Add(this.btnNuevo);
            this.panelBotones.Controls.Add(this.btnModificar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Controls.Add(this.btnAyuda);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.Location = new System.Drawing.Point(3, 3);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(119, 492);
            this.panelBotones.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.GreenYellow;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(113, 45);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(3, 54);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 45);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(3, 105);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 45);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(3, 156);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 45);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Location = new System.Drawing.Point(3, 207);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(113, 45);
            this.btnAyuda.TabIndex = 4;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.BackgroundImage = global::CocinaEconomica.Properties.Resources.fondo;
            this.gbPrincipal.Controls.Add(this.button1);
            this.gbPrincipal.Controls.Add(this.tablaDatos);
            this.gbPrincipal.Controls.Add(this.panelBuscar);
            this.gbPrincipal.Controls.Add(this.rbNoCaducados);
            this.gbPrincipal.Controls.Add(this.rBCaducados);
            this.gbPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrincipal.Location = new System.Drawing.Point(128, 3);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(1065, 492);
            this.gbPrincipal.TabIndex = 2;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Productos";
            // 
            // tablaDatos
            // 
            this.tablaDatos.ColumnCount = 1;
            this.tablaDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablaDatos.Controls.Add(this.dataGridProductos, 0, 0);
            this.tablaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaDatos.Location = new System.Drawing.Point(3, 58);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.RowCount = 1;
            this.tablaDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tablaDatos.Size = new System.Drawing.Size(1059, 431);
            this.tablaDatos.TabIndex = 1;
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AllowUserToAddRows = false;
            this.dataGridProductos.AllowUserToDeleteRows = false;
            this.dataGridProductos.AllowUserToOrderColumns = true;
            this.dataGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProductos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProductos.Location = new System.Drawing.Point(3, 3);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProductos.Size = new System.Drawing.Size(1053, 425);
            this.dataGridProductos.TabIndex = 1;
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Controls.Add(this.btnBuscar);
            this.panelBuscar.Controls.Add(this.label1);
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscar.Location = new System.Drawing.Point(3, 22);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(1059, 36);
            this.panelBuscar.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(3, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(371, 26);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscar.Location = new System.Drawing.Point(380, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(458, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "En esta ventana se pueden añadir/modificar/eliminar productos a la base de datos." +
    "";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbNoCaducados
            // 
            this.rbNoCaducados.AutoSize = true;
            this.rbNoCaducados.BackColor = System.Drawing.Color.Transparent;
            this.rbNoCaducados.Location = new System.Drawing.Point(417, 0);
            this.rbNoCaducados.Name = "rbNoCaducados";
            this.rbNoCaducados.Size = new System.Drawing.Size(240, 24);
            this.rbNoCaducados.TabIndex = 2;
            this.rbNoCaducados.TabStop = true;
            this.rbNoCaducados.Text = "Productos proximos a caducar";
            this.rbNoCaducados.UseVisualStyleBackColor = false;
            this.rbNoCaducados.CheckedChanged += new System.EventHandler(this.rbNoCaducados_CheckedChanged);
            // 
            // rBCaducados
            // 
            this.rBCaducados.AutoSize = true;
            this.rBCaducados.BackColor = System.Drawing.Color.Transparent;
            this.rBCaducados.Location = new System.Drawing.Point(221, 0);
            this.rBCaducados.Name = "rBCaducados";
            this.rBCaducados.Size = new System.Drawing.Size(181, 24);
            this.rBCaducados.TabIndex = 2;
            this.rBCaducados.TabStop = true;
            this.rBCaducados.Text = "Productos caducados";
            this.rBCaducados.UseVisualStyleBackColor = false;
            this.rBCaducados.CheckedChanged += new System.EventHandler(this.rBCaducados_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1196, 498);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Image = global::CocinaEconomica.Properties.Resources.reload;
            this.button1.Location = new System.Drawing.Point(676, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 30);
            this.button1.TabIndex = 3;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MDIProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 498);
            this.ControlBox = false;
            this.Controls.Add(this.TablaContenido);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MDIProductos";
            this.Text = "MDIProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIProductos_Load);
            this.TablaContenido.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.tablaDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablaContenido;
        private System.Windows.Forms.FlowLayoutPanel panelBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.TableLayoutPanel tablaDatos;
        private System.Windows.Forms.FlowLayoutPanel panelBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton rbNoCaducados;
        private System.Windows.Forms.RadioButton rBCaducados;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
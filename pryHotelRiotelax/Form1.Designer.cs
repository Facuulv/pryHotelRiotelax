namespace pryHotelRiotelax
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSpa = new System.Windows.Forms.CheckBox();
            this.chkInternet = new System.Windows.Forms.CheckBox();
            this.chkBar = new System.Windows.Forms.CheckBox();
            this.chkGimnasio = new System.Windows.Forms.CheckBox();
            this.cmbPiso = new System.Windows.Forms.ComboBox();
            this.cmbHabitacion = new System.Windows.Forms.ComboBox();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblServicios = new System.Windows.Forms.Label();
            this.lblTotalDia = new System.Windows.Forms.Label();
            this.lblPrecioHabitacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSpa);
            this.groupBox1.Controls.Add(this.chkInternet);
            this.groupBox1.Controls.Add(this.chkBar);
            this.groupBox1.Controls.Add(this.chkGimnasio);
            this.groupBox1.Location = new System.Drawing.Point(235, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios Adicionales";
            // 
            // chkSpa
            // 
            this.chkSpa.AutoSize = true;
            this.chkSpa.Location = new System.Drawing.Point(7, 100);
            this.chkSpa.Name = "chkSpa";
            this.chkSpa.Size = new System.Drawing.Size(54, 20);
            this.chkSpa.TabIndex = 3;
            this.chkSpa.Text = "Spa";
            this.chkSpa.UseVisualStyleBackColor = true;
            this.chkSpa.CheckedChanged += new System.EventHandler(this.chkSpa_CheckedChanged);
            // 
            // chkInternet
            // 
            this.chkInternet.AutoSize = true;
            this.chkInternet.Location = new System.Drawing.Point(7, 74);
            this.chkInternet.Name = "chkInternet";
            this.chkInternet.Size = new System.Drawing.Size(139, 20);
            this.chkInternet.TabIndex = 2;
            this.chkInternet.Text = "Wifi de 100 Megas";
            this.chkInternet.UseVisualStyleBackColor = true;
            this.chkInternet.CheckedChanged += new System.EventHandler(this.chkInternet_CheckedChanged);
            // 
            // chkBar
            // 
            this.chkBar.AutoSize = true;
            this.chkBar.Location = new System.Drawing.Point(7, 48);
            this.chkBar.Name = "chkBar";
            this.chkBar.Size = new System.Drawing.Size(104, 20);
            this.chkBar.TabIndex = 1;
            this.chkBar.Text = "Bar del hotel";
            this.chkBar.UseVisualStyleBackColor = true;
            this.chkBar.CheckedChanged += new System.EventHandler(this.chkBar_CheckedChanged);
            // 
            // chkGimnasio
            // 
            this.chkGimnasio.AutoSize = true;
            this.chkGimnasio.Location = new System.Drawing.Point(7, 22);
            this.chkGimnasio.Name = "chkGimnasio";
            this.chkGimnasio.Size = new System.Drawing.Size(86, 20);
            this.chkGimnasio.TabIndex = 0;
            this.chkGimnasio.Text = "Gimnasio";
            this.chkGimnasio.UseVisualStyleBackColor = true;
            this.chkGimnasio.CheckedChanged += new System.EventHandler(this.chkGimnasio_CheckedChanged);
            // 
            // cmbPiso
            // 
            this.cmbPiso.FormattingEnabled = true;
            this.cmbPiso.Location = new System.Drawing.Point(27, 53);
            this.cmbPiso.Name = "cmbPiso";
            this.cmbPiso.Size = new System.Drawing.Size(149, 24);
            this.cmbPiso.TabIndex = 1;
            this.cmbPiso.SelectedIndexChanged += new System.EventHandler(this.cmbPiso_SelectedIndexChanged);
            // 
            // cmbHabitacion
            // 
            this.cmbHabitacion.FormattingEnabled = true;
            this.cmbHabitacion.Location = new System.Drawing.Point(27, 123);
            this.cmbHabitacion.Name = "cmbHabitacion";
            this.cmbHabitacion.Size = new System.Drawing.Size(149, 24);
            this.cmbHabitacion.TabIndex = 2;
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(235, 53);
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(144, 22);
            this.numDias.TabIndex = 3;
            this.numDias.ValueChanged += new System.EventHandler(this.numDias_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultado);
            this.groupBox2.Controls.Add(this.lblServicios);
            this.groupBox2.Controls.Add(this.lblTotalDia);
            this.groupBox2.Controls.Add(this.lblPrecioHabitacion);
            this.groupBox2.Location = new System.Drawing.Point(21, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 139);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(6, 107);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 8;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Location = new System.Drawing.Point(6, 81);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(0, 16);
            this.lblServicios.TabIndex = 10;
            // 
            // lblTotalDia
            // 
            this.lblTotalDia.AutoSize = true;
            this.lblTotalDia.Location = new System.Drawing.Point(6, 55);
            this.lblTotalDia.Name = "lblTotalDia";
            this.lblTotalDia.Size = new System.Drawing.Size(0, 16);
            this.lblTotalDia.TabIndex = 9;
            // 
            // lblPrecioHabitacion
            // 
            this.lblPrecioHabitacion.AutoSize = true;
            this.lblPrecioHabitacion.Location = new System.Drawing.Point(6, 28);
            this.lblPrecioHabitacion.Name = "lblPrecioHabitacion";
            this.lblPrecioHabitacion.Size = new System.Drawing.Size(0, 16);
            this.lblPrecioHabitacion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccionar Piso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione Habitacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de dias";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(55, 176);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 43);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(313, 264);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 43);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(313, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 43);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(442, 431);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numDias);
            this.Controls.Add(this.cmbHabitacion);
            this.Controls.Add(this.cmbPiso);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva Hotel Riotelax";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPiso;
        private System.Windows.Forms.ComboBox cmbHabitacion;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPrecioHabitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSpa;
        private System.Windows.Forms.CheckBox chkInternet;
        private System.Windows.Forms.CheckBox chkBar;
        private System.Windows.Forms.CheckBox chkGimnasio;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Label lblTotalDia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}


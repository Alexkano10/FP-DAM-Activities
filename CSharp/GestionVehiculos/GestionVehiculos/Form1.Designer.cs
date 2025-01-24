namespace GestionVehiculos
{
    partial class btnGenerarReporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnGenerarReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Propietario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de ingreso";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(218, 34);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(166, 20);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(218, 65);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(166, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // txtPropietario
            // 
            this.txtPropietario.Location = new System.Drawing.Point(218, 93);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(166, 20);
            this.txtPropietario.TabIndex = 6;
            // 
            // dateTimePickerFechaIngreso
            // 
            this.dateTimePickerFechaIngreso.Location = new System.Drawing.Point(218, 125);
            this.dateTimePickerFechaIngreso.Name = "dateTimePickerFechaIngreso";
            this.dateTimePickerFechaIngreso.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerFechaIngreso.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(45, 203);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(173, 21);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar Vehiculo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(224, 203);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(173, 21);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar Vehiculo";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(403, 203);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(173, 21);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar Vehiculo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(582, 203);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(173, 21);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "ConsultarVehiculo";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(49, 251);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(705, 170);
            this.dgvVehiculos.TabIndex = 12;
            // 
            // btnGenerarReport
            // 
            this.btnGenerarReport.Location = new System.Drawing.Point(605, 58);
            this.btnGenerarReport.Name = "btnGenerarReport";
            this.btnGenerarReport.Size = new System.Drawing.Size(125, 20);
            this.btnGenerarReport.TabIndex = 13;
            this.btnGenerarReport.Text = "Generar Reporte";
            this.btnGenerarReport.UseVisualStyleBackColor = true;
            this.btnGenerarReport.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // btnGenerarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnGenerarReport);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dateTimePickerFechaIngreso);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "btnGenerarReporte";
            this.Text = "Generar Reporte";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaIngreso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnGenerarReport;
    }
}


namespace SubmarinoControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarInmersion = new Button();
            btnAscender = new Button();
            btnDetenerMotor = new Button();
            txtProfundidad = new TextBox();
            listBoxSensores = new ListBox();
            progressBarOxigeno = new ProgressBar();
            chkLucesExternas = new CheckBox();
            chkCamara = new CheckBox();
            chkMicrofono = new CheckBox();
            dataGridViewPresion = new DataGridView();
            lblAdvertencia = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPresion).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarInmersion
            // 
            btnIniciarInmersion.Location = new Point(12, 12);
            btnIniciarInmersion.Name = "btnIniciarInmersion";
            btnIniciarInmersion.Size = new Size(102, 26);
            btnIniciarInmersion.TabIndex = 0;
            btnIniciarInmersion.Text = "Iniciar";
            btnIniciarInmersion.UseVisualStyleBackColor = true;
            btnIniciarInmersion.Click += btnIniciarInmersion_Click;
            // 
            // btnAscender
            // 
            btnAscender.Location = new Point(12, 44);
            btnAscender.Name = "btnAscender";
            btnAscender.Size = new Size(102, 26);
            btnAscender.TabIndex = 1;
            btnAscender.Text = "Ascender\r\n";
            btnAscender.UseVisualStyleBackColor = true;
            btnAscender.Click += btnAscender_Click;
            // 
            // btnDetenerMotor
            // 
            btnDetenerMotor.Location = new Point(12, 76);
            btnDetenerMotor.Name = "btnDetenerMotor";
            btnDetenerMotor.Size = new Size(102, 26);
            btnDetenerMotor.TabIndex = 2;
            btnDetenerMotor.Text = "Detener";
            btnDetenerMotor.UseVisualStyleBackColor = true;
            btnDetenerMotor.Click += btnDetenerMotor_Click;
            // 
            // txtProfundidad
            // 
            txtProfundidad.Location = new Point(172, 12);
            txtProfundidad.Name = "txtProfundidad";
            txtProfundidad.Size = new Size(138, 23);
            txtProfundidad.TabIndex = 3;
            // 
            // listBoxSensores
            // 
            listBoxSensores.FormattingEnabled = true;
            listBoxSensores.ItemHeight = 15;
            listBoxSensores.Location = new Point(172, 41);
            listBoxSensores.Name = "listBoxSensores";
            listBoxSensores.Size = new Size(180, 79);
            listBoxSensores.TabIndex = 4;
            // 
            // progressBarOxigeno
            // 
            progressBarOxigeno.Location = new Point(172, 126);
            progressBarOxigeno.Name = "progressBarOxigeno";
            progressBarOxigeno.Size = new Size(182, 22);
            progressBarOxigeno.TabIndex = 5;
            // 
            // chkLucesExternas
            // 
            chkLucesExternas.AutoSize = true;
            chkLucesExternas.Location = new Point(419, 67);
            chkLucesExternas.Name = "chkLucesExternas";
            chkLucesExternas.Size = new Size(103, 19);
            chkLucesExternas.TabIndex = 6;
            chkLucesExternas.Text = "Luces externas";
            chkLucesExternas.UseVisualStyleBackColor = true;
            chkLucesExternas.CheckedChanged += checkBox_CheckedChanged;
            // 
            // chkCamara
            // 
            chkCamara.AutoSize = true;
            chkCamara.Location = new Point(419, 92);
            chkCamara.Name = "chkCamara";
            chkCamara.Size = new Size(67, 19);
            chkCamara.TabIndex = 7;
            chkCamara.Text = "Camara";
            chkCamara.UseVisualStyleBackColor = true;
            chkCamara.CheckedChanged += checkBox_CheckedChanged;
            // 
            // chkMicrofono
            // 
            chkMicrofono.AutoSize = true;
            chkMicrofono.Location = new Point(419, 117);
            chkMicrofono.Name = "chkMicrofono";
            chkMicrofono.Size = new Size(82, 19);
            chkMicrofono.TabIndex = 8;
            chkMicrofono.Text = "Microfono";
            chkMicrofono.UseVisualStyleBackColor = true;
            chkMicrofono.CheckedChanged += checkBox_CheckedChanged;
            // 
            // dataGridViewPresion
            // 
            dataGridViewPresion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPresion.Location = new Point(132, 187);
            dataGridViewPresion.Name = "dataGridViewPresion";
            dataGridViewPresion.Size = new Size(390, 134);
            dataGridViewPresion.TabIndex = 9;
            dataGridViewPresion.Columns.Add("Profundidad", "Profundidad (m)");
            dataGridViewPresion.Columns.Add("Presion", "Presión (atm)");
            this.Controls.Add(dataGridViewPresion);
            // Inicializar la tabla de presión con valores
            ActualizarPresion();
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.AutoSize = true;
            lblAdvertencia.Location = new Point(172, 160);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(0, 15);
            lblAdvertencia.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAdvertencia);
            Controls.Add(dataGridViewPresion);
            Controls.Add(chkMicrofono);
            Controls.Add(chkCamara);
            Controls.Add(chkLucesExternas);
            Controls.Add(progressBarOxigeno);
            Controls.Add(listBoxSensores);
            Controls.Add(txtProfundidad);
            Controls.Add(btnDetenerMotor);
            Controls.Add(btnAscender);
            Controls.Add(btnIniciarInmersion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPresion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarInmersion;
        private Button btnAscender;
        private Button btnDetenerMotor;
        private TextBox txtProfundidad;
        private ListBox listBoxSensores;
        private ProgressBar progressBarOxigeno;
        private CheckBox chkLucesExternas;
        private CheckBox chkCamara;
        private CheckBox chkMicrofono;
        private DataGridView dataGridViewPresion;
        private Label lblAdvertencia;
    }
}

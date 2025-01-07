namespace CronometroConRegistro
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
            components = new System.ComponentModel.Container();
            btnIniciarDetener = new Button();
            btnRegistrar = new Button();
            btnReiniciar = new Button();
            textBoxNombre = new TextBox();
            labelTiempo = new Label();
            dataGridView1 = new DataGridView();
            NombreColumna = new DataGridViewTextBoxColumn();
            TiempoColumna = new DataGridViewTextBoxColumn();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarDetener
            // 
            btnIniciarDetener.Location = new Point(142, 177);
            btnIniciarDetener.Name = "btnIniciarDetener";
            btnIniciarDetener.Size = new Size(141, 25);
            btnIniciarDetener.TabIndex = 0;
            btnIniciarDetener.Text = "Iniciar / Detener";
            btnIniciarDetener.UseVisualStyleBackColor = true;
            btnIniciarDetener.Click += btnIniciarDetener_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(336, 177);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(119, 25);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(481, 177);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(119, 25);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(391, 67);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(260, 23);
            textBoxNombre.TabIndex = 3;
            textBoxNombre.Text = "Nombre";
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.Location = new Point(173, 75);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(72, 15);
            labelTiempo.TabIndex = 4;
            labelTiempo.Text = "Cronometro";
            labelTiempo.Click += labelTiempo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreColumna, TiempoColumna });
            dataGridView1.Location = new Point(199, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(399, 161);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NombreColumna
            // 
            NombreColumna.HeaderText = "Nombre";
            NombreColumna.Name = "NombreColumna";
            // 
            // TiempoColumna
            // 
            TiempoColumna.HeaderText = "Tiempo";
            TiempoColumna.Name = "TiempoColumna";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(labelTiempo);
            Controls.Add(textBoxNombre);
            Controls.Add(btnReiniciar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnIniciarDetener);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarDetener;
        private Button btnRegistrar;
        private Button btnReiniciar;
        private TextBox textBoxNombre;
        private Label labelTiempo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NombreColumna;
        private DataGridViewTextBoxColumn TiempoColumna;
        private System.Windows.Forms.Timer timer;
    }
}

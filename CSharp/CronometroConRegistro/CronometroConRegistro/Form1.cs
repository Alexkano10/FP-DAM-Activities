namespace CronometroConRegistro
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private bool cronometroActivo = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempo = (DateTime.UtcNow - startTime);
            labelTiempo.Text = tiempo.ToString(@"hh\:mm\:ss");
        }
        private void btnIniciarDetener_Click(object sender, EventArgs e)
        {
            if (!cronometroActivo)
            {
                startTime = DateTime.UtcNow;
                timer.Start();
                btnIniciarDetener.Text = "Detener";
                cronometroActivo = true;
            }
            else
            {
                timer.Stop();
                btnIniciarDetener.Text = "Iniciar";
                cronometroActivo = false;
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNombre.Text) &&
            cronometroActivo)
            {
                TimeSpan tiempoRegistrado = DateTime.UtcNow - startTime;
                dataGridView1.Rows.Add(textBoxNombre.Text,
                tiempoRegistrado.ToString(@"hh\:mm\:ss"));
                textBoxNombre.Clear();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer.Stop();
            labelTiempo.Text = "00:00:00";
            btnIniciarDetener.Text = "Iniciar";
            cronometroActivo = false;
            dataGridView1.Rows.Clear();
        }

        private void labelTiempo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

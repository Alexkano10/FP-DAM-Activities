namespace SubmarinoControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkMicrofono_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarInmersion_Click(object sender, EventArgs e)
        {
            // Simular la inmersión aumentando la profundidad
            for (int i = 0; i <= 1000; i += 50)
            {
                txtProfundidad.Text = i.ToString() + " metros";
                Application.DoEvents(); // Para actualizar la UI durante el bucle
                System.Threading.Thread.Sleep(500); // Simular tiempo de inmersión
            }

        }

        private void btnAscender_Click(object sender, EventArgs e)
        {
            // Simular el ascenso reduciendo la profundidad
            for (int i = Convert.ToInt32(txtProfundidad.Text.Replace(" metros", "")); i
            >= 0; i -= 50)
            {
                txtProfundidad.Text = i.ToString() + " metros";
                Application.DoEvents(); // Para actualizar la UI durante el bucle
                System.Threading.Thread.Sleep(500); // Simular tiempo de ascenso
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // Actualizar sensores en el ListBox y la barra de oxígeno
            listBoxSensores.Items.Clear();
            int oxigenoRestante = progressBarOxigeno.Value;
            if (chkLucesExternas.Checked)
            {
                listBoxSensores.Items.Add("Luces externas activas");
                oxigenoRestante -= 10;
            }
            if (
            chkCamara.Checked)
            {
                listBoxSensores.Items.Add("Cámara de alta definición activa");
                oxigenoRestante -= 15;
            }
            if (
            chkMicrofono.Checked)
            {
                listBoxSensores.Items.Add("Micrófono subacuático activo");
                oxigenoRestante -= 5;
            }
            if (oxigenoRestante >= 0)
                progressBarOxigeno.Value = oxigenoRestante;
            // Mostrar advertencia si el oxígeno es crítico
            if (progressBarOxigeno.Value <= 20)
                lblAdvertencia.Text = "¡Advertencia! Nivel de oxígeno crítico.";
            else
                lblAdvertencia.Text = "";
        }

        private void btnDetenerMotor_Click(object sender, EventArgs e)
        {
            // Detener la simulación
            lblAdvertencia.Text = "Motor detenido.";
        }
        private void ActualizarPresion()
        {
            // Limpiar y actualizar el DataGridView con datos de presión
            dataGridViewPresion.Rows.Clear();
            for (int profundidad = 0; profundidad <= 1000; profundidad += 100)
            {
                double presion = CalcularPresion(profundidad); // Cálculo hipotético
                dataGridViewPresion.Rows.Add(profundidad, presion);
            }
        }
        private double CalcularPresion(int profundidad)
        {
            // Cálculo simple de la presión en función de la profundidad
            return profundidad * 0.1; // Ejemplo de cálculo (presión = profundidad * factor)
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVehiculos
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Credenciales predefinidas en el código
            string usuarioCorrecto = "admin";
            string contrasenaCorrecta = "1234";
            // Verifica si el usuario y la contraseña ingresados son correctos
            if (txtUsuario.Text == usuarioCorrecto && txtContrasena.Text ==
            contrasenaCorrecta)
            {
                // Si las credenciales son correctas, abrir la ventana principal(Form1)
                MessageBox.Show("Inicio de sesión exitoso");
                this.Hide(); // Oculta la ventana de inicio de sesión
                btnGenerarReporte ventanaPrincipal = new btnGenerarReporte();
                ventanaPrincipal.Show();
            }
            else
            {
                // Si las credenciales son incorrectas, mostrar un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

    }
}

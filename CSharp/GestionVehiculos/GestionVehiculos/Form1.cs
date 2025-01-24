using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVehiculos
{
    public partial class Form1 : Form
    {

        string connectionString = "Data Source=DESKTOP-QN60IBE\\SQLEXPRESS;Initial Catalog=TallerMecanicoDB;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new
            SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Vehiculos (Matricula, Modelo,Propietario, FechaIngreso) VALUES (@matricula, @modelo, @propietario, @fechaIngreso)";
                using (SqlCommand command = new SqlCommand(query,
                connection))
                {
                    command.Parameters.AddWithValue("@matricula",
                    txtMatricula.Text);
                    command.Parameters.AddWithValue("@modelo", txtModelo.Text);
                    command.Parameters.AddWithValue("@propietario",
                    txtPropietario.Text);
                    command.Parameters.AddWithValue("@fechaIngreso",
                    dateTimePickerFechaIngreso.Value);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Vehículo agregado correctamente.");
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            using (SqlConnection connection = new
            SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Vehiculos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvVehiculos.DataSource = dataTable;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new
            SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Vehiculos SET Matricula = @matricula,Modelo = @modelo, Propietario = @propietario, FechaIngreso = @fechaIngreso WHERE IdVehiculo = @id";
                using (SqlCommand command = new SqlCommand(query,
                connection))
                {
                    command.Parameters.AddWithValue("@id",
                    Convert.ToInt32(dgvVehiculos.CurrentRow.Cells["IdVehiculo"].Value));
                    command.Parameters.AddWithValue("@matricula",
                    txtMatricula.Text);
                    command.Parameters.AddWithValue("@modelo", txtModelo.Text);
                    command.Parameters.AddWithValue("@propietario",
                    txtPropietario.Text);
                    command.Parameters.AddWithValue("@fechaIngreso",
                    dateTimePickerFechaIngreso.Value);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Vehículo actualizado correctamente.");
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new
            SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Vehiculos WHERE IdVehiculo = @id";
                 using (SqlCommand command = new SqlCommand(query,
                connection))
                {
                    command.Parameters.AddWithValue("@id",
                    Convert.ToInt32(dgvVehiculos.CurrentRow.Cells["IdVehiculo"].Value));
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Vehículo eliminado correctamente.");
                CargarDatos();
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

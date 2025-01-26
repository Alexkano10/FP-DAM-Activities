using System;
using NUnit.Framework;
using System.Data.SqlClient;
using GestionVehiculos;

namespace GestionVehiculosTests
{
    [TestFixture]
    public class VehiculoServiceTests
    {
        private string connectionString = "Data Source=DESKTOP-QN60IBE\\SQLEXPRESS;Initial Catalog=TallerMecanicoDB;Integrated Security=True";
        private SqlConnection connection;

        [SetUp]
        public void Setup()
        {
            // Inicializar la conexión antes de cada prueba
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Assert.Fail($"Error al abrir la conexión: {ex.Message}");
            }
        }

        [TearDown]
        public void TearDown()
        {
            // Limpiar después de cada prueba
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        [Test]
        public void TestInsertarVehiculo()
        {
            // Preparar los datos de prueba
            var matricula = "ABC123";
            var modelo = "Toyota Corolla";
            var propietario = "Juan Perez";
            var fechaIngreso = DateTime.Now;

            string query = @"
                INSERT INTO Vehiculos (Matricula, Modelo, Propietario, FechaIngreso) 
                VALUES (@matricula, @modelo, @propietario, @fechaIngreso)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar los parámetros
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@modelo", modelo);
                    command.Parameters.AddWithValue("@propietario", propietario);
                    command.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);

                    // Ejecutar la inserción y verificar si se afectaron filas
                    int filasAfectadas = command.ExecuteNonQuery();
                    Assert.That(filasAfectadas, Is.GreaterThan(0), "La inserción no afectó ninguna fila.");
                }
            }
            catch (SqlException ex)
            {
                Assert.Fail($"Error al ejecutar el comando SQL: {ex.Message}");
            }
        }

        [Test]
        public void TestConsultarVehiculo()
        {
            // Insertar un vehículo para poder consultarlo
            var matricula = "DEF456";
            var modelo = "Honda Civic";
            var propietario = "Maria Gomez";
            var fechaIngreso = DateTime.Now;

            string insertQuery = "INSERT INTO Vehiculos (Matricula, Modelo, Propietario, FechaIngreso) VALUES (@matricula, @modelo, @propietario, @fechaIngreso)";
            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@matricula", matricula);
                insertCommand.Parameters.AddWithValue("@modelo", modelo);
                insertCommand.Parameters.AddWithValue("@propietario", propietario);
                insertCommand.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                insertCommand.ExecuteNonQuery();
            }

            // Consulta el vehículo insertado
            string selectQuery = "SELECT Matricula, Modelo, Propietario FROM Vehiculos WHERE Matricula = @matricula";
            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
            {
                selectCommand.Parameters.AddWithValue("@matricula", matricula);
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string resultadoMatricula = reader["Matricula"].ToString();
                        string resultadoModelo = reader["Modelo"].ToString();
                        string resultadoPropietario = reader["Propietario"].ToString();

                        Assert.That(resultadoMatricula, Is.EqualTo(matricula));
                        Assert.That(resultadoModelo, Is.EqualTo(modelo));
                        Assert.That(resultadoPropietario, Is.EqualTo(propietario));
                    }
                    else
                    {
                        Assert.Fail("No se encontró el vehículo con la matrícula especificada.");
                    }
                }
            }
        }

        [Test]
        public void TestActualizarVehiculo()
        {
            // Insertar un vehículo para poder actualizarlo
            var matricula = "GHI789";
            var modelo = "Mazda 3";
            var propietario = "Luis Martinez";
            var fechaIngreso = DateTime.Now;

            string insertQuery = "INSERT INTO Vehiculos (Matricula, Modelo, Propietario, FechaIngreso) VALUES (@matricula, @modelo, @propietario, @fechaIngreso)";
            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@matricula", matricula);
                insertCommand.Parameters.AddWithValue("@modelo", modelo);
                insertCommand.Parameters.AddWithValue("@propietario", propietario);
                insertCommand.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                insertCommand.ExecuteNonQuery();
            }

            // Actualizar el propietario del vehículo
            var nuevoPropietario = "Carlos Rodriguez";
            string updateQuery = "UPDATE Vehiculos SET Propietario = @nuevoPropietario WHERE Matricula = @matricula";
            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@nuevoPropietario", nuevoPropietario);
                updateCommand.Parameters.AddWithValue("@matricula", matricula);
                int filasAfectadas = updateCommand.ExecuteNonQuery();
                Assert.That(filasAfectadas, Is.GreaterThan(0), "La actualización no afectó ninguna fila.");
            }

            // Verificar que el propietario se haya actualizado correctamente
            string selectQuery = "SELECT Propietario FROM Vehiculos WHERE Matricula = @matricula";
            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
            {
                selectCommand.Parameters.AddWithValue("@matricula", matricula);
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string resultadoPropietario = reader["Propietario"].ToString();
                        Assert.That(resultadoPropietario, Is.EqualTo(nuevoPropietario), "El propietario no se actualizó correctamente.");
                    }
                    else
                    {
                        Assert.Fail("No se encontró el vehículo para verificar la actualización.");
                    }
                }
            }
        }

        [Test]
        public void TestEliminarVehiculo()
        {
            // Insertar un vehículo para poder eliminarlo
            var matricula = "JKL012";
            var modelo = "Ford Focus";
            var propietario = "Ana Torres";
            var fechaIngreso = DateTime.Now;

            string insertQuery = "INSERT INTO Vehiculos (Matricula, Modelo, Propietario, FechaIngreso) VALUES (@matricula, @modelo, @propietario, @fechaIngreso)";
            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@matricula", matricula);
                insertCommand.Parameters.AddWithValue("@modelo", modelo);
                insertCommand.Parameters.AddWithValue("@propietario", propietario);
                insertCommand.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                insertCommand.ExecuteNonQuery();
            }

            // Eliminar el vehículo
            string deleteQuery = "DELETE FROM Vehiculos WHERE Matricula = @matricula";
            using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
            {
                deleteCommand.Parameters.AddWithValue("@matricula", matricula);
                int filasAfectadas = deleteCommand.ExecuteNonQuery();
                Assert.That(filasAfectadas, Is.GreaterThan(0), "La eliminación no afectó ninguna fila.");
            }

            // Verificar que el vehículo ya no exista
            string selectQuery = "SELECT Matricula FROM Vehiculos WHERE Matricula = @matricula";
            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
            {
                selectCommand.Parameters.AddWithValue("@matricula", matricula);
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    Assert.That(reader.Read(), Is.False, "El vehículo no se eliminó correctamente.");
                }
            }
        }
    }
}


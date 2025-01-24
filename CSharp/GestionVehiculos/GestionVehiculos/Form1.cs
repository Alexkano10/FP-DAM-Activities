using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout.Element;


namespace GestionVehiculos
{
    public partial class btnGenerarReporte : Form
    {

        string connectionString = "Data Source=DESKTOP-QN60IBE\\SQLEXPRESS;Initial Catalog=TallerMecanicoDB;Integrated Security=True";
        public btnGenerarReporte()
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
        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            // Configurar el diálogo para guardar el archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Guardar Reporte de Vehículos",
                FileName = "ReporteVehiculos.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear un flujo para el archivo PDF
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        // Usar el espacio de nombres completo para evitar ambigüedad
                        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);

                        // Asociar el documento al flujo mediante PdfWriter
                        iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);

                        // Abrir el documento para agregar contenido
                        pdfDoc.Open();

                        // Añadir un título al documento
                        pdfDoc.Add(new iTextSharp.text.Paragraph("Reporte de Vehículos"));
                        pdfDoc.Add(new iTextSharp.text.Paragraph(" ")); // Espacio en blanco

                        // Crear una tabla con el número de columnas según el DataGridView
                        iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(dgvVehiculos.Columns.Count);

                        // Añadir las cabeceras de las columnas
                        foreach (DataGridViewColumn column in dgvVehiculos.Columns)
                        {
                            table.AddCell(new iTextSharp.text.Phrase(column.HeaderText));
                        }

                        // Añadir las filas con los datos del DataGridView
                        foreach (DataGridViewRow row in dgvVehiculos.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value != null)
                                {
                                    table.AddCell(new iTextSharp.text.Phrase(cell.Value.ToString()));
                                }
                            }
                        }

                        // Añadir la tabla al documento PDF
                        pdfDoc.Add(table);

                        // Cerrar el documento
                        pdfDoc.Close();
                    }

                    // Notificar al usuario que el reporte fue generado
                    MessageBox.Show("Reporte generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Manejar errores durante la generación del PDF
                    MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

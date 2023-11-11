using NUnit.Framework;
using System.Data;
using System.Data.SqlClient;

[TestFixture]
public class TestStoredProcedure
{
    private const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nava\\source\\repos\\Proyecto_CS\\Repository\\Database.mdf;Integrated Security=True";

    [Test]
    public void CrearCliente_Procedure_Test()
    {
        // Arrange
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();

            // Act
            using (SqlCommand cmd = new SqlCommand("CrearCliente", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_usuario", "TestUsuario");
                cmd.Parameters.AddWithValue("@contrasena", "TestPassword");
                cmd.Parameters.AddWithValue("@direccion", "TestAddress");
                cmd.Parameters.AddWithValue("@correo_electronico", "test@example.com");
                cmd.Parameters.AddWithValue("@telefono", "123456789");

                // Assert
                Assert.DoesNotThrow(() => cmd.ExecuteNonQuery());
            }

            // Realizar las comprobaciones necesarias después de ejecutar el procedimiento
            // (puedes consultar la base de datos para verificar que los datos se insertaron correctamente)

            // Limpiar datos de prueba después de ejecutar el procedimiento

        }
    }


}
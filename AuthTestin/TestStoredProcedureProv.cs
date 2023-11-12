using NUnit.Framework;
using System.Data;
using System.Data.SqlClient;

[TestFixture]
public class TestStoredProcedureProv
{
    private const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nava\\source\\repos\\Proyecto_CS\\Repository\\Database.mdf;Integrated Security=True";

    [Test]
    public void CrearProv_Procedure_Test()
    {
        // Arrange
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();

            // Act
            using (SqlCommand cmd = new SqlCommand("sp_CrearProveedor", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_usuario", "TestUsuario");
                cmd.Parameters.AddWithValue("@contrasena", "TestPassword");
                cmd.Parameters.AddWithValue("@nombre_empresa", "TestCompany");
                cmd.Parameters.AddWithValue("@contacto_nombre", "TestContact");
                cmd.Parameters.AddWithValue("@contacto_telefono", "123456789");
                cmd.Parameters.AddWithValue("@contacto_correo", "test@example.com");
                cmd.Parameters.AddWithValue("@direccion", "TestAddress");
                cmd.Parameters.AddWithValue("@ciudad", "TestCity");
                cmd.Parameters.AddWithValue("@provincia", "TS");
                cmd.Parameters.AddWithValue("@codigo_postal", "12345");
                cmd.Parameters.AddWithValue("@pais", "TestCountry");

                // Assert
                Assert.DoesNotThrow(() => cmd.ExecuteNonQuery());
            }

            // Realizar las comprobaciones necesarias después de ejecutar el procedimiento
            // (puedes consultar la base de datos para verificar que los datos se insertaron correctamente)

            // Limpiar datos de prueba después de ejecutar el procedimiento
        }
    }


}
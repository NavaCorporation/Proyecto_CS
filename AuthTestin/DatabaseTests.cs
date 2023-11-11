using NUnit.Framework;
using System.Data.SqlClient;

namespace AuthTesting
{
    [TestFixture]
    public class DatabaseTests
    {
        private const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nava\\source\\repos\\Proyecto_CS\\Repository\\Database.mdf;Integrated Security=True";

        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void TestCrearUsuarioYCliente()
        {
            // Arrange
            string nombreUsuario = "testUser";
            string contrasena = "testPassword";
            string direccion = "testAddress";
            string correoElectronico = "test@example.com";
            string telefono = "1234567890";

            // Act
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Llama al procedimiento almacenado CrearUsuarioYCliente
                using (SqlCommand command = new SqlCommand("CrearCliente", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
                    command.Parameters.AddWithValue("@contrasena", contrasena);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@correo_electronico", correoElectronico);
                    command.Parameters.AddWithValue("@telefono", telefono);

                    command.ExecuteNonQuery();
                }
            }

            // Assert
            // Afirmaciones para verificar que la operación fue exitosa
            Assert.IsTrue(UsuarioExists(nombreUsuario), "El usuario no se ha insertado correctamente.");
            Assert.IsTrue(ClienteExists(nombreUsuario), "El cliente no se ha insertado correctamente.");
        }

        [TearDown]
        public void TearDown()
        {
            /*// Lógica para limpiar después de todas las pruebas si es necesario
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Eliminar registros adicionales u realizar otras acciones de limpieza
                // Ejemplo: Eliminar todos los registros de las tablas Cliente y Usuario después de todas las pruebas
                using (SqlCommand command = new SqlCommand("DELETE FROM dbo.Cliente", connection))
                {
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand("DELETE FROM dbo.Usuario", connection))
                {
                    command.ExecuteNonQuery();
                }
            }*/
        }

        // Método auxiliar para verificar la existencia de un usuario en la base de datos
        private bool UsuarioExists(string nombreUsuario)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM dbo.Usuario WHERE nombre_usuario = '{nombreUsuario}'", connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Método auxiliar para verificar la existencia de un cliente en la base de datos att// NavaCorp
        private bool ClienteExists(string nombreUsuario)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM dbo.Cliente c JOIN dbo.Usuario u ON c.usuario_id = u.id_usuario WHERE u.nombre_usuario = '{nombreUsuario}'", connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
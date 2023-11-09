using System;
using System.Data.SqlClient;

namespace AuthTesting
{
    public class ConexionSqlServerTests
    {
        private string connectionString;

        public ConexionSqlServerTests()
        {
            // Configura la cadena de conexión a la base de datos de prueba
            string server = "Navarrete\\SQLEXPRESS";
            connectionString = $"Server={server};Database=Proyecto_CS;Integrated Security=True;";
        }

        public void TestConexionSqlServer()
        {
            // Intenta establecer una conexión con la base de datos SQL Server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        Console.WriteLine("La conexión a la base de datos se estableció con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("La conexión a la base de datos no se pudo establecer.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
                }
            }
        }

        public static void Main(string[] args)
        {
            ConexionSqlServerTests conexionSqlServerTests = new ConexionSqlServerTests();
            conexionSqlServerTests.TestConexionSqlServer();
        }
    }
}
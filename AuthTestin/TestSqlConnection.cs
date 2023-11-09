using NUnit.Framework;
using Microsoft.Data.SqlClient;

namespace AuthTestin
{
    public class Tests
    {

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nava\\source\\repos\\Proyecto_CS\\Repository\\Database.mdf;Integrated Security=True";

        [Test]
        public void TestDatabaseConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Assert.AreEqual(System.Data.ConnectionState.Open, connection.State);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
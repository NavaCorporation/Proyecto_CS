using NUnit.Framework;
using Microsoft.Data.SqlClient;

namespace AuthTestin
{
    public class Tests
    {

        private string connectionString = "Data Source=NAVARRETE\\SQLEXPRESS;Initial Catalog=Proyecto_CS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

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
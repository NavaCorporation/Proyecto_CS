using System.Data;
using System.Data.SqlClient;

//Esto es una prueba de dialogo
namespace ProyectoCS_CDatos
{
    public class CD_Connection
    {
        private SqlConnection conexion = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\nava\\source\\repos\\Proyecto_CS\\Repository\\Database.mdf;Integrated Security = True");
        public SqlConnection OpenConnection()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CloseConnection()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
        //Coneccion actual
        public SqlConnection GetCurrentConnection()
        {
            return conexion;
        }
    }
}
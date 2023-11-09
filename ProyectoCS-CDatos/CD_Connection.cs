using System.Data;
using System.Data.SqlClient;


namespace ProyectoCS_CDatos
{
    public class CD_Connection
    {
        //private SqlConnection DB_Connection = new SqlConnection("Server=Navarrete\\SQLEXPRESS;Database=Proyecto_CS; Integrated Security=True");
        static string server = "Navarrete\\SQLEXPRESS";
        private SqlConnection conexion = new SqlConnection("Server=" + server + "; Database=Proyecto_CS; Integrated Security=true");
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
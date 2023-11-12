using ProyectoCS_CDatos;
using System.Data.SqlClient;

namespace ExceptionHandling
{
    public class CE_Log
    {
        private CD_Connection conn = new CD_Connection();

        public string ModuloPorPerfil(string nombreUsuario)
        {
            string perfilUsuario = string.Empty;
            string sqlPerfil = "sp_ObtenerTipoUsuario";
            SqlCommand cmdPerfil = new SqlCommand();
            cmdPerfil.Connection = conn.OpenConnection();
            cmdPerfil.CommandText = sqlPerfil;
            cmdPerfil.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
            perfilUsuario = (string)cmdPerfil.ExecuteScalar();
            conn.CloseConnection();
            return perfilUsuario;
        }
    }
}
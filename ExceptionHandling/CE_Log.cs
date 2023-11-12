using ProyectoCS_CDatos;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

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
        public bool VerificarUsuario(string nombreUsuario)
        {
            string sql = "sp_VerificarNombreUsuarioDuplicado";
            SqlCommand cmdVF = new SqlCommand();
            cmdVF.Connection = conn.OpenConnection();
            cmdVF.CommandText = sql;
            cmdVF.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
            int count = (int)cmdVF.ExecuteScalar();
            conn.CloseConnection();
            return count > 0;
        }
        public bool MailValido(string correoElectronico )
        {
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            //
            return Regex.IsMatch(correoElectronico, patron);
        }



    }
}
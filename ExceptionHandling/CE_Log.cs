using ProyectoCS_CDatos;
using System.Data;
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
            cmdPerfil.CommandType = CommandType.StoredProcedure;
            cmdPerfil.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
            cmdPerfil.CommandText = sqlPerfil;
            SqlDataReader reader = cmdPerfil.ExecuteReader();
            if (reader.Read())
            {
                perfilUsuario = reader["tipo"].ToString();
            }
            reader.Close();
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
        public bool VerificarCorreo(string correo_electronico)
        {
            string sql = "sp_Verificar_correo"; // Corrige el nombre aquí
            SqlCommand cmd = new SqlCommand(sql, conn.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure; // Asegúrate de especificar el tipo de comando como procedimiento almacenado
            cmd.Parameters.AddWithValue("@nombre_usuario", correo_electronico); // Ajusta el nombre del parámetro si es necesario

            int count = (int)cmd.ExecuteScalar();
            conn.CloseConnection();
            return count > 0;
        }
        public string VerContrasena(string correo_electronico)
        {

            string contrasenaRecuperada = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.OpenConnection();
            cmd.CommandText = "sp_VerContraseñaCliente";
            cmd.Parameters.AddWithValue("@correo_electronico", correo_electronico);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                contrasenaRecuperada = reader["ContrasenaCliente"].ToString();

            }
            reader.Close();
            conn.CloseConnection();
            return contrasenaRecuperada;
        }
        public bool VerificarLog(string nombre_usuario, string contrasena)
        {
            string sql = "EXECUTE sp_VerificarLog @nombre_usuario, @contrasena";
            SqlCommand cmd = new SqlCommand(sql, conn.OpenConnection());
            cmd.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
            cmd.Parameters.AddWithValue("@contrasena", contrasena);
            int count = (int)cmd.ExecuteScalar();
            conn.CloseConnection();
            return count > 0;
        }
    }
}
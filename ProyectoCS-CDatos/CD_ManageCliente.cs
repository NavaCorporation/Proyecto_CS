using ProyectoCS_CDatos;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_CS_CNegocio
{
    public class CD_ManageCliente
    {
        private CD_Connection conn = new CD_Connection();

        public bool IngresarCliente(string nombreUsuario, string contrasena, string direccion, string correoElectronico, string telefono) {
            SqlCommand cmdCrearCliente = new SqlCommand();
            cmdCrearCliente.Connection = conn.OpenConnection();
            cmdCrearCliente.CommandType = CommandType.StoredProcedure;
            cmdCrearCliente.CommandText = "EXECUTE sp_CrearCliente @nombre_usuario,@contrasena,@direccion, @correo_electronico, @telefono ";
            // Parámetros del procedimiento almacenado
            cmdCrearCliente.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
            cmdCrearCliente.Parameters.AddWithValue("@contrasena", contrasena);
            cmdCrearCliente.Parameters.AddWithValue("@direccion", direccion);
            cmdCrearCliente.Parameters.AddWithValue("@correo_electronico", correoElectronico);
            cmdCrearCliente.Parameters.AddWithValue("@telefono", telefono);
            // Ejecutar el procedimiento almacenado
            cmdCrearCliente.ExecuteNonQuery();
            conn.CloseConnection();
            return true;
        }




    }
}
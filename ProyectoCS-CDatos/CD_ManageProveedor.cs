using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCS_CDatos
{
    public class CD_ManageProveedor
    {
        private CD_Connection conn = new CD_Connection();

        public bool IngresarProv(string nombreUsuario, string contrasena, string nombreEmpresa, string contactoNombre, string contactoTelefono, string contactoCorreo, string direccion, string ciudad, string provincia, string codigoPostal, string pais) {
            SqlCommand cmdCrearProv = new SqlCommand();
            cmdCrearProv.Connection = conn.OpenConnection();
            cmdCrearProv.CommandType = CommandType.StoredProcedure;
            cmdCrearProv.CommandText = "CrearCliente";
            // Parámetros del procedimiento almacenado
            cmdCrearProv.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
            cmdCrearProv.Parameters.AddWithValue("@contrasena", contrasena);
            cmdCrearProv.Parameters.AddWithValue("@nombre_empresa", nombreEmpresa);
            cmdCrearProv.Parameters.AddWithValue("@contacto_nombre", contactoNombre);
            cmdCrearProv.Parameters.AddWithValue("@contacto_telefono", contactoTelefono);
            cmdCrearProv.Parameters.AddWithValue("@contacto_correo", contactoCorreo);
            cmdCrearProv.Parameters.AddWithValue("@direccion", direccion);
            cmdCrearProv.Parameters.AddWithValue("@ciudad", ciudad);
            cmdCrearProv.Parameters.AddWithValue("@provincia", provincia);
            cmdCrearProv.Parameters.AddWithValue("@codigo_postal", codigoPostal);
            cmdCrearProv.Parameters.AddWithValue("@pais", pais);
            // Ejecutar el procedimiento almacenado
            cmdCrearProv.ExecuteNonQuery();
            conn.CloseConnection();
            return true;
        }

    }
}

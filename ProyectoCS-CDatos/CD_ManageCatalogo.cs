using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCS_CDatos
{
    public class CD_ManageCatalogo
    {
        private CD_Connection conn = new CD_Connection();

        public bool AgregarModelo(string nombreModelo, string descripcion)
        {
            SqlCommand cmdModelo = new SqlCommand();
            cmdModelo.Connection = conn.OpenConnection();
            cmdModelo.CommandType = CommandType.StoredProcedure;
            cmdModelo.CommandText = "sp_InsertarModelo";
            // Parámetros del procedimiento almacenado
            cmdModelo.Parameters.AddWithValue("@nombre_Modelo", nombreModelo);
            cmdModelo.Parameters.AddWithValue("@descripcion", descripcion);
            // Ejecutar el procedimiento almacenado
            cmdModelo.ExecuteNonQuery();
            conn.CloseConnection();
            return true;
        }
        public bool AgregarMarca(byte[] fotoMarca, string nombreMarca,string paisOrigen)
        {
            SqlCommand cmdMarca = new SqlCommand();
            cmdMarca.Connection = conn.OpenConnection();
            cmdMarca.CommandType = CommandType.StoredProcedure;
            cmdMarca.CommandText = "sp_InsertarMarca";
            // Parámetros del procedimiento almacenado
            cmdMarca.Parameters.Add("@foto_marca", SqlDbType.VarBinary).Value = fotoMarca;
            cmdMarca.Parameters.AddWithValue("@nombre_marca", nombreMarca);
            cmdMarca.Parameters.AddWithValue("@pais_origen", paisOrigen);
            // Ejecutar el procedimiento almacenado
            cmdMarca.ExecuteNonQuery();
            conn.CloseConnection();
            return true;
        }
        public bool AgregarTipoProducto(string nombreTipoProducto)
        {
            SqlCommand cmdTipoP = new SqlCommand();
            cmdTipoP.Connection = conn.OpenConnection();
            cmdTipoP.CommandType = CommandType.StoredProcedure;
            cmdTipoP.CommandText = "sp_InsertarTipoProducto";
            // Parámetros del procedimiento almacenado
            cmdTipoP.Parameters.AddWithValue("@nombre_tipo_producto", nombreTipoProducto);
            // Ejecutar el procedimiento almacenado
            cmdTipoP.ExecuteNonQuery();
            conn.CloseConnection();
            return true;
        }
        public bool AgregarAlCatalogo(byte[] fotoProducto, string nombreProducto, decimal precioProducto,
        int idProveedor, int idModelo, int idMarca, int idTipoProducto)
        {
            SqlCommand cmdCatalog = new SqlCommand();
            cmdCatalog.Connection = conn.OpenConnection();
            cmdCatalog.CommandType = CommandType.StoredProcedure;
            cmdCatalog.CommandText = "sp_InsertarProducto";
            // Parámetros del procedimiento almacenado
            cmdCatalog.Parameters.Add("@foto_producto", SqlDbType.VarBinary).Value = fotoProducto;
            cmdCatalog.Parameters.AddWithValue("@nombre_producto", nombreProducto);
            cmdCatalog.Parameters.AddWithValue("@precio_producto", precioProducto);
            cmdCatalog.Parameters.AddWithValue("@id_proveedor", idProveedor);
            cmdCatalog.Parameters.AddWithValue("@id_modelo", idModelo);
            cmdCatalog.Parameters.AddWithValue("@id_marca", idMarca);
            cmdCatalog.Parameters.AddWithValue("@id_tipo_producto", idTipoProducto);
            // Ejecutar el procedimiento almacenado
            cmdCatalog.ExecuteNonQuery();
            conn.CloseConnection();
            return true;
        }

    }
}

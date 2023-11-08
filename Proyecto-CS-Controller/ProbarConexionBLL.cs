// Att/ NavaCorp: Esto es una prueba
using Proyecto_CS.DAL; // Importación de espacio de nombres para acceder a funcionalidades relacionadas con la capa de acceso a datos.
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CS_Controller
{
    public class PruebaConexionBLL
    {
        // Este método intenta abrir una conexión a una base de datos SQL.
        // Recibe una instancia de SqlConnection como parámetro.
        // Devuelve 'true' si la conexión se abre con éxito y 'false' en caso de error. Att// NavaCorp
        public bool ProbarConexion(SqlConnection conexion)
        {
            try
            {
                conexion.Open(); //Se abre la conexion
                return true; // Si no hay exepcion se devuelve 'true'
            }
            catch
            {
                return false; // Si hay una excepción (error) al abrir la conexión, devuelve 'false'.
            }
        }
    }
}

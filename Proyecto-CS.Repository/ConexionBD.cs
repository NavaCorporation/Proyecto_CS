// Att/ NavaCorp: Esta es una prueba
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CS.DAL
{
    public class ConexionBD
    {
        private IConfiguration _configuration;
        // Constructor de la clase que recibe una instancia de IConfiguration para acceder a la configuracióna de la aplicación.
        public ConexionBD(IConfiguration configuration)
        {
            _configuration = configuration; // Almacena la configuración para su uso posterior.
        }
        // Método para obtener una conexión a la base de datos SQL.
        public SqlConnection ObtenerConexion()
        {
            // Obtiene la cadena de conexión desde la configuración usando la clave "cadenaSQL".
            string cadenaConexion = _configuration.GetConnectionString("cadenaSQL");
            // Crea y devuelve una nueva instancia de SqlConnection con la cadena de conexión especificada. Att//NavaCorp
            return new SqlConnection(cadenaConexion);
        }
    }
}

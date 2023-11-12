using ExceptionHandling;
using ProyectoCS_CDatos;
using System.Data;

namespace Proyecto_CS_CNegocio
{

    public class CN_Login
    {
        //Establecemos contacto con el manejador del login
        private CD_ManageLogin manejarLogin = new CD_ManageLogin();
        //Establecemos contacto con el manejador de excepciones
        private CE_Log manejarExceptiones = new CE_Log();
        // Llama a un método en la clase "manejarLogin" para obtener un DataTable.
        public DataTable getDataUsuario()
        {
            return manejarLogin.getDataTable();
        }
        public string ModuloPorPerfil(string username)
        {
            return manejarExceptiones.ModuloPorPerfil(username);
        }
        public bool VerificarUsuario(string nombreUsuario)
        {
            return manejarExceptiones.VerificarUsuario(nombreUsuario);
        }
        public bool MailValido(string correoElectronico)
        {
            return manejarExceptiones.MailValido(correoElectronico);
        }
        public bool VerificarLog(string nombre_usuario, string contrasena)
        {
            return manejarExceptiones.VerificarLog(nombre_usuario, contrasena);
        }
            
        

        //
    }
}

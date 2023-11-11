using ProyectoCS_CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CS_CNegocio
{

    public class CN_Login
    {
        //Establecemos contacto con el manejador del login
        private CD_ManageLogin manejarLog = new CD_ManageLogin();
        // Llama a un método en la clase "manejarLog" para obtener un DataTable.
        public DataTable getDataTable ()
        {
            return manejarLog.getDataTable();
        }

        //
    }
}

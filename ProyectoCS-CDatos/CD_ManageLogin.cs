using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace ProyectoCS_CDatos
{
    public class CD_ManageLogin
    {
        private CD_Connection conn = new CD_Connection();

        public DataTable getDataTable()
        {
            DataTable dt = new DataTable(); //Conectar
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            //Abrir conexion
            cmd.Connection = conn.OpenConnection();
            //Establecer la sentencia SQL a ejecutiar
            adapter = new SqlDataAdapter(cmd);
            //asignar los resultados al datatable
            adapter.Fill(dt);
            conn.CloseConnection();
            return dt;
        }

    }  

    
}

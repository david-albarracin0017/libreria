using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capa_datos.conexion;

namespace capa_datos.model
{
    public class existe_user
    {
        cd_conexion conx = new cd_conexion();
        SqlCommand com = new SqlCommand();
        SqlDataReader leer;

        public bool validacion(string user)
        {
            com.Connection = conx.abrirconexion();
            com.CommandText = "select * from usuario where nombre=@nombre";
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@nombre", user);
            leer = com.ExecuteReader();
            com.Parameters.Clear();

            if (leer.HasRows)
            {
                com.Connection = conx.cerrarconexion();
                return true;
            }


            else
            {
                com.Connection = conx.cerrarconexion();
                return false;
            }
        }

    }
}

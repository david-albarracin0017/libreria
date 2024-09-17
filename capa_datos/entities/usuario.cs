using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capa_datos.conexion;
using capa_common.atributs;

namespace capa_datos.entities
{
    public class usuario
    {
        cd_conexion conx = new cd_conexion();
        SqlCommand com = new SqlCommand();

        public void createuser(atribustsdb obj)
        {
            try
            {
                com.Connection = conx.abrirconexion();
                com.CommandText = "sp_registraruser";
                com.CommandType=CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@nombre", obj.Nombre);
                com.Parameters.AddWithValue("@apellido", obj.Apellido);
                com.Parameters.AddWithValue("@direccion", obj.Direccion);
                com.Parameters.AddWithValue("@telefono", obj.Telefono);
                com.Parameters.AddWithValue("@email", obj.Email);
                com.Parameters.AddWithValue("@contraseña", obj.Contraseña);
                com.ExecuteNonQuery();
                com.Parameters.Clear();



            }
            catch(Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                com.Connection = conx.cerrarconexion();
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capa_common.cache;
using capa_datos.conexion;

namespace capa_datos.model
{
    public class login_user
    {
        cd_conexion conx = new cd_conexion();
        SqlCommand com = new SqlCommand();
        SqlDataReader leer;

        public bool login(string user,string pass)
        {
            com.Connection = conx.abrirconexion();
            com.CommandText = "select * from usuario where nombre=@nombre and contraseña=@contraseña";
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@nombre",user);
            com.Parameters.AddWithValue("@contraseña", pass);
            leer = com.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    atributos_user.usuarioid = leer.GetInt32(0);
                    atributos_user.nombre = leer.GetString(1);
                    atributos_user.apellido = leer.GetString(2);
                    atributos_user.direccion = leer.GetString(3);
                    atributos_user.telefono = leer.GetString(4);
                    atributos_user.email = leer.GetString(5);
                    atributos_user.contraseña = leer.GetString(6);
                }
                return true;
            }
            else return false;
        }

    }
}

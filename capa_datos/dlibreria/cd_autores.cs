using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capa_datos.conexion;

namespace capa_datos.dlibreria
{
    public class cd_autores
    {
        private cd_conexion conx = new cd_conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable mostrar()
        {
            cmd.Connection = conx.abrirconexion();
            cmd.CommandText = "select * from autores";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conx.cerrarconexion();
            return tabla;

        }

        public void insertar(string nombre,string apellido,string nacionalidad,DateTime nacimiento)
        {
            cmd.Connection = conx.abrirconexion();
            cmd.CommandText = "insert into autores values('"+nombre+ "','"+apellido+ "','"+nacionalidad+ "','"+nacimiento+"')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        
    }
}

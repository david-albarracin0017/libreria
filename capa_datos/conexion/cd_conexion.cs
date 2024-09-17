using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos.conexion
{
    public class cd_conexion
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-TQ7DC3D\\SQLEXPRESS;database=biblioteca;integrated security=true");
        public SqlConnection abrirconexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection cerrarconexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

    }
}
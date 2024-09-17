using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capa_datos.dlibreria;

namespace capa_dominio.cnlibreria
{
    public class cn_autores
    {
        private cd_autores cdautores = new cd_autores();
        public DataTable mostrara()
        {
            DataTable tabla = new DataTable();
            tabla = cdautores.mostrar();
            return tabla;
        }

        public void insertaraut(string nombre, string apellido, string nacionalidad, string nacimiento)
        {
            cdautores.insertar(nombre, apellido, nacionalidad, DateTime.Parse(nacimiento));
        }
    }
}

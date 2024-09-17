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
    public class cn_libros
    {
        private cd_libros cdlibros = new cd_libros();
        public DataTable mostrarl()
        {
            DataTable tabla = new DataTable();
            tabla = cdlibros.mostrar();
            return tabla;
        }

        public void insertarlibros(string titulo, string isbn, string editorialid, string año,string paginas)
        {
            cdlibros.insertarl(titulo, isbn, Convert.ToInt32(editorialid),Convert.ToInt32(año),Convert.ToInt32(paginas));
        }

        public void editarlibro(string titulo, string isbn, string editorialid, string año, string paginas,string libroid)
        {
            cdlibros.editar(titulo, isbn, Convert.ToInt32(editorialid), Convert.ToInt32(año), Convert.ToInt32(paginas), Convert.ToInt32(libroid));
        }

        public void eliminarlibro(string libroid)
        {
            cdlibros.eliminar(Convert.ToInt32(libroid));
        }
    }
}

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
    public class cd_libros
    {
        private cd_conexion conx = new cd_conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable mostrar()
        {
            cmd.Connection = conx.abrirconexion();
            cmd.CommandText = "select * from libros";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conx.cerrarconexion();
            return tabla;

        }

        public void insertarl(string titulo, string isbn, int editorialid, int año,int paginas)
        {
            cmd.Connection = conx.abrirconexion();
            cmd.CommandText = "sp_AgregarLibro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.Parameters.AddWithValue("@editorialid", editorialid);
            cmd.Parameters.AddWithValue("@año", año);
            cmd.Parameters.AddWithValue("@paginas", paginas);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void editar(string titulo, string isbn, int editorialid, int año, int paginas,int libroid)
        {
            cmd.Connection = conx.abrirconexion();
            cmd.CommandText = "sp_ModificarLibro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.Parameters.AddWithValue("@editorialid", editorialid);
            cmd.Parameters.AddWithValue("@año", año);
            cmd.Parameters.AddWithValue("@paginas", paginas);
            cmd.Parameters.AddWithValue("@libroid", libroid);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void eliminar(int libroid)
        {
            cmd.Connection = conx.abrirconexion();
            cmd.CommandText = "sp_EliminarLibro";
            cmd.Parameters.AddWithValue("@libroid", libroid);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

    }
}

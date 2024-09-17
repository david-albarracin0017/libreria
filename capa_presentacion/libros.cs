using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_dominio.cnlibreria;

namespace capa_presentacion
{
    public partial class libros : Form
    {
        cn_libros cnlibros = new cn_libros();
        private string libroid = null;
        private bool editarr = false;
        private static libros instancia = null;
        public static libros unica()
        {
            if(instancia == null)
            {
                instancia = new libros();
                return instancia;
            }
            return instancia;
        }
        public libros()
        {
            InitializeComponent();
        }

        private void libros_Load(object sender, EventArgs e)
        {
            mostrarlibros();
        }
        private void mostrarlibros()
        {
            cn_libros objt = new cn_libros();
            dataGridView1.DataSource = objt.mostrarl();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (editarr == false)
            {
                try
                {
                    cnlibros.insertarlibros(titulotxt.Text, isbntxt.Text, editorialidtxt.Text, añotxt.Text, paginastxt.Text);
                    MessageBox.Show("datos ingresados");
                    mostrarlibros();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar datos" + ex);
                }
            }

            if (editarr == true)
            {
                try
                {
                    cnlibros.editarlibro(titulotxt.Text, isbntxt.Text, editorialidtxt.Text, añotxt.Text, paginastxt.Text, libroid);
                    MessageBox.Show("datos actualizados");
                    mostrarlibros();
                    limpiar();
                    editarr=false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("no se pudo insertar datos" + ex);
                }
            }
            

        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editarr = true;
                titulotxt.Text = dataGridView1.CurrentRow.Cells["titulo"].Value.ToString();
                isbntxt.Text = dataGridView1.CurrentRow.Cells["isbn"].Value.ToString();
                editorialidtxt.Text = dataGridView1.CurrentRow.Cells["editorialid"].Value.ToString();
                añotxt.Text = dataGridView1.CurrentRow.Cells["año"].Value.ToString();
                paginastxt.Text = dataGridView1.CurrentRow.Cells["paginas"].Value.ToString();
                libroid = dataGridView1.CurrentRow.Cells["libroid"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione la fila a editar");
        }

        private void limpiar()
        {
            titulotxt.Clear();
            isbntxt.Clear();
            editorialidtxt.Clear();
            añotxt.Clear();
            paginastxt.Clear();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                libroid = dataGridView1.CurrentRow.Cells["libroid"].Value.ToString();
                cnlibros.eliminarlibro(libroid);
                MessageBox.Show("Eliminacion Exitosa");
                mostrarlibros();
            }
            else
                MessageBox.Show("Seleccione la fila a eliminar");
        }
    }
}

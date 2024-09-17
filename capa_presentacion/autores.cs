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
    public partial class autores : Form
    {
        cn_autores cnautores = new cn_autores();
        private static autores instancia = null;
        public static autores unicav()
        {
            if (instancia == null)
            {
                instancia = new autores();
                return instancia;
            }
            return instancia;
        }
        public autores()
        {
            InitializeComponent();
        }

        private void autores_Load(object sender, EventArgs e)
        {
            mostrarautores();
        }
        private void mostrarautores()
        {
            dataGridView1.DataSource = cnautores.mostrara();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            try
            {
                cnautores.insertaraut(nombretxt.Text, apellidotxt.Text, nacionalidadtxt.Text, nacimientotxt.Text);
                MessageBox.Show("datos ingresados");
                mostrarautores();
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se pudo insertar datos"+ex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_common.cache;


namespace capa_presentacion
{
    public partial class libreria : Form
    {
        public libreria()
        {
            InitializeComponent();
        }

        private void libreria_Load(object sender, EventArgs e)
        {
            bienvenidotxt.Text = $"Bienvenido: {atributos_user.nombre}{atributos_user.apellido}";
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            libros libros = libros.unica();
            libros.MdiParent = this;
            libros.Show();
            libros.BringToFront();
        }

        private void btautoress_Click(object sender, EventArgs e)
        {
            autores autores = autores.unicav();
            autores.MdiParent = this;
            autores.Show();
            autores.BringToFront();
        }

        private void btminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

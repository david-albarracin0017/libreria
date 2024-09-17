using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using capa_dominio.modelos;

namespace capa_presentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam,int lparam);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (nombretxt.Text == "NOMBRE:")
            {
                nombretxt.Text = "";
                nombretxt.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (nombretxt.Text == "")
            {
                nombretxt.Text = "NOMBRE:";
                nombretxt.ForeColor = Color.DimGray;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (passtxt.Text == "CONTRASEÑA:")
            {
                passtxt.Text = "";
                passtxt.ForeColor = Color.Black;
                passtxt.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (passtxt.Text == "")
            {
                passtxt.Text = "CONTRASEÑA:";
                passtxt.ForeColor = Color.DimGray;
                passtxt.UseSystemPasswordChar = false;

            }
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this. Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btregistrarse_Click(object sender, EventArgs e)
        {
            registro registro = new registro();
            registro.Show();
            this.Hide();
            registro.FormClosed += closeform;
        }
        private void closeform(object sender,FormClosedEventArgs e)
        {
            this.Show();
            nombretxt.Focus();
            nombretxt.Text = "";
            passtxt.Text = "";
        }

        private void btingresar_Click(object sender, EventArgs e)
        {
            if (nombretxt.Text != "")
            {
                if (passtxt.Text != "")
                {
                    dlogin usermodel = new dlogin();
                    var validate = usermodel.loginp(nombretxt.Text,passtxt.Text);
                    if (validate)
                    {
                        this.Hide();
                        libreria aplicacion = new libreria();
                        aplicacion.Show();
                        aplicacion.FormClosed += closeform;

                    }
                    else MessageBox.Show("usuario o contraseña incorectos");
                    
                }
                else MessageBox.Show("Contraseña Incorrecta");

            }
            else MessageBox.Show("Usuario incorrecto");
            
        }
    }
}

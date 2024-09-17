using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_dominio.crud;
using capa_dominio.modelos;
using capa_common.atributs;

namespace capa_presentacion
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        dusuario dusuario = new dusuario();
        atribustsdb atributos = new atribustsdb();
        dexiste exis = new dexiste();

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (nombretxt.Text == "" || apellidotxt.Text == "" || direcciontxt.Text == "" || telefonotxt.Text == "" || correotxt.Text == "" || passtxt.Text == "")
            {
                MessageBox.Show("Campos Incompletos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //..
                atributos.Nombre = nombretxt.Text;
                atributos.Apellido = apellidotxt.Text;
                atributos.Direccion = direcciontxt.Text;
                atributos.Telefono = telefonotxt.Text;
                atributos.Email = correotxt.Text;
                atributos.Contraseña = passtxt.Text;

                var existe = exis.validateuser(nombretxt.Text);//valida si el ususario existe
                if (existe) MessageBox.Show("Este usuario ya esta registrado!", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    dusuario.create(atributos);
                    MessageBox.Show("Se a registrado exitosamente","registrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    nombretxt.Text = "";
                    apellidotxt.Text = "";
                    direcciontxt.Text = "";
                    telefonotxt.Text = "";
                    correotxt.Text = "";
                    passtxt.Text = "";
                }
            }
        }
    }
}

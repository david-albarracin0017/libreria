namespace capa_presentacion
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btingresar = new System.Windows.Forms.Button();
            this.btregistrarse = new System.Windows.Forms.Button();
            this.btcerrar = new System.Windows.Forms.PictureBox();
            this.btmini = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmini)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 374);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "LIBRERIA";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // nombretxt
            // 
            this.nombretxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombretxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombretxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretxt.Location = new System.Drawing.Point(264, 114);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(342, 20);
            this.nombretxt.TabIndex = 1;
            this.nombretxt.Text = "NOMBRE:";
            this.nombretxt.Enter += new System.EventHandler(this.textBox1_Enter);
            this.nombretxt.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passtxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(264, 154);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(342, 20);
            this.passtxt.TabIndex = 2;
            this.passtxt.Text = "CONTRASEÑA:";
            this.passtxt.Enter += new System.EventHandler(this.textBox2_Enter);
            this.passtxt.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "INGRESO";
            // 
            // btingresar
            // 
            this.btingresar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btingresar.FlatAppearance.BorderSize = 0;
            this.btingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btingresar.ForeColor = System.Drawing.Color.White;
            this.btingresar.Location = new System.Drawing.Point(315, 252);
            this.btingresar.Name = "btingresar";
            this.btingresar.Size = new System.Drawing.Size(267, 30);
            this.btingresar.TabIndex = 3;
            this.btingresar.Text = "INGRESAR";
            this.btingresar.UseVisualStyleBackColor = false;
            this.btingresar.Click += new System.EventHandler(this.btingresar_Click);
            // 
            // btregistrarse
            // 
            this.btregistrarse.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btregistrarse.FlatAppearance.BorderSize = 0;
            this.btregistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btregistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btregistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btregistrarse.ForeColor = System.Drawing.Color.White;
            this.btregistrarse.Location = new System.Drawing.Point(315, 297);
            this.btregistrarse.Name = "btregistrarse";
            this.btregistrarse.Size = new System.Drawing.Size(267, 30);
            this.btregistrarse.TabIndex = 0;
            this.btregistrarse.Text = "REGISTRARSE";
            this.btregistrarse.UseVisualStyleBackColor = false;
            this.btregistrarse.Click += new System.EventHandler(this.btregistrarse_Click);
            // 
            // btcerrar
            // 
            this.btcerrar.Image = ((System.Drawing.Image)(resources.GetObject("btcerrar.Image")));
            this.btcerrar.Location = new System.Drawing.Point(702, 0);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(25, 25);
            this.btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btcerrar.TabIndex = 6;
            this.btcerrar.TabStop = false;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // btmini
            // 
            this.btmini.Image = ((System.Drawing.Image)(resources.GetObject("btmini.Image")));
            this.btmini.Location = new System.Drawing.Point(671, 0);
            this.btmini.Name = "btmini";
            this.btmini.Size = new System.Drawing.Size(25, 25);
            this.btmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btmini.TabIndex = 7;
            this.btmini.TabStop = false;
            this.btmini.Click += new System.EventHandler(this.btmini_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(726, 374);
            this.Controls.Add(this.btmini);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.btregistrarse);
            this.Controls.Add(this.btingresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btingresar;
        private System.Windows.Forms.Button btregistrarse;
        private System.Windows.Forms.PictureBox btcerrar;
        private System.Windows.Forms.PictureBox btmini;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}


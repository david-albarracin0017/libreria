namespace capa_presentacion
{
    partial class libreria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libreria));
            this.bienvenidotxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btclose = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btautoress = new System.Windows.Forms.ToolStripTextBox();
            this.btminimizar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btclose)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // bienvenidotxt
            // 
            this.bienvenidotxt.AutoSize = true;
            this.bienvenidotxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenidotxt.ForeColor = System.Drawing.Color.White;
            this.bienvenidotxt.Location = new System.Drawing.Point(12, 9);
            this.bienvenidotxt.Name = "bienvenidotxt";
            this.bienvenidotxt.Size = new System.Drawing.Size(75, 25);
            this.bienvenidotxt.TabIndex = 1;
            this.bienvenidotxt.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.bienvenidotxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 49);
            this.panel1.TabIndex = 2;
            // 
            // btclose
            // 
            this.btclose.Image = ((System.Drawing.Image)(resources.GetObject("btclose.Image")));
            this.btclose.Location = new System.Drawing.Point(992, 0);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(37, 31);
            this.btclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btclose.TabIndex = 2;
            this.btclose.TabStop = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.btautoress});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.White;
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "libros";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // btautoress
            // 
            this.btautoress.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btautoress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btautoress.ForeColor = System.Drawing.Color.White;
            this.btautoress.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btautoress.Name = "btautoress";
            this.btautoress.Size = new System.Drawing.Size(100, 23);
            this.btautoress.Text = "autores";
            this.btautoress.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btautoress.Click += new System.EventHandler(this.btautoress_Click);
            // 
            // btminimizar
            // 
            this.btminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btminimizar.Image")));
            this.btminimizar.Location = new System.Drawing.Point(949, 0);
            this.btminimizar.Name = "btminimizar";
            this.btminimizar.Size = new System.Drawing.Size(37, 31);
            this.btminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btminimizar.TabIndex = 6;
            this.btminimizar.TabStop = false;
            this.btminimizar.Click += new System.EventHandler(this.btminimizar_Click);
            // 
            // libreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 636);
            this.Controls.Add(this.btminimizar);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "libreria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "libreria";
            this.Load += new System.EventHandler(this.libreria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btclose)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenidotxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btclose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox btautoress;
        private System.Windows.Forms.PictureBox btminimizar;
    }
}
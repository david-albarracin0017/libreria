namespace capa_presentacion
{
    partial class libros
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.titulotxt = new System.Windows.Forms.TextBox();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editorialidtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.añotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paginastxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btguardar = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "TITULO";
            // 
            // titulotxt
            // 
            this.titulotxt.Location = new System.Drawing.Point(673, 22);
            this.titulotxt.Name = "titulotxt";
            this.titulotxt.Size = new System.Drawing.Size(240, 20);
            this.titulotxt.TabIndex = 2;
            // 
            // isbntxt
            // 
            this.isbntxt.Location = new System.Drawing.Point(673, 62);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(240, 20);
            this.isbntxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISBN";
            // 
            // editorialidtxt
            // 
            this.editorialidtxt.Location = new System.Drawing.Point(673, 102);
            this.editorialidtxt.Name = "editorialidtxt";
            this.editorialidtxt.Size = new System.Drawing.Size(240, 20);
            this.editorialidtxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "EDITORIALID";
            // 
            // añotxt
            // 
            this.añotxt.Location = new System.Drawing.Point(673, 145);
            this.añotxt.Name = "añotxt";
            this.añotxt.Size = new System.Drawing.Size(240, 20);
            this.añotxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "AÑO";
            // 
            // paginastxt
            // 
            this.paginastxt.Location = new System.Drawing.Point(673, 188);
            this.paginastxt.Name = "paginastxt";
            this.paginastxt.Size = new System.Drawing.Size(240, 20);
            this.paginastxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(568, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "PAGINAS";
            // 
            // btguardar
            // 
            this.btguardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btguardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar.ForeColor = System.Drawing.Color.White;
            this.btguardar.Location = new System.Drawing.Point(655, 236);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(267, 34);
            this.btguardar.TabIndex = 11;
            this.btguardar.Text = "GUARDAR";
            this.btguardar.UseVisualStyleBackColor = false;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // bteditar
            // 
            this.bteditar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bteditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditar.ForeColor = System.Drawing.Color.White;
            this.bteditar.Location = new System.Drawing.Point(13, 337);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(86, 32);
            this.bteditar.TabIndex = 12;
            this.bteditar.Text = "EDITAR";
            this.bteditar.UseVisualStyleBackColor = false;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bteliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.ForeColor = System.Drawing.Color.White;
            this.bteliminar.Location = new System.Drawing.Point(129, 336);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(86, 32);
            this.bteliminar.TabIndex = 13;
            this.bteliminar.Text = "ELIMINAR";
            this.bteliminar.UseVisualStyleBackColor = false;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 464);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.paginastxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.añotxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editorialidtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isbntxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titulotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "libros";
            this.Load += new System.EventHandler(this.libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titulotxt;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editorialidtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox añotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paginastxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button bteliminar;
    }
}
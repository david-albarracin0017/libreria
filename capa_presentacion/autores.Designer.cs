namespace capa_presentacion
{
    partial class autores
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
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apellidotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nacionalidadtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nacimientotxt = new System.Windows.Forms.TextBox();
            this.btguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(710, 13);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(203, 20);
            this.nombretxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "APELLIDO";
            // 
            // apellidotxt
            // 
            this.apellidotxt.Location = new System.Drawing.Point(710, 48);
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(203, 20);
            this.apellidotxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "NACIONALIDAD";
            // 
            // nacionalidadtxt
            // 
            this.nacionalidadtxt.Location = new System.Drawing.Point(710, 85);
            this.nacionalidadtxt.Name = "nacionalidadtxt";
            this.nacionalidadtxt.Size = new System.Drawing.Size(203, 20);
            this.nacionalidadtxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "NACIMIENTO";
            // 
            // nacimientotxt
            // 
            this.nacimientotxt.Location = new System.Drawing.Point(710, 122);
            this.nacimientotxt.Name = "nacimientotxt";
            this.nacimientotxt.Size = new System.Drawing.Size(203, 20);
            this.nacimientotxt.TabIndex = 7;
            // 
            // btguardar
            // 
            this.btguardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btguardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar.ForeColor = System.Drawing.Color.White;
            this.btguardar.Location = new System.Drawing.Point(628, 179);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(285, 33);
            this.btguardar.TabIndex = 9;
            this.btguardar.Text = "GUARDAR";
            this.btguardar.UseVisualStyleBackColor = false;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(925, 464);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nacimientotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nacionalidadtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellidotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "autores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "autores";
            this.Load += new System.EventHandler(this.autores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellidotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nacionalidadtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nacimientotxt;
        private System.Windows.Forms.Button btguardar;
    }
}
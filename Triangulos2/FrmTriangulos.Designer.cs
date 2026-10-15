namespace Triangulos2
{
    partial class FrmTriangulos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTriangulos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.nudLado3 = new System.Windows.Forms.NumericUpDown();
            this.nudLado1 = new System.Windows.Forms.NumericUpDown();
            this.nudLado2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ldlTipo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTpo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picEquilatero = new System.Windows.Forms.PictureBox();
            this.picEscaleno = new System.Windows.Forms.PictureBox();
            this.picIsosceles = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEquilatero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEscaleno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIsosceles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.btnAnalisar);
            this.panel1.Controls.Add(this.nudLado3);
            this.panel1.Controls.Add(this.nudLado1);
            this.panel1.Controls.Add(this.nudLado2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(40, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 304);
            this.panel1.TabIndex = 0;
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAnalisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnalisar.FlatAppearance.BorderSize = 0;
            this.btnAnalisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnalisar.Location = new System.Drawing.Point(120, 224);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(104, 32);
            this.btnAnalisar.TabIndex = 9;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = false;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // nudLado3
            // 
            this.nudLado3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudLado3.Location = new System.Drawing.Point(120, 176);
            this.nudLado3.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLado3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLado3.Name = "nudLado3";
            this.nudLado3.Size = new System.Drawing.Size(104, 29);
            this.nudLado3.TabIndex = 8;
            this.nudLado3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLado3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLado3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // nudLado1
            // 
            this.nudLado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nudLado1.Location = new System.Drawing.Point(120, 96);
            this.nudLado1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLado1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLado1.Name = "nudLado1";
            this.nudLado1.Size = new System.Drawing.Size(104, 29);
            this.nudLado1.TabIndex = 7;
            this.nudLado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLado1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudLado2
            // 
            this.nudLado2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nudLado2.Location = new System.Drawing.Point(120, 136);
            this.nudLado2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLado2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLado2.Name = "nudLado2";
            this.nudLado2.Size = new System.Drawing.Size(104, 29);
            this.nudLado2.TabIndex = 6;
            this.nudLado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLado2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lado 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Informe os 3 lados do triângulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lado 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vamos descobrir os tipos de triângulos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lado 1:";
            // 
            // ldlTipo
            // 
            this.ldlTipo.AutoSize = true;
            this.ldlTipo.BackColor = System.Drawing.Color.Black;
            this.ldlTipo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlTipo.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.ldlTipo.Location = new System.Drawing.Point(64, 40);
            this.ldlTipo.Name = "ldlTipo";
            this.ldlTipo.Size = new System.Drawing.Size(184, 21);
            this.ldlTipo.TabIndex = 6;
            this.ldlTipo.Text = "Descobrindo Triangulos";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label7.Location = new System.Drawing.Point(376, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tipo do Triângulo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblTpo
            // 
            this.lblTpo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpo.ForeColor = System.Drawing.Color.White;
            this.lblTpo.Location = new System.Drawing.Point(376, 320);
            this.lblTpo.Name = "lblTpo";
            this.lblTpo.Size = new System.Drawing.Size(224, 40);
            this.lblTpo.TabIndex = 9;
            this.lblTpo.Text = "???";
            this.lblTpo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // picEquilatero
            // 
            this.picEquilatero.Image = ((System.Drawing.Image)(resources.GetObject("picEquilatero.Image")));
            this.picEquilatero.Location = new System.Drawing.Point(384, 56);
            this.picEquilatero.Name = "picEquilatero";
            this.picEquilatero.Size = new System.Drawing.Size(192, 224);
            this.picEquilatero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEquilatero.TabIndex = 11;
            this.picEquilatero.TabStop = false;
            this.picEquilatero.Visible = false;
            // 
            // picEscaleno
            // 
            this.picEscaleno.Image = ((System.Drawing.Image)(resources.GetObject("picEscaleno.Image")));
            this.picEscaleno.Location = new System.Drawing.Point(360, 48);
            this.picEscaleno.Name = "picEscaleno";
            this.picEscaleno.Size = new System.Drawing.Size(256, 232);
            this.picEscaleno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEscaleno.TabIndex = 12;
            this.picEscaleno.TabStop = false;
            this.picEscaleno.Visible = false;
            this.picEscaleno.Click += new System.EventHandler(this.picEscaleno_Click);
            // 
            // picIsosceles
            // 
            this.picIsosceles.Image = ((System.Drawing.Image)(resources.GetObject("picIsosceles.Image")));
            this.picIsosceles.Location = new System.Drawing.Point(376, 24);
            this.picIsosceles.Name = "picIsosceles";
            this.picIsosceles.Size = new System.Drawing.Size(224, 248);
            this.picIsosceles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIsosceles.TabIndex = 13;
            this.picIsosceles.TabStop = false;
            this.picIsosceles.Visible = false;
            // 
            // FrmTriangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(620, 392);
            this.Controls.Add(this.picIsosceles);
            this.Controls.Add(this.picEscaleno);
            this.Controls.Add(this.picEquilatero);
            this.Controls.Add(this.lblTpo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ldlTipo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTriangulos";
            this.Text = "Descubra o tipo de Triangulo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEquilatero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEscaleno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIsosceles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ldlTipo;
        private System.Windows.Forms.NumericUpDown nudLado3;
        private System.Windows.Forms.NumericUpDown nudLado1;
        private System.Windows.Forms.NumericUpDown nudLado2;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTpo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picEquilatero;
        private System.Windows.Forms.PictureBox picEscaleno;
        private System.Windows.Forms.PictureBox picIsosceles;
    }
}


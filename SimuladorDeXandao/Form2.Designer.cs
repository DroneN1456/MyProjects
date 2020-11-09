namespace SimuladorDeXandao
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblVida = new System.Windows.Forms.Label();
            this.tUpdate = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lblSuaVida = new System.Windows.Forms.Label();
            this.tDano = new System.Windows.Forms.Timer(this.components);
            this.btnAtacar = new System.Windows.Forms.Button();
            this.tFinal = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SimuladorDeXandao.Properties.Resources.feminista;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 207);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(88, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Feminista";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(344, 377);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(421, 49);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 1000;
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.BackColor = System.Drawing.Color.Transparent;
            this.lblVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.ForeColor = System.Drawing.Color.Lime;
            this.lblVida.Location = new System.Drawing.Point(470, 337);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(166, 37);
            this.lblVida.TabIndex = 3;
            this.lblVida.Text = "1000/1000";
            // 
            // tUpdate
            // 
            this.tUpdate.Enabled = true;
            this.tUpdate.Interval = 1;
            this.tUpdate.Tick += new System.EventHandler(this.tUpdate_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(13, 13);
            this.progressBar2.Maximum = 1000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(752, 31);
            this.progressBar2.TabIndex = 4;
            this.progressBar2.Value = 1000;
            // 
            // lblSuaVida
            // 
            this.lblSuaVida.AutoSize = true;
            this.lblSuaVida.BackColor = System.Drawing.Color.Transparent;
            this.lblSuaVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuaVida.ForeColor = System.Drawing.Color.Lime;
            this.lblSuaVida.Location = new System.Drawing.Point(320, 47);
            this.lblSuaVida.Name = "lblSuaVida";
            this.lblSuaVida.Size = new System.Drawing.Size(166, 37);
            this.lblSuaVida.TabIndex = 5;
            this.lblSuaVida.Text = "1000/1000";
            // 
            // tDano
            // 
            this.tDano.Enabled = true;
            this.tDano.Interval = 2000;
            this.tDano.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(591, 176);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(174, 46);
            this.btnAtacar.TabIndex = 6;
            this.btnAtacar.Text = "Argumentar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // tFinal
            // 
            this.tFinal.Interval = 3000;
            this.tFinal.Tick += new System.EventHandler(this.tFinal_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimuladorDeXandao.Properties.Resources.terraplana;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.lblSuaVida);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Terra Plana";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Timer tUpdate;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lblSuaVida;
        private System.Windows.Forms.Timer tDano;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Timer tFinal;
    }
}
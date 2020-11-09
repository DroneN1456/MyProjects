namespace SimuladorDeXandao
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkAuto = new System.Windows.Forms.CheckBox();
            this.lblFarmar4 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.btnFarmar4 = new System.Windows.Forms.Button();
            this.lblFarmar3 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.btnFarmar3 = new System.Windows.Forms.Button();
            this.lblFarm2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btnFarmar2 = new System.Windows.Forms.Button();
            this.lblFarmar1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnFarmar1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnComprar3 = new System.Windows.Forms.Button();
            this.lblLoja3 = new System.Windows.Forms.Label();
            this.btnComprar2 = new System.Windows.Forms.Button();
            this.lblLoja2 = new System.Windows.Forms.Label();
            this.btnComprar1 = new System.Windows.Forms.Button();
            this.lblLoja1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblViewers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.tFarm1 = new System.Windows.Forms.Timer(this.components);
            this.tUpdate = new System.Windows.Forms.Timer(this.components);
            this.tFarm2 = new System.Windows.Forms.Timer(this.components);
            this.tFarm3 = new System.Windows.Forms.Timer(this.components);
            this.tFarm4 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tBoost1 = new System.Windows.Forms.Timer(this.components);
            this.tBoost2 = new System.Windows.Forms.Timer(this.components);
            this.lblSeconds = new System.Windows.Forms.Label();
            this.tBoost3 = new System.Windows.Forms.Timer(this.components);
            this.tXandao = new System.Windows.Forms.Timer(this.components);
            this.tXandao2 = new System.Windows.Forms.Timer(this.components);
            this.tViewer = new System.Windows.Forms.Timer(this.components);
            this.lblLoja4 = new System.Windows.Forms.Label();
            this.btnComprar4 = new System.Windows.Forms.Button();
            this.btnTerraPlana = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(19, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTerraPlana);
            this.tabPage1.Controls.Add(this.checkAuto);
            this.tabPage1.Controls.Add(this.lblFarmar4);
            this.tabPage1.Controls.Add(this.progressBar4);
            this.tabPage1.Controls.Add(this.btnFarmar4);
            this.tabPage1.Controls.Add(this.lblFarmar3);
            this.tabPage1.Controls.Add(this.progressBar3);
            this.tabPage1.Controls.Add(this.btnFarmar3);
            this.tabPage1.Controls.Add(this.lblFarm2);
            this.tabPage1.Controls.Add(this.progressBar2);
            this.tabPage1.Controls.Add(this.btnFarmar2);
            this.tabPage1.Controls.Add(this.lblFarmar1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.btnFarmar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ganhar Dinheiro";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // checkAuto
            // 
            this.checkAuto.AutoSize = true;
            this.checkAuto.Location = new System.Drawing.Point(622, 304);
            this.checkAuto.Name = "checkAuto";
            this.checkAuto.Size = new System.Drawing.Size(71, 17);
            this.checkAuto.TabIndex = 12;
            this.checkAuto.Text = "AutoFarm";
            this.checkAuto.UseVisualStyleBackColor = true;
            // 
            // lblFarmar4
            // 
            this.lblFarmar4.AutoSize = true;
            this.lblFarmar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarmar4.Location = new System.Drawing.Point(498, 225);
            this.lblFarmar4.Name = "lblFarmar4";
            this.lblFarmar4.Size = new System.Drawing.Size(147, 29);
            this.lblFarmar4.TabIndex = 11;
            this.lblFarmar4.Text = "+25 dinheiro";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(224, 216);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(254, 38);
            this.progressBar4.TabIndex = 10;
            // 
            // btnFarmar4
            // 
            this.btnFarmar4.Location = new System.Drawing.Point(27, 215);
            this.btnFarmar4.Name = "btnFarmar4";
            this.btnFarmar4.Size = new System.Drawing.Size(179, 39);
            this.btnFarmar4.TabIndex = 9;
            this.btnFarmar4.Text = "Espancar terra globista";
            this.btnFarmar4.UseVisualStyleBackColor = true;
            this.btnFarmar4.Click += new System.EventHandler(this.btnFarmar4_Click);
            // 
            // lblFarmar3
            // 
            this.lblFarmar3.AutoSize = true;
            this.lblFarmar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarmar3.Location = new System.Drawing.Point(498, 166);
            this.lblFarmar3.Name = "lblFarmar3";
            this.lblFarmar3.Size = new System.Drawing.Size(147, 29);
            this.lblFarmar3.TabIndex = 8;
            this.lblFarmar3.Text = "+10 dinheiro";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(224, 157);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(254, 38);
            this.progressBar3.TabIndex = 7;
            // 
            // btnFarmar3
            // 
            this.btnFarmar3.Location = new System.Drawing.Point(27, 156);
            this.btnFarmar3.Name = "btnFarmar3";
            this.btnFarmar3.Size = new System.Drawing.Size(179, 39);
            this.btnFarmar3.TabIndex = 6;
            this.btnFarmar3.Text = "Streamar";
            this.btnFarmar3.UseVisualStyleBackColor = true;
            this.btnFarmar3.Click += new System.EventHandler(this.btnFarmar3_Click);
            // 
            // lblFarm2
            // 
            this.lblFarm2.AutoSize = true;
            this.lblFarm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarm2.Location = new System.Drawing.Point(498, 108);
            this.lblFarm2.Name = "lblFarm2";
            this.lblFarm2.Size = new System.Drawing.Size(134, 29);
            this.lblFarm2.TabIndex = 5;
            this.lblFarm2.Text = "+5 dinheiro";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(224, 99);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(254, 38);
            this.progressBar2.TabIndex = 4;
            // 
            // btnFarmar2
            // 
            this.btnFarmar2.Location = new System.Drawing.Point(27, 98);
            this.btnFarmar2.Name = "btnFarmar2";
            this.btnFarmar2.Size = new System.Drawing.Size(179, 39);
            this.btnFarmar2.TabIndex = 3;
            this.btnFarmar2.Text = "Jogar de draven";
            this.btnFarmar2.UseVisualStyleBackColor = true;
            this.btnFarmar2.Click += new System.EventHandler(this.btnFarmar2_Click);
            // 
            // lblFarmar1
            // 
            this.lblFarmar1.AutoSize = true;
            this.lblFarmar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarmar1.Location = new System.Drawing.Point(498, 50);
            this.lblFarmar1.Name = "lblFarmar1";
            this.lblFarmar1.Size = new System.Drawing.Size(134, 29);
            this.lblFarmar1.TabIndex = 2;
            this.lblFarmar1.Text = "+1 dinheiro";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(224, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 38);
            this.progressBar1.TabIndex = 1;
            // 
            // btnFarmar1
            // 
            this.btnFarmar1.Location = new System.Drawing.Point(27, 41);
            this.btnFarmar1.Name = "btnFarmar1";
            this.btnFarmar1.Size = new System.Drawing.Size(179, 39);
            this.btnFarmar1.TabIndex = 0;
            this.btnFarmar1.Text = "Caçar demonios";
            this.btnFarmar1.UseVisualStyleBackColor = true;
            this.btnFarmar1.Click += new System.EventHandler(this.btnFarmar1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnComprar4);
            this.tabPage2.Controls.Add(this.lblLoja4);
            this.tabPage2.Controls.Add(this.btnComprar3);
            this.tabPage2.Controls.Add(this.lblLoja3);
            this.tabPage2.Controls.Add(this.btnComprar2);
            this.tabPage2.Controls.Add(this.lblLoja2);
            this.tabPage2.Controls.Add(this.btnComprar1);
            this.tabPage2.Controls.Add(this.lblLoja1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnComprar3
            // 
            this.btnComprar3.Location = new System.Drawing.Point(387, 167);
            this.btnComprar3.Name = "btnComprar3";
            this.btnComprar3.Size = new System.Drawing.Size(187, 30);
            this.btnComprar3.TabIndex = 5;
            this.btnComprar3.Text = "$500";
            this.btnComprar3.UseVisualStyleBackColor = true;
            this.btnComprar3.Click += new System.EventHandler(this.btnComprar3_Click);
            // 
            // lblLoja3
            // 
            this.lblLoja3.AutoSize = true;
            this.lblLoja3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoja3.Location = new System.Drawing.Point(30, 167);
            this.lblLoja3.Name = "lblLoja3";
            this.lblLoja3.Size = new System.Drawing.Size(302, 31);
            this.lblLoja3.TabIndex = 4;
            this.lblLoja3.Text = "aprender fisica quantica";
            // 
            // btnComprar2
            // 
            this.btnComprar2.Location = new System.Drawing.Point(387, 101);
            this.btnComprar2.Name = "btnComprar2";
            this.btnComprar2.Size = new System.Drawing.Size(187, 30);
            this.btnComprar2.TabIndex = 3;
            this.btnComprar2.Text = "$250";
            this.btnComprar2.UseVisualStyleBackColor = true;
            this.btnComprar2.Click += new System.EventHandler(this.btnComprar2_Click);
            // 
            // lblLoja2
            // 
            this.lblLoja2.AutoSize = true;
            this.lblLoja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoja2.Location = new System.Drawing.Point(30, 95);
            this.lblLoja2.Name = "lblLoja2";
            this.lblLoja2.Size = new System.Drawing.Size(274, 31);
            this.lblLoja2.TabIndex = 2;
            this.lblLoja2.Text = "webcam lixotech t920";
            this.lblLoja2.Click += new System.EventHandler(this.lblLoja2_Click);
            // 
            // btnComprar1
            // 
            this.btnComprar1.Location = new System.Drawing.Point(387, 34);
            this.btnComprar1.Name = "btnComprar1";
            this.btnComprar1.Size = new System.Drawing.Size(187, 30);
            this.btnComprar1.TabIndex = 1;
            this.btnComprar1.Text = "$100";
            this.btnComprar1.UseVisualStyleBackColor = true;
            this.btnComprar1.Click += new System.EventHandler(this.btnComprar1_Click);
            // 
            // lblLoja1
            // 
            this.lblLoja1.AutoSize = true;
            this.lblLoja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoja1.Location = new System.Drawing.Point(30, 34);
            this.lblLoja1.Name = "lblLoja1";
            this.lblLoja1.Size = new System.Drawing.Size(212, 31);
            this.lblLoja1.TabIndex = 0;
            this.lblLoja1.Text = "pc gamer intel 8 ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblViewers);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(761, 344);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xandão";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblViewers
            // 
            this.lblViewers.AutoSize = true;
            this.lblViewers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewers.ForeColor = System.Drawing.Color.Red;
            this.lblViewers.Location = new System.Drawing.Point(452, 296);
            this.lblViewers.Name = "lblViewers";
            this.lblViewers.Size = new System.Drawing.Size(162, 37);
            this.lblViewers.TabIndex = 2;
            this.lblViewers.Text = "lblViewers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(95, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "===========================================";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro.ForeColor = System.Drawing.Color.Green;
            this.lblDinheiro.Location = new System.Drawing.Point(16, 13);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(156, 37);
            this.lblDinheiro.TabIndex = 1;
            this.lblDinheiro.Text = "Dinhero : ";
            // 
            // tFarm1
            // 
            this.tFarm1.Tick += new System.EventHandler(this.tFarm1_Tick);
            // 
            // tUpdate
            // 
            this.tUpdate.Interval = 1;
            this.tUpdate.Tick += new System.EventHandler(this.tUpdate_Tick);
            // 
            // tFarm2
            // 
            this.tFarm2.Interval = 200;
            this.tFarm2.Tick += new System.EventHandler(this.tFarm2_Tick);
            // 
            // tFarm3
            // 
            this.tFarm3.Interval = 300;
            this.tFarm3.Tick += new System.EventHandler(this.tFarm3_Tick);
            // 
            // tFarm4
            // 
            this.tFarm4.Interval = 400;
            this.tFarm4.Tick += new System.EventHandler(this.tFarm4_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Boost x2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBoost1
            // 
            this.tBoost1.Tick += new System.EventHandler(this.tBoost1_Tick);
            // 
            // tBoost2
            // 
            this.tBoost2.Tick += new System.EventHandler(this.tBoost2_Tick);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(587, 36);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(13, 13);
            this.lblSeconds.TabIndex = 3;
            this.lblSeconds.Text = "0";
            // 
            // tBoost3
            // 
            this.tBoost3.Tick += new System.EventHandler(this.tBoost3_Tick);
            // 
            // tXandao
            // 
            this.tXandao.Enabled = true;
            this.tXandao.Interval = 1000;
            this.tXandao.Tick += new System.EventHandler(this.tXandao_Tick);
            // 
            // tXandao2
            // 
            this.tXandao2.Interval = 1000;
            this.tXandao2.Tick += new System.EventHandler(this.tXandao2_Tick);
            // 
            // tViewer
            // 
            this.tViewer.Enabled = true;
            this.tViewer.Interval = 1000;
            this.tViewer.Tick += new System.EventHandler(this.tViewer_Tick);
            // 
            // lblLoja4
            // 
            this.lblLoja4.AutoSize = true;
            this.lblLoja4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoja4.Location = new System.Drawing.Point(30, 231);
            this.lblLoja4.Name = "lblLoja4";
            this.lblLoja4.Size = new System.Drawing.Size(208, 31);
            this.lblLoja4.TabIndex = 6;
            this.lblLoja4.Text = "foguete da naza";
            // 
            // btnComprar4
            // 
            this.btnComprar4.Location = new System.Drawing.Point(387, 231);
            this.btnComprar4.Name = "btnComprar4";
            this.btnComprar4.Size = new System.Drawing.Size(187, 30);
            this.btnComprar4.TabIndex = 7;
            this.btnComprar4.Text = "$5000";
            this.btnComprar4.UseVisualStyleBackColor = true;
            this.btnComprar4.Click += new System.EventHandler(this.btnComprar4_Click);
            // 
            // btnTerraPlana
            // 
            this.btnTerraPlana.Location = new System.Drawing.Point(224, 288);
            this.btnTerraPlana.Name = "btnTerraPlana";
            this.btnTerraPlana.Size = new System.Drawing.Size(234, 46);
            this.btnTerraPlana.TabIndex = 13;
            this.btnTerraPlana.Text = "provar que a terra é plana";
            this.btnTerraPlana.UseVisualStyleBackColor = true;
            this.btnTerraPlana.Click += new System.EventHandler(this.btnTerraPlana_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SimuladorDeXandao.Properties.Resources.Screenshot_159;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(100, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 268);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDinheiro);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnFarmar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Timer tFarm1;
        private System.Windows.Forms.Timer tUpdate;
        private System.Windows.Forms.Label lblFarmar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblFarm2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button btnFarmar2;
        private System.Windows.Forms.Button btnComprar1;
        private System.Windows.Forms.Label lblLoja1;
        private System.Windows.Forms.Timer tFarm2;
        private System.Windows.Forms.Label lblFarmar3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button btnFarmar3;
        private System.Windows.Forms.Button btnComprar2;
        private System.Windows.Forms.Label lblLoja2;
        private System.Windows.Forms.Timer tFarm3;
        private System.Windows.Forms.Label lblFarmar4;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button btnFarmar4;
        private System.Windows.Forms.Button btnComprar3;
        private System.Windows.Forms.Label lblLoja3;
        private System.Windows.Forms.Timer tFarm4;
        private System.Windows.Forms.CheckBox checkAuto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tBoost1;
        private System.Windows.Forms.Timer tBoost2;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Timer tBoost3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tXandao;
        private System.Windows.Forms.Timer tXandao2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblViewers;
        private System.Windows.Forms.Timer tViewer;
        private System.Windows.Forms.Button btnComprar4;
        private System.Windows.Forms.Label lblLoja4;
        private System.Windows.Forms.Button btnTerraPlana;
    }
}


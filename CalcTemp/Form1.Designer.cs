namespace CalcTemp
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
            this.valorTxt = new System.Windows.Forms.TextBox();
            this.escalaBox = new System.Windows.Forms.ComboBox();
            this.valorLbl = new System.Windows.Forms.Label();
            this.escalaLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.celcLbl = new System.Windows.Forms.Label();
            this.fahrLbl = new System.Windows.Forms.Label();
            this.kelvLbl = new System.Windows.Forms.Label();
            this.roundCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // valorTxt
            // 
            this.valorTxt.Location = new System.Drawing.Point(70, 109);
            this.valorTxt.Name = "valorTxt";
            this.valorTxt.Size = new System.Drawing.Size(182, 20);
            this.valorTxt.TabIndex = 0;
            // 
            // escalaBox
            // 
            this.escalaBox.FormattingEnabled = true;
            this.escalaBox.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.escalaBox.Location = new System.Drawing.Point(70, 61);
            this.escalaBox.Name = "escalaBox";
            this.escalaBox.Size = new System.Drawing.Size(121, 21);
            this.escalaBox.TabIndex = 1;
            // 
            // valorLbl
            // 
            this.valorLbl.AutoSize = true;
            this.valorLbl.Location = new System.Drawing.Point(70, 93);
            this.valorLbl.Name = "valorLbl";
            this.valorLbl.Size = new System.Drawing.Size(31, 13);
            this.valorLbl.TabIndex = 2;
            this.valorLbl.Text = "Valor";
            // 
            // escalaLbl
            // 
            this.escalaLbl.AutoSize = true;
            this.escalaLbl.Location = new System.Drawing.Point(70, 42);
            this.escalaLbl.Name = "escalaLbl";
            this.escalaLbl.Size = new System.Drawing.Size(118, 13);
            this.escalaLbl.TabIndex = 3;
            this.escalaLbl.Text = "Escala a ser convertida";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(73, 152);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(138, 39);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calcular";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // celcLbl
            // 
            this.celcLbl.AutoSize = true;
            this.celcLbl.Location = new System.Drawing.Point(350, 61);
            this.celcLbl.Name = "celcLbl";
            this.celcLbl.Size = new System.Drawing.Size(50, 13);
            this.celcLbl.TabIndex = 5;
            this.celcLbl.Text = "Celcius : ";
            // 
            // fahrLbl
            // 
            this.fahrLbl.AutoSize = true;
            this.fahrLbl.Location = new System.Drawing.Point(350, 83);
            this.fahrLbl.Name = "fahrLbl";
            this.fahrLbl.Size = new System.Drawing.Size(63, 13);
            this.fahrLbl.TabIndex = 6;
            this.fahrLbl.Text = "Fahrenheit :";
            this.fahrLbl.Click += new System.EventHandler(this.fahrLbl_Click);
            // 
            // kelvLbl
            // 
            this.kelvLbl.AutoSize = true;
            this.kelvLbl.Location = new System.Drawing.Point(350, 109);
            this.kelvLbl.Name = "kelvLbl";
            this.kelvLbl.Size = new System.Drawing.Size(42, 13);
            this.kelvLbl.TabIndex = 7;
            this.kelvLbl.Text = "Kelvin :";
            // 
            // roundCheck
            // 
            this.roundCheck.AutoSize = true;
            this.roundCheck.Location = new System.Drawing.Point(342, 174);
            this.roundCheck.Name = "roundCheck";
            this.roundCheck.Size = new System.Drawing.Size(78, 17);
            this.roundCheck.TabIndex = 8;
            this.roundCheck.Text = "Arredondar";
            this.roundCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 227);
            this.Controls.Add(this.roundCheck);
            this.Controls.Add(this.kelvLbl);
            this.Controls.Add(this.fahrLbl);
            this.Controls.Add(this.celcLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.escalaLbl);
            this.Controls.Add(this.valorLbl);
            this.Controls.Add(this.escalaBox);
            this.Controls.Add(this.valorTxt);
            this.Name = "Form1";
            this.Text = "Conversor Escala";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valorTxt;
        private System.Windows.Forms.ComboBox escalaBox;
        private System.Windows.Forms.Label valorLbl;
        private System.Windows.Forms.Label escalaLbl;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label celcLbl;
        private System.Windows.Forms.Label fahrLbl;
        private System.Windows.Forms.Label kelvLbl;
        private System.Windows.Forms.CheckBox roundCheck;
    }
}


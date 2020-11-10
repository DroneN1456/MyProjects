using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SimuladorDeXandao
{
    public partial class Form1 : Form
    {
        public double dinheiro = 0;
        public double viewers = 0;
        public int timerSeconds = 0;
        public int multiplicador = 1;
        public bool isFinished = false;
        public bool pcgamer = false;
        public bool isComprado1 = false;
        public bool isComprado2 = false;
        public bool isComprado3 = false;
        public bool webcam = false;
        public bool fisica = false;
        public bool foguete = false;
        public Form1()
        {
            InitializeComponent();
            // Seta as coisas com o valor padrão

            btnTerraPlana.Visible = false;

            lblSeconds.Visible = false;

            btnFarmar2.Visible = false;
            btnFarmar2.Enabled = false;
            progressBar2.Visible = false;
            lblFarm2.Visible = false;
            btnFarmar3.Visible = false;
            btnFarmar3.Enabled = false;
            progressBar3.Visible = false;
            lblFarmar3.Visible = false;
            btnFarmar4.Visible = false;
            btnFarmar4.Enabled = false;
            progressBar4.Visible = false;
            lblFarmar4.Visible = false;


            btnComprar1.Enabled = false;
            lblLoja2.Visible = false;
            btnComprar2.Visible = false;
            btnComprar2.Enabled = false;
            lblLoja3.Visible = false;
            btnComprar3.Visible = false;
            btnComprar3.Enabled = false;
            btnComprar4.Visible = false;
            btnComprar4.Enabled = false;
            lblLoja4.Visible = false;
        }

        private void btnFarmar1_Click(object sender, EventArgs e)
        {
            tFarm1.Enabled = true;

        }

        private void tFarm1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 25;
            if (progressBar1.Value == 100)
            {
                dinheiro += 1 * multiplicador;
                progressBar1.Value = 0;
                tFarm1.Enabled = false;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tUpdate.Enabled = true;
        }

        private void tUpdate_Tick(object sender, EventArgs e)
        {

            // verifica se o jogo acabou
            if (viewers >= 10000 && foguete == false)
            {
                btnComprar4.Visible = true;
                lblLoja4.Visible = true;
                if(dinheiro >= 5000)
                {
                    btnComprar4.Enabled = true;
                }
            }
            // update das info na tela
            lblDinheiro.Text = "Dinheiro: " + dinheiro;
            lblSeconds.Text = timerSeconds.ToString();
            lblViewers.Text = '\u2022' + " " + viewers.ToString();
            if(foguete == true)
            {
                btnTerraPlana.Visible = true;
            }
            // update do farm
            if (pcgamer == true)
            {
                btnFarmar2.Visible = true;
                btnFarmar2.Enabled = true;
                progressBar2.Visible = true;
                lblFarm2.Visible = true;
            }
            if (webcam == true)
            {
                btnFarmar3.Visible = true;
                btnFarmar3.Enabled = true;
                progressBar3.Visible = true;
                lblFarmar3.Visible = true;

            }
            if (fisica == true)
            {
                btnFarmar4.Visible = true;
                btnFarmar4.Enabled = true;
                progressBar4.Visible = true;
                lblFarmar4.Visible = true;
            }

            // update da loja
            if (dinheiro >= 100 && isComprado1 == false)
            {
                btnComprar1.Enabled = true;
            }
            if (dinheiro >= 250 && isComprado2 == false)
            {
                btnComprar2.Enabled = true;
            }
            if (dinheiro >= 500 && isComprado3 == false)
            {
                btnComprar3.Enabled = true;
            }
            


            // autofarm

            if (checkAuto.Checked == true)
            {
                tFarm1.Enabled = true;
                if (btnFarmar2.Enabled == true)
                {
                    tFarm2.Enabled = true;
                }
                if (btnFarmar3.Enabled == true)
                {
                    tFarm3.Enabled = true;
                }
                if (btnFarmar4.Enabled == true)
                {
                    tFarm4.Enabled = true;
                }
            }


        }

        private void btnComprar1_Click(object sender, EventArgs e)
        {
            dinheiro -= 100;
            pcgamer = true;
            btnComprar1.Text = "Comprado";
            btnComprar1.Enabled = false;
            isComprado1 = true;
            btnComprar2.Visible = true;
            lblLoja2.Visible = true;
        }

        private void tFarm2_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value == 100)
            {
                dinheiro += 5 * multiplicador;
                progressBar2.Value = 0;
                tFarm2.Enabled = false;
            }
            else
            {
                progressBar2.Value += 25;
            }
        }

        private void btnFarmar2_Click(object sender, EventArgs e)
        {
            tFarm2.Enabled = true;
        }

        private void lblLoja2_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar2_Click(object sender, EventArgs e)
        {
            dinheiro -= 250;
            webcam = true;
            btnComprar2.Text = "Comprado";
            btnComprar2.Enabled = false;
            isComprado2 = true;
            btnComprar3.Visible = true;
            lblLoja3.Visible = true;
        }

        private void tFarm3_Tick(object sender, EventArgs e)
        {
            if (progressBar3.Value == 100)
            {
                dinheiro += 10 * multiplicador;
                progressBar3.Value = 0;
                tFarm3.Enabled = false;
            }
            else
            {
                progressBar3.Value += 25;
            }
        }

        private void btnFarmar3_Click(object sender, EventArgs e)
        {
            tFarm3.Enabled = true;
        }

        private void btnComprar3_Click(object sender, EventArgs e)
        {
            dinheiro -= 500;
            fisica = true;
            btnComprar3.Text = "Comprado";
            btnComprar3.Enabled = false;
            isComprado3 = true;
            //btnComprar3.Visible = true;
            //lblLoja3.Visible = true;
        }

        private void btnFarmar4_Click(object sender, EventArgs e)
        {
            tFarm4.Enabled = true;
        }

        private void tFarm4_Tick(object sender, EventArgs e)
        {
            if (progressBar4.Value == 100)
            {
                dinheiro += 25 * multiplicador;
                progressBar4.Value = 0;
                tFarm4.Enabled = false;
            }
            else
            {
                progressBar4.Value += 25;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            lblSeconds.Visible = true;
            tBoost1.Interval = 60000;
            tBoost1.Enabled = true;
            tBoost2.Interval = 1000;
            tBoost2.Enabled = true;
            tBoost3.Interval = 180000;
            timerSeconds = 60;
            multiplicador = 2;

        }

        private void tBoost2_Tick(object sender, EventArgs e)
        {
            timerSeconds -= 1;
            if (timerSeconds == 0)
            {
                tBoost2.Enabled = false;
            }
        }

        private void tBoost1_Tick(object sender, EventArgs e)
        {
            multiplicador = 1;
            tBoost3.Enabled = true;
            timerSeconds = 180;
            tBoost2.Enabled = true;
        }

        private void tBoost3_Tick(object sender, EventArgs e)
        {
            lblSeconds.Visible = false;
            button1.Enabled = true;
        }

        private void tXandao_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = SimuladorDeXandao.Properties.Resources.Screenshot_160;
            tXandao2.Enabled = true;
            tXandao.Enabled = false;
        }

        private void tXandao2_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = SimuladorDeXandao.Properties.Resources.Screenshot_159;
            tXandao2.Enabled = false;
            tXandao.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tViewer_Tick(object sender, EventArgs e)
        {
            viewers += Math.Round(dinheiro * 0.05);
        }

        private void btnComprar4_Click(object sender, EventArgs e)
        {
            dinheiro -= 5000;
            foguete = true;
            btnComprar4.Enabled = false;
            btnComprar4.Text = "Comprado";
        }

        private void btnTerraPlana_Click(object sender, EventArgs e)
        {
            Form formaux = new Form2();
            formaux.Show();
            this.Hide();
        }
    }
}

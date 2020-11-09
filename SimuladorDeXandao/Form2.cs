using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorDeXandao
{
    public partial class Form2 : Form
    {

        public int vidaFeminista = 1000;
        public int vida = 1000;
        SoundPlayer soundPlayer = new SoundPlayer(SimuladorDeXandao.Properties.Resources.onmyown);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tUpdate_Tick(object sender, EventArgs e)
        {
            if (vida <= 0 || vidaFeminista <= 0)
            {
                finalpartida();
            }
            else
            {
                progressBar1.Value = vidaFeminista;
                lblVida.Text = vidaFeminista.ToString() + "/1000";
                progressBar2.Value = vida;
                lblSuaVida.Text = vida.ToString() + "/1000";
            }
        }

        private void finalpartida()
        {
            tUpdate.Enabled = false;
            tDano.Enabled = false;
            if(vida <= 0)
            {
                progressBar2.Value = 0;
                lblSuaVida.Text = "0/1000";
                MessageBox.Show("Voce perdeu!", ":(", MessageBoxButtons.OK);
                Application.Exit();

            }
            if(vidaFeminista <= 0)
            {
                lblVida.Visible = false;
                progressBar1.Visible = false;
                pictureBox1.Visible = false;
                label1.Visible = false;
                soundPlayer.Stop();
                tFinal.Enabled = true;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (vida <= 0)
            {
                finalpartida();
            }
            else
            {
                vida -= 50;
            }
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            if (vidaFeminista <= 0)
            {
                finalpartida();
            }
            else
            {
                vidaFeminista -= 4;
            }

        }

        private void tFinal_Tick(object sender, EventArgs e)
        {
            tFinal.Enabled = false;
            soundPlayer = new SoundPlayer(SimuladorDeXandao.Properties.Resources.doublebiceps);
            soundPlayer.Play();
            MessageBox.Show("Parabens, voce se tornou um campeao da terra!!!", "Dalezada", MessageBoxButtons.OK);
            Application.Exit();
        }
    }
}

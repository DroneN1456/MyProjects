using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorDeXandao
{
    public partial class Form2 : Form
    {

        public int vidaFeminista = 1000;
        public int vida = 1000;
        string[] lines = new string[2];
        string[] tent;
        int tentativas = 0;
        string path;
        string pathConfig;


        SoundPlayer soundPlayer = new SoundPlayer();

        public Form2()
        {
            InitializeComponent();
            path = (Application.StartupPath + @"\Config");
            pathConfig = (path + @"\easymode.cfg");
            initializeMyFiles();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            soundPlayer.Stream = Properties.Resources.onmyown;
            soundPlayer.Play();
            using (StreamReader sr = new StreamReader(pathConfig))
            {
                for (int i = 0; i <= 1; i++)
                {
                    lines[i] = sr.ReadLine();
                }
            }
            tent = lines[1].Split(':');
            tentativas = int.Parse(tent[1]);
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
            if (vida <= 0)
            {
               
                progressBar2.Value = 0;
                lblSuaVida.Text = "0/1000";
                MessageBox.Show("Voce perdeu!", ":(", MessageBoxButtons.OK);
                writeConfig(tentativas + 1);
                Application.Exit();
            }
            if (vidaFeminista <= 0)
            {
                lblVida.Visible = false;
                progressBar1.Visible = false;
                pictureBox1.Visible = false;
                label1.Visible = false;
                soundPlayer.Stop();
                tFinal.Enabled = true;
                tentativas = 0;
                writeConfig(0);
            }
        }

        private void writeConfig(double tentativas)
        {
            File.WriteAllText(pathConfig, "");
            using (StreamWriter sw = File.AppendText(pathConfig))
            {
                sw.WriteLine("//Se \"Tentativas\" for maior que 3, o easymode é ativado :)");
                sw.WriteLine("Tentativas:" + tentativas);
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
            if (tentativas > 3)
            {
                vidaFeminista -= 10;
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

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void initializeMyFiles()
        {

            Directory.CreateDirectory(path);
            if (!File.Exists(pathConfig))
            {
                File.WriteAllText(pathConfig, Properties.Resources.easymode);
            }

        }
    }
}

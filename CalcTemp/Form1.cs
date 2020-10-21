using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcTemp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            string tempTxt = valorTxt.Text;
            double tempEntrada = double.Parse(tempTxt);
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                if (escalaBox.SelectedIndex == i)
                {
                    index = i;
                }
            }
            double kelvRes;
            double celcRes;
            double fahrRes;
            int round;
            if (roundCheck.Checked == true)
            {
                round = 0;
            }
            else
            {
                round = 2;
            }
            switch (index)
            {
                 
                case 0:
                    kelvRes = Math.Round(tempEntrada + 273.15, round);
                    celcRes = Math.Round(tempEntrada, round);
                    fahrRes = Math.Round((tempEntrada * 1.8) + 32, round);
                    kelvLbl.Text = "Kelvin : " + kelvRes.ToString("F2");
                    celcLbl.Text = "Celcius : " + celcRes.ToString("F2");
                    fahrLbl.Text = "Fahrenheit : " + fahrRes.ToString("F2");
                    break;
                case 1:
                    kelvRes = Math.Round((tempEntrada - 32) * (5.0 / 9.0) + 273.15, round);
                    fahrRes = Math.Round(tempEntrada, round);
                    celcRes = Math.Round((tempEntrada - 32) * (5.0 / 9.0), round);
                    kelvLbl.Text = "Kelvin : " + kelvRes.ToString("F2");
                    celcLbl.Text = "Celcius : " + celcRes.ToString("F2");
                    fahrLbl.Text = "Fahrenheit : " + fahrRes.ToString("F2");
                    break;
                case 2:
                    kelvRes = Math.Round(tempEntrada, round);
                    fahrRes = Math.Round((tempEntrada - 273.15) * (9.0 / 5.0) + 32, round);
                    celcRes = Math.Round(tempEntrada - 273.15, round);
                    kelvLbl.Text = "Kelvin : " + kelvRes.ToString("F2");
                    celcLbl.Text = "Celcius : " + celcRes.ToString("F2");
                    fahrLbl.Text = "Fahrenheit : " + fahrRes.ToString("F2");
                    break;

            }
        }

        private void fahrLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

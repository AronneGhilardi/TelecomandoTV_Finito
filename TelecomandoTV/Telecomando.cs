using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelecomandoTV
{
    public partial class Telecomando : Form
    {
        private TV tv;

        public Telecomando()
        {
            InitializeComponent();
            tv = new TV();
            Spento();
        }

        public void Reset()
        {
            volLabel.Text = "0";
            chLabel.Text = "0";
            produttoreBox.Text = " ";
            modelloBox.Text = " ";
            infrLed.BackColor = Color.Transparent;
            blueLed.BackColor = Color.Transparent;
            wifiLed.BackColor = Color.Transparent;
        }

        public void Acceso()
        {
            powerLed.BackColor = Color.Green;
            infrButton.Enabled = true;
            blueButton.Enabled = true;
            wifiButton.Enabled = true;
            volupButton.Enabled = true;
            voldownButton.Enabled = true;
            volLabel.Text = "0";
            chupButton.Enabled = true;
            chdownButton.Enabled = true;
            chLabel.Text = "0";
            produttoreBox.Enabled = true;
            modelloBox.Enabled = true;
        }

        public void Spento()
        {
            powerLed.BackColor = Color.Red;
            infrButton.Enabled = false;
            blueButton.Enabled = false;
            wifiButton.Enabled = false;
            volupButton.Enabled = false;
            voldownButton.Enabled = false;
            volLabel.Text = "0";
            chupButton.Enabled = false;
            chdownButton.Enabled = false;
            chLabel.Text = "0";
            produttoreBox.Enabled = false;
            modelloBox.Enabled = false;
        }


        //STATO
        private void powerButton_Click(object sender, EventArgs e)
        {
            if (tv.invert() == true)
            {
                tv.on();
                Acceso();
            }
            else
            {
                tv.off();
                Spento();
            }
        }

        //RESET
        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //SEGNALE
        private void infrButton_Click(object sender, EventArgs e)
        {
            if (tv.getStato() == true)
            {
                infrLed.BackColor = Color.Yellow;
                blueLed.BackColor = Color.Transparent;
                wifiLed.BackColor = Color.Transparent;
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (tv.getStato() == true)
            {
                infrLed.BackColor = Color.Transparent;
                blueLed.BackColor = Color.Yellow;
                wifiLed.BackColor = Color.Transparent;
            }
        }

        private void wifiButton_Click(object sender, EventArgs e)
        {
            if (tv.getStato() == true)
            {
                infrLed.BackColor = Color.Transparent;
                blueLed.BackColor = Color.Transparent;
                wifiLed.BackColor = Color.Yellow;
            }
        }

        //VOLUME
        private void volupButton_Click(object sender, EventArgs e)
        {
            tv.setVolume(tv.getVolume() + 1);
            volLabel.Text = tv.getVolume().ToString();
        }

        private void voldownButton_Click(object sender, EventArgs e)
        {
            tv.setVolume(tv.getVolume() - 1);
            volLabel.Text = tv.getVolume().ToString();
            if(tv.getVolume() == 0)
            {
                voldownButton.Enabled = false;
            }
            if(tv.getVolume() != 0)
            {
                voldownButton.Enabled = true;
            }
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            volLabel.Text = "0";
        }

        //CANALE
        private void chupButton_Click(object sender, EventArgs e)
        {
            tv.setCanale(tv.getCanale() + 1);
            chLabel.Text = tv.getCanale().ToString();
        }

        private void chdownButton_Click(object sender, EventArgs e)
        {
            tv.setCanale(tv.getCanale() - 1);
            chLabel.Text = tv.getCanale().ToString();
            if(tv.getCanale() == -1)
            {
                tv.setCanale(99);
                chLabel.Text = tv.getCanale().ToString();
            }
            if (tv.getCanale() == 100)
            {
                tv.setCanale(0);
                chLabel.Text = tv.getCanale().ToString();
            }
        }

        //PRODUTTORE
        private void produttureBox_TextChanged(object sender, EventArgs e)
        {
            tv.setProduttore(produttoreBox.Text);
        }

        //MODELLO
        private void modelloBox_TextChanged(object sender, EventArgs e)
        {
            tv.setModello(modelloBox.Text);
        }
    }
}
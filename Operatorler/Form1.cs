using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnToplama_Click(object sender, EventArgs e)
        {
            int s1 = 120;
            int s2 = 25;

            int toplam = s1 + s2;
            // MessageBox.Show("Toplama işleminin sonucu : " + toplam);
            MessageBox.Show("Toplama işleminin sonucu : " +(s1 + s2)); // Çıktı =>145
        }

        private void BtnCikartma_Click(object sender, EventArgs e)
        {
            int s1 = 120;
            int s2 = 25;

            int cikarma = s1 - s2;
            MessageBox.Show("cikarma işleminin sonucu : " + cikarma);
        }

        private void BtnCarpma_Click(object sender, EventArgs e)
        {
            long s1 = 168;
            long s2 = 150;

            long carpma = s1 * s2;
            MessageBox.Show("Carpma işleminin sonucu : " + carpma);
        }

        private void BtnBolme_Click(object sender, EventArgs e)
        {
            double s1 = 3448;
            double s2 = 25;

            double bölme = s1 / s2;
            MessageBox.Show("Bölme işleminin sonucu : " + bölme);
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            float s1 = 28;
            float s2 = 11.5F;

            float mod = s1 % s2;
            MessageBox.Show("Mod işleminin sonucu : " + mod);

        }
    }
}

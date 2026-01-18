using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int sayi) && sayi >= 0)
            {
                label2.Text = "FAKTORIYEL(" + sayi + ") = " + FAKTORIYEL(sayi);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir pozitif tam sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int FAKTORIYEL(int say)
        {
            int sonuc = 1;
            for (int i = 2; i <= say; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double sayi))
            {
                label4.Text = "Mutlak(" + sayi + ") = " + Mutlak(sayi);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double Mutlak(double say)
        {
            return say < 0 ? -say : say;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double[] sayilar = textBox3.Text
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => double.Parse(s.Replace(',', '.')))
                    .ToArray();

                if (sayilar.Length > 0)
                {
                    label6.Text = "EnBuyuk(" + string.Join(", ", sayilar) + ") = " + EnBuyuk(sayilar);
                }
                else
                {
                    MessageBox.Show("Lütfen en az bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli sayıları girin! (Örn: 10, 20, 30)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double EnBuyuk(params double[] sayilar)
        {
            return sayilar.Max();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string[] girilenDegerler = textBox4.Text
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
   
                double[] sayilar = girilenDegerler
                    .Where(s => double.TryParse(s.Replace(',', '.'), out _)) 
                    .Select(s => double.Parse(s.Replace(',', '.'))) 
                    .ToArray();

                if (sayilar.Length == 0)
                {
                    MessageBox.Show("Lütfen en az bir geçerli sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

             
                label8.Text = "EnKucuk(" + string.Join(", ", sayilar) + ") = " + EnKucuk(sayilar);
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli sayıları girin! (Örn: 10, 20, 30)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double EnKucuk(params double[] sayilar)
        {
            return sayilar.Min();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string[] girilenDegerler = textBox5.Text
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                double[] sayilar = girilenDegerler
                    .Where(s => double.TryParse(s.Replace(',', '.'), out _))
                    .Select(s => double.Parse(s.Replace(',', '.')))
                    .ToArray();

                if (sayilar.Length == 0)
                {
                    MessageBox.Show("Lütfen en az bir geçerli sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                label10.Text = "Ortalama(" + string.Join(", ", sayilar) + ") = " + Ortalama(sayilar).ToString("F2");
                }
            catch
            {
                MessageBox.Show("Lütfen geçerli sayıları girin! (Örn: 10, 20, 30)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double Ortalama(params double[] sayilar)
        {
            return sayilar.Average();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi = double.Parse(textBox6.Text.Replace(',', '.'));
                int kuvvet = int.Parse(textBox7.Text);

                label13.Text = "KuvvetAl(" + sayi + ", " + kuvvet + ") = " + KuvvetAl(sayi, kuvvet);
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli sayıları girin! (Örn: 2 ve 5)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double KuvvetAl(double say, int kuvvet)
        {
            return Math.Pow(say, kuvvet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string mesaj = textBox8.Text;
                int adet = int.Parse(textBox9.Text);

                label16.Text = Listele(mesaj, adet);
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir mesaj ve adet girin! (Örn: 5)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string Listele(string mesaj, int adet)
        {
            return string.Concat(Enumerable.Repeat(mesaj + " ", adet)).Trim();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string mesaj = textBox10.Text;
                int adet = int.Parse(textBox11.Text);

                label19.Text = AltAltaListele(mesaj, adet);
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir mesaj ve adet girin! (Örn: 5)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string AltAltaListele(string mesaj, int adet)
        {
            return string.Join("\n", Enumerable.Repeat(mesaj, adet));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string mesaj = textBox12.Text.Trim();

                if (string.IsNullOrEmpty(mesaj))

                {
                    MessageBox.Show("Lütfen bir mesaj girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                label21.Text = Merdiven(mesaj);
            }
            catch
            {
                MessageBox.Show("Hata oluştu! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string Merdiven(string mesaj)
        {
            string sonuc = "";
            for (int i = 1; i <= mesaj.Length; i++)
            {
                sonuc += mesaj.Substring(0, i) + "\n";
            }
            return sonuc.Trim();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string mesaj = textBox13.Text.Trim();
                if (string.IsNullOrWhiteSpace(mesaj))
                {
                    MessageBox.Show("Lütfen bir mesaj girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                label23.Font = new System.Drawing.Font("Consolas", 12);
                label23.Text = V(mesaj);
            }
            catch
            {
                MessageBox.Show("Hata oluştu! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

private string V(string mesaj)
        {
            string sonuc = "";

            for (int i = 0; i < mesaj.Length; i++)
            {
                string solParca = mesaj.Substring(0, i + 1);
                string sagParca = mesaj.Substring(0, i + 1);
                int boslukSayisi = 1 + 2 * (mesaj.Length - i - 1);
                string satir = solParca + new string(' ', boslukSayisi) + sagParca;
                sonuc += satir + "\n";
            }

            return sonuc.Trim();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string mesaj = textBox14.Text.Trim();
                if (string.IsNullOrWhiteSpace(mesaj))
                {
                    MessageBox.Show("Lütfen bir mesaj girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                label25.Font = new System.Drawing.Font("Consolas", 12);
                label25.Text = TersV(mesaj);
            }
            catch
            {
                MessageBox.Show("Hata oluştu! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

private string TersV(string mesaj)
        {
            string sonuc = "";

            for (int i = mesaj.Length; i > 0; i--)
            {
                string solParca = mesaj.Substring(0, i);
                string sagParca = mesaj.Substring(0, i);
                int boslukSayisi = 1 + 2 * (mesaj.Length - i);
                string satir = solParca + new string(' ', boslukSayisi) + sagParca;
                sonuc += satir + "\n";
            }

            return sonuc.Trim();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}


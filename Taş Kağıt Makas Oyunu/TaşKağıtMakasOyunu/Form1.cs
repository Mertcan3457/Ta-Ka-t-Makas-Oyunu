using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaşKağıtMakasOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        int sayac = 0;
        int skor1 = 0;
        int skor2 = 0;
        Random rastgele = new Random();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 3 == 0)
            {
                pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Taş;
            }
            else if (sayac % 3 == 1)
            {
                pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Kağıt;
            }
            else if (sayac % 3 == 2)
            {
                pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Makas;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton4.Enabled = false;
                radioButton3.Enabled = false;
                pictureBox1.Visible = true;
                timer1.Stop();
                pictureBox1.Image = TaşKağıtMakasOyunu.Properties.Resources.Kağıt;
                sayi = rastgele.Next(1, 4);
                if (sayi == 1)
                {
                    pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Taş;
                }
                else if (sayi == 2)
                {
                    pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Kağıt;
                }
                else if (sayi == 3)
                {
                    pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Makas;
                }
                if (2 == sayi)
                {
                    MessageBox.Show("Berabere Puan Verilemedi", "Yönetici Tarafından Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (2 < sayi)
                {
                    skor2++;
                    label6.Text = skor2.ToString();
                    MessageBox.Show("Makas Kağıdı Keser\nBilgisayar 1 Puan Kazandı","Yönetici Tarafından Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (2 > sayi)
                {
                    skor1++;
                    label4.Text = skor1.ToString();
                    MessageBox.Show("Kağıt Taşı Sarar\n"+textBox1.Text+" 1 Puan Kazandı", "Yönetici Tarafından Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton4.Enabled = false;
                radioButton2.Enabled = false;
                pictureBox1.Visible = true;
                timer1.Stop();
                pictureBox1.Image = TaşKağıtMakasOyunu.Properties.Resources.Makas;
                sayi = rastgele.Next(1, 4);
                if (sayi == 1)
                {
                    pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Taş;
                }
                else if (sayi == 2)
                {
                    pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Kağıt;
                }
                else if (sayi == 3)
                {
                    pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Makas;
                }
                if (3 == sayi)
                {
                    MessageBox.Show("Berabere Puan Verilemedi", "Yönetici Tarafından Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (sayi < 2 && sayi < 3)
                {
                    skor2++;
                    label6.Text = skor2.ToString();
                    MessageBox.Show("Taş Makası Kırar\nBilgisayar 1 Puan Kazandı", "Yönetici Tarafından Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sayi < 3 && sayi > 1)
                {
                    skor1++;
                    label4.Text = skor1.ToString();
                    MessageBox.Show("Makas Kağıdı Keser\n"+textBox1.Text+" 1 Puan Kazandı", "Yönetici Tarafından Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                pictureBox1.Visible = true;
                timer1.Stop();
                pictureBox1.Image = TaşKağıtMakasOyunu.Properties.Resources.Taş;
                sayi = rastgele.Next(1, 4);
                if (sayi == 1)
                {
                    pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Taş;
                }
                else if (sayi == 2)
                {
                    pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Kağıt;
                }
                else if (sayi == 3)
                {
                    pictureBox2.Image = TaşKağıtMakasOyunu.Properties.Resources.Makas;
                }
                if (1 == sayi)
                {
                    MessageBox.Show("Berabere Puan Verilemedi", "Yönetici Tarafından Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (1 < sayi && sayi < 3)
                {
                    skor2++;
                    label6.Text = skor2.ToString();
                    MessageBox.Show("Kağıt Taşı Sarar\nBilgisayar 1 Puan Kazandı", "Yönetici Tarafından Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (1 < sayi && 2 < sayi)
                {
                    skor1++;
                    label4.Text = skor1.ToString();
                    MessageBox.Show("Taş Makası Kırar\n"+textBox1.Text+" 1 Puan Kazandı", "Yönetici Tarafından Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            radioButton4.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            if (skor1 == 5 || skor2 == 5) 
            {
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                button1.Visible = false;
                button3.Visible = true;
            }
            radioButton4.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            pictureBox1.Visible = true;
            sayac = 0;
            timer1.Start();
            if (skor1 == 5)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler "+textBox1.Text+"\nOyunu Kazandınız","Yönetici Tarafından Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if (skor2 == 5)
            {
                timer1.Stop();
                MessageBox.Show("Malesef Bilgisayar Oyunu Kazandı", "Yönetici Tarafından Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button3.Visible = false;
            radioButton4.AutoCheck= true;
            radioButton2.AutoCheck= true;
            radioButton3.AutoCheck = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            if (skor1 == 5 || skor2 == 5)
            {
                button3.Text = "Oyunu Sıfırla";
                button3.Visible = false;
                button1.Visible = true; 
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                skor1 = 0;
                skor2 = 0;
                label4.Text = skor1.ToString();
                label6.Text = skor2.ToString();
                sayac = 0;
                timer1.Start();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun Başlıyor İyi Şanslar");
            timer1.Start();
            label7.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
            groupBox1.Visible = true;
            label2.Text = textBox1.Text;
        }
    }
}

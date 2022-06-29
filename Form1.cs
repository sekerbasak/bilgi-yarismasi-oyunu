using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        int toplam_puan = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.ZoomFactor=1.5f;
            sayac++;
            label2.Text = sayac.ToString();
            if (sayac==5)
            {
                button5.Enabled = false;
            }
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
           

            if (sayac==1)
            {
                richTextBox1.Text = "Mustafa Kemal kaç yılında doğmuştur?";
                button1.Text = "1882";
                button2.Text = "1889";
                button3.Text = "1881";
                button4.Text = "1888";
               
            }
            if (sayac==2)
            {
                richTextBox1.Text = "Cumhuriyet ne zaman ilan edilmiştir?";
                button1.Text = "1919";
                button2.Text = "1924";
                button3.Text = "1918";
                button4.Text = "1923";
            }
            if (sayac==3)
            {
                richTextBox1.Text = "58+15=? sorusunun cevabı nedir?";
                button1.Text = "70";
                button2.Text = "71";
                button3.Text = "72";
                button4.Text = "73";
            }
            if (sayac == 4)
            {
                richTextBox1.Text = "Kendini başkasının yerine koymaya ne ad verilir?";
                button1.Text = "Empati";
                button2.Text = "Sempati";
                button3.Text = "Antisempati";
                button4.Text = "Özveri";
            }
            if (sayac == 5)
            {
                richTextBox1.Text = "En iyi bilgisayar mühendisi seçilen kimdir?:)";
                button1.Text = "Bill Gates";
                button2.Text = "Başak Şeker";
                button3.Text = "Alibaba";
                button4.Text = "Steve Jobs";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (sayac==1)
            {
                
                toplam_puan = toplam_puan + 20;
                button3.BackColor = Color.Green;
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                label8.Text = toplam_puan.ToString();
            }
            if (sayac == 3)
            {
                button4.BackColor = Color.Green;
                button3.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button1.BackColor = Color.Gray;
            }
            if (sayac == 2)
            {
                button4.BackColor = Color.Green;
                button3.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button1.BackColor = Color.Gray;
            }
            if (sayac == 4)
            {
                button1.BackColor = Color.Green;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
            }

            if (sayac == 5)
            {
                label9.Visible = true;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Gray;
                button1.BackColor = Color.Gray;
                timer1.Stop();
                if (toplam_puan >= 60)
                {
                   
                    label9.Text = "YARIŞMAYI " + toplam_puan + " PUANLA BİTİRDİN, TEBRİKLER!!";

                }
                else
                {
                    label9.Text = "YARIŞMAYI " + toplam_puan + " PUANLA BİTİRDİN, DAHA İYİSİNİ YAPABİLİRSİN:)";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (sayac == 3)
            {
               
                toplam_puan = toplam_puan + 20;
                button4.BackColor = Color.Green;
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                label8.Text = toplam_puan.ToString();
            }
            if (sayac == 1)

            {
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button1.BackColor = Color.Gray;
            }

            if (sayac==2)
            {
                toplam_puan = toplam_puan + 20;
                button4.BackColor = Color.Green;
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                label8.Text = toplam_puan.ToString();

            }
            if (sayac == 4)
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
            }
            if (sayac == 5)
            {
                label9.Visible = true;
                button2.BackColor = Color.Green;
                button4.BackColor = Color.Red;
                button1.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                timer1.Stop();
                if (toplam_puan >= 60)
                {
                    label9.Text = "YARIŞMAYI " + toplam_puan + " PUANLA BİTİRDİN, TEBRİKLER!!";

                }
                else
                {
                    label9.Text = "YARIŞMAYI " + toplam_puan + " PUANLA BİTİRDİN, DAHA İYİSİNİ YAPABİLİRSİN:)";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (sayac==1)

            {
                button3.BackColor = Color.Green;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
            }
            if (sayac==3)
            {
                button4.BackColor = Color.Green;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
            }
            if (sayac == 2)
            {
                button4.BackColor = Color.Green;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
            }
            if (sayac == 4)
            {
                toplam_puan = toplam_puan + 20;
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                label8.Text = toplam_puan.ToString();
                
            }
            if (sayac == 5)
            {
                label9.Visible = true;
                timer1.Stop();
                button2.BackColor = Color.Green;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                if (toplam_puan >= 60)
                {
                    label9.Text = "YARIŞMAYI " + toplam_puan + " PUANLA BİTİRDİN, TEBRİKLER!!";

                }
                else
                {
                    label9.Text = "YARIŞMAYI " + toplam_puan + " PUANLA BİTİRDİN, DAHA İYİSİNİ YAPABİLİRSİN:)";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (sayac == 3)
            {
                button4.BackColor = Color.Green;
                button2.BackColor = Color.Red;
                button1.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
            }
            if (sayac == 1)

            {
                button3.BackColor = Color.Green;
                button2.BackColor = Color.Red;
                button1.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
            }
            if (sayac == 2)
            {
                button4.BackColor = Color.Green;
                button2.BackColor = Color.Red;
                button1.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
            }
            if (sayac == 4)
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Red;
                button4.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
            }
            if (sayac == 5)
            {
                timer1.Stop();
                label9.Visible = true;
                toplam_puan = toplam_puan + 20;
                button2.BackColor = Color.Green;
                button1.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                label8.Text = toplam_puan.ToString();
                
                if (toplam_puan>=60)
                {
                    label9.Text = "YARIŞMAYI " + toplam_puan + " PUANLA BİTİRDİN, TEBRİKLER!!";

                }
                else
                {
                    label9.Text = "YARIŞMAYI " + toplam_puan + " PUANLA BİTİRDİN, DAHA İYİSİNİ YAPABİLİRSİN:)";
                }
               
            }
        }
        int sure=20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sure--;
            label10.Text = sure.ToString();
            if (sure==0)
            {
                timer1.Stop();
              DialogResult suredoldu=  MessageBox.Show("Süreniz Bitmiştir, Tekrar Deneyiniz", "SÜRE DOLDU!", MessageBoxButtons.OK);
                if (suredoldu==DialogResult.OK)
                {
                    this.Close();

                }
                
                
            }


        }
    }
}

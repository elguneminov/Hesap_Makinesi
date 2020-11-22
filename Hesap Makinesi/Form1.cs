using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1;
            int sayı2;
            int toplam;

            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);

            toplam = sayı1 + sayı2;

            label4.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, sonuc;

            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);

            sonuc = a * b;
            label5.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, sonuc;

            a = Convert.ToInt32(textBox6.Text);
            b = Convert.ToInt32(textBox5.Text);

            sonuc = a - b;
            label12.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, sonuc;

            a = Convert.ToInt32(textBox8.Text);
            b = Convert.ToInt32(textBox7.Text);

            sonuc = a / b;
            label17.Text = sonuc.ToString();
        }
    }
}

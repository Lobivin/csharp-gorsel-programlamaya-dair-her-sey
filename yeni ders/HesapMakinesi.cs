using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yeni_ders
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void dosyaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu frm = new AnaMenu();
            frm.Show();
        }

        private void çıkısToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Double Bir;
        String Isaret;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bir = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Isaret = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Bir = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Isaret = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Bir = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Isaret = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Bir = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Isaret = "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            label1.Text = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double Iki;
            double Sonuc;
            Iki = Convert.ToDouble(textBox1.Text);
            if (Isaret == "+")
            {
                Sonuc = (Bir + Iki);
                label1.Text = Sonuc.ToString();
            }
            if (Isaret == "-")
            {
                Sonuc = (Bir - Iki);
                label1.Text = Sonuc.ToString();
            }
            if (Isaret == "*")
            {
                Sonuc = (Bir * Iki);
                label1.Text =Sonuc.ToString();
            }
            if(Isaret == "/")
                if(Iki == 0)
                {
                    textBox1.Text = "Uygulanamaz";
                }
            else
                {
                    Sonuc = (Bir / Iki);
                    label1.Text = Sonuc.ToString();
                }
        }
    }
}

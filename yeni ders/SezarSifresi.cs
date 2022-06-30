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
    public partial class SezarSifresi : Form
    {
        public SezarSifresi()
        {
            InitializeComponent();
        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu frm = new AnaMenu();
            frm.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesa = "";
            mesa = textBox1.Text;
            int anahtar = Convert.ToInt32(textBox2.Text);
            char [] veri = mesa.ToCharArray();
            foreach(char elaman in veri)
            {
                textBox3.Text += Convert.ToChar(elaman + anahtar).ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sifre = "";
            sifre = textBox3.Text;
            int anahtar = Convert.ToInt32(textBox2.Text);
            char[] veri2 = sifre.ToCharArray();
            foreach (char elaman2 in veri2)
            {
                textBox1.Text += Convert.ToChar(elaman2 - anahtar).ToString();

            }
        
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}

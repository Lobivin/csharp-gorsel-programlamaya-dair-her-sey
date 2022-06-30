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
    public partial class FaktöriyelHesaplama : Form
    {
        public FaktöriyelHesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sonuc = 1;
            sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i < sayi; i++)
            {
                sonuc *= i;
            }
            label2.Text = sonuc.ToString();
            MessageBox.Show(sonuc.ToString());
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
    }
    }


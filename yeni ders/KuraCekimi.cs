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
    public partial class KuraCekimi : Form
    {
        public KuraCekimi()
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

        private void Form16_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ERTUĞRUL");
            listBox1.Items.Add("FURKAN");
            listBox1.Items.Add("YAVUZ");
            listBox1.Items.Add("SİNAN");
            listBox1.Items.Add("ÖMER");
            listBox1.Items.Add("ALİCAN");
            listBox1.Items.Add("RAHMET");
            listBox1.Items.Add("ZERDA");
            listBox1.Items.Add("OĞUZ");
            listBox1.Items.Add("İSA");
            listBox1.Items.Add("MESUT");
            listBox1.Items.Add("VAYNİ");
            listBox1.Items.Add("HARRY");
            listBox1.Items.Add("ASLI");
            listBox1.Items.Add("ASYA");
            listBox1.Items.Add("MELİSA");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int sayi = listBox1.Items.Count;
            int[] isimler = new int[sayi];
            Random rnd = new Random();
            int i = 0;
            while (i < 3)
            {
                int secim = rnd.Next(0, sayi);
                    if (Array.IndexOf(isimler, secim) == -1)
                {
                    isimler[i] = secim;
                    label1.Text += listBox1.Items[secim] + "\n";
                    i++;
                }
            }
        }
    }
}

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
    public partial class VizeFinal : Form
    {
        public VizeFinal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Vize = Convert.ToDouble(textBox1.Text);
            double Final = Convert.ToDouble(textBox2.Text);
            double ort = (Vize * 0.4) + (Final * 0.6);
            label5.Text = Convert.ToString(ort);
            if (ort < 50) { label6.Text = "ff"; }
            else if (ort < 60) { label6.Text = "cc"; }
            else if (ort < 70) { label6.Text = "cb"; }
            else if (ort < 80) { label6.Text = "bb"; }
            else if (ort < 90) { label6.Text = "ba"; }
            else if (ort <= 100) { label6.Text = "aa"; }
            else { label6.Text = "NOTLAR YANLIŞ"; }

        }
        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anaMenüToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu frm = new AnaMenu();
            frm.Show();
        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

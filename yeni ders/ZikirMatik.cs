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
    public partial class ZikirMatik : Form
    {
        public ZikirMatik()
        {
            InitializeComponent();
        }
        int sayi = 0;
     
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu frm = new AnaMenu();
            frm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //arti
            Convert.ToInt32(label1.Text);
            if (sayi > 48) { button1.Enabled = false; }
            else { button2.Enabled = true; }
            sayi++;
            label1.Text = (Convert.ToString(sayi));

            if
               (sayi <= 10) { label1.BackColor = Color.Red; }
            else if (sayi <= 20) { label1.BackColor = Color.Yellow; }
            else if (sayi <= 30) { label1.BackColor = Color.Orange; }
            else if (sayi <= 40) { label1.BackColor = Color.Blue; }
            else { label1.BackColor = Color.Pink; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //eksi
            if (sayi <= 1)
            {
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            sayi--;
            label1.Text = (Convert.ToString(sayi));
            if (sayi != -1) { Convert.ToString(sayi); }
            else { label1.Text = "0"; }
            if
             (sayi <= 10) { label1.BackColor = Color.Red; }
            else if (sayi <= 20) { label1.BackColor = Color.Yellow; }
            else if (sayi <= 30) { label1.BackColor = Color.Orange; }
            else if (sayi <= 40) { label1.BackColor = Color.Blue; }
            else { label1.BackColor = Color.Pink; }
        }
    }
}

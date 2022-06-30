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
    public partial class CevreHesaplama : Form
    {
        public CevreHesaplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa = Convert.ToInt32(textBox1.Text);
            int uzun = Convert.ToInt32(textBox2.Text);
            int alan = kisa * uzun;
            int cevre = (kisa + uzun);
            label3.Text = "Çevre =" + cevre;
            label4.Text = "Alan =" + alan;

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

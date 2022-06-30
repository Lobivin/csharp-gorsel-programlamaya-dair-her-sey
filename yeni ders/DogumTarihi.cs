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
    public partial class DogumTarihi : Form
    {
        public DogumTarihi()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu frm = new AnaMenu();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int yas;
            yas = 2022 - Convert.ToInt32(textBox1.Text);

            if (yas < 18)
            {
                MessageBox.Show("Yaşınız Uygun Değil..");
            }
            else
            {
             MessageBox.Show(Convert.ToString(yas));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

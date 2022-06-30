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
    public partial class AsalSayilar : Form
    {
        public AsalSayilar()
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
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);

            for (int i = s1; i <= s2; i++)
            {
                int kontrol = 0;
                for(int j=2; j<i; j++)
                {
                    if (i % j == 0)
                    {
                        kontrol++;
                        break;
                    }
                }
                if(kontrol == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Hareket : Form
    {
        public Hareket()
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

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Top += 25;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Left += 25;
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            checkBox1.Top -= 25;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Left -= 25;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }

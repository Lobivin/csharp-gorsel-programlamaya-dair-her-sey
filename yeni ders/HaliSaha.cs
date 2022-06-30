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
    public partial class HaliSaha : Form
    {
        public HaliSaha()
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

        private void button3Ekle_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 6)
            {
                MessageBox.Show("TAKIM 6 KİŞİDEN FAZLA OLAMAZ");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
            }

            textBox1.Text = "";
        }

        private void button1SİL_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Button1SAĞ_Click(object sender, EventArgs e)
        {

            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            if (listBox2.Items.Count >= 6)
            {
                MessageBox.Show("TAKIM 6 KİŞİDEN FAZLA OLAMAZ");
            }
            else
            {
                listBox2.Items.Add(textBox1.Text);
            }

            textBox1.Text = "";
        }

        private void button2SOL_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count >= 6)
            {
                MessageBox.Show("TAKIM 6 KİŞİDEN FAZLA OLAMAZ");
            }
            else
            {
                listBox2.Items.Add(textBox2.Text);
            }

            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

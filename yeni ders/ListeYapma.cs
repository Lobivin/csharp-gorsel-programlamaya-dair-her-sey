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
    public partial class ListeYapma : Form
    {
        public ListeYapma()
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

        private void Form7_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("elazığ");
            listBox1.Items.Add("antep");
            listBox1.Items.Add("giresun");
            listBox1.Items.Add("yalova");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // listBox1.Items.RemoveAt(2); İkinciyi silmek için kullanılır.
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex); //Seçtiğimiz item silinir.
            //MessageBox.Show(listBox1.Items.Count.ToString()); //Kalan itemin saısını mesajla gösterir.
            MessageBox.Show(listBox1.SelectedItem.ToString()); //Silinecek item gösterir
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Tüm itemleri temizler.
        }
    }
}

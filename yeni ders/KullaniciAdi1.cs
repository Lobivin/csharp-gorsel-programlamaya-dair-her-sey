﻿using System;
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
    public partial class KullaniciAdi1 : Form
    {
        public KullaniciAdi1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string Kullanici;

            string sifre;

            Kullanici = textBox1.Text;

            sifre = textBox2.Text;

            if (Kullanici == "m" && sifre == "1")
            {
                this.Hide();
                AnaMenu frm = new AnaMenu();
                frm.Show();
            }
            else
            {
                {
                    label3.Show();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Kullanici;

            string sifre;

            Kullanici = textBox1.Text;

            sifre = textBox2.Text;

            if (Kullanici == "e" && sifre == "1")
            {
                this.Hide();
                AnaMenu frm = new AnaMenu();
                frm.Show();
            }
            else
            {
                {
                    label3.Show();
                }
            }
        }
    }
}
        
   
    


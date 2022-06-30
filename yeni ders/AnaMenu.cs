using System;
using System.Windows.Forms;

namespace yeni_ders
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void zikirMatikToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ZikirMatik frm = new ZikirMatik();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hesapMakinasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HesapMakinesi frm = new HesapMakinesi();
            frm.Show();
        }

        private void halıSahaKadroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HaliSaha frm = new HaliSaha();
            frm.Show();
        }

        private void doğumTarihiHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DogumTarihi frm = new DogumTarihi();
            frm.Show();
        }

        private void listeYapmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListeYapma frm = new ListeYapma();
            frm.Show();
        }

        private void vizeFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            VizeFinal frm = new VizeFinal();
            frm.Show();
        }

        private void basitHesapMakinasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BasitHesapMakinasi frm = new BasitHesapMakinasi();
            frm.Show();
        }

        private void hareketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hareket frm = new Hareket();
            frm.Show();
        }

        private void sezarŞifresiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SezarSifresi frm = new SezarSifresi();
            frm.Show();
        }

        private void sayiTAHMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SayiTahmin frm = new SayiTahmin();
            frm.Show();
        }

        private void karakterSınırlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KarakterSinirlama frm =new KarakterSinirlama();
            frm.Show();
        }

        private void girilenSayıArasıHesaplamaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SayiAralariniHesaplama frm = new SayiAralariniHesaplama();
            frm.Show();
        }

        private void uygulamalar2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sayılarıAsalOlarakListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsalSayilar frm = new AsalSayilar();
            frm.Show();
        }

        private void kuraÇekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KuraCekimi frm = new KuraCekimi();
            frm.Show();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çevreHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CevreHesaplama frm = new CevreHesaplama();
            frm.Show();
        }

        private void dosyaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdSoyadEkleme frm = new AdSoyadEkleme();
            frm.Show();
        }

        private void faktöriyelHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaktöriyelHesaplama frm = new FaktöriyelHesaplama();
            frm.Show();
        }

        private void kareKökHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KareKökHesaplama frm = new KareKökHesaplama();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;

namespace yeni_ders
{
    partial class AnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zikirMatikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halıSahaKadroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doğumTarihiHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeYapmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizeFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basitHesapMakinasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hareketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezarŞifresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayiTAHMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karakterSınırlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamalar2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girilenSayıArasıHesaplamaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sayılarıAsalOlarakListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuraÇekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çevreHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faktöriyelHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kareKökHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(181, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİNİZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.derslerToolStripMenuItem,
            this.uygulamalar2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.indir__1_2;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            this.dosyaToolStripMenuItem.Click += new System.EventHandler(this.dosyaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.indir__1_1;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // derslerToolStripMenuItem
            // 
            this.derslerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zikirMatikToolStripMenuItem,
            this.hesapMakinasıToolStripMenuItem,
            this.halıSahaKadroToolStripMenuItem,
            this.doğumTarihiHesaplamaToolStripMenuItem,
            this.listeYapmaToolStripMenuItem,
            this.vizeFinalToolStripMenuItem,
            this.basitHesapMakinasıToolStripMenuItem,
            this.hareketToolStripMenuItem,
            this.sezarŞifresiToolStripMenuItem,
            this.sayiTAHMToolStripMenuItem,
            this.karakterSınırlamaToolStripMenuItem});
            this.derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            this.derslerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.derslerToolStripMenuItem.Text = "Uygulamalar";
            this.derslerToolStripMenuItem.Click += new System.EventHandler(this.derslerToolStripMenuItem_Click);
            // 
            // zikirMatikToolStripMenuItem
            // 
            this.zikirMatikToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.zikir;
            this.zikirMatikToolStripMenuItem.Name = "zikirMatikToolStripMenuItem";
            this.zikirMatikToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.zikirMatikToolStripMenuItem.Text = "ZikirMatik";
            this.zikirMatikToolStripMenuItem.Click += new System.EventHandler(this.zikirMatikToolStripMenuItem_Click_1);
            // 
            // hesapMakinasıToolStripMenuItem
            // 
            this.hesapMakinasıToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.hesap;
            this.hesapMakinasıToolStripMenuItem.Name = "hesapMakinasıToolStripMenuItem";
            this.hesapMakinasıToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.hesapMakinasıToolStripMenuItem.Text = "HesapMakinasi";
            this.hesapMakinasıToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinasıToolStripMenuItem_Click);
            // 
            // halıSahaKadroToolStripMenuItem
            // 
            this.halıSahaKadroToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.indir__2_1;
            this.halıSahaKadroToolStripMenuItem.Name = "halıSahaKadroToolStripMenuItem";
            this.halıSahaKadroToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.halıSahaKadroToolStripMenuItem.Text = "HaliSahaKadro";
            this.halıSahaKadroToolStripMenuItem.Click += new System.EventHandler(this.halıSahaKadroToolStripMenuItem_Click);
            // 
            // doğumTarihiHesaplamaToolStripMenuItem
            // 
            this.doğumTarihiHesaplamaToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.dogum;
            this.doğumTarihiHesaplamaToolStripMenuItem.Name = "doğumTarihiHesaplamaToolStripMenuItem";
            this.doğumTarihiHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.doğumTarihiHesaplamaToolStripMenuItem.Text = "DogumTarihiHesaplama";
            this.doğumTarihiHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.doğumTarihiHesaplamaToolStripMenuItem_Click);
            // 
            // listeYapmaToolStripMenuItem
            // 
            this.listeYapmaToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.liste;
            this.listeYapmaToolStripMenuItem.Name = "listeYapmaToolStripMenuItem";
            this.listeYapmaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listeYapmaToolStripMenuItem.Text = "ListeYapma";
            this.listeYapmaToolStripMenuItem.Click += new System.EventHandler(this.listeYapmaToolStripMenuItem_Click);
            // 
            // vizeFinalToolStripMenuItem
            // 
            this.vizeFinalToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.muslum;
            this.vizeFinalToolStripMenuItem.Name = "vizeFinalToolStripMenuItem";
            this.vizeFinalToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.vizeFinalToolStripMenuItem.Text = "VizeFinal";
            this.vizeFinalToolStripMenuItem.Click += new System.EventHandler(this.vizeFinalToolStripMenuItem_Click);
            // 
            // basitHesapMakinasıToolStripMenuItem
            // 
            this.basitHesapMakinasıToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.hesap;
            this.basitHesapMakinasıToolStripMenuItem.Name = "basitHesapMakinasıToolStripMenuItem";
            this.basitHesapMakinasıToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.basitHesapMakinasıToolStripMenuItem.Text = "BasitHesapMakinasi";
            this.basitHesapMakinasıToolStripMenuItem.Click += new System.EventHandler(this.basitHesapMakinasıToolStripMenuItem_Click);
            // 
            // hareketToolStripMenuItem
            // 
            this.hareketToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.hareket;
            this.hareketToolStripMenuItem.Name = "hareketToolStripMenuItem";
            this.hareketToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.hareketToolStripMenuItem.Text = "Hareket";
            this.hareketToolStripMenuItem.Click += new System.EventHandler(this.hareketToolStripMenuItem_Click);
            // 
            // sezarŞifresiToolStripMenuItem
            // 
            this.sezarŞifresiToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.ferdi;
            this.sezarŞifresiToolStripMenuItem.Name = "sezarŞifresiToolStripMenuItem";
            this.sezarŞifresiToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sezarŞifresiToolStripMenuItem.Text = "SezarSifresi";
            this.sezarŞifresiToolStripMenuItem.Click += new System.EventHandler(this.sezarŞifresiToolStripMenuItem_Click);
            // 
            // sayiTAHMToolStripMenuItem
            // 
            this.sayiTAHMToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.sayı;
            this.sayiTAHMToolStripMenuItem.Name = "sayiTAHMToolStripMenuItem";
            this.sayiTAHMToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sayiTAHMToolStripMenuItem.Text = "SayiTahminOyunu";
            this.sayiTAHMToolStripMenuItem.Click += new System.EventHandler(this.sayiTAHMToolStripMenuItem_Click);
            // 
            // karakterSınırlamaToolStripMenuItem
            // 
            this.karakterSınırlamaToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.orhan;
            this.karakterSınırlamaToolStripMenuItem.Name = "karakterSınırlamaToolStripMenuItem";
            this.karakterSınırlamaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.karakterSınırlamaToolStripMenuItem.Text = "Karakter Sınırlama";
            this.karakterSınırlamaToolStripMenuItem.Click += new System.EventHandler(this.karakterSınırlamaToolStripMenuItem_Click);
            // 
            // uygulamalar2ToolStripMenuItem
            // 
            this.uygulamalar2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girilenSayıArasıHesaplamaToolStripMenuItem1,
            this.sayılarıAsalOlarakListeleToolStripMenuItem,
            this.kuraÇekmeToolStripMenuItem,
            this.çevreHesaplamaToolStripMenuItem,
            this.dosyaToolStripMenuItem1,
            this.faktöriyelHesaplamaToolStripMenuItem,
            this.kareKökHesaplamaToolStripMenuItem});
            this.uygulamalar2ToolStripMenuItem.Name = "uygulamalar2ToolStripMenuItem";
            this.uygulamalar2ToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.uygulamalar2ToolStripMenuItem.Text = "Uygulamalar";
            this.uygulamalar2ToolStripMenuItem.Click += new System.EventHandler(this.uygulamalar2ToolStripMenuItem_Click);
            // 
            // girilenSayıArasıHesaplamaToolStripMenuItem1
            // 
            this.girilenSayıArasıHesaplamaToolStripMenuItem1.Image = global::yeni_ders.Properties.Resources.baris;
            this.girilenSayıArasıHesaplamaToolStripMenuItem1.Name = "girilenSayıArasıHesaplamaToolStripMenuItem1";
            this.girilenSayıArasıHesaplamaToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.girilenSayıArasıHesaplamaToolStripMenuItem1.Text = "Girilen Sayı Arası Hesaplama";
            this.girilenSayıArasıHesaplamaToolStripMenuItem1.Click += new System.EventHandler(this.girilenSayıArasıHesaplamaToolStripMenuItem1_Click);
            // 
            // sayılarıAsalOlarakListeleToolStripMenuItem
            // 
            this.sayılarıAsalOlarakListeleToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.neset;
            this.sayılarıAsalOlarakListeleToolStripMenuItem.Name = "sayılarıAsalOlarakListeleToolStripMenuItem";
            this.sayılarıAsalOlarakListeleToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.sayılarıAsalOlarakListeleToolStripMenuItem.Text = "Sayıları Asal Olarak Listele";
            this.sayılarıAsalOlarakListeleToolStripMenuItem.Click += new System.EventHandler(this.sayılarıAsalOlarakListeleToolStripMenuItem_Click);
            // 
            // kuraÇekmeToolStripMenuItem
            // 
            this.kuraÇekmeToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.liste1;
            this.kuraÇekmeToolStripMenuItem.Name = "kuraÇekmeToolStripMenuItem";
            this.kuraÇekmeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.kuraÇekmeToolStripMenuItem.Text = "Kura Çekme";
            this.kuraÇekmeToolStripMenuItem.Click += new System.EventHandler(this.kuraÇekmeToolStripMenuItem_Click);
            // 
            // çevreHesaplamaToolStripMenuItem
            // 
            this.çevreHesaplamaToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.indir1;
            this.çevreHesaplamaToolStripMenuItem.Name = "çevreHesaplamaToolStripMenuItem";
            this.çevreHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.çevreHesaplamaToolStripMenuItem.Text = "Çevre Hesaplama";
            this.çevreHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.çevreHesaplamaToolStripMenuItem_Click);
            // 
            // dosyaToolStripMenuItem1
            // 
            this.dosyaToolStripMenuItem1.Image = global::yeni_ders.Properties.Resources.kur;
            this.dosyaToolStripMenuItem1.Name = "dosyaToolStripMenuItem1";
            this.dosyaToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.dosyaToolStripMenuItem1.Text = "Ad Soyad ";
            this.dosyaToolStripMenuItem1.Click += new System.EventHandler(this.dosyaToolStripMenuItem1_Click);
            // 
            // faktöriyelHesaplamaToolStripMenuItem
            // 
            this.faktöriyelHesaplamaToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.Jerry;
            this.faktöriyelHesaplamaToolStripMenuItem.Name = "faktöriyelHesaplamaToolStripMenuItem";
            this.faktöriyelHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.faktöriyelHesaplamaToolStripMenuItem.Text = "Faktöriyel Hesaplama";
            this.faktöriyelHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.faktöriyelHesaplamaToolStripMenuItem_Click);
            // 
            // kareKökHesaplamaToolStripMenuItem
            // 
            this.kareKökHesaplamaToolStripMenuItem.Image = global::yeni_ders.Properties.Resources.ugur;
            this.kareKökHesaplamaToolStripMenuItem.Name = "kareKökHesaplamaToolStripMenuItem";
            this.kareKökHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.kareKökHesaplamaToolStripMenuItem.Text = "KareKök Hesaplama";
            this.kareKökHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.kareKökHesaplamaToolStripMenuItem_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaMenu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void zikirMatikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zikirMatikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halıSahaKadroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doğumTarihiHesaplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeYapmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizeFinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basitHesapMakinasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hareketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezarŞifresiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayiTAHMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karakterSınırlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamalar2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girilenSayıArasıHesaplamaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sayılarıAsalOlarakListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kuraÇekmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çevreHesaplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faktöriyelHesaplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kareKökHesaplamaToolStripMenuItem;
    }
}
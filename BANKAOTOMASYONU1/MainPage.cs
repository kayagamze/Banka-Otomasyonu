using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKAOTOMASYONU1
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        Musteri Musteri = new Musteri();
        public Musteri KaynakMusteri;
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Musteri m1 in AdminPage.Banka.MusteriListesi)
            {
                
                if (Login.GirisYapanKisi.Ad == m1.Ad && Login.GirisYapanKisi.Soyad == m1.Soyad && Login.GirisYapanKisi.Sifre == m1.Sifre)
                {
                    Musteri = m1;
                    this.KaynakMusteri = m1;
                    foreach (Hesap h in Musteri.Hesaplar)
                    {
                        lbhesaplar.Items.Add(h);
                        lb2hesaplar.Items.Add(h);
                    }
                }
            }
            foreach (Musteri m2 in AdminPage.Banka.MusteriListesi)
            {
                lb2musteriler.Items.Add(m2);
            }

        }

        private void btnhesapac_Click(object sender, EventArgs e)
        {
            Hesap EklenecekHesap = new Hesap();
            bool kontrol = true;
            foreach (Hesap h in Musteri.Hesaplar)
            {
                if (h.HesapNo == EklenecekHesap.HesapNo)
                {
                    kontrol = false;
                }
            }
            if (kontrol == true)
            {
                Musteri.HesapAcma(EklenecekHesap);
                lbhesaplar.Items.Clear();
                lb2hesaplar.Items.Clear();
                foreach (Hesap h in Musteri.Hesaplar)
                {
                    lbhesaplar.Items.Add(h);
                    lb2hesaplar.Items.Add(h);
                }
            }
        }

        private void btnhesapkapat_Click(object sender, EventArgs e)
        {
            Hesap KapanacakHesap = (Hesap)lbhesaplar.SelectedItem;
             if (KapanacakHesap.Bakiye == 0)
                {
                Musteri.HesapKapama(KapanacakHesap);
                lbhesaplar.Items.Clear();
                lb2hesaplar.Items.Clear();
                lbhesaplar.Items.Remove(lbhesaplar.SelectedItems);
                lb2hesaplar.Items.Remove(lbhesaplar.SelectedItems);
                foreach (Hesap h in Musteri.Hesaplar)
                {
                    lbhesaplar.Items.Add(h);
                    lb2hesaplar.Items.Add(h);
                }
                lblp1hesapno.Text = "";
                lblp1bakiye.Text = "";
                lblp1ehb.Text = "";
                }
             else
                {
                MessageBox.Show("Hesap kapatmak için bakiyeniz 0 TL olmalıdır.");
                }

        }
        public Hesap secilen_hesap { get; set; }


        private void btnparacek_Click(object sender, EventArgs e)
        {
            Hesap h = (Hesap)lbhesaplar.SelectedItem;
            decimal tutar = 0;
            tutar = Convert.ToInt64(txtcytutar.Text);
            Musteri.ParaCek(h, tutar);
            txtpcguncelbakiye.Text = Convert.ToString(h.Bakiye);
            txtpcguncelehb.Text = Convert.ToString(h.EkHesapBakiye);
            lbhesaplar.Items.Clear();
            lb2hesaplar.Items.Clear();
            foreach (Hesap hsp in Musteri.Hesaplar)
            {
                lbhesaplar.Items.Add(hsp);
                lb2hesaplar.Items.Add(hsp);
            }
        }

        private void btnparayatir_Click(object sender, EventArgs e)
        {
            Hesap h = (Hesap)lbhesaplar.SelectedItem;
            decimal tutar = 0;
            tutar = Convert.ToInt64(txtcytutar.Text);
            txtpyguncelbakiye.Text = Convert.ToString(Musteri.ParaYatir(h, tutar));
            txtpygehb.Text = Convert.ToString(h.EkHesapBakiye);
            lbhesaplar.Items.Clear();
            lb2hesaplar.Items.Clear();
            foreach (Hesap hsp in Musteri.Hesaplar)
            {
                lbhesaplar.Items.Add(hsp);
                lb2hesaplar.Items.Add(hsp);
            }
        }

        private void btnpcsifirla_Click(object sender, EventArgs e)
        {
            txtpcguncelbakiye.Text = "";
            txtpcguncelehb.Text = "";
            txtcytutar.Text = "";

        }

        private void btnpysifirla_Click(object sender, EventArgs e)
        {
            txtpyguncelbakiye.Text = "";
            txtpygehb.Text = "";
            txtcytutar.Text = "";
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            Login Giris = new Login();
            this.Hide();
            Giris.ShowDialog();
            this.Close();
            
        }

        private void btnhesapozeti_Click(object sender, EventArgs e)
        {
            AccountSummary HesapOzeti = new AccountSummary(this.secilen_hesap);
            this.Hide();
            HesapOzeti.ShowDialog();
            this.Show();            

        }
        public Musteri HedefMusteri;

        private void btnhavaleyap_Click(object sender, EventArgs e)
        {
            Hesap h1 = (Hesap)lb2hesaplar.SelectedItem;
            Hesap h2 = (Hesap)lb2musterihesap.SelectedItem;
            decimal tutar = 0; 
            tutar = Convert.ToDecimal(txthavaletutar.Text);
            Musteri.ParaHavale(h1,h2, this.KaynakMusteri, this.HedefMusteri, tutar);
            lbl2bakiye.Text = h1.Bakiye.ToString()+" TL";
            lbl2mbakiye.Text = h2.Bakiye.ToString()+" TL";
            lbl2hesapno.Text = h1.HesapNo.ToString();
            lbl2mhesapno.Text = h2.HesapNo.ToString();
            txthavaletutar.Text = "";
            lbhesaplar.Items.Clear();
            lb2hesaplar.Items.Clear();
            foreach (Hesap hsp in Musteri.Hesaplar)
            {
                lbhesaplar.Items.Add(hsp);
                lb2hesaplar.Items.Add(hsp);
            }
            Musteri m = (Musteri)lb2musteriler.SelectedItem;
            this.HedefMusteri = m;
            lb2musterihesap.Items.Clear();
            foreach (Musteri ms in AdminPage.Banka.MusteriListesi)
            {
                if (m.MusteriNo == ms.MusteriNo)
                {
                    foreach (Hesap h in ms.Hesaplar)
                    {
                        lb2musterihesap.Items.Add(h);
                    }
                }
            }

        }

        private void btnhesapbilgilerigetir_Click(object sender, EventArgs e)
        {
            Hesap h = (Hesap)lbhesaplar.SelectedItem;
            this.secilen_hesap = h;
            lblp1hesapno.Text = h.HesapNo.ToString();
            lblp1bakiye.Text = h.Bakiye.ToString() + " TL";
            lblp1ehb.Text = h.EkHesapBakiye.ToString() + " TL";

        }

        private void btn2mhesaplarilistele_Click(object sender, EventArgs e)
        {
            Musteri m = (Musteri)lb2musteriler.SelectedItem;
            this.HedefMusteri = m;
            lb2musterihesap.Items.Clear();
            foreach (Musteri ms in AdminPage.Banka.MusteriListesi)
            {
                if (m.MusteriNo == ms.MusteriNo)
                {
                    foreach (Hesap h in ms.Hesaplar)
                    {
                        lb2musterihesap.Items.Add(h);
                    }
                }
            }
        }
    }
}
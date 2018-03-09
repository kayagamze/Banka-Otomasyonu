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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static Kisi GirisYapanKisi= new Kisi();
        public static Yetkili Yetkili1 = new Yetkili("DENİZ","KILINÇ",1);

        private void btngiris_Click(object sender, EventArgs e)
        {
            MainPage Anasayfa = new MainPage();
            AdminPage YetkiliGirisi = new AdminPage();
            GirisYapanKisi.Ad = txtad.Text.ToUpper();
            GirisYapanKisi.Soyad = txtsoyad.Text.ToUpper();
            GirisYapanKisi.Sifre = Convert.ToInt32(txtsifre.Text);
            bool kontrol = true;
            if(kontrol ==true)
            {
                foreach (Musteri m in AdminPage.Banka.MusteriListesi)
                {
                    if (GirisYapanKisi.Ad == m.Ad && GirisYapanKisi.Soyad == m.Soyad && GirisYapanKisi.Sifre == m.Sifre)
                    {
                        kontrol = false;
                        this.Hide();
                        Anasayfa.ShowDialog();
                        this.Close();
                    }
                }
            }
            if(kontrol==true)
            {
                if (GirisYapanKisi.Ad == Yetkili1.Ad && GirisYapanKisi.Soyad == Yetkili1.Soyad && GirisYapanKisi.Sifre == Yetkili1.Sifre)
                {
                    this.Hide();
                    YetkiliGirisi.ShowDialog();
                    this.Close();
                }
                else if(kontrol==true)
                {
                    MessageBox.Show("Hatalı giriş yaptınız.Tekrar deneyiniz!");
                    txtad.Text = "";
                    txtsoyad.Text = "";
                    txtsifre.Text = "";
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}

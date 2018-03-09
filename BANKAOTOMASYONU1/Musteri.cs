using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKAOTOMASYONU1
{
  
    public class Musteri:Kisi
    {
        public List<Hesap> Hesaplar { get; set; }
        public Hesap Hesap1 { get; set; }
        public string Tip { get; set; }
        public int MusteriNo { get; set; }
        public Musteri()
        {
            this.Hesaplar = new List<Hesap>();
            this.Hesap1=new Hesap();
            Hesaplar.Add(Hesap1);
            Random r = new Random();
            this.MusteriNo = r.Next(3, 100);
        }
        public override void KisiBilgisiDoldur(string Ad, string Soyad)
        {
            base.KisiBilgisiDoldur(Ad, Soyad);

        }
        public Musteri(string ad,string soyad,int musterino,int sifre)
        {
            this.Ad = ad.ToUpper();
            this.Soyad = soyad.ToUpper();
            this.MusteriNo = musterino;
            this.Sifre = sifre;
        }

        public void HesapAcma(Hesap h)
        {
            Hesaplar.Add(h);
        }
        public void HesapKapama(Hesap h)
        {
            Hesaplar.Remove(h);
        }
        public void ParaCek(Hesap h,decimal Tutar)
        {
            foreach (Hesap hs in Hesaplar)
            {
                if(hs.HesapNo==h.HesapNo)
                {
                    if(Tutar <= 750)
                    {
                        if(Tutar <= h.Bakiye)
                        {
                            h.Bakiye -= Tutar;
                            AdminPage.Banka.GidenPara -= h.Bakiye;
                        }          
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Bakiyeniz yetersiz olduğu için ek hesabınızdan işlem yapıldı!");
                            h.EkHesapBakiye = h.EkHesapBakiye - Tutar;
                        }
                        HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
                        hesap_hareketi_h1.EklenenPara = 0;
                        hesap_hareketi_h1.CikanPara = Tutar;
                        hesap_hareketi_h1.Kim = this;
                        hesap_hareketi_h1.IslemTarihi = DateTime.Now;
                        hesap_hareketi_h1.IsTransfer = false;

                        h.HesapDefteriEkle(hesap_hareketi_h1);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Günlük para çekme limiti 750 TL'dir.İşleminiz gerçekleştirilemedi!");
                    }   
                }
            }
        }
        public decimal ParaYatir(Hesap h, decimal Tutar)
        {
            foreach (Hesap hs in Hesaplar)
            {
                if (hs.HesapNo == h.HesapNo)
                {
                    h.Bakiye += Tutar;
                    HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
                    hesap_hareketi_h1.EklenenPara = Tutar;
                    hesap_hareketi_h1.CikanPara = 0;
                    hesap_hareketi_h1.Kim = this;
                    hesap_hareketi_h1.IslemTarihi = DateTime.Now;
                    hesap_hareketi_h1.IsTransfer = false;

                    h.HesapDefteriEkle(hesap_hareketi_h1);
                    AdminPage.Banka.GelenPara += Tutar;
                }
            }
            return h.Bakiye;
        }
        public void ParaHavale(Hesap h1,Hesap h2, Musteri KaynakMusteri, Musteri HedefMusteri, decimal tutar)
        {
            decimal havaleucreti = 0;
            if(KaynakMusteri.Tip=="Bireysel")
            {
                havaleucreti= (tutar * 2) / 100;
                System.Windows.Forms.MessageBox.Show("Bireysel müşteri olduğunuz için "+havaleucreti+"TL havale ucreti kesildi!");
                h1.Bakiye -= havaleucreti;
            }
            h1.Bakiye -= tutar;
            h2.Bakiye += tutar;
            HesapOzeti hesap_hareketi_h1 = new HesapOzeti();
            hesap_hareketi_h1.EklenenPara = 0;
            hesap_hareketi_h1.CikanPara = tutar;
            hesap_hareketi_h1.Kim = HedefMusteri;
            hesap_hareketi_h1.IsTransfer = true;
            hesap_hareketi_h1.IslemTarihi = DateTime.Now;

            HesapOzeti hesap_hareketi_h2 = new HesapOzeti();
            hesap_hareketi_h2.EklenenPara = tutar;
            hesap_hareketi_h2.CikanPara = 0;
            hesap_hareketi_h2.IsTransfer = true;
            hesap_hareketi_h2.Kim = KaynakMusteri;
            hesap_hareketi_h2.IslemTarihi = hesap_hareketi_h1.IslemTarihi;

            h1.HesapDefteriEkle(hesap_hareketi_h1);
            h2.HesapDefteriEkle(hesap_hareketi_h2);
        
            System.Windows.Forms.MessageBox.Show("Havale başarıyla gerçekleştirildi!");

        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", "Ad:",Ad," Soyad:",Soyad," Müşteri No:",MusteriNo," Tipi:",Tip);
        }





    }
}

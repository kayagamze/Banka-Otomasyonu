using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKAOTOMASYONU1
{
    public class Yetkili:Kisi
    {
        public Yetkili (string Ad, string Soyad,int Sifre)
        {
            this.Ad = Ad.ToUpper();
            this.Soyad = Soyad.ToUpper();
            this.Sifre = Sifre;
        }
        public override void KisiBilgisiDoldur(string Ad, string Soyad)
        {
            base.KisiBilgisiDoldur(Ad, Soyad);

        }
    }

}

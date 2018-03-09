using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKAOTOMASYONU1
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TcKimlikNo { get; set; }
        public int Sifre { get; set; }
        public virtual void KisiBilgisiDoldur(string Ad, string Soyad)
        {
            this.Ad = Ad.ToUpper();
            this.Soyad = Soyad.ToUpper();
        }
    }
}

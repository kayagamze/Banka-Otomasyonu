using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKAOTOMASYONU1
{
    public class Hesap
    {

        public int HesapNo { get; set; }
        public decimal Bakiye { get; set; }
        public decimal EkHesapBakiye { get; set; }
        public List<HesapOzeti> HesapDefteri;
        public Hesap()
        {
            Random r = new Random();
            this.HesapNo = r.Next(1, 100);
            this.Bakiye = 100;
            this.EkHesapBakiye = 2000;
            this.HesapDefteri = new List<HesapOzeti>();
        }
        public void HesapDefteriEkle(HesapOzeti ozet)
        {
            this.HesapDefteri.Add(ozet);
        }
        public void LoadHesapHareketleriToGridView(DataGridView grid, DateTime baslangic, DateTime bitis)
        {
            string tutar = "";
            string kim = "";
            string tur = "";
            grid.Rows.Clear();
            foreach (HesapOzeti hesap_hareketi in this.HesapDefteri)
            {
                if (hesap_hareketi.IslemTarihi.Date >= baslangic.Date && hesap_hareketi.IslemTarihi.Date <= bitis.Date)
                {
                    if (hesap_hareketi.EklenenPara != 0)
                        tutar = "+" + hesap_hareketi.EklenenPara;
                    else
                        tutar = "-" + hesap_hareketi.CikanPara;
                    if (hesap_hareketi.IsTransfer == false)
                    {
                        kim = "";
                        tur = "ATM";
                    }
                    else
                    {
                        kim = hesap_hareketi.Kim.Ad + " " + hesap_hareketi.Kim.Soyad;
                        tur = "Havale";
                    }
                        
                    grid.Rows.Add(tutar, kim, hesap_hareketi.IslemTarihi.ToShortDateString(), tur);
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", "Hesap No:",HesapNo," Bakiye:",Bakiye,"TL","Ek Hesap Bakiye:",EkHesapBakiye,"TL");
        }




    }
}

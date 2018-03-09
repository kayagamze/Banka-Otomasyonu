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
    public partial class AccountSummary : Form
    {
        public Hesap ozetlenecek_hesap;
        public AccountSummary(Hesap ozeti_gosterilecek_hesap)
        {
            InitializeComponent();
            this.ozetlenecek_hesap = ozeti_gosterilecek_hesap;
            dataGridView1.Columns.Add("tutar", "Çekilen/Yatırılan");
            dataGridView1.Columns.Add("kime", "Kime/Kimden");
            dataGridView1.Columns.Add("tarih", "İşlem Tarihi");
            dataGridView1.Columns.Add("tur", "İşlem Tipi");
        }

        private void AccountSummary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ozetlenecek_hesap.LoadHesapHareketleriToGridView(dataGridView1, dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}

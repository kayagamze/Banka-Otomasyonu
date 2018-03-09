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
    public partial class AdminPage : Form
    {
        public Banka bankaApp;
        public AdminPage()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("in_tutar", "Gelen Para");
            dataGridView1.Columns.Add("out_tutar", "Giden Para");
            dataGridView1.Columns.Add("toplam", "Bankadaki Para");
        }
        public static Banka Banka = new Banka();
        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Musteri m in Banka.MusteriListesi)
            {
                lbmusteriler.Items.Add(m);
            }
            cmbmusteritipi.SelectedIndex = 0;
        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" || txtsoyad.Text == "" || txttckimlik.Text == "" || txtsifre.Text == "" || cmbmusteritipi.Text == "")
            {
                MessageBox.Show("Bu alanlar boş bırakılamaz.");
            }
            else
            {
                Musteri EklenecekMusteri = new Musteri();
                EklenecekMusteri.Ad = txtad.Text.ToUpper();
                EklenecekMusteri.Soyad = txtsoyad.Text.ToUpper();
                EklenecekMusteri.TcKimlikNo = Convert.ToInt64(txttckimlik.Text);
                EklenecekMusteri.Sifre = Convert.ToInt32(txtsifre.Text);
                EklenecekMusteri.Tip = cmbmusteritipi.Text;
                bool kontrol = true;
                foreach (Musteri m in AdminPage.Banka.MusteriListesi)
                {
                    if (m.MusteriNo == EklenecekMusteri.MusteriNo)
                        kontrol = false;
                    else if(m.TcKimlikNo==EklenecekMusteri.TcKimlikNo)
                    {
                        kontrol = false;
                        MessageBox.Show("Aynı Tc Kimlik numarasına sahip müşteri var.");
                    }
                }
                if (kontrol == true)
                {
                    AdminPage.Banka.MusteriEkle(EklenecekMusteri);
                    lbmusteriler.Items.Clear();
                    foreach (Musteri m in AdminPage.Banka.MusteriListesi)
                    {
                        lbmusteriler.Items.Add(m);
                        txtad.Text = "";
                        txtsoyad.Text = "";
                        txttckimlik.Text = "";
                        txtsifre.Text = "";
                    }
                }
            }
        }

        private void btngeridon_Click(object sender, EventArgs e)
        {
            Login Giris = new Login();
            this.Hide();
            Giris.ShowDialog();
            this.Close();
        }

        private void btnraporgoruntule_Click(object sender, EventArgs e)
        {
            decimal gelen_para = 0;
            decimal giden_para = 0;
            foreach (Musteri musteri in Banka.MusteriListesi)
            {
                foreach (Hesap hesap in musteri.Hesaplar)
                {
                    foreach (HesapOzeti hesap_hareketi in hesap.HesapDefteri)
                    {
                        if (hesap_hareketi.IsTransfer == false)
                        {
                            gelen_para += hesap_hareketi.EklenenPara;
                            giden_para += hesap_hareketi.CikanPara;
                        }
                    }
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(gelen_para.ToString(), giden_para.ToString(), (gelen_para - giden_para).ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyon_v1
{
    public partial class MusteriBilgi : Form
    {
        public Banka BankApp;

        public MusteriBilgi(Banka BankApp)
        {
            InitializeComponent();
            this.BankApp = BankApp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MusteriBilgi_Load(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (txtMusteriNo.Text == "")
            {
                MessageBox.Show("Müşteri numarası Girin !");
            }
            else if (BankApp.Musteriler.Count == 0)
            {
                MessageBox.Show("Bilgiler hatalı");
            }



            else
            {
                int musteriNo = Convert.ToInt32(txtMusteriNo.Text);
                foreach (Musteri m in BankApp.Musteriler)
                {

                    if (m.MusteriNo == musteriNo)
                    {
                        txtHesaplar.Text = "";
                        txtAd.Text = m.Adi;
                        txtSoyad.Text = m.Soyadi;
                        txtTC.Text = m.TC.ToString();
                        if (m.MusteriTuru == true)
                        {
                            txtMusteriTuru.Text = "Ticari Müşteri";
                        }
                        else
                        {
                            txtMusteriTuru.Text = "Bireysel Müşteri";

                        }

                        foreach (Hesap h in m.hesaplar)
                        {
                            txtHesaplar.Text += ("Hesap Numarası : " + h.HesapNo + "                 Bakiye : " + h.Bakiye + Environment.NewLine);
                        }


                    }

                }
            }
        }
    }
}




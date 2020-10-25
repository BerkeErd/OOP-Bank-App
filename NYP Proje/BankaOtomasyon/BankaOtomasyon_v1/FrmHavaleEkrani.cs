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
    public partial class FrmHavale : Form
    {
        public Banka BankApp;

        public FrmHavale(Banka BankApp)
        {
            InitializeComponent();
            this.BankApp = BankApp;
        }



        private void btnHavale_Click(object sender, EventArgs e)
        {

            if(txtTC.Text.Length ==0)
            { MessageBox.Show("Kimlik numarası boş olamaz !"); }

            else if (txtGonderenHesapNo.Text.Length == 0)
            { MessageBox.Show("Gönderen hesap numarası boş olamaz !"); }

            else if (txtHedefHesapNo.Text.Length == 0)
            { MessageBox.Show("Alıcı hesap numarası boş olamaz !"); }

            else if (txtMiktar.Text.Length == 0)
            { MessageBox.Show("Miktar boş olamaz !"); }

            else
            {
                int TC;
                int bizimHesapNo;
                int hedefHesapNo;
                decimal Miktar = 0;
                int i = 0; //biz
                int x = 0; //hedef
                


                Miktar = Convert.ToDecimal(txtMiktar.Text);
                hedefHesapNo = Convert.ToInt32(txtHedefHesapNo.Text);
                bizimHesapNo = Convert.ToInt32(txtGonderenHesapNo.Text);
                TC = Convert.ToInt32(txtTC.Text);
                txtMiktar.Text = "0";

                foreach (Musteri n in BankApp.Musteriler)
                {


                    foreach (Hesap h in n.hesaplar)
                    {
                        if (bizimHesapNo == h.HesapNo && TC == h.HesapSahibi.TC)
                        {
                            i++;

                            foreach (Hesap h2 in BankApp.Hesaplar)
                            {

                                if (hedefHesapNo == h2.HesapNo)
                                {
                                    x++;
                                    n.HesabaHavale(h, Miktar, h2);
                                    break;
                                }

                            }


                        }

                    }
                }



                if (i == 0)
                    MessageBox.Show("Gönderen Hesap Numarası veya TC Kimlik Hatalıdır");
                else if (x == 0)
                    MessageBox.Show("Alıcı Hesap Numarası Bulunamadı");
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtGonderenHesapNo_TextChanged(object sender, EventArgs e)
        {
            foreach (Hesap h in BankApp.Hesaplar)
            {
                if (txtGonderenHesapNo.Text != "")
                {
                    if (h.HesapNo == Convert.ToInt32(txtGonderenHesapNo.Text))
                    {
                        txtMiktar.Enabled = true;
                        break;
                    }
                    else
                        txtMiktar.Enabled = false;
                }
            }


        }

        private void FrmHavale_Load(object sender, EventArgs e)
        {

        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            foreach (Musteri m in BankApp.Musteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (h.HesapNo == Convert.ToInt32(txtGonderenHesapNo.Text))
                    {

                        if (h.HesapSahibi.MusteriTuru == true)//ticari ise
                        {
                            txtGereken.Text = txtMiktar.Text;
                        }
                        else
                        {
                            if (txtMiktar.Text == null)

                                txtGereken.Text = "0";
                            else
                                txtGereken.Text = (Convert.ToInt32(txtMiktar.Text) / 100 * 2 + Convert.ToInt32(txtMiktar.Text)).ToString();
                        }

                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

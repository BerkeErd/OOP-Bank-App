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

    public partial class FrmParaYatirmaVeCekme : Form
    {
        public Banka BankApp;
        public FrmParaYatirmaVeCekme(Banka BankApp)
        {
            InitializeComponent();
            this.BankApp = BankApp;
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            if (txtTC.Text.Length == 0)
            {
                MessageBox.Show("Kimlik numarası boş olamaz !");
            }

            else if (txtHesapNo.Text.Length == 0)
            {
                MessageBox.Show("hesap numarası boş olamaz !");
            }

            else if (txtMiktar.Text == "")
            {
                MessageBox.Show("Miktar boş olamaz !");
            }

            else
            {
                int Miktar = Convert.ToInt32(txtMiktar.Text);
                int HesapNo = Convert.ToInt32(txtHesapNo.Text);
                string TC = txtTC.Text;
                int i = 0;


                foreach (Musteri n in BankApp.Musteriler)
                {
                    foreach (Hesap h in n.hesaplar)
                    {
                        if (HesapNo == h.HesapNo && TC == h.HesapSahibi.TC)
                        {

                            i++;
                            h.ParaYatirma(BankApp, h, Miktar);

                            txtBakiye.Text = h.Bakiye.ToString();
                        }

                    }

                }
                if (i == 0)
                    MessageBox.Show("Bilgiler Hatalı");



            }
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            {
                if (txtTC.Text.Length == 0)
                {
                    MessageBox.Show("Kimlik numarası boş olamaz !");
                }

                else if (txtHesapNo.Text.Length == 0)
                {
                    MessageBox.Show("hesap numarası boş olamaz !");
                }

                else if (txtMiktar.Text == "")
                {
                    MessageBox.Show("Miktar boş olamaz !");
                }

                else
                {
                    int Miktar = Convert.ToInt32(txtMiktar.Text);
                    int HesapNo = Convert.ToInt32(txtHesapNo.Text);
                    string TC = txtTC.Text;
                    int i = 0;


                    foreach (Musteri n in BankApp.Musteriler)
                    {
                        foreach (Hesap h in n.hesaplar)
                        {
                            if (HesapNo == h.HesapNo && TC == h.HesapSahibi.TC)
                            {

                                i++;
                                h.ParaCekme(BankApp, h, Miktar);

                                txtBakiye.Text = h.Bakiye.ToString();
                            }

                        }

                    }
                    if (i == 0)
                        MessageBox.Show("Bilgiler Hatalı");
                }


            }
        }

        private void FrmParaYatirmaVeCekme_Load(object sender, EventArgs e)
        {

        }
    }
}

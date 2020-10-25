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
    public partial class FrmHesapKapatma : Form
    {
        public Banka BankApp;

        public FrmHesapKapatma(Banka BankApp)
        {
            InitializeComponent();
            this.BankApp = BankApp;
        }

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            if(txtHesapNo.Text.Length==0)
            { MessageBox.Show("Hesap numarası boş olamaz !"); }

            else if (txtTC.Text.Length == 0)
            { MessageBox.Show("Kimlik numarası boş olamaz !"); }

            else
            {
                int TC;
                int HesapNo;
                int t = 0;
                TC = Convert.ToInt32(txtTC.Text);
                HesapNo = Convert.ToInt32(txtHesapNo.Text);

                foreach (Musteri m in BankApp.Musteriler)
                {
                    foreach (Hesap h in m.hesaplar)
                    {
                        if (h.HesapNo == HesapNo && h.HesapSahibi.TC == TC)
                        {
                            t++;
                            m.HesapSil(BankApp, m, h);
                            break;
                        }
                    }

                }
                if (t == 0)
                    MessageBox.Show("İşlem Başarısız");
            }
        }

        private void FrmHesapKapatma_Load(object sender, EventArgs e)
        {

        }
    }
}

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
   

    public partial class FrmHesapAcmaEkrani : Form
    {
        public Banka BankApp;

        public FrmHesapAcmaEkrani(Banka BankApp)
        {
            InitializeComponent();
            this.BankApp = BankApp;

        }

        

        private void btnOzet_Click(object sender, EventArgs e)
        {

            if (txtMusteriNo.Text.Length == 0)
            { MessageBox.Show("Müşteri numarası hatalı !"); }

            else if (txtTC.Text.Length == 0)
            { MessageBox.Show("Kimlik numarası hatalı !"); }

            else
            {
                int musteriNo = Convert.ToInt32(txtMusteriNo.Text);
                string TC = txtTC.Text;
                int i = 0;



                foreach (Musteri m in BankApp.Musteriler)
                {
                    if (musteriNo == m.MusteriNo && TC == m.TC)
                    {
                        m.HesapAc(BankApp, m);



                        i++;
                        break;
                    }

                }
                if (i == 0)
                    MessageBox.Show("Hesap Açılamadı");


            }


        }

        private void FrmHesapAcmaEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}

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

    public partial class FrmHesapOzeti : Form
    {
        public Banka BankApp;
        public FrmHesapOzeti(Banka BankApp)
        {
            InitializeComponent();
            this.BankApp = BankApp;
        }

        private void HesapOzeti_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHesapOzet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOzet_Click(object sender, EventArgs e)
        {

        }

        private void btnOzet_Click_1(object sender, EventArgs e)
        {
            if (txtHesapNo.Text.Length == 0)
            { MessageBox.Show("Hesap numarası boş olamaz !"); }

            if (txtTC.Text.Length == 0)
            { MessageBox.Show("Kimlik numarası boş olamaz !"); }

            else
            {
                int hesapNo = Convert.ToInt32(txtHesapNo.Text);
                int TC = Convert.ToInt32(txtTC.Text);
                int a = 0;
                int t = 0;

                DateTime Baslangic;
                DateTime Bitis;
                Baslangic = dtTarihBas.Value;
                Bitis = dtTarihSon.Value;

                dtTarihSon.MinDate = dtTarihBas.Value;
                
                dtgOzet.Rows.Clear();

                foreach (Hesap h in BankApp.Hesaplar)
                {
                    if (hesapNo == h.HesapNo && TC == h.HesapSahibi.TC)
                    {
                        foreach (Islem i in h.İşlemler)
                        {
                            if ((i.Zaman.Day >= Baslangic.Day) && (i.Zaman.Day <= Bitis.Day))
                            {
                                a = dtgOzet.Rows.Add();

                                dtgOzet.Rows[a].Cells[0].Value = i.Zaman;
                                dtgOzet.Rows[a].Cells[1].Value = h.HesapNo;
                                dtgOzet.Rows[a].Cells[2].Value = i.Olay;
                                a++;
                            }
                        }
                        t++;
                        break;
                    }


                }
                if (t == 0)
                {
                    MessageBox.Show("Girdiğiniz bilgiler hatalı");

                }
            }
        }

        private void dtTarihBas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

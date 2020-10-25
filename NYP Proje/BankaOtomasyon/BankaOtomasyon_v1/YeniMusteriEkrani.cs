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


    public partial class FrmYeniMusteriEkrani : Form
    {
        public Banka BankApp;


        public FrmYeniMusteriEkrani(Banka BankApp)
        {
            InitializeComponent();
            this.BankApp = BankApp;

        }


        private void chkBireysel_CheckedChanged(object sender, EventArgs e)
        {
            chkTicari.Enabled = false;

            if (chkBireysel.Checked == false)
                chkTicari.Enabled = true;
        }

        private void chkTicari_CheckedChanged(object sender, EventArgs e)
        {
            chkBireysel.Enabled = false;
            txtVergiNo.Enabled = true;
            txtVergiNo.Visible = true;
            lblVergiNo.Visible = true;

            if (chkTicari.Checked == false)
            {
                chkBireysel.Enabled = true;
                txtVergiNo.Enabled = false;
                txtVergiNo.Visible = false;
                lblVergiNo.Visible = false;
            }

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text.Length == 0)
            {
                MessageBox.Show("Geçerli isim giriniz !");
            }
            else if (txtSoyisim.Text.Length == 0)
            { MessageBox.Show("Geçerli soyad giriniz !"); }

            else if (txtTC.Text.Length == 0)
            { MessageBox.Show("Geçerli kimlik numarası giriniz !"); }



            else
            {


                if (chkBireysel.Checked == true)
                {
                    BireyselMusteri b = new BireyselMusteri();

                    b.Adi = txtIsim.Text;
                    b.Soyadi = txtSoyisim.Text;
                    b.TC = txtTC.Text;
                    b.MusteriNo += BankApp.Musteriler.Count;
                    b.MusteriTuru = false; //bireysel musteri

                    txtMusteriNo.Text = b.MusteriNo.ToString();
                    MessageBox.Show("Müşteri Numaranız :" + b.MusteriNo + " Lütfen Kaydedin");
                    BankApp.MusteriEkle(b);
                }

                else if (chkTicari.Checked == true)
                {
                    if (txtVergiNo.Text.Length == 0)
                    {
                        MessageBox.Show("Geçersiz Vergi Numarasi");
                    }

                    else
                    {
                        TicariMusteri t = new TicariMusteri();
                        t.Adi = txtIsim.Text;
                        t.Soyadi = txtSoyisim.Text;
                        t.VergiNumarasi = Convert.ToInt32(txtVergiNo.Text);
                        t.MusteriTuru = true; //ticari musteri
                        t.TC = txtTC.Text;
                        t.MusteriNo += BankApp.Musteriler.Count;


                        txtMusteriNo.Text = t.MusteriNo.ToString();
                        MessageBox.Show("Müşteri Numaranız :" + t.MusteriNo + " Lütfen Kaydedin");
                        BankApp.MusteriEkle(t);
                    }

                }
                else

                    MessageBox.Show("Müsteri Türünü Seçiniz.");
            }

        }



        private void FrmYeniMusteriEkrani_Load(object sender, EventArgs e)
        {

        }


    }
}

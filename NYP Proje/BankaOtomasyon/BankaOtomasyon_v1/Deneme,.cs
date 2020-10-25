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
    public partial class Frm_AnaMenu : Form
    {
        public Frm_AnaMenu()
        {
            InitializeComponent();
            
        }


        Banka BankApp = new Banka();


        private void button1_Click(object sender, EventArgs e)
        {

            BireyselMusteri b = new BireyselMusteri();
            TicariMusteri t = new TicariMusteri();
    

            b.Adi = "emre";
            b.Soyadi = "cırganıs";
            b.MusteriNo = 12345;
          

            t.Adi = "aşi";
            t.Soyadi = "asfas";
            t.MusteriNo = 15454;
          

            b.HesapAc(b);
      
           

            //b.HesabaHavale(h, 200, h2);

            MessageBox.Show("" + b.hesaplar);





            MessageBox.Show(t.Soyadi);
            MessageBox.Show(b.Adi);
           



        }

        private void Frm_AnaMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteriEkrani y = new FrmYeniMusteriEkrani(BankApp);
            y.Show();
        }
    }
}

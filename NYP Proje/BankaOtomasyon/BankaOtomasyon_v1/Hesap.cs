using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon_v1
{
    public class Hesap
    {
        public int HesapNo { get; set; }
        public decimal Bakiye { get; set; }
        public Musteri HesapSahibi { get; set; }
        public DateTime SonÇekim { get; set; }
        public decimal Sınır { get; set; }

        public List<Islem> İşlemler = new List<Islem>();
        public Islem İşlem { get; set; }

        public Hesap()
        {
            this.İşlem = new Islem();

            Random rnd = new Random();
            HesapNo = rnd.Next(1000000, 9999999);
            Bakiye = 0;
            Sınır = 750;



        }

        public void ParaCekme(Banka b, Hesap hesap, decimal para)
        {
            if (para > hesap.Bakiye)
            {
                System.Windows.Forms.MessageBox.Show("Bakiyeniz Yetersiz");

            }
            else
            {
                if (DateTime.Now.Day != SonÇekim.Day)
                {
                    Sınır = 750;
                }
                Sınır -= para;
                if (Sınır >= 0)
                {
                    this.İşlem = new Islem();
                    hesap.Bakiye -= para;
                    b.Kasa -= para;                   
                    hesap.İşlem.Olay = "-" + para.ToString() + " TL" + " para çekildi. ";
                    hesap.İşlem.Zaman = DateTime.Now;
                    hesap.İşlemler.Add(hesap.İşlem);


                    SonÇekim = DateTime.Now;
                    System.Windows.Forms.MessageBox.Show("İşlem Başarılı");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Günlük 750 TL para çekme sınırını aştınız.");
                }
            }
        }

        public void ParaYatirma(Banka b, Hesap hesap, decimal para)
        {
            this.İşlem = new Islem();
            hesap.Bakiye += para;
            b.Kasa += para;            
            hesap.İşlem.Olay = "+" + para.ToString() + " TL" + " para yatırıldı. ";
            hesap.İşlem.Zaman = DateTime.Now;
            hesap.İşlemler.Add(hesap.İşlem);

            System.Windows.Forms.MessageBox.Show("İşlem Başarılı");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon_v1
{

    public abstract class Musteri
    {


        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public int MusteriNo = 1;
        public bool MusteriTuru; //eğer ticari ise true bireysel ise false olacak  

        public int TC { get; set; }
        public List<Hesap> hesaplar = new List<Hesap>();




        public Musteri()
        {




        }
        public void HesapAc(Banka Banka, Musteri m)
        {
            Random rnd = new Random();
            Hesap h = new Hesap();

            h.HesapSahibi = m;

            m.hesaplar.Add(h);


            x:
            foreach (Hesap t in Banka.Hesaplar)
            {
                if (h.HesapNo == t.HesapNo)
                {
                    h.HesapNo = rnd.Next(1000000, 9999999);
                    goto x;
                }

            }

            Banka.Hesaplar.Add(h);

            System.Windows.Forms.MessageBox.Show("Hesabınız Açıldı!" + Environment.NewLine + "Hesap Numarasi : " + h.HesapNo);



        }

        public void HesapSil(Banka Banka, Musteri m, Hesap h)
        {

            if (h.Bakiye != 0)
                System.Windows.Forms.MessageBox.Show("Bakiyeniz 0 TL olmadığı için hesabınız kapatılamıyor.");

            else
            {
                m.hesaplar.Remove(h);
                Banka.Hesaplar.Remove(h);
                System.Windows.Forms.MessageBox.Show("Hesabınız Kapatıldı");
                /*
                 *Hesap Bakiyesi 0 olmali. 
                 */
            }
        }




        public abstract void HesabaHavale(Hesap Gonderen, decimal miktar, Hesap Alan);
       






    }
}

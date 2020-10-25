using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon_v1
{
    public class Banka
    {
        public List<Musteri> Musteriler = new List<Musteri>();
        public List<Hesap> Hesaplar = new List<Hesap>();
        public decimal Kasa { get; set; }
        
        public void MusteriEkle(Musteri m)
        {
            Musteriler.Add(m);
        }

        public Banka()
        {
            
            
        }


    }
}


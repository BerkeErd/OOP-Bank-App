﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon_v1
{
    public class TicariMusteri : Musteri
    {

        public int VergiNumarasi { get; set; }

        public override void HesabaHavale(Hesap Gonderen, decimal miktar, Hesap Alan)
        {
            Gonderen.İşlem = new Islem();
            Alan.İşlem = new Islem();

            if (Gonderen.HesapNo == Alan.HesapNo)
            {
                System.Windows.Forms.MessageBox.Show("Kendine Havale Gönderemezsin!");
            }
            else
            {
                if (miktar > Gonderen.Bakiye)
                {
                    System.Windows.Forms.MessageBox.Show("Bakiyeniz Yetersiz");
                }
                else
                {

                    Gonderen.Bakiye -= miktar;
                    Alan.Bakiye += miktar;

                    Gonderen.İşlem.Olay = "-" + miktar.ToString() + " TL " + Alan.HesapNo + " Nolu hesaba havale yapılmıştır.";
                    Gonderen.İşlem.Zaman = DateTime.Now;
                    Gonderen.İşlemler.Add(Gonderen.İşlem);

                    Alan.İşlem.Olay = "+" + miktar.ToString() + "TL" + Gonderen.HesapNo + " Nolu hesaptan havale gelmiştir.";
                    Alan.İşlem.Zaman = DateTime.Now;
                    Alan.İşlemler.Add(Alan.İşlem);


                    System.Windows.Forms.MessageBox.Show("İşlem Başarılı");



                }
            }
        }





    }
}

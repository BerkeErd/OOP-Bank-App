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
    public partial class FrmBankaGelirGider : Form
    {
        public Banka BankApp;

        public FrmBankaGelirGider(Banka BankApp)
        {
            InitializeComponent();
            this.BankApp = BankApp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmBankaGelirGider_Load(object sender, EventArgs e)
        {
            decimal Bakiye = 0;
            Bakiye = BankApp.Kasa;

            int a = 0;

            lblBakiye.Text = Bakiye.ToString();
           

            foreach (Hesap h in BankApp.Hesaplar)
            {
                
                    foreach (Islem i in h.İşlemler)
                    {
                        
                        
                            a = dtgGelirGider.Rows.Add();

                            dtgGelirGider.Rows[a].Cells[0].Value = i.Zaman;
                            dtgGelirGider.Rows[a].Cells[1].Value = h.HesapNo;
                            dtgGelirGider.Rows[a].Cells[2].Value = i.Olay;
                            a++;
                        
                    }
                    
                


            }
        }
    }
}

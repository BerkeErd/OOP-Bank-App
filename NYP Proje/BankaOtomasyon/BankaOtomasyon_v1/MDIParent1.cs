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
    public partial class MDIParent1 : Form
    {
        // private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();



        }

        Banka BankApp = new Banka();





        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }





        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {


            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void hesapKApatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        private void hesapKApatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FrmHesapKapatma y = new FrmHesapKapatma(BankApp);
            y.MdiParent = this;
            y.Show();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)

        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            FrmYeniMusteriEkrani y = new FrmYeniMusteriEkrani(BankApp);
            y.MdiParent = this;

            y.Show();
        }

        private void hesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FrmHesapAcmaEkrani y = new FrmHesapAcmaEkrani(BankApp);
            y.MdiParent = this;
            y.Show();
        }

        private void hesapÖzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FrmHesapOzeti y = new FrmHesapOzeti(BankApp);
            y.MdiParent = this;
            y.Show();
        }

        private void paraÇekYatırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FrmParaYatirmaVeCekme y = new FrmParaYatirmaVeCekme(BankApp);
            y.MdiParent = this;
            y.Show();
        }

        private void havaleGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FrmHavale y = new FrmHavale(BankApp);
            y.MdiParent = this;
            y.Show();

        }

        private void gelirGiderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FrmBankaGelirGider y = new FrmBankaGelirGider(BankApp);
            y.MdiParent = this;
            y.Show();


        }



        private void hesapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            MusteriBilgi y = new MusteriBilgi(BankApp);
            y.MdiParent = this;
            y.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

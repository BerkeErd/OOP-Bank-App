namespace BankaOtomasyon_v1
{
    partial class MDIParent1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapKApatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapÖzetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekYatırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.hesapToolStripMenuItem,
            this.işlemlerToolStripMenuItem,
            this.bankaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(624, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.yeniToolStripMenuItem.Text = "Yeni Müşteri";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapAçToolStripMenuItem,
            this.hesapKApatToolStripMenuItem,
            this.hesapÖzetiToolStripMenuItem});
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.hesapToolStripMenuItem.Text = "Hesap";
            this.hesapToolStripMenuItem.Click += new System.EventHandler(this.hesapToolStripMenuItem_Click);
            // 
            // hesapAçToolStripMenuItem
            // 
            this.hesapAçToolStripMenuItem.Name = "hesapAçToolStripMenuItem";
            this.hesapAçToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.hesapAçToolStripMenuItem.Text = "Hesap Aç";
            this.hesapAçToolStripMenuItem.Click += new System.EventHandler(this.hesapAçToolStripMenuItem_Click);
            // 
            // hesapKApatToolStripMenuItem
            // 
            this.hesapKApatToolStripMenuItem.Name = "hesapKApatToolStripMenuItem";
            this.hesapKApatToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.hesapKApatToolStripMenuItem.Text = "Hesap Kapat";
            this.hesapKApatToolStripMenuItem.Click += new System.EventHandler(this.hesapKApatToolStripMenuItem_Click_1);
            // 
            // hesapÖzetiToolStripMenuItem
            // 
            this.hesapÖzetiToolStripMenuItem.Name = "hesapÖzetiToolStripMenuItem";
            this.hesapÖzetiToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.hesapÖzetiToolStripMenuItem.Text = "Hesap Özeti";
            this.hesapÖzetiToolStripMenuItem.Click += new System.EventHandler(this.hesapÖzetiToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraÇekYatırToolStripMenuItem,
            this.havaleGönderToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // paraÇekYatırToolStripMenuItem
            // 
            this.paraÇekYatırToolStripMenuItem.Name = "paraÇekYatırToolStripMenuItem";
            this.paraÇekYatırToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.paraÇekYatırToolStripMenuItem.Text = "Para Çek/Yatır";
            this.paraÇekYatırToolStripMenuItem.Click += new System.EventHandler(this.paraÇekYatırToolStripMenuItem_Click);
            // 
            // havaleGönderToolStripMenuItem
            // 
            this.havaleGönderToolStripMenuItem.Name = "havaleGönderToolStripMenuItem";
            this.havaleGönderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.havaleGönderToolStripMenuItem.Text = "Havale Gönder";
            this.havaleGönderToolStripMenuItem.Click += new System.EventHandler(this.havaleGönderToolStripMenuItem_Click);
            // 
            // bankaToolStripMenuItem
            // 
            this.bankaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirGiderListesiToolStripMenuItem,
            this.müşteriBilgileriToolStripMenuItem});
            this.bankaToolStripMenuItem.Name = "bankaToolStripMenuItem";
            this.bankaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.bankaToolStripMenuItem.Text = "Banka";
            // 
            // gelirGiderListesiToolStripMenuItem
            // 
            this.gelirGiderListesiToolStripMenuItem.Name = "gelirGiderListesiToolStripMenuItem";
            this.gelirGiderListesiToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.gelirGiderListesiToolStripMenuItem.Text = "Gelir Gider Listesi";
            this.gelirGiderListesiToolStripMenuItem.Click += new System.EventHandler(this.gelirGiderListesiToolStripMenuItem_Click);
            // 
            // müşteriBilgileriToolStripMenuItem
            // 
            this.müşteriBilgileriToolStripMenuItem.Name = "müşteriBilgileriToolStripMenuItem";
            this.müşteriBilgileriToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.müşteriBilgileriToolStripMenuItem.Text = "Müşteri Bilgileri";
            this.müşteriBilgileriToolStripMenuItem.Click += new System.EventHandler(this.müşteriBilgileriToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 515);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::BankaOtomasyon_v1.Properties.Resources.banka;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 537);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(640, 575);
            this.MinimumSize = new System.Drawing.Size(640, 575);
            this.Name = "MDIParent1";
            this.Text = "Banka";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekYatırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapKApatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapÖzetiToolStripMenuItem;
    }
}




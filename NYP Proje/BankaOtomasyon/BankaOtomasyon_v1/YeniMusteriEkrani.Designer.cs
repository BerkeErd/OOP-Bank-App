namespace BankaOtomasyon_v1
{
    partial class FrmYeniMusteriEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.chkBireysel = new System.Windows.Forms.CheckBox();
            this.chkTicari = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.lblVergiNo = new System.Windows.Forms.Label();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(253, 93);
            this.txtIsim.MaxLength = 16;
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 20);
            this.txtIsim.TabIndex = 2;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(253, 133);
            this.txtSoyisim.MaxLength = 16;
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtSoyisim.TabIndex = 3;
            // 
            // chkBireysel
            // 
            this.chkBireysel.AutoSize = true;
            this.chkBireysel.Location = new System.Drawing.Point(167, 240);
            this.chkBireysel.Name = "chkBireysel";
            this.chkBireysel.Size = new System.Drawing.Size(99, 17);
            this.chkBireysel.TabIndex = 4;
            this.chkBireysel.Text = "Bireysel Müşteri";
            this.chkBireysel.UseVisualStyleBackColor = true;
            this.chkBireysel.CheckedChanged += new System.EventHandler(this.chkBireysel_CheckedChanged);
            // 
            // chkTicari
            // 
            this.chkTicari.AutoSize = true;
            this.chkTicari.Location = new System.Drawing.Point(301, 240);
            this.chkTicari.Name = "chkTicari";
            this.chkTicari.Size = new System.Drawing.Size(89, 17);
            this.chkTicari.TabIndex = 5;
            this.chkTicari.Text = "Ticari Müşteri";
            this.chkTicari.UseVisualStyleBackColor = true;
            this.chkTicari.CheckedChanged += new System.EventHandler(this.chkTicari_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri Numarası";
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(251, 309);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.ReadOnly = true;
            this.txtMusteriNo.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriNo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(217, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yeni Müşteri";
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Enabled = false;
            this.txtVergiNo.Location = new System.Drawing.Point(246, 273);
            this.txtVergiNo.MaxLength = 11;
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(100, 20);
            this.txtVergiNo.TabIndex = 14;
            this.txtVergiNo.Visible = false;
            // 
            // lblVergiNo
            // 
            this.lblVergiNo.AutoSize = true;
            this.lblVergiNo.Location = new System.Drawing.Point(164, 280);
            this.lblVergiNo.Name = "lblVergiNo";
            this.lblVergiNo.Size = new System.Drawing.Size(78, 13);
            this.lblVergiNo.TabIndex = 13;
            this.lblVergiNo.Text = "Vergi Numarası";
            this.lblVergiNo.Visible = false;
            // 
            // btnMusteri
            // 
            this.btnMusteri.Location = new System.Drawing.Point(421, 313);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(104, 64);
            this.btnMusteri.TabIndex = 15;
            this.btnMusteri.Text = "Müşteri Oluştur";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(253, 175);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "TC Kimlik Numarasi";
            // 
            // FrmYeniMusteriEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 486);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.txtVergiNo);
            this.Controls.Add(this.lblVergiNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkTicari);
            this.Controls.Add(this.chkBireysel);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmYeniMusteriEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "YeniMusteriEkrani";
            this.Load += new System.EventHandler(this.FrmYeniMusteriEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.CheckBox chkBireysel;
        private System.Windows.Forms.CheckBox chkTicari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVergiNo;
        private System.Windows.Forms.Label lblVergiNo;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label4;
    }
}
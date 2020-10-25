namespace BankaOtomasyon_v1
{
    partial class MusteriBilgi
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
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusteriTuru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHesaplar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(313, 106);
            this.txtMusteriNo.MaxLength = 7;
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriNo.TabIndex = 3;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(277, 151);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(225, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "Müşteri Bilgileri";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(142, 281);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Soyadı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(142, 307);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "TC Kimlik Numarası";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(142, 333);
            this.txtTC.Name = "txtTC";
            this.txtTC.ReadOnly = true;
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Müsteri Türü";
            // 
            // txtMusteriTuru
            // 
            this.txtMusteriTuru.Location = new System.Drawing.Point(142, 359);
            this.txtMusteriTuru.Name = "txtMusteriTuru";
            this.txtMusteriTuru.ReadOnly = true;
            this.txtMusteriTuru.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriTuru.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Numarası";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(388, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Hesaplar";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtHesaplar
            // 
            this.txtHesaplar.Location = new System.Drawing.Point(266, 237);
            this.txtHesaplar.Multiline = true;
            this.txtHesaplar.Name = "txtHesaplar";
            this.txtHesaplar.Size = new System.Drawing.Size(310, 197);
            this.txtHesaplar.TabIndex = 35;
            // 
            // MusteriBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(620, 486);
            this.Controls.Add(this.txtHesaplar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMusteriTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MusteriBilgi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusteriTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHesaplar;
    }
}
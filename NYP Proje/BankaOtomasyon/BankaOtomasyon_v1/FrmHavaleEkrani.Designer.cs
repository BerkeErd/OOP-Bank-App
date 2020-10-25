namespace BankaOtomasyon_v1
{
    partial class FrmHavale
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
            this.txtHedefHesapNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHavale = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtGonderenHesapNo = new System.Windows.Forms.TextBox();
            this.txtGereken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHedefHesapNo
            // 
            this.txtHedefHesapNo.Location = new System.Drawing.Point(455, 150);
            this.txtHedefHesapNo.MaxLength = 7;
            this.txtHedefHesapNo.Name = "txtHedefHesapNo";
            this.txtHedefHesapNo.Size = new System.Drawing.Size(100, 20);
            this.txtHedefHesapNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hesap Numarası";
            // 
            // btnHavale
            // 
            this.btnHavale.Location = new System.Drawing.Point(382, 282);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(126, 52);
            this.btnHavale.TabIndex = 7;
            this.btnHavale.Text = "Havale Gönder";
            this.btnHavale.UseVisualStyleBackColor = true;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(132, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sizin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(418, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alıcı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(41, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Göndermek İstenen Miktar";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Enabled = false;
            this.txtMiktar.Location = new System.Drawing.Point(185, 234);
            this.txtMiktar.MaxLength = 10;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 19;
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hesap Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "TC Kimlik Numarası";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(154, 154);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 16;
            this.txtTC.TextChanged += new System.EventHandler(this.txtMusteriNo_TextChanged);
            // 
            // txtGonderenHesapNo
            // 
            this.txtGonderenHesapNo.Location = new System.Drawing.Point(154, 195);
            this.txtGonderenHesapNo.MaxLength = 7;
            this.txtGonderenHesapNo.Name = "txtGonderenHesapNo";
            this.txtGonderenHesapNo.Size = new System.Drawing.Size(100, 20);
            this.txtGonderenHesapNo.TabIndex = 15;
            this.txtGonderenHesapNo.TextChanged += new System.EventHandler(this.txtGonderenHesapNo_TextChanged);
            // 
            // txtGereken
            // 
            this.txtGereken.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtGereken.Location = new System.Drawing.Point(207, 281);
            this.txtGereken.MaxLength = 10;
            this.txtGereken.Name = "txtGereken";
            this.txtGereken.ReadOnly = true;
            this.txtGereken.Size = new System.Drawing.Size(100, 20);
            this.txtGereken.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Gereken Miktar (+Havale Ücreti)";
            // 
            // FrmHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(620, 486);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGereken);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtGonderenHesapNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHavale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHedefHesapNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHavale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Havale Ekranı";
            this.Load += new System.EventHandler(this.FrmHavale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHedefHesapNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtGonderenHesapNo;
        private System.Windows.Forms.TextBox txtGereken;
        private System.Windows.Forms.Label label4;
    }
}
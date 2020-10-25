namespace BankaOtomasyon_v1
{
    partial class FrmParaYatirmaVeCekme
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(145, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Miktar";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(239, 198);
            this.txtMiktar.MaxLength = 10;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hesap Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "TC Kimlik Numarası";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(239, 113);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 16;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(239, 154);
            this.txtHesapNo.MaxLength = 7;
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(100, 20);
            this.txtHesapNo.TabIndex = 15;
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(148, 250);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(75, 23);
            this.btnParaCek.TabIndex = 21;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(309, 250);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(75, 23);
            this.btnParaYatir.TabIndex = 22;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // txtBakiye
            // 
            this.txtBakiye.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBakiye.Location = new System.Drawing.Point(439, 170);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtBakiye.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Yeni Bakiye";
            // 
            // FrmParaYatirmaVeCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(620, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtHesapNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmParaYatirmaVeCekme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ParaYatirmaVeCekme";
            this.Load += new System.EventHandler(this.FrmParaYatirmaVeCekme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label1;
    }
}
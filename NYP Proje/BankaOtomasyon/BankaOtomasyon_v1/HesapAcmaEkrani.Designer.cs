namespace BankaOtomasyon_v1
{
    partial class FrmHesapAcmaEkrani
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMusteriNo.Location = new System.Drawing.Point(303, 167);
            this.txtMusteriNo.MaxLength = 7;
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriNo.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Müşteri Numarası";
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHesapAc.Location = new System.Drawing.Point(255, 248);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(94, 23);
            this.btnHesapAc.TabIndex = 25;
            this.btnHesapAc.Text = "Hesap Aç";
            this.btnHesapAc.UseVisualStyleBackColor = true;
            this.btnHesapAc.Click += new System.EventHandler(this.btnOzet_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(215, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 31);
            this.label7.TabIndex = 28;
            this.label7.Text = "Hesap Açma";
            // 
            // txtTC
            // 
            this.txtTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTC.Location = new System.Drawing.Point(303, 201);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "TC Kimlik Numarası";
            // 
            // FrmHesapAcmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 486);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHesapAc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHesapAcmaEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HesapAcmaEkrani";
            this.Load += new System.EventHandler(this.FrmHesapAcmaEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label1;
    }
}
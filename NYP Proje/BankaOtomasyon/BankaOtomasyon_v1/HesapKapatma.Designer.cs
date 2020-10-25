namespace BankaOtomasyon_v1
{
    partial class FrmHesapKapatma
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
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(182, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "Hesap Kapatma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hesap Numarası";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(289, 179);
            this.txtHesapNo.MaxLength = 7;
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(100, 20);
            this.txtHesapNo.TabIndex = 20;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(289, 221);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "TC Kimlik Numarası";
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.Location = new System.Drawing.Point(255, 285);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(94, 23);
            this.btnHesapKapat.TabIndex = 25;
            this.btnHesapKapat.Text = "Hesabı Kapat";
            this.btnHesapKapat.UseVisualStyleBackColor = true;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // FrmHesapKapatma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 486);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHesapNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHesapKapatma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HesapKapatma";
            this.Load += new System.EventHandler(this.FrmHesapKapatma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapKapat;
    }
}
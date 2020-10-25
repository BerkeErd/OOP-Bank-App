namespace BankaOtomasyon_v1
{
    partial class FrmBankaGelirGider
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
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgGelirGider = new System.Windows.Forms.DataGridView();
            this.Zaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HesapNumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Islem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGelirGider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(170, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banka Bakiye :";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBakiye.Location = new System.Drawing.Point(308, 22);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(20, 24);
            this.lblBakiye.TabIndex = 2;
            this.lblBakiye.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtgGelirGider
            // 
            this.dtgGelirGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGelirGider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zaman,
            this.HesapNumarasi,
            this.Islem});
            this.dtgGelirGider.Location = new System.Drawing.Point(29, 70);
            this.dtgGelirGider.Name = "dtgGelirGider";
            this.dtgGelirGider.Size = new System.Drawing.Size(562, 383);
            this.dtgGelirGider.TabIndex = 4;
            // 
            // Zaman
            // 
            this.Zaman.HeaderText = "Zaman";
            this.Zaman.Name = "Zaman";
            this.Zaman.ReadOnly = true;
            this.Zaman.Width = 130;
            // 
            // HesapNumarasi
            // 
            this.HesapNumarasi.HeaderText = "Hesap Numarası";
            this.HesapNumarasi.Name = "HesapNumarasi";
            this.HesapNumarasi.ReadOnly = true;
            // 
            // Islem
            // 
            this.Islem.HeaderText = "İşlem";
            this.Islem.Name = "Islem";
            this.Islem.ReadOnly = true;
            this.Islem.Width = 286;
            // 
            // FrmBankaGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 486);
            this.Controls.Add(this.dtgGelirGider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankaGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BankaGelirGider";
            this.Load += new System.EventHandler(this.FrmBankaGelirGider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGelirGider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgGelirGider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn HesapNumarasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Islem;
    }
}
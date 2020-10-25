namespace BankaOtomasyon_v1
{
    partial class FrmHesapOzeti
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
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.btnOzet = new System.Windows.Forms.Button();
            this.dtTarihBas = new System.Windows.Forms.DateTimePicker();
            this.dtTarihSon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgOzet = new System.Windows.Forms.DataGridView();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HesapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İslem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOzet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(479, 104);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "TC  Kimlik Numarası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(239, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "Hesap Ozeti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hesap No";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(129, 104);
            this.txtHesapNo.MaxLength = 7;
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(100, 20);
            this.txtHesapNo.TabIndex = 20;
            // 
            // btnOzet
            // 
            this.btnOzet.Location = new System.Drawing.Point(264, 127);
            this.btnOzet.Name = "btnOzet";
            this.btnOzet.Size = new System.Drawing.Size(75, 23);
            this.btnOzet.TabIndex = 19;
            this.btnOzet.Text = "Hesap Ozet";
            this.btnOzet.UseVisualStyleBackColor = true;
            this.btnOzet.Click += new System.EventHandler(this.btnOzet_Click_1);
            // 
            // dtTarihBas
            // 
            this.dtTarihBas.Location = new System.Drawing.Point(29, 53);
            this.dtTarihBas.Name = "dtTarihBas";
            this.dtTarihBas.Size = new System.Drawing.Size(200, 20);
            this.dtTarihBas.TabIndex = 26;
            this.dtTarihBas.ValueChanged += new System.EventHandler(this.dtTarihBas_ValueChanged);
            // 
            // dtTarihSon
            // 
            this.dtTarihSon.Location = new System.Drawing.Point(29, 79);
            this.dtTarihSon.Name = "dtTarihSon";
            this.dtTarihSon.Size = new System.Drawing.Size(200, 20);
            this.dtTarihSon.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tarihinden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tarihine Kadar";
            // 
            // dtgOzet
            // 
            this.dtgOzet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOzet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarih,
            this.HesapNo,
            this.İslem});
            this.dtgOzet.Location = new System.Drawing.Point(29, 156);
            this.dtgOzet.Name = "dtgOzet";
            this.dtgOzet.Size = new System.Drawing.Size(567, 318);
            this.dtgOzet.TabIndex = 30;
            this.dtgOzet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.Width = 130;
            // 
            // HesapNo
            // 
            this.HesapNo.HeaderText = "Hesap No";
            this.HesapNo.Name = "HesapNo";
            this.HesapNo.ReadOnly = true;
            // 
            // İslem
            // 
            this.İslem.HeaderText = "İşlem";
            this.İslem.Name = "İslem";
            this.İslem.ReadOnly = true;
            this.İslem.Width = 294;
            // 
            // FrmHesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 486);
            this.Controls.Add(this.dtgOzet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTarihSon);
            this.Controls.Add(this.dtTarihBas);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.btnOzet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHesapOzeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HesapOzeti";
            this.Load += new System.EventHandler(this.HesapOzeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOzet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Button btnOzet;
        private System.Windows.Forms.DateTimePicker dtTarihBas;
        private System.Windows.Forms.DateTimePicker dtTarihSon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgOzet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn HesapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn İslem;
    }
}
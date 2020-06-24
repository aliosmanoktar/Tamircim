namespace Tamircim
{
    partial class frm_personel_islem_ekle
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ucret = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_cari_listele = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ünvan:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(73, 56);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.ReadOnly = true;
            this.txt_ad.Size = new System.Drawing.Size(173, 20);
            this.txt_ad.TabIndex = 6;
            this.txt_ad.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Açıklama:";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(73, 133);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(173, 20);
            this.txt_aciklama.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ucret:";
            // 
            // txt_ucret
            // 
            this.txt_ucret.Location = new System.Drawing.Point(73, 170);
            this.txt_ucret.Name = "txt_ucret";
            this.txt_ucret.Size = new System.Drawing.Size(173, 20);
            this.txt_ucret.TabIndex = 4;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(12, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.Text = "Kaydet";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_cari_listele
            // 
            this.btn_cari_listele.Location = new System.Drawing.Point(104, 12);
            this.btn_cari_listele.Name = "btn_cari_listele";
            this.btn_cari_listele.Size = new System.Drawing.Size(95, 23);
            this.btn_cari_listele.TabIndex = 6;
            this.btn_cari_listele.Text = "Personel Listele";
            this.btn_cari_listele.UseVisualStyleBackColor = true;
            this.btn_cari_listele.Click += new System.EventHandler(this.btn_cari_listele_Click);
            // 
            // tarih
            // 
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.Location = new System.Drawing.Point(73, 94);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(173, 20);
            this.tarih.TabIndex = 2;
            // 
            // frm_personel_islem_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 225);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.btn_cari_listele);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_ucret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_personel_islem_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlem Ekle";
            this.Load += new System.EventHandler(this.frm_personel_islem_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ucret;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_cari_listele;
        private System.Windows.Forms.DateTimePicker tarih;
    }
}
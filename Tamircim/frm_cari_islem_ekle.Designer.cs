namespace Tamircim
{
    partial class frm_cari_islem_ekle
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
            this.cmb_islem_turu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_unvan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_borc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_alacak = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_cari_listele = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tür:";
            // 
            // cmb_islem_turu
            // 
            this.cmb_islem_turu.FormattingEnabled = true;
            this.cmb_islem_turu.Location = new System.Drawing.Point(79, 72);
            this.cmb_islem_turu.Name = "cmb_islem_turu";
            this.cmb_islem_turu.Size = new System.Drawing.Size(173, 21);
            this.cmb_islem_turu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ünvan:";
            // 
            // txt_unvan
            // 
            this.txt_unvan.Location = new System.Drawing.Point(79, 114);
            this.txt_unvan.Name = "txt_unvan";
            this.txt_unvan.ReadOnly = true;
            this.txt_unvan.Size = new System.Drawing.Size(173, 20);
            this.txt_unvan.TabIndex = 6;
            this.txt_unvan.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Açıklama:";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(79, 191);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(173, 20);
            this.txt_aciklama.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Borç:";
            // 
            // txt_borc
            // 
            this.txt_borc.Location = new System.Drawing.Point(79, 228);
            this.txt_borc.Name = "txt_borc";
            this.txt_borc.Size = new System.Drawing.Size(173, 20);
            this.txt_borc.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ödenen:";
            // 
            // txt_alacak
            // 
            this.txt_alacak.Location = new System.Drawing.Point(79, 266);
            this.txt_alacak.Name = "txt_alacak";
            this.txt_alacak.Size = new System.Drawing.Size(173, 20);
            this.txt_alacak.TabIndex = 5;
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
            this.btn_cari_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_cari_listele.TabIndex = 6;
            this.btn_cari_listele.Text = "Cari Listele";
            this.btn_cari_listele.UseVisualStyleBackColor = true;
            this.btn_cari_listele.Click += new System.EventHandler(this.btn_cari_listele_Click);
            // 
            // tarih
            // 
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.Location = new System.Drawing.Point(79, 152);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(173, 20);
            this.tarih.TabIndex = 2;
            // 
            // frm_cari_islem_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 301);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.btn_cari_listele);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_alacak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_borc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_unvan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_islem_turu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cari_islem_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari İşlem Ekle";
            this.Load += new System.EventHandler(this.frm_cari_islem_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_islem_turu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_unvan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_borc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_alacak;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_cari_listele;
        private System.Windows.Forms.DateTimePicker tarih;
    }
}
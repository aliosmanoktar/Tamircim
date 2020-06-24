namespace Tamircim
{
    partial class frm_servis_toplam
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_iscilik_toplam = new System.Windows.Forms.Label();
            this.lbl_parca_toplam = new System.Windows.Forms.Label();
            this.lbl_ara_toplam = new System.Windows.Forms.Label();
            this.lbl_kdv = new System.Windows.Forms.Label();
            this.lbl_odenen = new System.Windows.Forms.Label();
            this.list_odemeler = new System.Windows.Forms.DataGridView();
            this.lbl_odenecek = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_odeme_ekle = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.lbl_genel_toplam = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_servis_durumu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.list_odemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşçilik Toplam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parçalar Toplamı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ara Toplam:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(260, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 1);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(260, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 1);
            this.label5.TabIndex = 1;
            this.label5.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "KDV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ödenenen:";
            // 
            // lbl_iscilik_toplam
            // 
            this.lbl_iscilik_toplam.Location = new System.Drawing.Point(386, 55);
            this.lbl_iscilik_toplam.Name = "lbl_iscilik_toplam";
            this.lbl_iscilik_toplam.Size = new System.Drawing.Size(74, 13);
            this.lbl_iscilik_toplam.TabIndex = 0;
            this.lbl_iscilik_toplam.Text = "₺";
            this.lbl_iscilik_toplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_parca_toplam
            // 
            this.lbl_parca_toplam.Location = new System.Drawing.Point(386, 78);
            this.lbl_parca_toplam.Name = "lbl_parca_toplam";
            this.lbl_parca_toplam.Size = new System.Drawing.Size(74, 13);
            this.lbl_parca_toplam.TabIndex = 0;
            this.lbl_parca_toplam.Text = "₺";
            this.lbl_parca_toplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ara_toplam
            // 
            this.lbl_ara_toplam.Location = new System.Drawing.Point(386, 108);
            this.lbl_ara_toplam.Name = "lbl_ara_toplam";
            this.lbl_ara_toplam.Size = new System.Drawing.Size(74, 13);
            this.lbl_ara_toplam.TabIndex = 0;
            this.lbl_ara_toplam.Text = "₺";
            this.lbl_ara_toplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_kdv
            // 
            this.lbl_kdv.Location = new System.Drawing.Point(386, 135);
            this.lbl_kdv.Name = "lbl_kdv";
            this.lbl_kdv.Size = new System.Drawing.Size(74, 13);
            this.lbl_kdv.TabIndex = 0;
            this.lbl_kdv.Text = "₺";
            this.lbl_kdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_odenen
            // 
            this.lbl_odenen.Location = new System.Drawing.Point(386, 184);
            this.lbl_odenen.Name = "lbl_odenen";
            this.lbl_odenen.Size = new System.Drawing.Size(74, 13);
            this.lbl_odenen.TabIndex = 0;
            this.lbl_odenen.Text = "₺";
            this.lbl_odenen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // list_odemeler
            // 
            this.list_odemeler.AllowUserToAddRows = false;
            this.list_odemeler.AllowUserToDeleteRows = false;
            this.list_odemeler.AllowUserToResizeColumns = false;
            this.list_odemeler.AllowUserToResizeRows = false;
            this.list_odemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_odemeler.BackgroundColor = System.Drawing.SystemColors.Window;
            this.list_odemeler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.list_odemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_odemeler.Location = new System.Drawing.Point(12, 44);
            this.list_odemeler.Name = "list_odemeler";
            this.list_odemeler.ReadOnly = true;
            this.list_odemeler.RowHeadersVisible = false;
            this.list_odemeler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.list_odemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_odemeler.ShowEditingIcon = false;
            this.list_odemeler.Size = new System.Drawing.Size(237, 223);
            this.list_odemeler.TabIndex = 2;
            // 
            // lbl_odenecek
            // 
            this.lbl_odenecek.Location = new System.Drawing.Point(386, 203);
            this.lbl_odenecek.Name = "lbl_odenecek";
            this.lbl_odenecek.Size = new System.Drawing.Size(74, 13);
            this.lbl_odenecek.TabIndex = 0;
            this.lbl_odenecek.Text = "₺";
            this.lbl_odenecek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ödenecek:";
            // 
            // btn_odeme_ekle
            // 
            this.btn_odeme_ekle.Location = new System.Drawing.Point(12, 12);
            this.btn_odeme_ekle.Name = "btn_odeme_ekle";
            this.btn_odeme_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_odeme_ekle.TabIndex = 3;
            this.btn_odeme_ekle.Text = "Ekle";
            this.btn_odeme_ekle.UseVisualStyleBackColor = true;
            this.btn_odeme_ekle.Click += new System.EventHandler(this.btn_odeme_ekle_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(93, 12);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_duzenle.TabIndex = 3;
            this.btn_duzenle.Text = "Duzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(174, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // lbl_genel_toplam
            // 
            this.lbl_genel_toplam.Location = new System.Drawing.Point(386, 153);
            this.lbl_genel_toplam.Name = "lbl_genel_toplam";
            this.lbl_genel_toplam.Size = new System.Drawing.Size(74, 13);
            this.lbl_genel_toplam.TabIndex = 0;
            this.lbl_genel_toplam.Text = "₺";
            this.lbl_genel_toplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Genel Toplam:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(260, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 1);
            this.label10.TabIndex = 1;
            this.label10.Text = "label4";
            // 
            // cmb_servis_durumu
            // 
            this.cmb_servis_durumu.FormattingEnabled = true;
            this.cmb_servis_durumu.Location = new System.Drawing.Point(331, 233);
            this.cmb_servis_durumu.Name = "cmb_servis_durumu";
            this.cmb_servis_durumu.Size = new System.Drawing.Size(129, 21);
            this.cmb_servis_durumu.TabIndex = 10;
            this.cmb_servis_durumu.SelectionChangeCommitted += new System.EventHandler(this.cmb_servis_durumu_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "S. Durumu:";
            // 
            // frm_servis_toplam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 279);
            this.Controls.Add(this.cmb_servis_durumu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_odeme_ekle);
            this.Controls.Add(this.list_odemeler);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_odenecek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_genel_toplam);
            this.Controls.Add(this.lbl_odenen);
            this.Controls.Add(this.lbl_kdv);
            this.Controls.Add(this.lbl_ara_toplam);
            this.Controls.Add(this.lbl_parca_toplam);
            this.Controls.Add(this.lbl_iscilik_toplam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_servis_toplam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis Toplam";
            this.Load += new System.EventHandler(this.frm_servis_toplam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_odemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_iscilik_toplam;
        private System.Windows.Forms.Label lbl_parca_toplam;
        private System.Windows.Forms.Label lbl_ara_toplam;
        private System.Windows.Forms.Label lbl_kdv;
        private System.Windows.Forms.Label lbl_odenen;
        private System.Windows.Forms.DataGridView list_odemeler;
        private System.Windows.Forms.Label lbl_odenecek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_odeme_ekle;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label lbl_genel_toplam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_servis_durumu;
        private System.Windows.Forms.Label label8;
    }
}
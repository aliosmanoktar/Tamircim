using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tamircim
{
    partial class frm_stok_ekle
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
            this.btn_stok_ekle = new System.Windows.Forms.Button();
            this.txt_parca = new System.Windows.Forms.TextBox();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_kdv = new System.Windows.Forms.TextBox();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.txt_birim = new System.Windows.Forms.TextBox();
            this.txt_stok_kodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_stok_drm = new System.Windows.Forms.Button();
            this.btn_stok_listele = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_stok_ekle
            // 
            this.btn_stok_ekle.Location = new System.Drawing.Point(93, 12);
            this.btn_stok_ekle.Name = "btn_stok_ekle";
            this.btn_stok_ekle.Size = new System.Drawing.Size(83, 23);
            this.btn_stok_ekle.TabIndex = 27;
            this.btn_stok_ekle.Text = "Hızlı Stok Ekle";
            this.btn_stok_ekle.UseVisualStyleBackColor = true;
            this.btn_stok_ekle.Click += new System.EventHandler(this.btn_stok_ekle_Click);
            // 
            // txt_parca
            // 
            this.txt_parca.Location = new System.Drawing.Point(88, 70);
            this.txt_parca.Name = "txt_parca";
            this.txt_parca.Size = new System.Drawing.Size(144, 20);
            this.txt_parca.TabIndex = 21;
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(505, 70);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.ReadOnly = true;
            this.txt_tutar.Size = new System.Drawing.Size(72, 20);
            this.txt_tutar.TabIndex = 26;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(432, 70);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(72, 20);
            this.txt_fiyat.TabIndex = 25;
            this.txt_fiyat.TextChanged += new System.EventHandler(this.txt_kdv_TextChanged);
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kdv_KeyPress);
            // 
            // txt_kdv
            // 
            this.txt_kdv.Location = new System.Drawing.Point(306, 70);
            this.txt_kdv.Name = "txt_kdv";
            this.txt_kdv.Size = new System.Drawing.Size(52, 20);
            this.txt_kdv.TabIndex = 24;
            this.txt_kdv.TextChanged += new System.EventHandler(this.txt_kdv_TextChanged);
            this.txt_kdv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kdv_KeyPress);
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(359, 70);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(72, 20);
            this.txt_miktar.TabIndex = 23;
            this.txt_miktar.TextChanged += new System.EventHandler(this.txt_kdv_TextChanged);
            this.txt_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kdv_KeyPress);
            // 
            // txt_birim
            // 
            this.txt_birim.Location = new System.Drawing.Point(233, 70);
            this.txt_birim.Name = "txt_birim";
            this.txt_birim.Size = new System.Drawing.Size(72, 20);
            this.txt_birim.TabIndex = 22;
            // 
            // txt_stok_kodu
            // 
            this.txt_stok_kodu.Location = new System.Drawing.Point(15, 70);
            this.txt_stok_kodu.Name = "txt_stok_kodu";
            this.txt_stok_kodu.Size = new System.Drawing.Size(72, 20);
            this.txt_stok_kodu.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tutar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "KDV %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Birim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Parça";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stok Kodu";
            // 
            // btn_stok_drm
            // 
            this.btn_stok_drm.Location = new System.Drawing.Point(263, 12);
            this.btn_stok_drm.Name = "btn_stok_drm";
            this.btn_stok_drm.Size = new System.Drawing.Size(75, 23);
            this.btn_stok_drm.TabIndex = 19;
            this.btn_stok_drm.Text = "Stok Durum";
            this.btn_stok_drm.UseVisualStyleBackColor = true;
            this.btn_stok_drm.Click += new System.EventHandler(this.btn_stok_drm_Click);
            // 
            // btn_stok_listele
            // 
            this.btn_stok_listele.Location = new System.Drawing.Point(182, 12);
            this.btn_stok_listele.Name = "btn_stok_listele";
            this.btn_stok_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_stok_listele.TabIndex = 17;
            this.btn_stok_listele.Text = "Stok Listele";
            this.btn_stok_listele.UseVisualStyleBackColor = true;
            this.btn_stok_listele.Click += new System.EventHandler(this.btn_stok_listele_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(12, 12);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // frm_stok_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 124);
            this.Controls.Add(this.btn_stok_ekle);
            this.Controls.Add(this.txt_parca);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_kdv);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.txt_birim);
            this.Controls.Add(this.txt_stok_kodu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stok_drm);
            this.Controls.Add(this.btn_stok_listele);
            this.Controls.Add(this.btn_kaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_stok_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Ekle";
            this.Load += new System.EventHandler(this.frm_stok_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button btn_stok_ekle;
        private TextBox txt_parca;
        private TextBox txt_tutar;
        private TextBox txt_fiyat;
        private TextBox txt_kdv;
        private TextBox txt_miktar;
        private TextBox txt_birim;
        private TextBox txt_stok_kodu;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_stok_drm;
        private Button btn_stok_listele;
        private Button btn_kaydet;
        #endregion
    }
}
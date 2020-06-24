using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Tamircim
{
    partial class frm_stok_giris
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
            this.btn_tedarikci_sec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_toptanci_name = new System.Windows.Forms.TextBox();
            this.txt_toptanci_tel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_stok_giris = new System.Windows.Forms.DataGridView();
            this.btn_urun_sil = new System.Windows.Forms.Button();
            this.btn_urun_duzenle = new System.Windows.Forms.Button();
            this.btn_urun_ekle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_stok_giris)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tedarikci_sec
            // 
            this.btn_tedarikci_sec.Location = new System.Drawing.Point(356, 15);
            this.btn_tedarikci_sec.Name = "btn_tedarikci_sec";
            this.btn_tedarikci_sec.Size = new System.Drawing.Size(91, 23);
            this.btn_tedarikci_sec.TabIndex = 0;
            this.btn_tedarikci_sec.Text = "Tedarikci Seç";
            this.btn_tedarikci_sec.UseVisualStyleBackColor = true;
            this.btn_tedarikci_sec.Click += new System.EventHandler(this.btn_tedarikci_sec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tedarikçi Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tedarikçi Telefon:";
            // 
            // txt_toptanci_name
            // 
            this.txt_toptanci_name.Location = new System.Drawing.Point(101, 19);
            this.txt_toptanci_name.Name = "txt_toptanci_name";
            this.txt_toptanci_name.ReadOnly = true;
            this.txt_toptanci_name.Size = new System.Drawing.Size(191, 20);
            this.txt_toptanci_name.TabIndex = 3;
            // 
            // txt_toptanci_tel
            // 
            this.txt_toptanci_tel.Location = new System.Drawing.Point(100, 46);
            this.txt_toptanci_tel.Name = "txt_toptanci_tel";
            this.txt_toptanci_tel.ReadOnly = true;
            this.txt_toptanci_tel.Size = new System.Drawing.Size(192, 20);
            this.txt_toptanci_tel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_toptanci_name);
            this.groupBox1.Controls.Add(this.txt_toptanci_tel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toptancı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_stok_giris);
            this.groupBox2.Controls.Add(this.btn_urun_sil);
            this.groupBox2.Controls.Add(this.btn_urun_duzenle);
            this.groupBox2.Controls.Add(this.btn_urun_ekle);
            this.groupBox2.Location = new System.Drawing.Point(2, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 262);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Urunler";
            // 
            // list_stok_giris
            // 
            this.list_stok_giris.AllowUserToAddRows = false;
            this.list_stok_giris.AllowUserToDeleteRows = false;
            this.list_stok_giris.AllowUserToResizeColumns = false;
            this.list_stok_giris.AllowUserToResizeRows = false;
            this.list_stok_giris.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_stok_giris.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_stok_giris.BackgroundColor = System.Drawing.SystemColors.Window;
            this.list_stok_giris.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.list_stok_giris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.list_stok_giris.Location = new System.Drawing.Point(6, 48);
            this.list_stok_giris.Name = "list_stok_giris";
            this.list_stok_giris.ReadOnly = true;
            this.list_stok_giris.RowHeadersVisible = false;
            this.list_stok_giris.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.list_stok_giris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_stok_giris.ShowEditingIcon = false;
            this.list_stok_giris.Size = new System.Drawing.Size(677, 208);
            this.list_stok_giris.TabIndex = 2;
            // 
            // btn_urun_sil
            // 
            this.btn_urun_sil.Location = new System.Drawing.Point(168, 19);
            this.btn_urun_sil.Name = "btn_urun_sil";
            this.btn_urun_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_urun_sil.TabIndex = 1;
            this.btn_urun_sil.Text = "Sil";
            this.btn_urun_sil.UseVisualStyleBackColor = true;
            this.btn_urun_sil.Click += new System.EventHandler(this.btn_urun_sil_Click);
            // 
            // btn_urun_duzenle
            // 
            this.btn_urun_duzenle.Location = new System.Drawing.Point(87, 19);
            this.btn_urun_duzenle.Name = "btn_urun_duzenle";
            this.btn_urun_duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_urun_duzenle.TabIndex = 1;
            this.btn_urun_duzenle.Text = "Düzenle";
            this.btn_urun_duzenle.UseVisualStyleBackColor = true;
            this.btn_urun_duzenle.Click += new System.EventHandler(this.btn_urun_duzenle_Click);
            // 
            // btn_urun_ekle
            // 
            this.btn_urun_ekle.Location = new System.Drawing.Point(6, 19);
            this.btn_urun_ekle.Name = "btn_urun_ekle";
            this.btn_urun_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_urun_ekle.TabIndex = 1;
            this.btn_urun_ekle.Text = "Ekle";
            this.btn_urun_ekle.UseVisualStyleBackColor = true;
            this.btn_urun_ekle.Click += new System.EventHandler(this.btn_urun_ekle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(453, 15);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(91, 23);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(550, 15);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(75, 23);
            this.btn_yazdir.TabIndex = 3;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // frm_stok_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 364);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_tedarikci_sec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_stok_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Girişi";
            this.Load += new System.EventHandler(this.frm_stok_girisi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_stok_giris)).EndInit();
            this.ResumeLayout(false);

        }
        private Button btn_tedarikci_sec;
        private Label label1;
        private Label label2;
        private TextBox txt_toptanci_name;
        private TextBox txt_toptanci_tel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_urun_sil;
        private Button btn_urun_duzenle;
        private Button btn_urun_ekle;
        private DataGridView list_stok_giris;
        private Button btn_kaydet;
        private Button btn_yazdir;
        #endregion
    }
}
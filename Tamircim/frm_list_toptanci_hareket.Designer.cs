using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Tamircim
{
    partial class frm_list_toptanci_hareket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.txt_toptanci_name = new System.Windows.Forms.TextBox();
            this.txt_toptanci_tel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_toptanci_hareket = new System.Windows.Forms.DataGridView();
            this.btn_islem_sil = new System.Windows.Forms.Button();
            this.btn_islem_duzenle = new System.Windows.Forms.Button();
            this.btn_islem_ekle = new System.Windows.Forms.Button();
            this.grp_arama = new System.Windows.Forms.GroupBox();
            this.btn_arama_kapat = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_bitis = new System.Windows.Forms.DateTimePicker();
            this.dt_baslangic = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_toptanci_hareket)).BeginInit();
            this.grp_arama.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.btn_yazdir);
            this.groupBox1.Controls.Add(this.txt_toptanci_name);
            this.groupBox1.Controls.Add(this.txt_toptanci_tel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toptancı";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(316, 49);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 5;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(316, 17);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(75, 23);
            this.btn_yazdir.TabIndex = 4;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_toptanci_hareket);
            this.groupBox2.Controls.Add(this.btn_islem_sil);
            this.groupBox2.Controls.Add(this.btn_islem_duzenle);
            this.groupBox2.Controls.Add(this.btn_islem_ekle);
            this.groupBox2.Location = new System.Drawing.Point(4, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 262);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // list_toptanci_hareket
            // 
            this.list_toptanci_hareket.AllowUserToAddRows = false;
            this.list_toptanci_hareket.AllowUserToDeleteRows = false;
            this.list_toptanci_hareket.AllowUserToResizeColumns = false;
            this.list_toptanci_hareket.AllowUserToResizeRows = false;
            this.list_toptanci_hareket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_toptanci_hareket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_toptanci_hareket.BackgroundColor = System.Drawing.SystemColors.Window;
            this.list_toptanci_hareket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.list_toptanci_hareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.list_toptanci_hareket.Location = new System.Drawing.Point(6, 48);
            this.list_toptanci_hareket.Name = "list_toptanci_hareket";
            this.list_toptanci_hareket.ReadOnly = true;
            this.list_toptanci_hareket.RowHeadersVisible = false;
            this.list_toptanci_hareket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.list_toptanci_hareket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_toptanci_hareket.ShowEditingIcon = false;
            this.list_toptanci_hareket.Size = new System.Drawing.Size(700, 208);
            this.list_toptanci_hareket.TabIndex = 2;
            // 
            // btn_islem_sil
            // 
            this.btn_islem_sil.Location = new System.Drawing.Point(168, 19);
            this.btn_islem_sil.Name = "btn_islem_sil";
            this.btn_islem_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_islem_sil.TabIndex = 1;
            this.btn_islem_sil.Text = "Sil";
            this.btn_islem_sil.UseVisualStyleBackColor = true;
            this.btn_islem_sil.Click += new System.EventHandler(this.btn_islem_sil_Click);
            // 
            // btn_islem_duzenle
            // 
            this.btn_islem_duzenle.Location = new System.Drawing.Point(87, 19);
            this.btn_islem_duzenle.Name = "btn_islem_duzenle";
            this.btn_islem_duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_islem_duzenle.TabIndex = 1;
            this.btn_islem_duzenle.Text = "Düzenle";
            this.btn_islem_duzenle.UseVisualStyleBackColor = true;
            this.btn_islem_duzenle.Click += new System.EventHandler(this.btn_islem_duzenle_Click);
            // 
            // btn_islem_ekle
            // 
            this.btn_islem_ekle.Location = new System.Drawing.Point(6, 19);
            this.btn_islem_ekle.Name = "btn_islem_ekle";
            this.btn_islem_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_islem_ekle.TabIndex = 1;
            this.btn_islem_ekle.Text = "Ekle";
            this.btn_islem_ekle.UseVisualStyleBackColor = true;
            this.btn_islem_ekle.Click += new System.EventHandler(this.btn_islem_ekle_Click);
            // 
            // grp_arama
            // 
            this.grp_arama.Controls.Add(this.btn_arama_kapat);
            this.grp_arama.Controls.Add(this.btn_listele);
            this.grp_arama.Controls.Add(this.label4);
            this.grp_arama.Controls.Add(this.label3);
            this.grp_arama.Controls.Add(this.dt_bitis);
            this.grp_arama.Controls.Add(this.dt_baslangic);
            this.grp_arama.Location = new System.Drawing.Point(410, 0);
            this.grp_arama.Name = "grp_arama";
            this.grp_arama.Size = new System.Drawing.Size(306, 83);
            this.grp_arama.TabIndex = 6;
            this.grp_arama.TabStop = false;
            this.grp_arama.Text = "Arama";
            // 
            // btn_arama_kapat
            // 
            this.btn_arama_kapat.Location = new System.Drawing.Point(222, 46);
            this.btn_arama_kapat.Name = "btn_arama_kapat";
            this.btn_arama_kapat.Size = new System.Drawing.Size(75, 23);
            this.btn_arama_kapat.TabIndex = 5;
            this.btn_arama_kapat.Text = "Kapat";
            this.btn_arama_kapat.UseVisualStyleBackColor = true;
            this.btn_arama_kapat.Click += new System.EventHandler(this.btn_arama_kapat_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(222, 18);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_listele.TabIndex = 5;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bitiş Zamanı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Başlangıç zamanı:";
            // 
            // dt_bitis
            // 
            this.dt_bitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_bitis.Location = new System.Drawing.Point(103, 45);
            this.dt_bitis.Name = "dt_bitis";
            this.dt_bitis.Size = new System.Drawing.Size(99, 20);
            this.dt_bitis.TabIndex = 0;
            // 
            // dt_baslangic
            // 
            this.dt_baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_baslangic.Location = new System.Drawing.Point(103, 19);
            this.dt_baslangic.Name = "dt_baslangic";
            this.dt_baslangic.Size = new System.Drawing.Size(99, 20);
            this.dt_baslangic.TabIndex = 0;
            // 
            // frm_list_toptanci_hareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 360);
            this.Controls.Add(this.grp_arama);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_list_toptanci_hareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi Hareketleri";
            this.Load += new System.EventHandler(this.frm_list_toptanci_hareket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_toptanci_hareket)).EndInit();
            this.grp_arama.ResumeLayout(false);
            this.grp_arama.PerformLayout();
            this.ResumeLayout(false);

        }
        private GroupBox groupBox1;
        private TextBox txt_toptanci_name;
        private TextBox txt_toptanci_tel;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView list_toptanci_hareket;
        private Button btn_islem_sil;
        private Button btn_islem_duzenle;
        private Button btn_islem_ekle;
        private Button btn_yazdir;
        private Button btn_ara;
        private GroupBox grp_arama;
        private Button btn_arama_kapat;
        private Button btn_listele;
        private Label label4;
        private Label label3;
        private DateTimePicker dt_bitis;
        private DateTimePicker dt_baslangic;
        #endregion
    }
}
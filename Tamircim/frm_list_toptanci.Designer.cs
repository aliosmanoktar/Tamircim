namespace Tamircim
{
    partial class frm_list_toptanci
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
            this.grp_arama = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_aranan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_secenekler = new System.Windows.Forms.ComboBox();
            this.kapat = new System.Windows.Forms.Button();
            this.list_cari = new System.Windows.Forms.DataGridView();
            this.btn_arama = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_hareket_gor = new System.Windows.Forms.Button();
            this.grp_arama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_cari)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_arama
            // 
            this.grp_arama.Controls.Add(this.button1);
            this.grp_arama.Controls.Add(this.txt_aranan);
            this.grp_arama.Controls.Add(this.label1);
            this.grp_arama.Controls.Add(this.cmb_secenekler);
            this.grp_arama.Controls.Add(this.kapat);
            this.grp_arama.Location = new System.Drawing.Point(1, 41);
            this.grp_arama.Name = "grp_arama";
            this.grp_arama.Size = new System.Drawing.Size(758, 78);
            this.grp_arama.TabIndex = 13;
            this.grp_arama.TabStop = false;
            this.grp_arama.Text = "Arama Seçenekleri";
            this.grp_arama.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_aranan
            // 
            this.txt_aranan.Location = new System.Drawing.Point(19, 48);
            this.txt_aranan.Name = "txt_aranan";
            this.txt_aranan.Size = new System.Drawing.Size(629, 20);
            this.txt_aranan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama Seçenekleri:";
            // 
            // cmb_secenekler
            // 
            this.cmb_secenekler.FormattingEnabled = true;
            this.cmb_secenekler.Location = new System.Drawing.Point(121, 21);
            this.cmb_secenekler.Name = "cmb_secenekler";
            this.cmb_secenekler.Size = new System.Drawing.Size(146, 21);
            this.cmb_secenekler.TabIndex = 0;
            // 
            // kapat
            // 
            this.kapat.Location = new System.Drawing.Point(669, 14);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(75, 23);
            this.kapat.TabIndex = 0;
            this.kapat.Text = "Kapat";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // list_cari
            // 
            this.list_cari.AllowUserToAddRows = false;
            this.list_cari.AllowUserToDeleteRows = false;
            this.list_cari.AllowUserToResizeColumns = false;
            this.list_cari.AllowUserToResizeRows = false;
            this.list_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_cari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_cari.BackgroundColor = System.Drawing.SystemColors.Window;
            this.list_cari.CausesValidation = false;
            this.list_cari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.list_cari.Location = new System.Drawing.Point(1, 41);
            this.list_cari.Name = "list_cari";
            this.list_cari.ReadOnly = true;
            this.list_cari.RowHeadersVisible = false;
            this.list_cari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_cari.ShowEditingIcon = false;
            this.list_cari.Size = new System.Drawing.Size(756, 369);
            this.list_cari.TabIndex = 8;
            this.list_cari.DoubleClick += new System.EventHandler(this.list_cari_DoubleClick);
            // 
            // btn_arama
            // 
            this.btn_arama.Location = new System.Drawing.Point(256, 12);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(75, 23);
            this.btn_arama.TabIndex = 9;
            this.btn_arama.Text = "Ara";
            this.btn_arama.UseVisualStyleBackColor = true;
            this.btn_arama.Click += new System.EventHandler(this.btn_arama_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(175, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(94, 12);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_duzenle.TabIndex = 11;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(13, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 10;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_hareket_gor
            // 
            this.btn_hareket_gor.Location = new System.Drawing.Point(337, 12);
            this.btn_hareket_gor.Name = "btn_hareket_gor";
            this.btn_hareket_gor.Size = new System.Drawing.Size(94, 23);
            this.btn_hareket_gor.TabIndex = 14;
            this.btn_hareket_gor.Text = "Hareket Listele";
            this.btn_hareket_gor.UseVisualStyleBackColor = true;
            this.btn_hareket_gor.Click += new System.EventHandler(this.btn_hareket_gor_Click);
            // 
            // frm_list_toptanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 430);
            this.Controls.Add(this.grp_arama);
            this.Controls.Add(this.list_cari);
            this.Controls.Add(this.btn_arama);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_hareket_gor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_list_toptanci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi Listesi";
            this.Load += new System.EventHandler(this.frm_list_toptanci_Load);
            this.grp_arama.ResumeLayout(false);
            this.grp_arama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_cari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_arama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_aranan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_secenekler;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.DataGridView list_cari;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_hareket_gor;
    }
}
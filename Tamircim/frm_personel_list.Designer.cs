namespace Tamircim
{
    partial class frm_personel_list
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
            this.list_personel = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.grp_arama = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_aranan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_secenekler = new System.Windows.Forms.ComboBox();
            this.kapat = new System.Windows.Forms.Button();
            this.btn_islem_listele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_personel)).BeginInit();
            this.grp_arama.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_personel
            // 
            this.list_personel.AllowUserToAddRows = false;
            this.list_personel.AllowUserToDeleteRows = false;
            this.list_personel.AllowUserToResizeColumns = false;
            this.list_personel.AllowUserToResizeRows = false;
            this.list_personel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_personel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_personel.BackgroundColor = System.Drawing.SystemColors.Window;
            this.list_personel.CausesValidation = false;
            this.list_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.list_personel.Location = new System.Drawing.Point(0, 44);
            this.list_personel.Name = "list_personel";
            this.list_personel.ReadOnly = true;
            this.list_personel.RowHeadersVisible = false;
            this.list_personel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_personel.ShowEditingIcon = false;
            this.list_personel.Size = new System.Drawing.Size(710, 386);
            this.list_personel.TabIndex = 0;
            this.list_personel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_personel_MouseDoubleClick);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(12, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(93, 12);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_duzenle.TabIndex = 1;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(174, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 1;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(255, 12);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 1;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // grp_arama
            // 
            this.grp_arama.Controls.Add(this.button1);
            this.grp_arama.Controls.Add(this.txt_aranan);
            this.grp_arama.Controls.Add(this.label1);
            this.grp_arama.Controls.Add(this.cmb_secenekler);
            this.grp_arama.Controls.Add(this.kapat);
            this.grp_arama.Location = new System.Drawing.Point(0, 44);
            this.grp_arama.Name = "grp_arama";
            this.grp_arama.Size = new System.Drawing.Size(710, 78);
            this.grp_arama.TabIndex = 5;
            this.grp_arama.TabStop = false;
            this.grp_arama.Text = "Arama Seçenekleri";
            this.grp_arama.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_aranan
            // 
            this.txt_aranan.Location = new System.Drawing.Point(21, 48);
            this.txt_aranan.Name = "txt_aranan";
            this.txt_aranan.Size = new System.Drawing.Size(571, 20);
            this.txt_aranan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama Seçenekleri:";
            // 
            // cmb_secenekler
            // 
            this.cmb_secenekler.FormattingEnabled = true;
            this.cmb_secenekler.Location = new System.Drawing.Point(123, 21);
            this.cmb_secenekler.Name = "cmb_secenekler";
            this.cmb_secenekler.Size = new System.Drawing.Size(146, 21);
            this.cmb_secenekler.TabIndex = 0;
            // 
            // kapat
            // 
            this.kapat.Location = new System.Drawing.Point(615, 14);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(75, 23);
            this.kapat.TabIndex = 0;
            this.kapat.Text = "Kapat";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // btn_islem_listele
            // 
            this.btn_islem_listele.Location = new System.Drawing.Point(336, 12);
            this.btn_islem_listele.Name = "btn_islem_listele";
            this.btn_islem_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_islem_listele.TabIndex = 6;
            this.btn_islem_listele.Text = "İşlem Listele";
            this.btn_islem_listele.UseVisualStyleBackColor = true;
            this.btn_islem_listele.Click += new System.EventHandler(this.btn_islem_listele_Click);
            // 
            // frm_personel_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 433);
            this.Controls.Add(this.btn_islem_listele);
            this.Controls.Add(this.grp_arama);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.list_personel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_personel_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.frm_personel_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_personel)).EndInit();
            this.grp_arama.ResumeLayout(false);
            this.grp_arama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView list_personel;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.GroupBox grp_arama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_aranan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_secenekler;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button btn_islem_listele;
    }
}
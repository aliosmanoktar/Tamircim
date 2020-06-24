namespace Tamircim
{
    partial class frm_stok_karti
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.list_stoklar = new System.Windows.Forms.DataGridView();
            this.btn_duzelt = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.grp_arama = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_aranan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_secenekler = new System.Windows.Forms.ComboBox();
            this.kapat = new System.Windows.Forms.Button();
            this.btn_yazdir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_stoklar)).BeginInit();
            this.grp_arama.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(12, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // list_stoklar
            // 
            this.list_stoklar.AllowUserToAddRows = false;
            this.list_stoklar.AllowUserToDeleteRows = false;
            this.list_stoklar.AllowUserToResizeColumns = false;
            this.list_stoklar.AllowUserToResizeRows = false;
            this.list_stoklar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_stoklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_stoklar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.list_stoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_stoklar.Location = new System.Drawing.Point(0, 41);
            this.list_stoklar.MultiSelect = false;
            this.list_stoklar.Name = "list_stoklar";
            this.list_stoklar.ReadOnly = true;
            this.list_stoklar.RowHeadersVisible = false;
            this.list_stoklar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.list_stoklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_stoklar.Size = new System.Drawing.Size(628, 308);
            this.list_stoklar.TabIndex = 1;
            this.list_stoklar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_stoklar_MouseDoubleClick);
            this.list_stoklar.Resize += new System.EventHandler(this.list_stoklar_Resize);
            // 
            // btn_duzelt
            // 
            this.btn_duzelt.Location = new System.Drawing.Point(93, 12);
            this.btn_duzelt.Name = "btn_duzelt";
            this.btn_duzelt.Size = new System.Drawing.Size(75, 23);
            this.btn_duzelt.TabIndex = 1;
            this.btn_duzelt.Text = "Düzelt";
            this.btn_duzelt.UseVisualStyleBackColor = true;
            this.btn_duzelt.Click += new System.EventHandler(this.btn_duzelt_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(174, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(255, 12);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 3;
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
            this.grp_arama.Location = new System.Drawing.Point(0, 41);
            this.grp_arama.Name = "grp_arama";
            this.grp_arama.Size = new System.Drawing.Size(628, 78);
            this.grp_arama.TabIndex = 4;
            this.grp_arama.TabStop = false;
            this.grp_arama.Text = "Arama Seçenekleri";
            this.grp_arama.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 48);
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
            this.txt_aranan.Size = new System.Drawing.Size(474, 20);
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
            this.kapat.Location = new System.Drawing.Point(523, 14);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(75, 23);
            this.kapat.TabIndex = 0;
            this.kapat.Text = "Kapat";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(336, 12);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(75, 23);
            this.btn_yazdir.TabIndex = 5;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_stok_karti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 351);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.grp_arama);
            this.Controls.Add(this.list_stoklar);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_duzelt);
            this.Controls.Add(this.btn_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_stok_karti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.frm_stok_karti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_stoklar)).EndInit();
            this.grp_arama.ResumeLayout(false);
            this.grp_arama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView list_stoklar;
        private System.Windows.Forms.Button btn_duzelt;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.GroupBox grp_arama;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_aranan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_secenekler;
        private System.Windows.Forms.Button btn_yazdir;
    }
}
namespace Tamircim
{
    partial class frm_cari_islem
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
            this.list_cari_islem = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_cari_islem)).BeginInit();
            this.SuspendLayout();
            // 
            // list_cari_islem
            // 
            this.list_cari_islem.AllowUserToAddRows = false;
            this.list_cari_islem.AllowUserToDeleteRows = false;
            this.list_cari_islem.AllowUserToResizeColumns = false;
            this.list_cari_islem.AllowUserToResizeRows = false;
            this.list_cari_islem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_cari_islem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_cari_islem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.list_cari_islem.CausesValidation = false;
            this.list_cari_islem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.list_cari_islem.Location = new System.Drawing.Point(0, 41);
            this.list_cari_islem.Name = "list_cari_islem";
            this.list_cari_islem.ReadOnly = true;
            this.list_cari_islem.RowHeadersVisible = false;
            this.list_cari_islem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_cari_islem.ShowEditingIcon = false;
            this.list_cari_islem.Size = new System.Drawing.Size(710, 389);
            this.list_cari_islem.TabIndex = 0;
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
            this.btn_duzenle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(174, 12);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 1;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_cari_islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 433);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.list_cari_islem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cari_islem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari İşlem";
            this.Load += new System.EventHandler(this.frm_cari_islem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_cari_islem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView list_cari_islem;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_sil;
    }
}
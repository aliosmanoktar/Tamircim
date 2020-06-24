namespace Tamircim
{
    partial class frm_servis_odeme_ekle
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
            this.date_tarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_odeme = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_odeme_turu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // date_tarih
            // 
            this.date_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_tarih.Location = new System.Drawing.Point(103, 22);
            this.date_tarih.Name = "date_tarih";
            this.date_tarih.Size = new System.Drawing.Size(121, 20);
            this.date_tarih.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alınan Ödeme:";
            // 
            // txt_odeme
            // 
            this.txt_odeme.Location = new System.Drawing.Point(103, 60);
            this.txt_odeme.Name = "txt_odeme";
            this.txt_odeme.Size = new System.Drawing.Size(121, 20);
            this.txt_odeme.TabIndex = 3;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(115, 129);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 4;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ödeme Türü:";
            // 
            // cmb_odeme_turu
            // 
            this.cmb_odeme_turu.FormattingEnabled = true;
            this.cmb_odeme_turu.Location = new System.Drawing.Point(103, 93);
            this.cmb_odeme_turu.Name = "cmb_odeme_turu";
            this.cmb_odeme_turu.Size = new System.Drawing.Size(121, 21);
            this.cmb_odeme_turu.TabIndex = 6;
            // 
            // frm_servis_odeme_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 164);
            this.Controls.Add(this.cmb_odeme_turu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_odeme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_tarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_servis_odeme_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis Odeme Ekle";
            this.Load += new System.EventHandler(this.frm_servis_odeme_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_tarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_odeme;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_odeme_turu;
    }
}
namespace Tamircim
{
    partial class frm_servis_ekle
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
            this.date_tarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.date_saat = new System.Windows.Forms.DateTimePicker();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_yakit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_getiren = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_emanet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih:";
            // 
            // date_tarih
            // 
            this.date_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_tarih.Location = new System.Drawing.Point(67, 15);
            this.date_tarih.Name = "date_tarih";
            this.date_tarih.Size = new System.Drawing.Size(101, 20);
            this.date_tarih.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saat:";
            // 
            // date_saat
            // 
            this.date_saat.CustomFormat = "HH:mm";
            this.date_saat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_saat.Location = new System.Drawing.Point(216, 15);
            this.date_saat.Name = "date_saat";
            this.date_saat.ShowUpDown = true;
            this.date_saat.Size = new System.Drawing.Size(101, 20);
            this.date_saat.TabIndex = 1;
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(67, 41);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(100, 20);
            this.txt_km.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Km:";
            // 
            // txt_yakit
            // 
            this.txt_yakit.Location = new System.Drawing.Point(216, 41);
            this.txt_yakit.Name = "txt_yakit";
            this.txt_yakit.Size = new System.Drawing.Size(100, 20);
            this.txt_yakit.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yakıt:";
            // 
            // txt_getiren
            // 
            this.txt_getiren.Location = new System.Drawing.Point(67, 67);
            this.txt_getiren.Name = "txt_getiren";
            this.txt_getiren.Size = new System.Drawing.Size(250, 20);
            this.txt_getiren.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Getiren:";
            // 
            // txt_emanet
            // 
            this.txt_emanet.Location = new System.Drawing.Point(67, 93);
            this.txt_emanet.Name = "txt_emanet";
            this.txt_emanet.Size = new System.Drawing.Size(250, 20);
            this.txt_emanet.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Not:";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(63, 130);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(225, 130);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 7;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            // 
            // frm_servis_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 165);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_yakit);
            this.Controls.Add(this.txt_emanet);
            this.Controls.Add(this.txt_getiren);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.date_saat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_tarih);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_servis_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis Ekle";
            this.Load += new System.EventHandler(this.frm_servis_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_tarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_saat;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_yakit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_getiren;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_emanet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_iptal;
    }
}
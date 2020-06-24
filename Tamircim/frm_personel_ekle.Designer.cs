namespace Tamircim
{
    partial class frm_personel_ekle
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
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bolum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ucret = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(75, 25);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(183, 20);
            this.txt_ad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon:";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(75, 60);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(183, 20);
            this.txt_tel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adres:";
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(74, 86);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(183, 57);
            this.txt_adres.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bolum:";
            // 
            // txt_bolum
            // 
            this.txt_bolum.Location = new System.Drawing.Point(75, 158);
            this.txt_bolum.Name = "txt_bolum";
            this.txt_bolum.Size = new System.Drawing.Size(183, 20);
            this.txt_bolum.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ucret:";
            // 
            // txt_ucret
            // 
            this.txt_ucret.Location = new System.Drawing.Point(75, 193);
            this.txt_ucret.Name = "txt_ucret";
            this.txt_ucret.Size = new System.Drawing.Size(183, 20);
            this.txt_ucret.TabIndex = 5;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(107, 236);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // frm_personel_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 284);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_bolum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ucret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_personel_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekle";
            this.Load += new System.EventHandler(this.frm_personel_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bolum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ucret;
        private System.Windows.Forms.Button btn_kaydet;
    }
}
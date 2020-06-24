namespace Tamircim
{
    partial class frm_urun_ekle
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
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_birim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kdv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_satis = new System.Windows.Forms.TextBox();
            this.chk_stok_dus = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(13, 13);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(94, 13);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 6;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kodu:";
            // 
            // txt_kodu
            // 
            this.txt_kodu.Location = new System.Drawing.Point(70, 51);
            this.txt_kodu.Name = "txt_kodu";
            this.txt_kodu.Size = new System.Drawing.Size(141, 20);
            this.txt_kodu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(70, 77);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(141, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birim:";
            // 
            // txt_birim
            // 
            this.txt_birim.Location = new System.Drawing.Point(70, 103);
            this.txt_birim.Name = "txt_birim";
            this.txt_birim.Size = new System.Drawing.Size(141, 20);
            this.txt_birim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "KDV ( % ):";
            // 
            // txt_kdv
            // 
            this.txt_kdv.Location = new System.Drawing.Point(70, 129);
            this.txt_kdv.Name = "txt_kdv";
            this.txt_kdv.Size = new System.Drawing.Size(141, 20);
            this.txt_kdv.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Satış Fiyatı:";
            // 
            // txt_satis
            // 
            this.txt_satis.Location = new System.Drawing.Point(70, 155);
            this.txt_satis.Name = "txt_satis";
            this.txt_satis.Size = new System.Drawing.Size(141, 20);
            this.txt_satis.TabIndex = 4;
            // 
            // chk_stok_dus
            // 
            this.chk_stok_dus.AutoSize = true;
            this.chk_stok_dus.Location = new System.Drawing.Point(75, 244);
            this.chk_stok_dus.Name = "chk_stok_dus";
            this.chk_stok_dus.Size = new System.Drawing.Size(94, 17);
            this.chk_stok_dus.TabIndex = 7;
            this.chk_stok_dus.Text = "Stoktan Düşer";
            this.chk_stok_dus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ürün Not:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 181);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 57);
            this.textBox1.TabIndex = 9;
            // 
            // frm_urun_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 273);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chk_stok_dus);
            this.Controls.Add(this.txt_satis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_kdv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_birim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_urun_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Ekle";
            this.Load += new System.EventHandler(this.frm_urun_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_birim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kdv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_satis;
        private System.Windows.Forms.CheckBox chk_stok_dus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}
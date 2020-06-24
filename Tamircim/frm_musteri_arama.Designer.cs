namespace Tamircim
{
    partial class frm_musteri_arama
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
            this.cmb_arama_secenekleri = new System.Windows.Forms.ComboBox();
            this.txt_aranan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Seçeneği:";
            // 
            // cmb_arama_secenekleri
            // 
            this.cmb_arama_secenekleri.FormattingEnabled = true;
            this.cmb_arama_secenekleri.Location = new System.Drawing.Point(106, 6);
            this.cmb_arama_secenekleri.Name = "cmb_arama_secenekleri";
            this.cmb_arama_secenekleri.Size = new System.Drawing.Size(121, 21);
            this.cmb_arama_secenekleri.TabIndex = 1;
            // 
            // txt_aranan
            // 
            this.txt_aranan.Location = new System.Drawing.Point(106, 36);
            this.txt_aranan.Name = "txt_aranan";
            this.txt_aranan.Size = new System.Drawing.Size(121, 20);
            this.txt_aranan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arama Değeri:";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(106, 74);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 4;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // frm_musteri_arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 117);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_aranan);
            this.Controls.Add(this.cmb_arama_secenekleri);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_musteri_arama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Arama";
            this.Load += new System.EventHandler(this.frm_musteri_arama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_arama_secenekleri;
        private System.Windows.Forms.TextBox txt_aranan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ara;
    }
}
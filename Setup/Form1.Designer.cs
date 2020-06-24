namespace Setup
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_arayuz = new System.Windows.Forms.Panel();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_arayuz
            // 
            this.pnl_arayuz.Location = new System.Drawing.Point(6, 84);
            this.pnl_arayuz.Name = "pnl_arayuz";
            this.pnl_arayuz.Size = new System.Drawing.Size(430, 390);
            this.pnl_arayuz.TabIndex = 0;
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(351, 479);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(75, 23);
            this.btn_ileri.TabIndex = 0;
            this.btn_ileri.Text = "İleri";
            this.btn_ileri.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(268, 479);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_geri.TabIndex = 0;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            // 
            // img
            // 
            this.img.BackgroundImage = global::Setup.Properties.Resources.giris;
            this.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img.Location = new System.Drawing.Point(0, 0);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(445, 77);
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 514);
            this.Controls.Add(this.img);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.pnl_arayuz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamircim Setup";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_arayuz;
        public System.Windows.Forms.Button btn_ileri;
        public System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.PictureBox img;
    }
}


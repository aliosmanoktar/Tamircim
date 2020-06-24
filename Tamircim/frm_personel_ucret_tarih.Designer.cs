namespace Tamircim
{
    partial class frm_personel_ucret_tarih
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_personel = new System.Windows.Forms.TextBox();
            this.btn_personel_listele = new System.Windows.Forms.Button();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_bitis = new System.Windows.Forms.DateTimePicker();
            this.dt_baslangic = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 65);
            this.label1.TabIndex = 8;
            this.label1.Text = "Personel seçimi boş bırakılırsa seçilen tarih aralığındaki bütün personel işlemle" +
    "ri listelenir";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_personel);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Seçimi";
            // 
            // txt_personel
            // 
            this.txt_personel.Location = new System.Drawing.Point(6, 31);
            this.txt_personel.Name = "txt_personel";
            this.txt_personel.Size = new System.Drawing.Size(219, 20);
            this.txt_personel.TabIndex = 2;
            this.txt_personel.TextChanged += new System.EventHandler(this.txt_personel_TextChanged);
            // 
            // btn_personel_listele
            // 
            this.btn_personel_listele.Location = new System.Drawing.Point(93, 12);
            this.btn_personel_listele.Name = "btn_personel_listele";
            this.btn_personel_listele.Size = new System.Drawing.Size(104, 23);
            this.btn_personel_listele.TabIndex = 4;
            this.btn_personel_listele.Text = "Personel Listele";
            this.btn_personel_listele.UseVisualStyleBackColor = true;
            this.btn_personel_listele.Click += new System.EventHandler(this.btn_personel_listele_Click);
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(12, 12);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(75, 23);
            this.btn_yazdir.TabIndex = 5;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dt_bitis);
            this.groupBox2.Controls.Add(this.dt_baslangic);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 80);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tarih Seçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // dt_bitis
            // 
            this.dt_bitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_bitis.Location = new System.Drawing.Point(133, 32);
            this.dt_bitis.Name = "dt_bitis";
            this.dt_bitis.Size = new System.Drawing.Size(92, 20);
            this.dt_bitis.TabIndex = 0;
            // 
            // dt_baslangic
            // 
            this.dt_baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_baslangic.Location = new System.Drawing.Point(6, 32);
            this.dt_baslangic.Name = "dt_baslangic";
            this.dt_baslangic.Size = new System.Drawing.Size(92, 20);
            this.dt_baslangic.TabIndex = 0;
            // 
            // frm_personel_ucret_tarih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_personel_listele);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_personel_ucret_tarih";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Rapor";
            this.Load += new System.EventHandler(this.frm_personel_ucret_tarih_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_personel;
        private System.Windows.Forms.Button btn_personel_listele;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_bitis;
        private System.Windows.Forms.DateTimePicker dt_baslangic;
    }
}
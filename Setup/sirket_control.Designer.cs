namespace Setup
{
    partial class sirket_control
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sicil_no = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mersis_no = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_vergi_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_vergi_dairesi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_unvan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_baglan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_adres
            // 
            this.txt_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adres.Location = new System.Drawing.Point(127, 73);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(221, 67);
            this.txt_adres.TabIndex = 2;
            this.txt_adres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adres:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.Location = new System.Drawing.Point(127, 285);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(221, 21);
            this.txt_email.TabIndex = 8;
            this.txt_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(71, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "E-Mail:";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telefon.Location = new System.Drawing.Point(127, 259);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(221, 21);
            this.txt_telefon.TabIndex = 7;
            this.txt_telefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            this.txt_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vergi_no_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(64, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Telefon:";
            // 
            // txt_sicil_no
            // 
            this.txt_sicil_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sicil_no.Location = new System.Drawing.Point(127, 233);
            this.txt_sicil_no.Name = "txt_sicil_no";
            this.txt_sicil_no.Size = new System.Drawing.Size(221, 21);
            this.txt_sicil_no.TabIndex = 6;
            this.txt_sicil_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            this.txt_sicil_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vergi_no_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(64, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sicil No:";
            // 
            // txt_mersis_no
            // 
            this.txt_mersis_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mersis_no.Location = new System.Drawing.Point(127, 207);
            this.txt_mersis_no.Name = "txt_mersis_no";
            this.txt_mersis_no.Size = new System.Drawing.Size(221, 21);
            this.txt_mersis_no.TabIndex = 5;
            this.txt_mersis_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            this.txt_mersis_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vergi_no_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mersis No:";
            // 
            // txt_vergi_no
            // 
            this.txt_vergi_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_vergi_no.Location = new System.Drawing.Point(127, 175);
            this.txt_vergi_no.Name = "txt_vergi_no";
            this.txt_vergi_no.Size = new System.Drawing.Size(221, 21);
            this.txt_vergi_no.TabIndex = 4;
            this.txt_vergi_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            this.txt_vergi_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vergi_no_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vergi No / TC No:";
            // 
            // txt_vergi_dairesi
            // 
            this.txt_vergi_dairesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_vergi_dairesi.Location = new System.Drawing.Point(127, 146);
            this.txt_vergi_dairesi.Name = "txt_vergi_dairesi";
            this.txt_vergi_dairesi.Size = new System.Drawing.Size(221, 21);
            this.txt_vergi_dairesi.TabIndex = 3;
            this.txt_vergi_dairesi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vergi Dairesi:";
            // 
            // txt_unvan
            // 
            this.txt_unvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_unvan.Location = new System.Drawing.Point(127, 47);
            this.txt_unvan.Name = "txt_unvan";
            this.txt_unvan.Size = new System.Drawing.Size(221, 21);
            this.txt_unvan.TabIndex = 1;
            this.txt_unvan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Firma Ünvanı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(354, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(354, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(124, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(215, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "* \'lı alanların doldurulması zorunludur!";
            // 
            // btn_baglan
            // 
            this.btn_baglan.Location = new System.Drawing.Point(273, 331);
            this.btn_baglan.Name = "btn_baglan";
            this.btn_baglan.Size = new System.Drawing.Size(75, 23);
            this.btn_baglan.TabIndex = 20;
            this.btn_baglan.Text = "Bağlan";
            this.btn_baglan.UseVisualStyleBackColor = true;
            this.btn_baglan.Visible = false;
            this.btn_baglan.Click += new System.EventHandler(this.btn_baglan_Click);
            // 
            // sirket_control
            // 
            this.Controls.Add(this.btn_baglan);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_sicil_no);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_mersis_no);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_vergi_no);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_vergi_dairesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_unvan);
            this.Controls.Add(this.label1);
            this.Name = "sirket_control";
            this.Size = new System.Drawing.Size(420, 470);
            this.Load += new System.EventHandler(this.sirket_control_Load);
            this.VisibleChanged += new System.EventHandler(this.sirket_control_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sicil_no;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mersis_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_vergi_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_vergi_dairesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_unvan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_baglan;
    }
}

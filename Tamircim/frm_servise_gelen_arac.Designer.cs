namespace Tamircim
{
    partial class frm_servise_gelen_arac
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_bitis = new System.Windows.Forms.DateTimePicker();
            this.dt_baslangic = new System.Windows.Forms.DateTimePicker();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dt_bitis);
            this.groupBox2.Controls.Add(this.dt_baslangic);
            this.groupBox2.Location = new System.Drawing.Point(12, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 80);
            this.groupBox2.TabIndex = 2;
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
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(12, 12);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(75, 23);
            this.btn_yazdir.TabIndex = 3;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // frm_servise_gelen_arac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 140);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_servise_gelen_arac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servise Gelen Araçlar";
            this.Load += new System.EventHandler(this.frm_servise_gelen_arac_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_bitis;
        private System.Windows.Forms.DateTimePicker dt_baslangic;
        private System.Windows.Forms.Button btn_yazdir;
    }
}
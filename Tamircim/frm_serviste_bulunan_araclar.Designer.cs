namespace Tamircim
{
    partial class frm_serviste_bulunan_araclar
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
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.list_servisteki_araclar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.list_servisteki_araclar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(12, 12);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(75, 23);
            this.btn_yazdir.TabIndex = 0;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // list_servisteki_araclar
            // 
            this.list_servisteki_araclar.AllowUserToAddRows = false;
            this.list_servisteki_araclar.AllowUserToDeleteRows = false;
            this.list_servisteki_araclar.AllowUserToResizeColumns = false;
            this.list_servisteki_araclar.AllowUserToResizeRows = false;
            this.list_servisteki_araclar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_servisteki_araclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_servisteki_araclar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.list_servisteki_araclar.CausesValidation = false;
            this.list_servisteki_araclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.list_servisteki_araclar.Location = new System.Drawing.Point(0, 40);
            this.list_servisteki_araclar.Name = "list_servisteki_araclar";
            this.list_servisteki_araclar.ReadOnly = true;
            this.list_servisteki_araclar.RowHeadersVisible = false;
            this.list_servisteki_araclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_servisteki_araclar.ShowEditingIcon = false;
            this.list_servisteki_araclar.Size = new System.Drawing.Size(781, 391);
            this.list_servisteki_araclar.TabIndex = 0;
            // 
            // frm_serviste_bulunan_araclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 431);
            this.Controls.Add(this.list_servisteki_araclar);
            this.Controls.Add(this.btn_yazdir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_serviste_bulunan_araclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serviste Bulunan Araçlar";
            this.Load += new System.EventHandler(this.frm_serviste_bulunan_araclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_servisteki_araclar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.DataGridView list_servisteki_araclar;
    }
}
namespace ProjeOdev2
{
    partial class AnaMenu
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
            this.OgrenciDosyasiBtn = new System.Windows.Forms.Button();
            this.SoruBankasiBtn = new System.Windows.Forms.Button();
            this.SinavGirBtn = new System.Windows.Forms.Button();
            this.SinavHazirlaBtn = new System.Windows.Forms.Button();
            this.RaporlarBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.uyari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OgrenciDosyasiBtn
            // 
            this.OgrenciDosyasiBtn.Location = new System.Drawing.Point(35, 133);
            this.OgrenciDosyasiBtn.Name = "OgrenciDosyasiBtn";
            this.OgrenciDosyasiBtn.Size = new System.Drawing.Size(145, 23);
            this.OgrenciDosyasiBtn.TabIndex = 0;
            this.OgrenciDosyasiBtn.Text = "Öğrenci Dosyası";
            this.OgrenciDosyasiBtn.UseVisualStyleBackColor = true;
            this.OgrenciDosyasiBtn.Click += new System.EventHandler(this.OgrenciDosyasiBtn_Click);
            // 
            // SoruBankasiBtn
            // 
            this.SoruBankasiBtn.Location = new System.Drawing.Point(233, 133);
            this.SoruBankasiBtn.Name = "SoruBankasiBtn";
            this.SoruBankasiBtn.Size = new System.Drawing.Size(145, 23);
            this.SoruBankasiBtn.TabIndex = 1;
            this.SoruBankasiBtn.Text = "Soru Bankası";
            this.SoruBankasiBtn.UseVisualStyleBackColor = true;
            this.SoruBankasiBtn.Click += new System.EventHandler(this.SoruBankasiBtn_Click);
            // 
            // SinavGirBtn
            // 
            this.SinavGirBtn.Location = new System.Drawing.Point(35, 242);
            this.SinavGirBtn.Name = "SinavGirBtn";
            this.SinavGirBtn.Size = new System.Drawing.Size(145, 23);
            this.SinavGirBtn.TabIndex = 2;
            this.SinavGirBtn.Text = "Sınav Gir";
            this.SinavGirBtn.UseVisualStyleBackColor = true;
            this.SinavGirBtn.Click += new System.EventHandler(this.SinavGirBtn_Click);
            // 
            // SinavHazirlaBtn
            // 
            this.SinavHazirlaBtn.Location = new System.Drawing.Point(233, 242);
            this.SinavHazirlaBtn.Name = "SinavHazirlaBtn";
            this.SinavHazirlaBtn.Size = new System.Drawing.Size(145, 23);
            this.SinavHazirlaBtn.TabIndex = 3;
            this.SinavHazirlaBtn.Text = "Sınav Hazırla";
            this.SinavHazirlaBtn.UseVisualStyleBackColor = true;
            this.SinavHazirlaBtn.Click += new System.EventHandler(this.SinavHazirlaBtn_Click);
            // 
            // RaporlarBtn
            // 
            this.RaporlarBtn.Location = new System.Drawing.Point(436, 133);
            this.RaporlarBtn.Name = "RaporlarBtn";
            this.RaporlarBtn.Size = new System.Drawing.Size(145, 23);
            this.RaporlarBtn.TabIndex = 4;
            this.RaporlarBtn.Text = "Raporlar";
            this.RaporlarBtn.UseVisualStyleBackColor = true;
            this.RaporlarBtn.Click += new System.EventHandler(this.RaporlarBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(436, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // uyari
            // 
            this.uyari.AutoSize = true;
            this.uyari.Location = new System.Drawing.Point(187, 357);
            this.uyari.Name = "uyari";
            this.uyari.Size = new System.Drawing.Size(0, 13);
            this.uyari.TabIndex = 6;
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uyari);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RaporlarBtn);
            this.Controls.Add(this.SinavHazirlaBtn);
            this.Controls.Add(this.SinavGirBtn);
            this.Controls.Add(this.SoruBankasiBtn);
            this.Controls.Add(this.OgrenciDosyasiBtn);
            this.Name = "AnaMenu";
            this.Text = "AnaMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OgrenciDosyasiBtn;
        private System.Windows.Forms.Button SoruBankasiBtn;
        private System.Windows.Forms.Button SinavGirBtn;
        private System.Windows.Forms.Button SinavHazirlaBtn;
        private System.Windows.Forms.Button RaporlarBtn;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label uyari;
    }
}
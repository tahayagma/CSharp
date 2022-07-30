namespace ProjeOdev2
{
    partial class Ogrenci_Dosyasi
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
            this.OgrTc = new System.Windows.Forms.TextBox();
            this.OgrSifre = new System.Windows.Forms.TextBox();
            this.OgrAdSoyad = new System.Windows.Forms.TextBox();
            this.OgrencSilTxt = new System.Windows.Forms.TextBox();
            this.OgrenciSilBtn = new System.Windows.Forms.Button();
            this.OgrenciEkleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OgrenciEkleAlert = new System.Windows.Forms.Label();
            this.OgrListeleBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.silindiAlert = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OgrTc
            // 
            this.OgrTc.Location = new System.Drawing.Point(138, 7);
            this.OgrTc.Name = "OgrTc";
            this.OgrTc.Size = new System.Drawing.Size(100, 20);
            this.OgrTc.TabIndex = 0;
            // 
            // OgrSifre
            // 
            this.OgrSifre.Location = new System.Drawing.Point(138, 60);
            this.OgrSifre.Name = "OgrSifre";
            this.OgrSifre.Size = new System.Drawing.Size(100, 20);
            this.OgrSifre.TabIndex = 1;
            this.OgrSifre.UseSystemPasswordChar = true;
            // 
            // OgrAdSoyad
            // 
            this.OgrAdSoyad.Location = new System.Drawing.Point(138, 32);
            this.OgrAdSoyad.Name = "OgrAdSoyad";
            this.OgrAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.OgrAdSoyad.TabIndex = 2;
            // 
            // OgrencSilTxt
            // 
            this.OgrencSilTxt.Location = new System.Drawing.Point(50, 47);
            this.OgrencSilTxt.Name = "OgrencSilTxt";
            this.OgrencSilTxt.Size = new System.Drawing.Size(100, 20);
            this.OgrencSilTxt.TabIndex = 3;
            // 
            // OgrenciSilBtn
            // 
            this.OgrenciSilBtn.Location = new System.Drawing.Point(234, 44);
            this.OgrenciSilBtn.Name = "OgrenciSilBtn";
            this.OgrenciSilBtn.Size = new System.Drawing.Size(102, 23);
            this.OgrenciSilBtn.TabIndex = 4;
            this.OgrenciSilBtn.Text = "Öğrenci Sil";
            this.OgrenciSilBtn.UseVisualStyleBackColor = true;
            this.OgrenciSilBtn.Click += new System.EventHandler(this.OgrenciSilBtn_Click);
            // 
            // OgrenciEkleBtn
            // 
            this.OgrenciEkleBtn.Location = new System.Drawing.Point(138, 130);
            this.OgrenciEkleBtn.Name = "OgrenciEkleBtn";
            this.OgrenciEkleBtn.Size = new System.Drawing.Size(100, 23);
            this.OgrenciEkleBtn.TabIndex = 5;
            this.OgrenciEkleBtn.Text = "Öğrenci Ekle";
            this.OgrenciEkleBtn.UseVisualStyleBackColor = true;
            this.OgrenciEkleBtn.Click += new System.EventHandler(this.OgrenciEkleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "* TC: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şifre:";
            // 
            // OgrenciEkleAlert
            // 
            this.OgrenciEkleAlert.AutoSize = true;
            this.OgrenciEkleAlert.Location = new System.Drawing.Point(13, 102);
            this.OgrenciEkleAlert.Name = "OgrenciEkleAlert";
            this.OgrenciEkleAlert.Size = new System.Drawing.Size(0, 13);
            this.OgrenciEkleAlert.TabIndex = 10;
            // 
            // OgrListeleBtn
            // 
            this.OgrListeleBtn.Location = new System.Drawing.Point(28, 364);
            this.OgrListeleBtn.Name = "OgrListeleBtn";
            this.OgrListeleBtn.Size = new System.Drawing.Size(200, 23);
            this.OgrListeleBtn.TabIndex = 11;
            this.OgrListeleBtn.Text = "Listele";
            this.OgrListeleBtn.UseVisualStyleBackColor = true;
            this.OgrListeleBtn.Click += new System.EventHandler(this.OgrListeleBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 134);
            this.listBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 14;
            // 
            // silindiAlert
            // 
            this.silindiAlert.AutoSize = true;
            this.silindiAlert.Location = new System.Drawing.Point(10, 91);
            this.silindiAlert.Name = "silindiAlert";
            this.silindiAlert.Size = new System.Drawing.Size(15, 13);
            this.silindiAlert.TabIndex = 15;
            this.silindiAlert.Text = "al";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.OgrTc);
            this.panel1.Controls.Add(this.OgrAdSoyad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.OgrenciEkleAlert);
            this.panel1.Controls.Add(this.OgrSifre);
            this.panel1.Controls.Add(this.OgrenciEkleBtn);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 164);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.OgrencSilTxt);
            this.panel2.Controls.Add(this.OgrenciSilBtn);
            this.panel2.Controls.Add(this.silindiAlert);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(395, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 126);
            this.panel2.TabIndex = 17;
            // 
            // Ogrenci_Dosyasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.OgrListeleBtn);
            this.Name = "Ogrenci_Dosyasi";
            this.Text = "Ogrenci_Dosyasi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label OgrenciEkleAlert;
        private System.Windows.Forms.TextBox OgrTc;
        private System.Windows.Forms.TextBox OgrSifre;
        private System.Windows.Forms.TextBox OgrAdSoyad;
        private System.Windows.Forms.TextBox OgrencSilTxt;
        private System.Windows.Forms.Button OgrenciSilBtn;
        private System.Windows.Forms.Button OgrenciEkleBtn;
        private System.Windows.Forms.Button OgrListeleBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label silindiAlert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
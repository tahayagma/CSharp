/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 YAZ DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje 1
**				ÖĞRENCİ ADI............: TAHA YAĞMA
**				ÖĞRENCİ NUMARASI.......: S211210167
**              DERSİN ALINDIĞI GRUP...: 1.Öğretim A
****************************************************************************/


namespace ProjeOdev2
{
    partial class SinavHazirlama
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SınavSureBox = new System.Windows.Forms.TextBox();
            this.GecmePuaniBox = new System.Windows.Forms.TextBox();
            this.SinavAdBox = new System.Windows.Forms.TextBox();
            this.SinavOlusturBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SayiBox = new System.Windows.Forms.TextBox();
            this.OgrSınavcheckedList = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SinavHazirlaListeleBtn = new System.Windows.Forms.Button();
            this.SinavHazirlaAlert = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.SilBtn = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Sınav Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Sınav Süresi\n  (Dakika)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Sınav Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "* Geçme Puanı:";
            // 
            // SınavSureBox
            // 
            this.SınavSureBox.Location = new System.Drawing.Point(103, 58);
            this.SınavSureBox.Name = "SınavSureBox";
            this.SınavSureBox.Size = new System.Drawing.Size(100, 20);
            this.SınavSureBox.TabIndex = 5;
            // 
            // GecmePuaniBox
            // 
            this.GecmePuaniBox.Location = new System.Drawing.Point(103, 89);
            this.GecmePuaniBox.Name = "GecmePuaniBox";
            this.GecmePuaniBox.Size = new System.Drawing.Size(100, 20);
            this.GecmePuaniBox.TabIndex = 6;
            // 
            // SinavAdBox
            // 
            this.SinavAdBox.Location = new System.Drawing.Point(103, 22);
            this.SinavAdBox.Name = "SinavAdBox";
            this.SinavAdBox.Size = new System.Drawing.Size(100, 20);
            this.SinavAdBox.TabIndex = 4;
            // 
            // SinavOlusturBtn
            // 
            this.SinavOlusturBtn.Location = new System.Drawing.Point(12, 369);
            this.SinavOlusturBtn.Name = "SinavOlusturBtn";
            this.SinavOlusturBtn.Size = new System.Drawing.Size(146, 23);
            this.SinavOlusturBtn.TabIndex = 10;
            this.SinavOlusturBtn.Text = "Oluştur";
            this.SinavOlusturBtn.UseVisualStyleBackColor = true;
            this.SinavOlusturBtn.Click += new System.EventHandler(this.SinavOlusturBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "* Soru Sayısı:";
            // 
            // SayiBox
            // 
            this.SayiBox.Location = new System.Drawing.Point(103, 159);
            this.SayiBox.Name = "SayiBox";
            this.SayiBox.Size = new System.Drawing.Size(100, 20);
            this.SayiBox.TabIndex = 8;
            // 
            // OgrSınavcheckedList
            // 
            this.OgrSınavcheckedList.FormattingEnabled = true;
            this.OgrSınavcheckedList.Location = new System.Drawing.Point(12, 225);
            this.OgrSınavcheckedList.Name = "OgrSınavcheckedList";
            this.OgrSınavcheckedList.Size = new System.Drawing.Size(188, 94);
            this.OgrSınavcheckedList.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "* Öğrenci Sınav Listesi";
            // 
            // SinavHazirlaListeleBtn
            // 
            this.SinavHazirlaListeleBtn.Location = new System.Drawing.Point(206, 296);
            this.SinavHazirlaListeleBtn.Name = "SinavHazirlaListeleBtn";
            this.SinavHazirlaListeleBtn.Size = new System.Drawing.Size(49, 23);
            this.SinavHazirlaListeleBtn.TabIndex = 13;
            this.SinavHazirlaListeleBtn.Text = "Listele";
            this.SinavHazirlaListeleBtn.UseVisualStyleBackColor = true;
            this.SinavHazirlaListeleBtn.Click += new System.EventHandler(this.SinavHazirlaListeleBtn_Click);
            // 
            // SinavHazirlaAlert
            // 
            this.SinavHazirlaAlert.AutoSize = true;
            this.SinavHazirlaAlert.Location = new System.Drawing.Point(15, 336);
            this.SinavHazirlaAlert.Name = "SinavHazirlaAlert";
            this.SinavHazirlaAlert.Size = new System.Drawing.Size(0, 13);
            this.SinavHazirlaAlert.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 22, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.SilBtn);
            this.panel1.Controls.Add(this.EkleBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkedListBox2);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Location = new System.Drawing.Point(347, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 422);
            this.panel1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 17;
            // 
            // SilBtn
            // 
            this.SilBtn.Location = new System.Drawing.Point(283, 309);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(106, 23);
            this.SilBtn.TabIndex = 16;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(34, 309);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(106, 23);
            this.EkleBtn.TabIndex = 15;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Öğrencileri Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sınavları Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(132, 3);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(302, 94);
            this.checkedListBox2.TabIndex = 12;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(132, 144);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(302, 94);
            this.checkedListBox1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(347, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Öğrenci Ekle /  Sil";
            // 
            // SinavHazirlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SinavHazirlaAlert);
            this.Controls.Add(this.SinavHazirlaListeleBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OgrSınavcheckedList);
            this.Controls.Add(this.SayiBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SinavOlusturBtn);
            this.Controls.Add(this.SinavAdBox);
            this.Controls.Add(this.GecmePuaniBox);
            this.Controls.Add(this.SınavSureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SinavHazirlama";
            this.Text = "SinavHazirlama";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SınavSureBox;
        private System.Windows.Forms.TextBox GecmePuaniBox;
        private System.Windows.Forms.TextBox SinavAdBox;
        private System.Windows.Forms.Button SinavOlusturBtn;
        private System.Windows.Forms.TextBox SayiBox;
        private System.Windows.Forms.CheckedListBox OgrSınavcheckedList;
        private System.Windows.Forms.Button SinavHazirlaListeleBtn;
        private System.Windows.Forms.Label SinavHazirlaAlert;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}
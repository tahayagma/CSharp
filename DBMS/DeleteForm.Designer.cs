namespace DBMS_Proje
{
    partial class DeleteForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FilmRadio = new System.Windows.Forms.RadioButton();
            this.PersonelRadio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPersonel = new System.Windows.Forms.Panel();
            this.PMaas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PCinsiyet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PSoyad = new System.Windows.Forms.TextBox();
            this.PAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFilm = new System.Windows.Forms.Panel();
            this.YSirket = new System.Windows.Forms.TextBox();
            this.OdulAd = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.OdulSayi = new System.Windows.Forms.TextBox();
            this.Hasilat = new System.Windows.Forms.TextBox();
            this.OrtPuan = new System.Windows.Forms.TextBox();
            this.Ulke = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tur = new System.Windows.Forms.TextBox();
            this.Dil = new System.Windows.Forms.TextBox();
            this.Oy = new System.Windows.Forms.TextBox();
            this.Sure = new System.Windows.Forms.TextBox();
            this.Butce = new System.Windows.Forms.TextBox();
            this.FilmAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FilmID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPersonel.SuspendLayout();
            this.panelFilm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(570, 294);
            this.dataGridView1.TabIndex = 6;
        
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtrele";
            // 
            // FilmRadio
            // 
            this.FilmRadio.AutoSize = true;
            this.FilmRadio.Location = new System.Drawing.Point(3, 3);
            this.FilmRadio.Name = "FilmRadio";
            this.FilmRadio.Size = new System.Drawing.Size(43, 17);
            this.FilmRadio.TabIndex = 8;
            this.FilmRadio.TabStop = true;
            this.FilmRadio.Text = "Film";
            this.FilmRadio.UseVisualStyleBackColor = true;
            this.FilmRadio.CheckedChanged += new System.EventHandler(this.FilmRadio_CheckedChanged);
            // 
            // PersonelRadio
            // 
            this.PersonelRadio.AutoSize = true;
            this.PersonelRadio.Location = new System.Drawing.Point(73, 3);
            this.PersonelRadio.Name = "PersonelRadio";
            this.PersonelRadio.Size = new System.Drawing.Size(66, 17);
            this.PersonelRadio.TabIndex = 9;
            this.PersonelRadio.TabStop = true;
            this.PersonelRadio.Text = "Personel";
            this.PersonelRadio.UseVisualStyleBackColor = true;
            this.PersonelRadio.CheckedChanged += new System.EventHandler(this.PersonelRadio_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FilmRadio);
            this.panel1.Controls.Add(this.PersonelRadio);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 25);
            this.panel1.TabIndex = 10;
            // 
            // panelPersonel
            // 
            this.panelPersonel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPersonel.Controls.Add(this.PMaas);
            this.panelPersonel.Controls.Add(this.label5);
            this.panelPersonel.Controls.Add(this.PCinsiyet);
            this.panelPersonel.Controls.Add(this.label4);
            this.panelPersonel.Controls.Add(this.PSoyad);
            this.panelPersonel.Controls.Add(this.PAd);
            this.panelPersonel.Controls.Add(this.label3);
            this.panelPersonel.Controls.Add(this.label2);
            this.panelPersonel.Location = new System.Drawing.Point(12, 95);
            this.panelPersonel.Name = "panelPersonel";
            this.panelPersonel.Size = new System.Drawing.Size(176, 114);
            this.panelPersonel.TabIndex = 11;
            // 
            // PMaas
            // 
            this.PMaas.Location = new System.Drawing.Point(73, 83);
            this.PMaas.Name = "PMaas";
            this.PMaas.Size = new System.Drawing.Size(100, 20);
            this.PMaas.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Maaş: ";
            // 
            // PCinsiyet
            // 
            this.PCinsiyet.Location = new System.Drawing.Point(73, 55);
            this.PCinsiyet.Name = "PCinsiyet";
            this.PCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.PCinsiyet.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cinsiyet: ";
            // 
            // PSoyad
            // 
            this.PSoyad.Location = new System.Drawing.Point(73, 29);
            this.PSoyad.Name = "PSoyad";
            this.PSoyad.Size = new System.Drawing.Size(100, 20);
            this.PSoyad.TabIndex = 3;
            // 
            // PAd
            // 
            this.PAd.Location = new System.Drawing.Point(73, 3);
            this.PAd.Name = "PAd";
            this.PAd.Size = new System.Drawing.Size(100, 20);
            this.PAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı: ";
            // 
            // panelFilm
            // 
            this.panelFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilm.Controls.Add(this.YSirket);
            this.panelFilm.Controls.Add(this.OdulAd);
            this.panelFilm.Controls.Add(this.label18);
            this.panelFilm.Controls.Add(this.label17);
            this.panelFilm.Controls.Add(this.label16);
            this.panelFilm.Controls.Add(this.OdulSayi);
            this.panelFilm.Controls.Add(this.Hasilat);
            this.panelFilm.Controls.Add(this.OrtPuan);
            this.panelFilm.Controls.Add(this.Ulke);
            this.panelFilm.Controls.Add(this.label15);
            this.panelFilm.Controls.Add(this.label14);
            this.panelFilm.Controls.Add(this.label13);
            this.panelFilm.Controls.Add(this.label12);
            this.panelFilm.Controls.Add(this.label11);
            this.panelFilm.Controls.Add(this.label10);
            this.panelFilm.Controls.Add(this.label9);
            this.panelFilm.Controls.Add(this.label8);
            this.panelFilm.Controls.Add(this.Tur);
            this.panelFilm.Controls.Add(this.Dil);
            this.panelFilm.Controls.Add(this.Oy);
            this.panelFilm.Controls.Add(this.Sure);
            this.panelFilm.Controls.Add(this.Butce);
            this.panelFilm.Controls.Add(this.FilmAd);
            this.panelFilm.Controls.Add(this.label7);
            this.panelFilm.Controls.Add(this.FilmID);
            this.panelFilm.Controls.Add(this.label6);
            this.panelFilm.Location = new System.Drawing.Point(9, 95);
            this.panelFilm.Name = "panelFilm";
            this.panelFilm.Size = new System.Drawing.Size(179, 343);
            this.panelFilm.TabIndex = 12;
            // 
            // YSirket
            // 
            this.YSirket.Location = new System.Drawing.Point(73, 317);
            this.YSirket.Name = "YSirket";
            this.YSirket.Size = new System.Drawing.Size(100, 20);
            this.YSirket.TabIndex = 37;
            // 
            // OdulAd
            // 
            this.OdulAd.Location = new System.Drawing.Point(73, 291);
            this.OdulAd.Name = "OdulAd";
            this.OdulAd.Size = new System.Drawing.Size(100, 20);
            this.OdulAd.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(0, 321);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Yapımcı Şirket:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 299);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Ödül Adı:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 272);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Ödül Sayısı:";
            // 
            // OdulSayi
            // 
            this.OdulSayi.Location = new System.Drawing.Point(73, 265);
            this.OdulSayi.Name = "OdulSayi";
            this.OdulSayi.Size = new System.Drawing.Size(100, 20);
            this.OdulSayi.TabIndex = 32;
            // 
            // Hasilat
            // 
            this.Hasilat.Location = new System.Drawing.Point(74, 242);
            this.Hasilat.Name = "Hasilat";
            this.Hasilat.Size = new System.Drawing.Size(100, 20);
            this.Hasilat.TabIndex = 17;
            // 
            // OrtPuan
            // 
            this.OrtPuan.Location = new System.Drawing.Point(73, 187);
            this.OrtPuan.Name = "OrtPuan";
            this.OrtPuan.Size = new System.Drawing.Size(100, 20);
            this.OrtPuan.TabIndex = 20;
            // 
            // Ulke
            // 
            this.Ulke.Location = new System.Drawing.Point(73, 83);
            this.Ulke.Name = "Ulke";
            this.Ulke.Size = new System.Drawing.Size(100, 20);
            this.Ulke.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Ülke:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Tür:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Dil:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Oy:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ort Puan:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Süre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Bütçe: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Hasılat: ";
            // 
            // Tur
            // 
            this.Tur.Location = new System.Drawing.Point(73, 55);
            this.Tur.Name = "Tur";
            this.Tur.Size = new System.Drawing.Size(100, 20);
            this.Tur.TabIndex = 23;
            // 
            // Dil
            // 
            this.Dil.Location = new System.Drawing.Point(73, 135);
            this.Dil.Name = "Dil";
            this.Dil.Size = new System.Drawing.Size(100, 20);
            this.Dil.TabIndex = 22;
            // 
            // Oy
            // 
            this.Oy.Location = new System.Drawing.Point(73, 161);
            this.Oy.Name = "Oy";
            this.Oy.Size = new System.Drawing.Size(100, 20);
            this.Oy.TabIndex = 21;
            // 
            // Sure
            // 
            this.Sure.Location = new System.Drawing.Point(73, 109);
            this.Sure.Name = "Sure";
            this.Sure.Size = new System.Drawing.Size(100, 20);
            this.Sure.TabIndex = 19;
            // 
            // Butce
            // 
            this.Butce.Location = new System.Drawing.Point(73, 216);
            this.Butce.Name = "Butce";
            this.Butce.Size = new System.Drawing.Size(100, 20);
            this.Butce.TabIndex = 18;
            // 
            // FilmAd
            // 
            this.FilmAd.Location = new System.Drawing.Point(73, 29);
            this.FilmAd.Name = "FilmAd";
            this.FilmAd.Size = new System.Drawing.Size(100, 20);
            this.FilmAd.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Film Adı:";
            // 
            // FilmID
            // 
            this.FilmID.Location = new System.Drawing.Point(73, 3);
            this.FilmID.Name = "FilmID";
            this.FilmID.Size = new System.Drawing.Size(100, 20);
            this.FilmID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Film ID:";
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(390, 395);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(177, 23);
            this.FilterBtn.TabIndex = 13;
            this.FilterBtn.Text = "Sonuçları Filtrele";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.panelFilm);
            this.Controls.Add(this.panelPersonel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeleteForm";
            this.Text = "Sil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPersonel.ResumeLayout(false);
            this.panelPersonel.PerformLayout();
            this.panelFilm.ResumeLayout(false);
            this.panelFilm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton FilmRadio;
        private System.Windows.Forms.RadioButton PersonelRadio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PMaas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PCinsiyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PSoyad;
        private System.Windows.Forms.TextBox PAd;
        private System.Windows.Forms.Panel panelFilm;
        private System.Windows.Forms.TextBox YSirket;
        private System.Windows.Forms.TextBox OdulAd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox OdulSayi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Ulke;
        private System.Windows.Forms.TextBox Tur;
        private System.Windows.Forms.TextBox Dil;
        private System.Windows.Forms.TextBox Oy;
        private System.Windows.Forms.TextBox OrtPuan;
        private System.Windows.Forms.TextBox Sure;
        private System.Windows.Forms.TextBox Butce;
        private System.Windows.Forms.TextBox Hasilat;
        private System.Windows.Forms.TextBox FilmAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FilmID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FilterBtn;
    }
}
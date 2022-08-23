namespace DBMS_Proje
{
    partial class UpdateForm
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
            this.comboAlan = new System.Windows.Forms.ComboBox();
            this.comboOzellik = new System.Windows.Forms.ComboBox();
            this.degisenID = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.onceki = new System.Windows.Forms.Label();
            this.OncekiBox = new System.Windows.Forms.TextBox();
            this.SonrakiBox = new System.Windows.Forms.TextBox();
            this.yeni = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboAlan
            // 
            this.comboAlan.FormattingEnabled = true;
            this.comboAlan.Items.AddRange(new object[] {
            "Personel",
            "Film"});
            this.comboAlan.Location = new System.Drawing.Point(12, 32);
            this.comboAlan.Name = "comboAlan";
            this.comboAlan.Size = new System.Drawing.Size(151, 21);
            this.comboAlan.TabIndex = 0;
            this.comboAlan.Text = "Alanı Seç: ";
            this.comboAlan.SelectedIndexChanged += new System.EventHandler(this.comboAlan_SelectedIndexChanged);
            // 
            // comboOzellik
            // 
            this.comboOzellik.FormattingEnabled = true;
            this.comboOzellik.Location = new System.Drawing.Point(12, 59);
            this.comboOzellik.Name = "comboOzellik";
            this.comboOzellik.Size = new System.Drawing.Size(151, 21);
            this.comboOzellik.TabIndex = 1;
            this.comboOzellik.Text = "Özellik Seç: ";
            this.comboOzellik.SelectedIndexChanged += new System.EventHandler(this.comboOzellik_SelectedIndexChanged);
            // 
            // degisenID
            // 
            this.degisenID.AutoSize = true;
            this.degisenID.Location = new System.Drawing.Point(9, 102);
            this.degisenID.Name = "degisenID";
            this.degisenID.Size = new System.Drawing.Size(45, 13);
            this.degisenID.TabIndex = 2;
            this.degisenID.Text = "Film ID: ";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(132, 99);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 20);
            this.IDBox.TabIndex = 3;
            // 
            // onceki
            // 
            this.onceki.AutoSize = true;
            this.onceki.Location = new System.Drawing.Point(9, 137);
            this.onceki.Name = "onceki";
            this.onceki.Size = new System.Drawing.Size(102, 13);
            this.onceki.TabIndex = 4;
            this.onceki.Text = "Önceki Yayın Tarihi:";
            // 
            // OncekiBox
            // 
            this.OncekiBox.Location = new System.Drawing.Point(132, 137);
            this.OncekiBox.Name = "OncekiBox";
            this.OncekiBox.Size = new System.Drawing.Size(100, 20);
            this.OncekiBox.TabIndex = 5;
            // 
            // SonrakiBox
            // 
            this.SonrakiBox.Location = new System.Drawing.Point(132, 173);
            this.SonrakiBox.Name = "SonrakiBox";
            this.SonrakiBox.Size = new System.Drawing.Size(100, 20);
            this.SonrakiBox.TabIndex = 6;
            // 
            // yeni
            // 
            this.yeni.AutoSize = true;
            this.yeni.Location = new System.Drawing.Point(9, 173);
            this.yeni.Name = "yeni";
            this.yeni.Size = new System.Drawing.Size(89, 13);
            this.yeni.TabIndex = 7;
            this.yeni.Text = "Yeni Yayın Tarihi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 173);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.Location = new System.Drawing.Point(23, 234);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(140, 23);
            this.GuncelleBtn.TabIndex = 10;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = true;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.yeni);
            this.Controls.Add(this.SonrakiBox);
            this.Controls.Add(this.OncekiBox);
            this.Controls.Add(this.onceki);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.degisenID);
            this.Controls.Add(this.comboOzellik);
            this.Controls.Add(this.comboAlan);
            this.Name = "UpdateForm";
            this.Text = "Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAlan;
        private System.Windows.Forms.ComboBox comboOzellik;
        private System.Windows.Forms.Label degisenID;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label onceki;
        private System.Windows.Forms.TextBox OncekiBox;
        private System.Windows.Forms.TextBox SonrakiBox;
        private System.Windows.Forms.Label yeni;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button GuncelleBtn;
    }
}
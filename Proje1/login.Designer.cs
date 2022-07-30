namespace ProjeOdev2
{
    partial class login
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
            this.GirisYap = new System.Windows.Forms.Button();
            this.TCgir = new System.Windows.Forms.TextBox();
            this.SifreGir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GirisYap
            // 
            this.GirisYap.Location = new System.Drawing.Point(120, 178);
            this.GirisYap.Name = "GirisYap";
            this.GirisYap.Size = new System.Drawing.Size(100, 23);
            this.GirisYap.TabIndex = 0;
            this.GirisYap.Text = "Giriş Yap";
            this.GirisYap.UseVisualStyleBackColor = true;
            this.GirisYap.Click += new System.EventHandler(this.GirisYap_Click);
            // 
            // TCgir
            // 
            this.TCgir.Location = new System.Drawing.Point(120, 48);
            this.TCgir.Name = "TCgir";
            this.TCgir.Size = new System.Drawing.Size(100, 20);
            this.TCgir.TabIndex = 1;
            // 
            // SifreGir
            // 
            this.SifreGir.Location = new System.Drawing.Point(120, 108);
            this.SifreGir.Name = "SifreGir";
            this.SifreGir.Size = new System.Drawing.Size(100, 20);
            this.SifreGir.TabIndex = 2;
            this.SifreGir.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TC : ";
            // 
            // loginAlert
            // 
            this.loginAlert.AutoSize = true;
            this.loginAlert.Location = new System.Drawing.Point(120, 145);
            this.loginAlert.Name = "loginAlert";
            this.loginAlert.Size = new System.Drawing.Size(0, 13);
            this.loginAlert.TabIndex = 5;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 249);
            this.Controls.Add(this.loginAlert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SifreGir);
            this.Controls.Add(this.TCgir);
            this.Controls.Add(this.GirisYap);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GirisYap;
        private System.Windows.Forms.TextBox TCgir;
        private System.Windows.Forms.TextBox SifreGir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginAlert;
    }
}
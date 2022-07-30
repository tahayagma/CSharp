namespace ProjeOdev2
{
    partial class SinavGir
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
            this.SinavLink = new System.Windows.Forms.LinkLabel();
            this.Sınav_AdıCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinav_SuresiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinav_TarihiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soru_SayisiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GecmePuaniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sınav_AdıCol,
            this.Sinav_SuresiCol,
            this.Sinav_TarihiCol,
            this.Soru_SayisiCol,
            this.GecmePuaniCol});
            this.dataGridView1.Location = new System.Drawing.Point(60, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SinavLink
            // 
            this.SinavLink.Location = new System.Drawing.Point(0, 0);
            this.SinavLink.Name = "SinavLink";
            this.SinavLink.Size = new System.Drawing.Size(100, 23);
            this.SinavLink.TabIndex = 0;
            // 
            // Sınav_AdıCol
            // 
            this.Sınav_AdıCol.HeaderText = "Sınav Adı";
            this.Sınav_AdıCol.Name = "Sınav_AdıCol";
            this.Sınav_AdıCol.ReadOnly = true;
            this.Sınav_AdıCol.Width = 130;
            // 
            // Sinav_SuresiCol
            // 
            this.Sinav_SuresiCol.HeaderText = "Sınav Süresi(Dakika)";
            this.Sinav_SuresiCol.Name = "Sinav_SuresiCol";
            this.Sinav_SuresiCol.ReadOnly = true;
            this.Sinav_SuresiCol.Width = 120;
            // 
            // Sinav_TarihiCol
            // 
            this.Sinav_TarihiCol.HeaderText = "Sınav Tarihi";
            this.Sinav_TarihiCol.Name = "Sinav_TarihiCol";
            this.Sinav_TarihiCol.ReadOnly = true;
            this.Sinav_TarihiCol.Width = 130;
            // 
            // Soru_SayisiCol
            // 
            this.Soru_SayisiCol.HeaderText = "Soru Sayısı";
            this.Soru_SayisiCol.Name = "Soru_SayisiCol";
            this.Soru_SayisiCol.ReadOnly = true;
            this.Soru_SayisiCol.Width = 120;
            // 
            // GecmePuaniCol
            // 
            this.GecmePuaniCol.HeaderText = "Geçme Puanı";
            this.GecmePuaniCol.Name = "GecmePuaniCol";
            this.GecmePuaniCol.ReadOnly = true;
            // 
            // SinavGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.SinavLink);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SinavGir";
            this.Text = "SinavGir";
            this.Load += new System.EventHandler(this.SinavGir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel SinavLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sınav_AdıCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sinav_SuresiCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sinav_TarihiCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soru_SayisiCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GecmePuaniCol;
    }
}
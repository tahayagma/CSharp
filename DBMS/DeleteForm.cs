using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Proje
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void PersonelRadio_CheckedChanged(object sender, EventArgs e)
        {
            panelFilm.Hide();
            panelPersonel.Show();
        }

        private void FilmRadio_CheckedChanged(object sender, EventArgs e)
        {
            panelPersonel.Hide();
            panelFilm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            if (FilmRadio.Checked == true)// film radio button tıklandıysa panel filmdeki verileri alacak
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                DataGridViewTextBoxColumn filmID = new DataGridViewTextBoxColumn();
                filmID.HeaderText = "Film ID";
                DataGridViewTextBoxColumn filmAd = new DataGridViewTextBoxColumn();
                filmAd.HeaderText = "Film Adı";
                DataGridViewTextBoxColumn tur = new DataGridViewTextBoxColumn();
                tur.HeaderText = "Film Türü";
                DataGridViewTextBoxColumn ulke = new DataGridViewTextBoxColumn();
                ulke.HeaderText = "Ülke";
                DataGridViewTextBoxColumn sure = new DataGridViewTextBoxColumn();
                sure.HeaderText = "Film Süresi";
                DataGridViewTextBoxColumn dil = new DataGridViewTextBoxColumn();
                dil.HeaderText = "Dil";
                DataGridViewTextBoxColumn oy = new DataGridViewTextBoxColumn();
                oy.HeaderText = "Alınan Oy";
                DataGridViewTextBoxColumn puan = new DataGridViewTextBoxColumn();
                puan.HeaderText = "Puan";
                DataGridViewTextBoxColumn butce = new DataGridViewTextBoxColumn();
                butce.HeaderText = "Bütçe";
                DataGridViewTextBoxColumn hasilat = new DataGridViewTextBoxColumn();
                hasilat.HeaderText = "Hasılat";
                DataGridViewTextBoxColumn odulsay = new DataGridViewTextBoxColumn();
                odulsay.HeaderText = "Ödül Sayısı";
                DataGridViewTextBoxColumn odulAd = new DataGridViewTextBoxColumn();
                odulAd.HeaderText = "Ödül Ad";
                DataGridViewTextBoxColumn yapımcısirket = new DataGridViewTextBoxColumn();
                yapımcısirket.HeaderText = "Yapımcı Şirket";
                DataGridViewButtonColumn detayBtn = new DataGridViewButtonColumn();
                detayBtn.Text = "Detay";
                detayBtn.ReadOnly = true;
                detayBtn.UseColumnTextForButtonValue = true;
                DataGridViewButtonColumn silbtn = new DataGridViewButtonColumn();
                silbtn.Text = "Sil";
                silbtn.ReadOnly = true;
                silbtn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.AddRange(new DataGridViewColumn[]{filmID,filmAd,tur,ulke,sure,dil,oy,puan,butce,hasilat,odulsay,odulAd,yapımcısirket,detayBtn,silbtn });
                foreach (Control a in this.panelFilm.Controls)
                {
                    if(!a.Name.Contains("label") && a.Text != "")
                        dataGridView1.Rows.Add(a.Name, a.Text);
                }
            }
            else// değilse panel personeldeki verileri alacak
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                DataGridViewTextBoxColumn pID = new DataGridViewTextBoxColumn();
                pID.HeaderText = "Personel ID";
                DataGridViewTextBoxColumn pAd = new DataGridViewTextBoxColumn();
                pAd.HeaderText = "Adı";
                DataGridViewTextBoxColumn pSoyad = new DataGridViewTextBoxColumn();
                pSoyad.HeaderText = "Soyadı";
                DataGridViewTextBoxColumn pCins = new DataGridViewTextBoxColumn();
                pCins.HeaderText = "Cinsiyet";
                DataGridViewTextBoxColumn pMaas = new DataGridViewTextBoxColumn();
                pMaas.HeaderText = "Maaş";

                DataGridViewButtonColumn detayBtn = new DataGridViewButtonColumn();
                detayBtn.Text = "Detay";
                detayBtn.ReadOnly = true;
                detayBtn.UseColumnTextForButtonValue = true;
                DataGridViewButtonColumn silbtn = new DataGridViewButtonColumn();
                silbtn.Text = "Sil";
                silbtn.ReadOnly = true;
                silbtn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.AddRange(new DataGridViewColumn[] { pID,pAd,pSoyad,pCins,pMaas,detayBtn, silbtn });
                foreach (Control a in this.panelPersonel.Controls)
                {
                    if (!a.Name.Contains("label") && a.Text != "")
                        dataGridView1.Rows.Add(a.Name, a.Text);
                    // a.Name ve a.Text değerlerini ayrı ayrı dizilerde tut ve her sonu Insert INTO ile başka bir
                    // tablo tut ve yeni aramayı bu tablo üzerinde yap ve sonucu tekrar geçici tabloda tut

                   
                  
                }
            }
        }//
    }
}

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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void comboAlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            if(comboAlan.SelectedItem == "Film")
            {
                comboOzellik.Items.Clear();
                comboOzellik.Items.AddRange(new object[] {
                "Film Adı","Hasılat","Bütçe","Süre","Yayın Tarihi","Dil","Ülke","Tür","Ödül","Oy","Ortalama Puan"
                });
                degisenID.Text = "Film ID: ";
               
            }
            else
            {   
                comboOzellik.Items.Clear();
                comboOzellik.Items.AddRange(new object[] {
                "Ad","Soyad","Cinsiyet","Departman","Kategori","Karakter","Maaş","Ünvan"});
                degisenID.Text = "Personel ID: ";
            }
        }//

        private void comboOzellik_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            onceki.Text = "Önceki " + comboOzellik.SelectedItem + ":";
            yeni.Text = "Yeni " + comboOzellik.SelectedItem + ":";

            if(comboOzellik.SelectedItem == "Yayın Tarihi")
            {
                OncekiBox.Hide();
                SonrakiBox.Hide();
                dateTimePicker1.Show();
                dateTimePicker2.Show();
            }
            else
            {
                dateTimePicker1.Hide();
                dateTimePicker2.Hide();
                OncekiBox.Show();
                SonrakiBox.Show();
            }

        }//

        private void clear()
        {
            OncekiBox.Clear();
            SonrakiBox.Clear();
            IDBox.Clear();
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

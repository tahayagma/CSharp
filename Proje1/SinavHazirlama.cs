using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdev2
{
    public partial class SinavHazirlama : Form
    {
        public SinavHazirlama()
        {
            InitializeComponent();
        }
        //public static SinavHazirla[] sinavlar = new SinavHazirla[1];
        public static int[] KayitliOgrIndis;
  
        private void SinavHazirlaListeleBtn_Click(object sender, EventArgs e) // Öğrenci Listeleme
        {
            OgrSınavcheckedList.Items.Clear();
            foreach (Ogrenci og in OgrenciDosya.ogr)
            {
                if (og == null)
                {
                    label7.ForeColor = System.Drawing.Color.Red;
                    label7.Text = "Liste boş !";
                    break;
                }
                else
                {
                    OgrSınavcheckedList.Items.Add(og.getTC() + " " + og.getAdiSoyadi());
                }


            }


        }

        private void SinavOlusturBtn_Click(object sender, EventArgs e) // Sınav Olusturma
        {
            if(SinavAdBox.Text == "" || SınavSureBox.Text == ""|| GecmePuaniBox.Text == ""|| SayiBox.Text == "" || OgrSınavcheckedList.CheckedItems.Count == 0)
            {
                SinavHazirlaAlert.ForeColor = System.Drawing.Color.Red;
                SinavHazirlaAlert.Text = "( * ) Doldurulması zorunlu alanlar ! ";
            }
            else if(int.TryParse(SınavSureBox.Text,out _) == false || int.TryParse(SayiBox.Text, out _) == false || int.TryParse(GecmePuaniBox.Text, out _) == false)
            {
                SinavHazirlaAlert.ForeColor = System.Drawing.Color.Red;
                SinavHazirlaAlert.Text = "Sınav Süresi , Soru Sayısı, Geçme Puanı numeric değerler olmalı  ! ";
            }
            else if (Convert.ToInt32(SayiBox.Text) > SoruBanka.sorular.Length)
            {
                SinavHazirlaAlert.ForeColor = System.Drawing.Color.Red;
                SinavHazirlaAlert.Text = "Soru bankasında yeteri kadar soru yok !";
            }
            else
            {
                KayitliOgrIndis = new int[OgrSınavcheckedList.CheckedItems.Count];
                for (int i = 0; i < KayitliOgrIndis.Length; i++)
                {
                    KayitliOgrIndis[i] = OgrSınavcheckedList.CheckedIndices[i];
                }
                SinavHazirla tmp = new SinavHazirla();
                tmp.olustur(SinavAdBox.Text,
                    Convert.ToInt32(SayiBox.Text),
                    Convert.ToInt32(GecmePuaniBox.Text),
                    Convert.ToInt32(SınavSureBox.Text),
                    dateTimePicker1.Value, KayitliOgrIndis);
                SinavHazirlaAlert.ForeColor = System.Drawing.Color.Green;
                SinavHazirlaAlert.Text = "Sınav oluşturuldu. ";
                Clear();
            }
            
        }//
        private void Clear()
        {
            SinavAdBox.Text = null;
            SayiBox.Text = null;
            GecmePuaniBox.Text = null;
            SınavSureBox.Text = null;
            OgrSınavcheckedList.Items.Clear();
           
        }
    }
}

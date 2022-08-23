using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdev2
{
    public partial class SinavGir : Form
    {
        public SinavGir()
        {
            InitializeComponent();
        }
        private void SinavGir_Load(object sender, EventArgs e)
        {
            if (SinavHazirla.sinavlar.Length > 0)// sinavlar dizisi boş değilse
            {
                foreach (SinavHazirla sinav in SinavHazirla.sinavlar) // sinavlar dizisi üzerinde gez tek tek al
                {
                    dataGridView1.Rows.Add(sinav.SinavAdi, sinav.SinavSuresi, sinav.SinavTarihi, sinav.SoruSayisi, sinav.GecmePuani);
                }
            }
        }
        public static int aktifSınav;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aktifSınav = dataGridView1.CurrentCell.RowIndex;
            login lg = new login();
            lg.Show();
            this.Hide();

        }
    }
}

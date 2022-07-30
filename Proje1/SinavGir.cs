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
    public partial class SinavGir : Form
    {
        public SinavGir()
        {
            InitializeComponent();
        }
        private void SinavGir_Load(object sender, EventArgs e)
        {
            if (SinavHazirla.sinavlar.Length > 0)
            {
                foreach (SinavHazirla sinav in SinavHazirla.sinavlar)
                {

                    dataGridView1.Rows.Add(sinav.SinavAdi, sinav.SinavSuresi, sinav.SinavTarihi, sinav.SoruSayisi, sinav.GecmePuani);

                }
            }
        }
        public static int aktifSınav;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // EGER SINAV TARİHİ ŞAUNKİ TARİHE EŞİTSE GİR DEĞİLSE UYARI YAZDIR
            aktifSınav = dataGridView1.CurrentCell.RowIndex;
            login lg = new login();
            lg.Show();
            this.Hide();

        }
    }
}

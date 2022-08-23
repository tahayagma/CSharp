using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdev2
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            foreach (Raporlar rp in Raporlar.rapor) // rapor dizisi üzerinde gezinip tek tek raporları alıyor
            {

                dataGridView1.Rows.Add(rp.getTC(),rp.SinavAdi,rp.Puan,rp.Durum);

            }

        }
    }
}

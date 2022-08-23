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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdev2
{
    public class SinavHazirla
    {
        public string SinavAdi;
        public int SoruSayisi;
        public int GecmePuani;
        public int SinavSuresi;
        public int[] ogrenciler;
        public Soru[] sorular;
        public DateTime SinavTarihi;

        public static SinavHazirla[] sinavlar = new SinavHazirla[1];
        public static int[] KayitliOgrIndis;

        public SinavHazirla() { }
        public SinavHazirla(string SinavAdi, int SoruSayisi, int GecmePuani, int sinavSuresi, DateTime SinavTarihi, int[] ogrenciler)
        {
            this.SinavAdi = SinavAdi;
            this.SoruSayisi = SoruSayisi;
            this.GecmePuani = GecmePuani;
            this.SinavSuresi = sinavSuresi;
            this.SinavTarihi = SinavTarihi;
            this.ogrenciler = ogrenciler;
            sorular = new Soru[SoruSayisi];
            for (int i = 0; i < SoruSayisi; i++)
            {
                sorular[i] = SoruBanka.sorular[i];
            }

        }
        public void olustur(string SinavAdi, int SoruSayisi, int GecmePuani, int sinavSuresi,DateTime SinavTarihi, int[] ogrenciler)
        {
            
            
            if (sinavlar[sinavlar.Length - 1] != null)// sinavlar dizisi boş değilse
            {
                SinavHazirla[] tmp = new SinavHazirla[sinavlar.Length + 1];// boyut bir arttırılıp gecici dizi oluşturuldu
                for (int i = 0; i < sinavlar.Length; i++)// dizideki bilgiler gecici diziye kopyalanıyor
                {
                    tmp[i] = sinavlar[i];
                }
                // yeni gelen sinavi gecici diziye atıyoruz
                tmp[tmp.Length - 1] = new SinavHazirla(SinavAdi,
                    Convert.ToInt32(SoruSayisi),
                    Convert.ToInt32(GecmePuani),
                    Convert.ToInt32(sinavSuresi),
                    SinavTarihi, ogrenciler);
                sinavlar = tmp; // gecici dizi sinavlar dizisine atanyor 
            }
            else
            {
                sinavlar[sinavlar.Length - 1] = new SinavHazirla(SinavAdi,
                    Convert.ToInt32(SoruSayisi),
                    Convert.ToInt32(GecmePuani),
                    Convert.ToInt32(sinavSuresi),
                    SinavTarihi, ogrenciler);
            }
        }
    }
}

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
    internal class OgrenciDosya
    {
        public static Ogrenci[] ogr = new Ogrenci[1];
        public void OgrenciEkle(string Tc,string AdSoyad,string parola) // öğrenci ekle
        {
            // ogr dizi boş değilse 
            if (ogr[ogr.Length - 1] != null)
            {
                Ogrenci[] tmp = new Ogrenci[ogr.Length + 1];// ogr dizi boyutunu bir fazlasında geçici bir dizi oluşturduk
                // ogr dizisindeki eski öğrenciler geçici diziye kopyalanıyor
                for (int i = 0; i < ogr.Length; i++)
                {
                    tmp[i] = ogr[i];

                }
                // gecici dizinin sonuna yeni gelen öğreniyi ekliyoruz
                tmp[tmp.Length - 1] = new Ogrenci(Tc, AdSoyad,parola);
                //tmp dizisini ogr dizisine atıyoruz
                ogr = tmp;
            }
            // ogr dizisi boş ise sona ekleme yapacak
            else
            {
                ogr[ogr.Length - 1] = new Ogrenci(Tc, AdSoyad, parola);
            }
        }//
        public static bool OgrenciSil(string OgrenciTC) // öğrenci sil
        {
            bool result = true; // öğrenci silindi mi silinmedi mi durumu göstermek için 

            
            if (ogr.Length == 1)// eğer tek öğrenci varsa
            {
                if (OgrenciTC == ogr[0].getTC())
                {
                    ogr = new Ogrenci[1];
                }
                else
                {
                    result = false;
                }
            }
            else // birden fazla öğrenci varsa
            {
                bool v = false;// ogr dizisinde girilen TC de bir öğrenci var mı durumunu belirtmek için
                foreach (Ogrenci s in ogr) // ogr dizisi üzerinde gez
                {
                    if (s.getTC() == OgrenciTC) // bilgiler eşleşiyorsa
                    {
                        v = true; // öğrenci var
                    }
                }
                int counter = 0;
                if (v) // öğrenci varsa
                {
                    Ogrenci[] tmp = new Ogrenci[ogr.Length - 1];
                    for (int i = 0; i < ogr.Length; i++) // eski dizideki öğrenciler yeni diziye kopyalanıyor
                    {
                        if (ogr[i].getTC() != OgrenciTC)
                        {
                            tmp[counter] = ogr[i];
                            counter += 1;
                        }
                    }
                    ogr = tmp;
                }

                else
                {
                    result = false;
                }
            }
            return result;
        }//

        public static string Listele(Ogrenci og) // listele
        {
            return String.Format("{0}\t\t{1}",og.getTC(),og.getAdiSoyadi());
        }//

    }
}

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
using System.Drawing;
using System.Threading.Tasks;

namespace ProjeOdev2
{
    internal class SoruBanka
    {
        public static Soru[] sorular = new Soru[1];

        public void SoruEkle(string st, string[] sec, string c, double p, string zs, Image r)// soru ekle
        {
            if (sorular[sorular.Length - 1] != null) // sorular dizisi boş değilse  kontrolü yapılıyor
            {
                Soru[] tmp = new Soru[sorular.Length + 1];
                for (int i = 0; i < sorular.Length; i++)
                {
                    tmp[i] = sorular[i];
                }
                tmp[tmp.Length - 1] = new Soru(st,sec,c,p,zs,r,tmp.Length - 1);
                
                sorular = tmp;
            }
            else // eğer dizi boş ise sonuna yeni soruyu ekle
            {
                sorular[sorular.Length - 1] = new Soru(st,sec,c,p,zs,r,sorular.Length - 1);
            }
        }

        public static bool SoruSil(int soruID)// soru sil
        {
            bool result = true;
            
            if (sorular.Length == 1) // eğer dizide tek soru varsa
            {
                if(soruID == sorular[0].SoruID)
                {
                    sorular = new Soru[1];
                }
                else
                {
                    result = false;
                }
            }
            else // dizide birden fazla soru varsa
            {
                bool v = false;//girilen ID numaralı bir soru var mı yok mu durumunu göstermek için
                foreach(Soru s in sorular) // girilen degerde bir SoruId var mı kontrol ediliyor
                {
                    if(s.SoruID == soruID)
                    {
                        v = true; // soru var
                    }
                }
                int counter = 0;
                if (v) // eğer giriklen değerde bir  soru varsa 
                {
                    Soru[] tmp = new Soru[sorular.Length - 1];
                    for(int i= 0; i < sorular.Length; i++)
                    {
                        if (sorular[i].SoruID != soruID)
                        {
                            tmp[counter] = sorular[i];
                            counter += 1;
                        }
                    }
                    sorular = tmp;
                }
                
                else
                {
                    result = false;
                }
            }
            return result;
        }//


    }
}

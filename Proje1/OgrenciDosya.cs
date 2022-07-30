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
            if (ogr[ogr.Length - 1] != null)
            {
                Ogrenci[] tmp = new Ogrenci[ogr.Length + 1];
                for (int i = 0; i < ogr.Length; i++)
                {
                    tmp[i] = ogr[i];
                }
                tmp[tmp.Length - 1] = new Ogrenci(Tc, AdSoyad,parola);
                ogr = tmp;
            }
            else
            {
                ogr[ogr.Length - 1] = new Ogrenci(Tc, AdSoyad, parola);
            }
        }//
        public static bool OgrenciSil(string OgrenciTC) // öğrenci sil
        {
            bool result = true;

            if (ogr.Length == 1)
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
            else
            {
                bool v = false;
                foreach (Ogrenci s in ogr)
                {
                    if (s.getTC() == OgrenciTC)
                    {
                        v = true;
                    }
                }
                int counter = 0;
                if (v)
                {
                    Ogrenci[] tmp = new Ogrenci[ogr.Length - 1];
                    for (int i = 0; i < ogr.Length; i++)
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

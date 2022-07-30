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
            if (sorular[sorular.Length - 1] != null)
            {
                Soru[] tmp = new Soru[sorular.Length + 1];
                for (int i = 0; i < sorular.Length; i++)
                {
                    tmp[i] = sorular[i];
                }
                tmp[tmp.Length - 1] = new Soru(st,sec,c,p,zs,r,tmp.Length - 1);
                
                sorular = tmp;
            }
            else
            {
                sorular[sorular.Length - 1] = new Soru(st,sec,c,p,zs,r,sorular.Length - 1);
            }
        }

        public static bool SoruSil(int soruID)// soru sil
        {
            bool result = true;
            
            if (sorular.Length == 1)
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
            else
            {
                bool v = false;
                foreach(Soru s in sorular)
                {
                    if(s.SoruID == soruID)
                    {
                        v = true;
                    }
                }
                int counter = 0;
                if (v)
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

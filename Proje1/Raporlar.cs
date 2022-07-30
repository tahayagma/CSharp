using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdev2
{
    public class Raporlar
    {
        string TC;
        public string SinavAdi;
        public double Puan;
        public string Durum;
        

        public Raporlar()
        {
            TC = "";
            SinavAdi = "";
            Puan = 0;
            Durum = "";
            
        }
        public Raporlar(string TC, string SinavAdi, double Puan,string Durum)
        {
            this.TC = TC;
            this.SinavAdi = SinavAdi;
            this.Puan = Puan;
            this.Durum = Durum;
        }
        public string getTC() { return TC; }
        public static Raporlar[] rapor = new Raporlar[1];
        public void RaporEkle(string TC, string SinavAdi, double Puan,int aktifSınav)
        {
            string durum;
            if (Puan >= SinavHazirla.sinavlar[aktifSınav].GecmePuani)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı ";
            }
            if (rapor[rapor.Length - 1] != null)
            {
                Raporlar[] tmp = new Raporlar[rapor.Length + 1];
                for (int i = 0; i < rapor.Length; i++)
                {
                    tmp[i] = rapor[i];
                }
                tmp[tmp.Length - 1] = new Raporlar(TC,SinavAdi,Puan,durum);

                rapor = tmp;
            }
            else
            {
                rapor[rapor.Length - 1] = new Raporlar(TC, SinavAdi, Puan,durum);
            }

        }
    }

    
    
}

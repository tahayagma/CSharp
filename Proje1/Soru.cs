using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace ProjeOdev2
{
    public class Soru
    {
        public string soruText; //soru textti
        public string[] secenekler = new string[5]; // soru seçenekleri
        public string cevap;//doğru cevap
        public double puan; //sorunun puanı
        public string ZorlukSeviye; // sorunun zorluk seviyesi 
        public Image resim; //soru için resim
        public int SoruID; // soruyu silmek için kullanılacak
        public Soru()
        {
            soruText = "";
            for (int i = 0; i <= 4; i++)
                secenekler[i] = "";
            cevap = "";
            puan = 0;
            ZorlukSeviye = "";
            resim = Image.FromFile("C:\\Users\\akmet\\Desktop\\cat.jpg");
            SoruID = 0;
        }
        public Soru(string st, string[] sec, string c, double p, string zs, Image r,int id)
        {
            soruText = st;
            for (int i = 0; i <= 4; i++)
                secenekler[i] = sec[i];
            cevap = c.ToUpper();
            puan = p;
            ZorlukSeviye = zs;
            resim = r;
            SoruID = id;
        }
    }
}

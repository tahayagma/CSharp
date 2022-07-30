using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdev2
{
    public class Ogrenci
    {
        string TC;
        string AdSoyad;
        string password;
        public Ogrenci()
        {
            TC = "";
            AdSoyad = "";
            password = "";
        }
        public Ogrenci(string TC, string AdSoyad, string password)
        {
            this.AdSoyad = AdSoyad;
            this.TC = TC;
            this.password = password;
        }
        public string getTC() { return TC; }
        public string getAdiSoyadi (){ return AdSoyad; }
        public string getPassword() { return password; }

        
    }

    
}

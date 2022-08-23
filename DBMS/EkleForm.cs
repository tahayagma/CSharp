using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Proje
{
    public partial class EkleForm : Form
    {
        public EkleForm()
        {
            InitializeComponent();
        }
        Npgsql.NpgsqlConnection con;// = new Npgsql.NpgsqlConnection("server=localhost;port=5432;User Id=postgres;password=***123***"); // bağlanti 
        Npgsql.NpgsqlDataAdapter da;// = new Npgsql.NpgsqlDataAdapter();// veri okuma select işlemleri
        Npgsql.NpgsqlCommand cmd;// = new Npgsql.NpgsqlCommand();// veri manipüle  add delete update işlemleri 
        private void FilmiEkleBtn_Click(object sender, EventArgs e)
        {
            if (FilmAdıBox.Text == "" || ÜlkeBox.Text == "" || ButceBox.Text == "" || TurBox.Text == "" || SureBox.Text == "" || DilBox.Text == "")
            {
                FilmAlert.ForeColor = Color.Red;
                FilmAlert.Text = "( * ) Doldurulması zorunlu alanlar ! ";
            }
            else
            {
                // birden faza dil tür ülke veya şirket girildiğin , ile ayırıp liste şeklinde eklenecektir(for ile )
                List<string> dilList = DilBox.Text.Split(',').ToList();
                List<string> turList = TurBox.Text.Split(',').ToList();
                List<string> ulkeList = ÜlkeBox.Text.Split(',').ToList();
                List<string> sirketList = SirketBox.Text.Split(',').ToList();

            /*List<string> deneme;
            deneme = "Turkish,English".Split(',').ToList();
            Console.WriteLine(deneme.Count);
            for (int i = 0; i < deneme.Count; i++)
                Console.WriteLine(deneme[i].ToLower());*/

                int dil_id, tur_id, ulke_id, film_id, sirket_id;
                FilmAlert.Text = "";

                // FİLM
                con = new Npgsql.NpgsqlConnection("server=localhost;port=5432;User Id=postgres;password=***123***;Database=filmpaneli");
                con.Open();
                cmd = new Npgsql.NpgsqlCommand("INSERT INTO film(filmadı,yayıntarihi,butce,hasilat,oy,ortpuan,filmsure)" +
                    "Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7);",con);
                cmd.Parameters.AddWithValue("@p1",FilmAdıBox.Text);
                cmd.Parameters.AddWithValue("@p2", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@p3", int.Parse(ButceBox.Text));
                cmd.Parameters.AddWithValue("@p4", int.Parse(HasilatBox.Text));
                cmd.Parameters.AddWithValue("@p5", int.Parse(OyBox.Text));
                cmd.Parameters.AddWithValue("@p6", float.Parse(PuanBox.Text));
                cmd.Parameters.AddWithValue("@p7", int.Parse(SureBox.Text));
                cmd.ExecuteNonQuery();

                cmd = new Npgsql.NpgsqlCommand("select id from film ORDER BY id DESC LIMIT 1", con);
                film_id = (int)cmd.ExecuteScalar();

                // Dil
                try
                {
                    for(int i = 0; i < dilList.Count; i++)
                    {
                        cmd = new Npgsql.NpgsqlCommand("INSERT INTO dil(adi) Values (@p1);", con);
                        cmd.Parameters.AddWithValue("@p1", dilList[i].ToLower());
                        cmd.ExecuteNonQuery();

                        cmd = new Npgsql.NpgsqlCommand("select id from dil WHERE adi = (@p1)", con);
                        cmd.Parameters.AddWithValue("@p1", dilList[i].ToLower());
                        dil_id = (int)cmd.ExecuteScalar();

                        cmd = new Npgsql.NpgsqlCommand("INSERT INTO filmdil(filmid,dilid) Values (@p1,@p2);", con);
                        cmd.Parameters.AddWithValue("@p1", film_id);
                        cmd.Parameters.AddWithValue("@p2", dil_id);
                        cmd.ExecuteNonQuery();

                    }
                    

                }
                catch (Npgsql.NpgsqlException ex)
                {

                    if (ex.ErrorCode == 23505)
                    {
                        for (int i = 0; i < dilList.Count; i++)
                        {
                            cmd = new Npgsql.NpgsqlCommand("select id from dil WHERE adi = (@p1)", con);
                            cmd.Parameters.AddWithValue("@p1", dilList[i].ToLower());
                            dil_id = (int)cmd.ExecuteScalar();

                            cmd = new Npgsql.NpgsqlCommand("INSERT INTO filmdil(filmid,dilid) Values (@p1,@p2);", con);
                            cmd.Parameters.AddWithValue("@p1", film_id);
                            cmd.Parameters.AddWithValue("@p2", dil_id);
                            cmd.ExecuteNonQuery();

                        }
                    }
                }


                // TUR
                try
                {
                    for(int i = 0; i < turList.Count; i++)
                    {
                        cmd = new Npgsql.NpgsqlCommand("INSERT INTO tur(adi) Values (@p1);", con);
                        cmd.Parameters.AddWithValue("@p1", turList[i].ToLower());
                        cmd.ExecuteNonQuery();

                        cmd = new Npgsql.NpgsqlCommand("select id from tur WHERE adi = (@p1)", con);
                        cmd.Parameters.AddWithValue("@p1", turList[i].ToLower());
                        tur_id = (int)cmd.ExecuteScalar();

                        cmd = new Npgsql.NpgsqlCommand("INSERT INTO filmtur(filmid,turid) Values (@p1,@p2);", con);
                        cmd.Parameters.AddWithValue("@p1", film_id);
                        cmd.Parameters.AddWithValue("@p2", tur_id);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Npgsql.NpgsqlException ex)
                {
                    if (ex.ErrorCode == 23505)
                    {
                        for (int i = 0; i < turList.Count; i++)
                        {
                            cmd = new Npgsql.NpgsqlCommand("select id from tur WHERE adi = (@p1)", con);
                            cmd.Parameters.AddWithValue("@p1", turList[i].ToLower());
                            tur_id = (int)cmd.ExecuteScalar();

                            cmd = new Npgsql.NpgsqlCommand("INSERT INTO filmtur(filmid,turid) Values (@p1,@p2);", con);
                            cmd.Parameters.AddWithValue("@p1", film_id);
                            cmd.Parameters.AddWithValue("@p2", tur_id);
                            cmd.ExecuteNonQuery();

                        }
                    }

                }


                // ULKE

                try
                {

                    for(int i = 0; i < ulkeList.Count; i++)
                    {
                        cmd = new Npgsql.NpgsqlCommand("INSERT INTO ulke(adi) Values (@p1);", con);
                        cmd.Parameters.AddWithValue("@p1", ulkeList[i].ToLower());
                        cmd.ExecuteNonQuery();

                        cmd = new Npgsql.NpgsqlCommand("select id from ulke WHERE adi = (@p1)", con);
                        cmd.Parameters.AddWithValue("@p1", ulkeList[i].ToLower());
                        ulke_id = (int)cmd.ExecuteScalar();

                        cmd = new Npgsql.NpgsqlCommand("INSERT INTO filmulke(filmid,ulkeid) Values (@p1,@p2);", con);
                        cmd.Parameters.AddWithValue("@p1", film_id);
                        cmd.Parameters.AddWithValue("@p2", ulke_id);
                        cmd.ExecuteNonQuery();

                    }

                }
                catch (Npgsql.NpgsqlException ex)
                {
                    if (ex.ErrorCode == 23505)
                    {
                        for (int i = 0; i < ulkeList.Count; i++)
                        {
                            cmd = new Npgsql.NpgsqlCommand("select id from ulke WHERE adi = (@p1)", con);
                            cmd.Parameters.AddWithValue("@p1", ulkeList[i].ToLower());
                            ulke_id = (int)cmd.ExecuteScalar();

                            cmd = new Npgsql.NpgsqlCommand("INSERT INTO filmulke(filmid,ulkeid) Values (@p1,@p2);", con);
                            cmd.Parameters.AddWithValue("@p1", film_id);
                            cmd.Parameters.AddWithValue("@p2", ulke_id);
                            cmd.ExecuteNonQuery();

                        }
                    }
                }


                // YAPİMCİ SİRKET(LER)
                try
                {
                    for(int i = 0; i < sirketList.Count; i++)
                    {
                        cmd = new Npgsql.NpgsqlCommand("INSERT INTO yapimcisirket(adi) Values (@p1);", con);
                        cmd.Parameters.AddWithValue("@p1", sirketList[i].ToLower());
                        cmd.ExecuteNonQuery();

                        cmd = new Npgsql.NpgsqlCommand("select id from yapimcisirket WHERE adi = (@p1)", con);
                        cmd.Parameters.AddWithValue("@p1", sirketList[i].ToLower());
                        sirket_id = (int)cmd.ExecuteScalar();

                        cmd = new Npgsql.NpgsqlCommand("INSERT INTO filmyapimci(filmid,sirketid) Values (@p1,@p2);", con);
                        cmd.Parameters.AddWithValue("@p1", film_id);
                        cmd.Parameters.AddWithValue("@p2", sirket_id);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Npgsql.NpgsqlException ex)
                {

                    if (ex.ErrorCode == 23505)
                    {
                        for (int i = 0; i < sirketList.Count; i++)
                        {
                            cmd = new Npgsql.NpgsqlCommand("select id from yapimcisirket WHERE adi = (@p1)", con);
                            cmd.Parameters.AddWithValue("@p1", sirketList[i].ToLower());
                            sirket_id = (int)cmd.ExecuteScalar();

                            cmd = new Npgsql.NpgsqlCommand("INSERT INTO filmyapimci(filmid,sirketid) Values (@p1,@p2);", con);
                            cmd.Parameters.AddWithValue("@p1", film_id);
                            cmd.Parameters.AddWithValue("@p2", sirket_id);
                            cmd.ExecuteNonQuery();

                        }
                    }
                }

                // FİLM EKİP
                cmd = new Npgsql.NpgsqlCommand("INSERT INTO filmekip(filmid) VALUES(@p1);",con);
                cmd.Parameters.AddWithValue("@p1", film_id);
                cmd.ExecuteNonQuery();

                con.Close();
                

                FClear();
                FilmAlert.Text = "Film Eklendi. ID:  "+film_id;
            }
               
            
        }

        private void FClear()
        {
            FilmAdıBox.Clear();
            ÜlkeBox.Clear();
            ButceBox.Clear();
            PuanBox.Clear();
            TurBox.Clear();
            HasilatBox.Clear();
            SureBox.Clear();
            DilBox.Clear();
            dateTimePicker1.Value = DateTime.Today;
            OyBox.Clear();
            SirketBox.Clear();
            FilmAlert.ForeColor = Color.Green;
        }

        private void Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Kategori.SelectedIndex == 2)
            {
                label16.Text = "Karakter: ";
                UnvanBox.Enabled = false;
            }
            else
            {
                label16.Text = "Departman: ";
                UnvanBox.Enabled = true;
            }
        }//

        // Gerekli olan tablolar oluşturuluyor.
        private void createTables()
        {
            con = new Npgsql.NpgsqlConnection("server=localhost;port=5432;Database= filmpaneli;User Id=postgres;password=***123***");
            con.Open();
            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS film(" +
                "ID SERIAL PRIMARY KEY," +
                "filmadı TEXT NOT NULL," +
                "filmsure INT NOT NULL," +
                "yayıntarihi DATE NOT NULL DEFAULT now()," +
                "butce BIGINT NOT NULL DEFAULT 0," +
                "hasilat BIGINT NOT NULL DEFAULT 0," +
                "oy INT DEFAULT 0," +
                "ortpuan FLOAT DEFAULT 0);", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS filmekip(" +
               "ID SERIAL PRIMARY KEY," +
               "filmID INT NOT NULL," +
               "CONSTRAINT f_ıd FOREIGN KEY(filmID) REFERENCES film(ID));", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS ulke(" +
               "ID SERIAL PRIMARY KEY," +
               "adi TEXT NOT NULL UNIQUE);", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS dil(" +
               "ID SERIAL PRIMARY KEY," +
               "adi TEXT NOT NULL UNIQUE);", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS tur(" +
               "ID SERIAL PRIMARY KEY," +
               "adi TEXT NOT NULL UNIQUE);", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS odul(" +
               "ID SERIAL PRIMARY KEY," +
               "adı TEXT NOT NULL UNIQUE);", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS personel(" +
               "ID SERIAL PRIMARY KEY," +
               "filmekibID INT NOT NULL," +
               "adi TEXT NOT NULL," +
               "soyadi TEXT NOT NULL," +
               "cinsiyet CHAR(1) NOT NULL," +
               "maas INT DEFAULT 0," +
               "CONSTRAINT filmekibID FOREIGN KEY(filmekibID) REFERENCES filmekip(ID));", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS prodüksiyon(" + // kalıtım
               //"personelID INT," + kalıtım aldıkları için tekrar personel id girmeye gerek yoktur
               "görev TEXT NOT NULL DEFAULT 'bilinmiyor')INHERITS(personel);", con);
            //"CONSTRAINT p_ID FOREIGN KEY(personelID) REFERENCES personel(ID))
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS oyuncu(" + // kalıtım
               //"personelID INT," +
               "karakter TEXT NOT NULL DEFAULT 'bilinmiyor')INHERITS(personel);", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS teknik(" + // kalıtım
               //"personelID INT," +
               "departman TEXT DEFAULT 'bilinmiyor'," +
               "görev TEXT DEFAULT 'bilinmiyor')INHERITS(personel);", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS yapimcisirket(" +
               "ID SERIAL PRIMARY KEY," +
               "adi TEXT NOT NULL);", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS filmyapimci(" +
               "filmid INT NOT NULL," +
               "sirketID INT NOT NULL," +
               "CONSTRAINT filmekib_ID FOREIGN KEY(filmid) REFERENCES film(ID)," +
               "CONSTRAINT sirket_ID FOREIGN KEY(sirketID) REFERENCES yapimcisirket(ID));", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS filmdil(" +
               "filmID INT NOT NULL," +
               "dilID INT NOT NULL," +
               "CONSTRAINT film_ID FOREIGN KEY(filmID) REFERENCES film(ID)," +
               "CONSTRAINT dil_ID FOREIGN KEY(dilID) REFERENCES dil(ID));", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS filmtur(" +
               "filmID INT NOT NULL," +
               "turID INT NOT NULL," +
               "CONSTRAINT film_ID FOREIGN KEY(filmID) REFERENCES film(ID)," +
               "CONSTRAINT tur_ID FOREIGN KEY(turID) REFERENCES tur(ID));", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS filmulke(" +
               "filmID INT NOT NULL," +
               "ulkeID INT NOT NULL," +
               "CONSTRAINT film_ID FOREIGN KEY(filmID) REFERENCES film(ID)," +
               "CONSTRAINT ulke_ID FOREIGN KEY(ulkeID) REFERENCES ulke(ID));", con);
            cmd.ExecuteNonQuery();

            cmd = new Npgsql.NpgsqlCommand("CREATE TABLE IF NOT EXISTS filmodul(" +
               "filmID INT NOT NULL," +
               "odulID INT NOT NULL," +
               "verilistarihi DATE NOT NULL DEFAULT now()," +
               "CONSTRAINT film_ID FOREIGN KEY(filmID) REFERENCES film(ID)," +
               "CONSTRAINT odul_ID FOREIGN KEY(odulID) REFERENCES odul(ID));", con);
            cmd.ExecuteNonQuery();

            con.Close();

        }

        private void EkleForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;


            //createTables();// gerekli tüm tablolar oluşturuluyor.*/

        }

        private void PEkleBtn_Click(object sender, EventArgs e)
        {
            if (PersonelAd.Text == "" || PersonelSoyad.Text == "" || PersonelCinsiyet.Text == "" || PFilmID.Text == "")
            {
                PersonelAlert.ForeColor = Color.Red;
                PersonelAlert.Text = "( * ) Doldurulması zorulu alanlar !";

            }
            else
            {
                string departman,unvan;
                int maas;
                if (DepartmanBox.Text == "") departman = "bilinmiyor";
                else departman = DepartmanBox.Text;
                if (UnvanBox.Text == "") unvan = "bilinmiyor";
                else unvan = UnvanBox.Text;
                if (MaasBox.Text == "") maas = 0;
                else maas = int.Parse(MaasBox.Text);

                int fekip_id;
                con = new Npgsql.NpgsqlConnection("server=localhost;port=5432;User Id=postgres;password=***123***;Database=filmpaneli");
                con.Open();

                // girilen film id ye ait  film ekibinin id değeri çekiliyor
                cmd = new Npgsql.NpgsqlCommand("select id from filmekip WHERE filmid = (@p1)", con);
                cmd.Parameters.AddWithValue("@p1", int.Parse(PFilmID.Text));
                fekip_id = (int)cmd.ExecuteScalar();


                string k = Kategori.SelectedItem.ToString();
                if (k == "Oyuncu")
                {
                    cmd = new Npgsql.NpgsqlCommand("INSERT INTO oyuncu(adi,soyadi,cinsiyet,maas,filmekibid,karakter)" +
                    "VALUES(@p1,@p2,@p3,@p4,@p5,@p6);", con);
                    cmd.Parameters.AddWithValue("@p1", PersonelAd.Text);
                    cmd.Parameters.AddWithValue("@p2", PersonelSoyad.Text);
                    cmd.Parameters.AddWithValue("@p3", PersonelCinsiyet.Text);
                    cmd.Parameters.AddWithValue("@p4", maas);
                    cmd.Parameters.AddWithValue("@p5", fekip_id);
                    cmd.Parameters.AddWithValue("@p6", departman);
                    cmd.ExecuteNonQuery();
                }
                else if (k == "Prodüksiyon")
                {
                    cmd = new Npgsql.NpgsqlCommand("INSERT INTO prodüksiyon(adi,soyadi,cinsiyet,maas,filmekibid,görev)" +
                    "VALUES(@p1,@p2,@p3,@p4,@p5,@p6);", con);
                    cmd.Parameters.AddWithValue("@p1", PersonelAd.Text);
                    cmd.Parameters.AddWithValue("@p2", PersonelSoyad.Text);
                    cmd.Parameters.AddWithValue("@p3", PersonelCinsiyet.Text);
                    cmd.Parameters.AddWithValue("@p4", maas);
                    cmd.Parameters.AddWithValue("@p5", fekip_id);
                    cmd.Parameters.AddWithValue("@p6", departman);
                    cmd.ExecuteNonQuery();

                }
                else
                {
                    cmd = new Npgsql.NpgsqlCommand("INSERT INTO teknik(adi,soyadi,cinsiyet,maas,filmekibid,departman,görev)" +
                    "VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7);", con);
                    cmd.Parameters.AddWithValue("@p1", PersonelAd.Text);
                    cmd.Parameters.AddWithValue("@p2", PersonelSoyad.Text);
                    cmd.Parameters.AddWithValue("@p3", PersonelCinsiyet.Text);
                    cmd.Parameters.AddWithValue("@p4", maas);
                    cmd.Parameters.AddWithValue("@p5", fekip_id);
                    cmd.Parameters.AddWithValue("@p6", departman);
                    cmd.Parameters.AddWithValue("@p7", unvan);
                    cmd.ExecuteNonQuery();
                }

                con.Close();
                PersonelAlert.ForeColor = Color.Green;
                PersonelAlert.Text = "Personel Kaydedildi.";
                clearP();
            }
        }

        private void OdulKaydetBtn_Click(object sender, EventArgs e)
        {
            con = new Npgsql.NpgsqlConnection("server=localhost;port=5432;User Id=postgres;password=***123***;Database=filmpaneli");
            con.Open();
            List<string> odulList = OdulBox.Text.Split(',').ToList();
            int odul_id;
            // ödül adı odul tablosuna eklendi.
            try
            {
                for(int i = 0; i < odulList.Count; i++)
                {
                    cmd = new Npgsql.NpgsqlCommand("INSERT INTO odul(adı) VALUES(@p1);",con);
                    cmd.Parameters.AddWithValue("@p1", odulList[i].ToLower());
                    cmd.ExecuteNonQuery();

                    // eklenen ödülün ıd degeri çekiliyor.
                    
                    cmd = new Npgsql.NpgsqlCommand("SELECT id FROM odul WHERE adı = (@p1);",con);
                    cmd.Parameters.AddWithValue("@p1", odulList[i].ToLower());
                    odul_id = (int)cmd.ExecuteScalar();

                    //çekilen odul id değeri film id ile filmodul tablosuna eklendi.
                    cmd = new Npgsql.NpgsqlCommand("INSERT INTO filmodul(filmid,odulid,verilistarihi)" +
                        "VALUES(@p1,@p2,@p3);",con);
                    cmd.Parameters.AddWithValue("@p1", int.Parse(ÖdülFilmID.Text));
                    cmd.Parameters.AddWithValue("@p2", odul_id);
                    cmd.Parameters.AddWithValue("@p3", dateTimePicker2.Value);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Npgsql.NpgsqlException ex)
            {
                if (ex.ErrorCode == 23505)
                {
                    for (int i = 0; i < odulList.Count; i++)
                    {
                        cmd = new Npgsql.NpgsqlCommand("SELECT id FROM odul WHERE adı = (@p1);", con);
                        cmd.Parameters.AddWithValue("@p1", odulList[i].ToLower());
                        odul_id = (int)cmd.ExecuteScalar();

                        //çekilen odul id değeri film id ile filmodul tablosuna eklendi.
                        cmd = new Npgsql.NpgsqlCommand("INSERT INTO filmodul(filmid,odulid,verilistarihi)" +
                            "VALUES(@p1,@p2,@p3);", con);
                        cmd.Parameters.AddWithValue("@p1", int.Parse(ÖdülFilmID.Text));
                        cmd.Parameters.AddWithValue("@p2", odul_id);
                        cmd.Parameters.AddWithValue("@p3", dateTimePicker2.Value);
                        cmd.ExecuteNonQuery();

                    }
                }
                con.Close();
                ÖdülFilmID.Clear();
                OdulBox.Clear();
                dateTimePicker2.Value = DateTime.Now;
                ÖdülAlert.ForeColor = Color.Green;
                ÖdülAlert.Text = "Ödül Kaydedildi.";
            }
            
            con.Close();
            ÖdülFilmID.Clear();
            OdulBox.Clear();
            dateTimePicker2.Value = DateTime.Now;
            ÖdülAlert.ForeColor = Color.Green;
            ÖdülAlert.Text = "Ödül Kaydedildi.";

        }
        private void clearP()
        {
            PersonelAd.Clear();
            PersonelSoyad.Clear();
            PersonelCinsiyet.Clear();
            MaasBox.Clear();
            UnvanBox.Clear();
            PFilmID.Clear();
            DepartmanBox.Clear();
        }
    }

      
}

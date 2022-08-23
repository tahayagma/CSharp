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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        Npgsql.NpgsqlConnection con;
        Npgsql.NpgsqlCommand cmd;
        private void button1_Click(object sender, EventArgs e)//ekle
        {
            //con = new Npgsql.NpgsqlConnection("server=localhost;port=5432;User Id=postgres;password=***123***");
            //con.Open();
            //cmd = new Npgsql.NpgsqlCommand("CREATE DATABASE filmpaneli;", con);

            /*cmd = new Npgsql.NpgsqlCommand("SELECT 'CREATE DATABASE filmpaneli'" +
            "WHERE NOT EXISTS(SELECT FROM pg_database WHERE datname = 'filmpaneli');", con);*/

            //cmd.ExecuteNonQuery();
            //con.Close();

            EkleForm ekleform = new EkleForm();
            ekleform.Show();

        }

        private void button2_Click(object sender, EventArgs e)// güncelle
        {
            UpdateForm updateform = new UpdateForm();
            updateform.Show();
        }

        private void button3_Click(object sender, EventArgs e)// sil
        {
            DeleteForm deleteform = new DeleteForm();
            deleteform.Show();
        }

        private void button4_Click(object sender, EventArgs e)// ara
        {
            SearchForm searchform = new SearchForm();
            searchform.Show();
        }
    }
}

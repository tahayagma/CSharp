using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdev2
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            foreach (Raporlar rp in Raporlar.rapor)
            {

                dataGridView1.Rows.Add(rp.getTC(),rp.SinavAdi,rp.Puan,rp.Durum);

            }

        }
    }
}

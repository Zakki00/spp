using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spp
{
    public partial class Form1 : Form
    {


        transaksi transaksi = new transaksi();
        Uberanda beranda = new Uberanda(); 
        Umaster master = new Umaster();
        Ulaporan laporan = new Ulaporan();
        Usiswa siswa = new Usiswa();
        Upetugas peyugas = new Upetugas();  
        public string idpetugas = "0";
        public string petugas;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            beranda.label3.Text = petugas;
            label1.Text = idpetugas;
            panel2.Controls.Clear();
            panel2.Controls.Add(beranda);
            beranda.Dock = DockStyle.Fill;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(beranda);
            beranda.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(master);
            master.Dock = DockStyle.Fill;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            siswa.opendata();
            transaksi.idpetugas = idpetugas;
            panel2.Controls.Clear();
            panel2.Controls.Add(transaksi);
            transaksi.Dock = DockStyle.Fill;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            laporan.GET();
            panel2.Controls.Clear();
            panel2.Controls.Add(laporan);
            laporan.Dock = DockStyle.Fill;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

         login login = new login();
         login.Show();
         this.Close();
        }

     
    }
}

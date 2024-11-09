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


        public transaksi transaksi;

        Uberanda beranda = new Uberanda(); 
        Umaster master = new Umaster();
        public string idpetugas = "0";
        
        public Form1()
        {
            InitializeComponent();
            transaksi = new transaksi(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            panel2.Controls.Clear();
            panel2.Controls.Add(transaksi);
            transaksi.Dock = DockStyle.Fill;

        }

        private void button4_Click(object sender, EventArgs e)
        {

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

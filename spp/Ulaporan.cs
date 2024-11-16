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
    public partial class Ulaporan : UserControl
    {
        Class1 class1 = new Class1();   
        public Ulaporan()
        {
            InitializeComponent();
        }

        private void Ulaporan_Load(object sender, EventArgs e)
        {
            GET();
        }
        public void GET()
        {
            string sql = "select * from vpembayaran where siswa like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = class1.getData(sql);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GET();
        }
    }
}

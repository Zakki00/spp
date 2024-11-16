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
    
    public partial class transaksi : UserControl
    {
      
        public string idpetugas = "0";
        string idsiswa = "0";
        Class1 Class1 = new Class1();
        public transaksi()
        {
            InitializeComponent();
          
        }
        private void transaksi_Load(object sender, EventArgs e)
        {
            GET();
          
            label8.Text = idpetugas;
        }

        void GET()
        {
            string sql = "select * from siswa";
            dataGridView1.DataSource = Class1.getData(sql);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Class1.Kosong(groupBox2))
            {
                MessageBox.Show("Siliahkan Isi Data");
            }else
            {
                if (idsiswa == "0")
                {
                    MessageBox.Show("Silahkan Pilih Data Siswa");

                }
                else
                {
                    string sql = "insert into pembayaran values ('" + idpetugas + "','" + idsiswa + "','" + textBox1.Text + "', '" + dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "', '" + dateTimePicker3.Text + "')";
                    Class1.exc(sql);
                    MessageBox.Show("Pembayaran Berhasil");
                    Class1.clearForm(groupBox2);
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                idsiswa = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                label6.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                //label9.Text = dataGridView1.Rows[e.RowIndex].Cells[]
              
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

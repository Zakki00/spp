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
    public partial class Utransaksi : UserControl
    {
        Class1 class1 = new Class1();
        public string idpetugas = "0";
        public string idsiswa = "0";
        public Utransaksi()
        {
            InitializeComponent();
        }
        void opendata()
        {
            string sql = "select * from siswa where siswa like '%"+ textBox1.Text +"%'";
            dataGridView1.DataSource = class1.getData(sql);
        }
      

        private void Utransaksi_Load(object sender, EventArgs e)
        {
            opendata();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            opendata();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           if (idsiswa=="0")
           {
                MessageBox.Show("Silahkan Pilih Data Siswa");
           }
            else
            {
                if (class1.Kosong(groupBox2))
                {
                    MessageBox.Show("Silahkan Isi Nominal Pembayaran");


                }
                else
                {
                    string sql = "insert into pembayaran values ('" + idpetugas + "','" + idsiswa + "','" + textBox2.Text + "','" + dateTimePicker1.Value.ToString() + "', '" + dateTimePicker2.Value.ToString() + "', '" + dateTimePicker3.Value.ToString() + "')";
                    class1.exc(sql);
                    MessageBox.Show("Pembayaran Berhasil");
                    class1.clearForm(groupBox1);

                }
                
            }
        }

       

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idsiswa = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

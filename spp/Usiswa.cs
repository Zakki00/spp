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
    public partial class Usiswa : UserControl
    {
        Class1 class1 = new Class1();
        string id = "0";
        public Usiswa()
        {
            InitializeComponent();
        }
        void opendata()
        {
            string sql = "select * from siswa where siswa LIke '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = class1.getData(sql);
        }
        private void Usiswa_Load(object sender, EventArgs e)
        {
            opendata();
            groupBox2.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            class1.clearForm(groupBox2);
            groupBox2.Enabled = false;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (class1.Kosong(groupBox2))
            {
                MessageBox.Show("Masukan Data Terlebih Dahulu");
            }
            else
            {
                if(id == "0")
                {
                    string sql = "insert into siswa values ('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
                    class1.exc(sql);
                    class1.clearForm(groupBox2);
                    MessageBox.Show("Data Sudah Di Tambahkan");

                }
                else
                {
                    string sql = "update siswa set siswa = '" + textBox2.Text + "', kelas = '" + textBox3.Text + "', jurusan = '" + textBox4.Text + "' where idsiswa = '" + id + "'";
                    class1.exc(sql);
                    class1.clearForm(groupBox2);
                    MessageBox.Show("Data Sudah Di Perbarui");
                }
            }
            id = "0";
            opendata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
                
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (id == "0") 
            {
                MessageBox.Show("Silahkan Pilih Data Terlebih Dahulu");

            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            opendata();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (id == "0") 
            {
                MessageBox.Show("Pilih Data Yang Ingin Di Hapus");
            }
            else
            {
                string sql = "delete from siswa where idsiswa = '" + id + "'";
                class1.pesan("Apakah Anda Yakin Ingin Menghapus '"+ textBox2.Text +"', '"+ textBox3.Text +"', '"+ textBox4.Text +"'");
                class1.exc(sql);
                class1.clearForm(groupBox2);
                id = "0";

            }
        }
    }
}

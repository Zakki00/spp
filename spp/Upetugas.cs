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
    public partial class Upetugas : UserControl
    {

        Class1 Class1 = new Class1();


        string id = "0";
        public Upetugas()
        {
            InitializeComponent();
        }
        void awal()
        {
            groupBox2.Enabled = false;
        }
        void opendata()
        {
            string sql = "select * from petugas where petugas LIke '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = Class1.getData(sql);

        }

        private void Upetugas_Load(object sender, EventArgs e)
        {
            opendata();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_2(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Class1.Kosong(groupBox2))
            {
                MessageBox.Show("Silahkan Isi Data Terlebih Dahulu");
            }
            else
            {
                string insert = "insert into petugas values ( '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";
                string update = "update petugas set petugas = '" + textBox2.Text + "', alamat = '" + textBox3.Text + "', username = '" + textBox4.Text + "', password = '" + textBox5.Text + "' where idpetugas = '"+ id +"'";
                if(id == "0")
                {
                    Class1.exc(insert);
                    Class1.clearForm(groupBox2);
                    MessageBox.Show("Data Berhasil Di Tambah");
                    opendata();
                }
                else
                {
                    Class1.exc(update);
                    Class1.clearForm(groupBox2);
                    MessageBox.Show("Data Berhasil Di Ubah");
                    opendata();
                    id = "0";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            { 
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id == "0")
            {
                MessageBox.Show("Pilih Data Yang ingin Di Hapus");
            }
            else
            {
                Class1.dialogForm("Apakah Anda Yakin Ingin Menghapus"+" "+textBox2.Text);
                string delete = "delete from petugas where idpetugas = '" + id + "'";
                Class1.exc(delete);
                opendata();
                Class1.clearForm(groupBox2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (id == "0")
            {
              MessageBox.Show("Pilih Data Terlebih Dahulu");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.clearForm(groupBox2);
            id = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Class1.clearForm(groupBox2);
            id = "0";
        }
    }
}

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
        public string idpetugas { get; set; }

        string idsiswa = "0";
        Class1 Class1 = new Class1();
        private Form1 form1;
        public transaksi(Form1 form1Instance)
        {
            InitializeComponent();
            form1 = form1Instance;
        }
        private void transaksi_Load(object sender, EventArgs e)
        {
            GET();
            Form1 form1 = new Form1();


            label8.Text = form1.label1.Text;
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

              
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      
        public void UpdateIdPetugasDisplay()
        {
            MessageBox.Show("Memperbarui label8 dengan ID: " + idpetugas); // Memastikan idpetugas terisi
            label8.Text = idpetugas;
        }
    }
}

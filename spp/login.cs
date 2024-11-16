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
    public partial class login : Form
    {
        Uberanda beranda = new Uberanda();
        Class1 class1 = new Class1();
        public transaksi transaksi;
        Form1 form1 = new Form1();     
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from petugas where username = '" + textBox1.Text + "' AND password  = '" + textBox2.Text + "'";
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Silahkan isi data");
            }

            else
            {
                if(class1.getCount(sql)== 0)
                {
                    MessageBox.Show("Username Atau Password Salah");
                }
                else
                {
                    form1.idpetugas = class1.getValue(sql, "idpetugas");
                    form1.petugas = class1.getValue(sql, "petugas");
                    class1.exc(sql);
                    form1.ShowDialog();
                    this.Close();


                }
               

            }
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}

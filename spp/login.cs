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
        Class1 class1 = new Class1();
        Utransaksi transaksi = new Utransaksi();
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
                    transaksi.idpetugas = class1.getValue(sql, "idpetugas");
                    form1.Show();
                    class1.exc(sql);
                    this.Hide();
                }
               

            }
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}

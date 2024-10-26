﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spp
{
    internal class Class1
    {
        public SqlConnection conn;
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public DataTable dt;
        public SqlCommand cmd;

        public readonly string namaServer = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=spp;Integrated Security=True";



        public void koneksi()
        {
            conn = new SqlConnection(namaServer);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeKoneksi()
        {
            conn.Close();
            cmd.Dispose();
        }

        public DataTable getData(string sql)
        {
            koneksi();
            try
            {
                cmd = new SqlCommand(sql, conn);
                da = new SqlDataAdapter();
                dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                closeKoneksi();
            }
        }

        public int getCount(string sql)
        {
            koneksi();
            try
            {
                cmd = new SqlCommand(sql, conn);
                da = new SqlDataAdapter();
                dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                closeKoneksi();
            }
        }

        public string getValue(string sql, string col)
        {
            koneksi();
            object value = null;
            try
            {
                cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    if (dr.IsDBNull(dr.GetOrdinal(col)))
                    {
                        return "";
                    }
                    else
                    {
                        value = dr[col];
                        return value.ToString();
                    }
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            finally
            {
                closeKoneksi();
            }
        }

        public bool exc(string sql)
        {
            koneksi();
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                closeKoneksi();
            }
        }

        public bool Kosong(GroupBox gb)
        {
            foreach (Control ct in gb.Controls)
            {
                if (ct is TextBox textBox && textBox.Text.Trim() == string.Empty)
                {
                    return true;
                }
            }
            return false;
        }

        public void clearForm(GroupBox gb)
        {
            foreach (Control ct in gb.Controls)
            {
                if (ct is TextBox tx)
                {
                    tx.Text = "";
                }
                else if (ct is NumericUpDown np)
                {
                    np.Value = 0;
                }
                else if (ct is ComboBox cb)
                {
                    cb.SelectedIndex = 0;
                }
            }
        }

        public void onlyNumber(KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.Handled = true;
                }
            }
        }

        public bool dialogForm(string s)
        {
            DialogResult a = MessageBox.Show(s, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        public void pesan(string s)
        {
            MessageBox.Show(s);
        }


    }
}

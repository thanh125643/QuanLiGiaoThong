using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class DoiMatKhau : Form
    {
        string connectsql;
        string userid;
        string type = "aa";
        Main f;
        public DoiMatKhau(Main f,string connectsql,string userid)
        {
            InitializeComponent();
            this.f = f;
            this.connectsql = connectsql;
            this.userid = userid;
        }

        void checkLoai()//kiem tra user thuoc loai nao 
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select LOAI from USERS where USERID=@id", sqlcon);
            querry.Parameters.AddWithValue("@id", userid);
            string count = Convert.ToString(querry.ExecuteScalar());
            sqlcon.Close();
            type = count;
        }

        private void btnSubmit_Click(object sender, EventArgs e)//dua cac thong tin cua mot user vao database ngoai ra neu la user dc dk trc tiep thi doi thuoc tinh LOAI tu 4 thanh 1 neu khong thi insert vao nhu binh thuong
        {
            if (!txtMkCu.Text.Equals("") && !txtMkMoi.Text.Equals("") && !txtNhapLai.Text.Equals(""))
            {
                checkLoai();
                if (type.Equals("4"))
                {
                    SqlConnection sqlcon = new SqlConnection(connectsql);
                    sqlcon.Open();
                    SqlCommand querry = new SqlCommand("Select MK from USERS where USERID=@id", sqlcon);
                    querry.Parameters.AddWithValue("@id", userid);
                    string count = Convert.ToString(querry.ExecuteScalar());
                    sqlcon.Close();
                    if (txtMkCu.Text.Equals(count))
                    {
                        if (txtMkMoi.Text.Equals(txtNhapLai.Text))
                        {
                            sqlcon.Open();
                            string command = "UPDATE USERS SET MK=@mk,LOAI = 1 WHERE USERID = @id";
                            SqlCommand querry1 = new SqlCommand(command, sqlcon);
                            querry1.Parameters.AddWithValue("@mk", txtMkMoi.Text);
                            querry1.Parameters.AddWithValue("@id", userid);
                            int result = querry1.ExecuteNonQuery();
                            sqlcon.Close();
                            if (result > 0)
                            {
                                MessageBox.Show("Update done");
                            }
                            else
                            {
                                MessageBox.Show("Update fail");
                            }
                        }
                    }
                }
                else
                {
                    SqlConnection sqlcon = new SqlConnection(connectsql);
                    sqlcon.Open();
                    SqlCommand querry = new SqlCommand("Select MK from USERS where USERID=@id", sqlcon);
                    querry.Parameters.AddWithValue("@id", userid);
                    string count = Convert.ToString(querry.ExecuteScalar());
                    sqlcon.Close();
                    if (txtMkCu.Text.Equals(count))
                    {
                        if (txtMkMoi.Text.Equals(txtNhapLai.Text))
                        {
                            sqlcon.Open();
                            string command = "UPDATE USERS SET MK=@mk WHERE USERID = @id";
                            SqlCommand querry1 = new SqlCommand(command, sqlcon);
                            querry1.Parameters.AddWithValue("@mk", txtMkMoi.Text);
                            querry1.Parameters.AddWithValue("@id", userid);
                            int result = querry1.ExecuteNonQuery();
                            sqlcon.Close();
                            if (result > 0)
                            {
                                MessageBox.Show("Update done");
                            }
                            else
                            {
                                MessageBox.Show("Update fail");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Xin dien day du thong tin");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void DoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

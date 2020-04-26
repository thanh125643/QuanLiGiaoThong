using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Register : Form
    {
        public string connectsql;
        int type = 2;
        int i;
        string fusion;
        string fusion1;
        string UserID;
        Login f;
        public Register(Login f, string connectsql)
        {
            InitializeComponent();
            this.f = f;
            this.connectsql = connectsql;
            checkUserID();
        }

        void checkUserID()
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            string command = "Select top 1 USERID from USERS order by ID DESC";
            SqlCommand querry = new SqlCommand(command, sqlcon);
            string result = Convert.ToString(querry.ExecuteScalar());
            sqlcon.Close();
            string abc = result.Substring(0, 8);
            i = Convert.ToInt32(result.Substring(12));
            fusion1 = DateTime.Now.ToString("ddMMyyyy");
            if (!fusion1.Equals(abc))
            {
                i = 0;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!txtAddress.Text.Equals("") && !txtAssignPassword.Text.Equals("") && !txtCMND.Text.Equals("") && !txtName.Text.Equals("") && !txtPassWord.Text.Equals("") && !txtSĐT.Text.Equals("") & !txtUserName.Text.Equals("") && !cmbPhuong.Text.Equals("") && !cmbQuan.Text.Equals(""))
            {
                i++;
                fusion = cmbPhuong.Text + cmbQuan.Text;
                UserID = fusion1 + fusion + i.ToString("00");
                SqlConnection sqlcon = new SqlConnection(connectsql);
                sqlcon.Open();
                SqlCommand querry = new SqlCommand("SP_USERSINSERT", sqlcon);
                querry.CommandType = CommandType.StoredProcedure;
                querry.Parameters.AddWithValue("@Userid", UserID);
                querry.Parameters.AddWithValue("@HOTEN", txtName.Text);
                querry.Parameters.AddWithValue("@SDT", txtSĐT.Text);
                querry.Parameters.AddWithValue("@CMND", txtCMND.Text);
                querry.Parameters.AddWithValue("@Username", txtUserName.Text);
                querry.Parameters.AddWithValue("@MATKHAU", txtPassWord.Text);
                querry.Parameters.AddWithValue("@DIACHI", txtAddress.Text + ",P" + cmbPhuong.Text + ",Q" + cmbQuan.Text);
                querry.Parameters.AddWithValue("@LOAI", type);
                if (txtPassWord.Text.Equals(txtAssignPassword.Text))
                {
                    if ((txtSĐT.Text.Length >= 10 && txtSĐT.Text.Length <= 11))
                    {
                        try
                        {
                            int cmd = querry.ExecuteNonQuery();
                            //sqlcon1.Close();
                            sqlcon.Close();
                            if (cmd > 0)
                            {
                                MessageBox.Show("Bạn đã đăng ký thành công");
                                txtAddress.Clear();
                                txtAssignPassword.Clear();
                                txtCMND.Clear();
                                txtName.Clear();
                                txtPassWord.Clear();
                                txtSĐT.Clear();
                                txtUserName.Clear();
                            }
                            else
                            {
                                MessageBox.Show("CMND trung lap hoac so dien thoai trung lap");
                                txtAddress.Clear();
                                txtAssignPassword.Clear();
                                txtCMND.Clear();
                                txtName.Clear();
                                txtPassWord.Clear();
                                txtSĐT.Clear();
                                txtUserName.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Do dai SDT khong hop le");
                    }
                }
                else
                {
                    MessageBox.Show("Loi");
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

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

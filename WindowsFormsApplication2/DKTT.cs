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
    public partial class DKTT : Form
    {
        string connectsql;
        int i;
        int type = 4;
        string fusion;
        string fusion1;
        string UserID;
        string password;
        Main f;
        public DKTT(Main f,string connectsql)
        {
            InitializeComponent();
            this.f = f;
            this.connectsql = connectsql;
            checkUserID();
            cmbPhuong.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void checkUserID()
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            string command = "Select top 1 USERID from USERS order by USERID DESC";
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

        void random()//tao password random
        {
            int length = 7;

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            password = str_build.ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!txtAddress.Text.Equals("") && !txtCMND.Text.Equals("") && !txtName.Text.Equals("") && !txtSĐT.Text.Equals("") & !txtUserName.Text.Equals("") && !cmbPhuong.Text.Equals("") && !cmbQuan.Text.Equals(""))
            {
                random();
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
                querry.Parameters.AddWithValue("@MATKHAU", password);
                querry.Parameters.AddWithValue("@DIACHI", txtAddress.Text + ",P" + cmbPhuong.Text + ",Q" + cmbQuan.Text);
                querry.Parameters.AddWithValue("@LOAI", type);
                int result = querry.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Insert done");
                    MessageBox.Show(password);
                    txtAddress.Clear();
                    txtCMND.Clear();
                    txtName.Clear();
                    txtSĐT.Clear();
                    txtUserName.Clear();
                    cmbPhuong.ResetText();
                    cmbQuan.ResetText();
                }
                else
                {
                    MessageBox.Show("Insert fail");
                    txtAddress.Clear();
                    txtCMND.Clear();
                    txtName.Clear();
                    txtSĐT.Clear();
                    txtUserName.Clear();
                    cmbPhuong.ResetText();
                    cmbQuan.ResetText();
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

        private void DKTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

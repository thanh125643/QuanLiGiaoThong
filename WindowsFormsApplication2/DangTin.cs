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
    public partial class DangTin : Form
    {
        string connectsql;
        string name;
        String fusion;
        String fusion1;
        int i;
        byte type = 0;
        string count;
        Main f;
        public DangTin(Main f,string connectsql,string name)
        {
            InitializeComponent();
            this.connectsql = connectsql;
            this.name = name;
            this.f = f;
            checkInformID();
            fusion1 = fusion + i.ToString("000");
            checkID();
            cmbPhuong.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void checkInformID()//thuat toan dung de tao id cho moi mot vu viec moi
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            string command = "Select top 1 INFORMID from THONGTIN order by ID DESC";
            SqlCommand querry = new SqlCommand(command, sqlcon);
            string result = Convert.ToString(querry.ExecuteScalar());
            sqlcon.Close();
            string abc = result.Substring(0, 8);
            i = Convert.ToInt32(result.Substring(9));
            fusion = DateTime.Now.ToString("ddMMyyyy");
            if (!fusion.Equals(abc))
            {
                i = 0;
            }
        }
        bool checkrong()
        {
            if(txtChiTiet.Text=="" && txtDuong.Text=="" && cmbPhuong.Text=="" && cmbQuan.Text=="" && (txtSoNguoiLQ.Text=="" || txtSoNguoiLQ.Text == "0")) 
            {
                return false; 
            }
            return true;
        }
        void checkID()//lay ra phan tu USERID tu ten dang nhap lay tu bien public ben form login
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select USERID from USERS WHERE USERNAME = @name", sqlcon);//lấy ra CMND nếu MK có trong cơ sở dữ liệu
            querry.Parameters.AddWithValue("@name", name);
            count = Convert.ToString(querry.ExecuteScalar());//Lấy ra phần tử CMND trong bảng để so sánh với username nhập vào
            sqlcon.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)//dua cac thong tin cua mot thong tin duoc dien tu nguoi dang vao db
        {
            if (checkrong())
            {
                i++;
                fusion1 = fusion + i.ToString("000");
                int soNguoiLQ = Convert.ToInt32(txtSoNguoiLQ.Text);
                SqlConnection sqlcon = new SqlConnection(connectsql);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("Insert into THONGTIN(INFORMID,USERID,INFORMCONTENT,PLACE,SONGUOILQ,THOIGIAN) values(@id,@userid,@content,@place,@count,@date)", sqlcon);
                cmd.Parameters.AddWithValue("@id", fusion1);
                cmd.Parameters.AddWithValue("@userid", count);
                cmd.Parameters.AddWithValue("@content", txtChiTiet.Text);
                cmd.Parameters.AddWithValue("@place", txtDuong.Text + ",P" + cmbPhuong.Text + ",Q" + cmbQuan.Text);
                cmd.Parameters.AddWithValue("@count", soNguoiLQ);
                cmd.Parameters.AddWithValue("@date", dtNgay.Value);
                int result = cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("Insert into THONGTINCHECK values(@id,@type)", sqlcon);
                cmd1.Parameters.AddWithValue("@id", fusion1);
                cmd1.Parameters.AddWithValue("@type", type);
                int result1 = cmd1.ExecuteNonQuery();
                sqlcon.Close();
                if (result > 0 && result1 > 0)
                {
                    MessageBox.Show("Insert done");
                    txtChiTiet.Clear();
                    txtDuong.Clear();
                    txtSoNguoiLQ.Clear();
                    cmbPhuong.ResetText();
                    cmbQuan.ResetText();
                }
                else
                {
                    MessageBox.Show("Insert fail");
                    txtChiTiet.Clear();
                    txtDuong.Clear();
                    txtSoNguoiLQ.Clear();
                    cmbPhuong.ResetText();
                    cmbQuan.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Xin dien day du cac truong");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void DangTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

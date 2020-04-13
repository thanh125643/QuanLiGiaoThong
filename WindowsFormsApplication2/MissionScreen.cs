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
    public partial class MissionScreen : Form
    {
        string connectsql;
        string userid;
        DataTable dta;
        Main f;
        byte hoanthanh = 1;
        public MissionScreen(Main f,string connectsql, string userid)
        {
            InitializeComponent();
            this.f = f;
            this.connectsql = connectsql;
            this.userid = userid;
            LoadMission();
            binding();
            txtInformId.ReadOnly = true;
            txtNguoiDang.ReadOnly = true;
            txtNoiDung.ReadOnly = true;
            txtSoNguoiLQ.ReadOnly = true;
            txtThoiGian.ReadOnly = true;
            txtViTri.ReadOnly = true;
        }

        void LoadMission()//ham dung de hien thi cac thong tin cua user trong bang USERS
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select THONGTIN.INFORMID AS INFORMID,THONGTIN.PLACE AS PLACE,THONGTIN.SONGUOILQ AS SONGUOILQ,THONGTIN.USERID AS USERID,THONGTIN.INFORMCONTENT AS INFORMCONTENT from THONGTIN,PHANCONG,TINHTRANGVUVIEC where THONGTIN.INFORMID=PHANCONG.INFORMID and TINHTRANGVUVIEC.INFORMID=PHANCONG.INFORMID and PHANCONG.USERID=@userid and TINHTRANGVUVIEC.HOANTHANH=0", sqlcon);
            querry.Parameters.AddWithValue("@userid", userid);
            dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(querry);
            //DataTable dta = new DataTable();
            sda.Fill(dta);
            sqlcon.Close();
            dataGridView1.DataSource = dta;
        }

        void binding()//gan cac du lieu lay ra tu datatable vao cac o du lieu
        {
            txtInformId.DataBindings.Clear();
            txtInformId.DataBindings.Add("text", dta, "INFORMID");

            txtViTri.DataBindings.Clear();
            txtViTri.DataBindings.Add("text", dta, "PLACE");

            txtSoNguoiLQ.DataBindings.Clear();
            txtSoNguoiLQ.DataBindings.Add("text", dta, "SONGUOILQ");

            txtNguoiDang.DataBindings.Clear();
            txtNguoiDang.DataBindings.Add("text", dta, "USERID");

            txtThoiGian.DataBindings.Clear();

            txtNoiDung.DataBindings.Clear();
            txtNoiDung.DataBindings.Add("text", dta, "INFORMCONTENT");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)//cap nhat lai cac nguon du lieu cua mot vu viec trong bang tinh trang va ban phan cong
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            string command = "UPDATE PHANCONG SET THONGBAO = 0 WHERE USERID=@id AND INFORMID=@informid";
            SqlCommand querry = new SqlCommand(command, sqlcon);
            querry.Parameters.AddWithValue("@id", userid);
            querry.Parameters.AddWithValue("@informid", txtInformId.Text);
            int result = querry.ExecuteNonQuery();

            string command1 = "UPDATE TINHTRANGVUVIEC SET HOANTHANH = @hoanthanh WHERE INFORMID=@informid";
            SqlCommand querry1 = new SqlCommand(command1, sqlcon);
            querry1.Parameters.AddWithValue("@hoanthanh", hoanthanh);
            querry1.Parameters.AddWithValue("@informid", txtInformId.Text);
            int result1 = querry1.ExecuteNonQuery();
            sqlcon.Close();

            if (result > 0 && result1 > 0)
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Fail");
            }
            dta.Clear();
            LoadMission();
            binding();
        }

        private void MissionScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

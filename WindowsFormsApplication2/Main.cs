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
    public partial class Main : Form
    {
        string connectsql;
        string checkban;
        string userid;

        string vaiTro;
        string name;
        byte hoanthanh = 1;
        byte chuahoanthanh = 0;
        Login f;
        DangTin dangtin;
        MissionScreen missionScreen;
        QuanLi quanli;
        CheckTin checkTin;
        PhanCong phanCong;
        DoiMatKhau doiMatKhau;
        DKTT dKTT;
        public Main(Login f,String connectsql,String checkban,String userid,String vaiTro,String name)
        {
            InitializeComponent();
            this.connectsql = connectsql;
            this.checkban = checkban;
            this.userid = userid;
            this.vaiTro = vaiTro;
            this.name = name;
            this.f = f;
            dangtin = new DangTin(this, connectsql, name);
            missionScreen = new MissionScreen(this, connectsql, userid);
            quanli = new QuanLi(this, connectsql);
            checkTin = new CheckTin(this, connectsql);
            phanCong = new PhanCong(this, connectsql);
            doiMatKhau = new DoiMatKhau(this, connectsql, userid);
            dKTT = new DKTT(this, connectsql);
            check();
            checkMission();
            checkVaitro();
            cmbQuan.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCount.ReadOnly = true;
            txtViecChuaGQ.ReadOnly = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        void checkMission()//kiem tra xem neu la nguoi dung co vai tro la user khi dang nhaap vao neu co nhiem vu duoc giao thi se hien thong bao co nhiem vu moi duoc giao cho
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select THONGBAO from PHANCONG where USERID = @id AND THONGBAO=1", sqlcon);
            querry.Parameters.AddWithValue("@id",userid);
            string count = Convert.ToString(querry.ExecuteScalar());
            sqlcon.Close();
            if (count.Equals("True"))
            {
                MessageBox.Show("You have new mission");
            }
        }

        void check()//kiem tra co bi ban hay ko
        {
            if (checkban.Equals("ban"))
            {
                MessageBox.Show("you have ben ban from post news");
                daToolStripMenuItem.Enabled = false;
            }
            else
            {
                daToolStripMenuItem.Enabled = true;
            }
        }

        void checkVaitro()//kiem tra vai tro cua ng dang nhap de thuc hien an cac nut chuc nang khong phu hop
        {
            if (vaiTro.Equals("QuanLi"))
            {
                quảnLýToolStripMenuItem.Enabled = false;
                phânCôngToolStripMenuItem.Enabled = false;
                checkTinToolStripMenuItem.Enabled = false;
                nhiệmVụToolStripMenuItem.Enabled = true;
                dKTTToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (vaiTro.Equals("User"))
                {
                    quảnLýToolStripMenuItem.Enabled = false;
                    phânCôngToolStripMenuItem.Enabled = false;
                    checkTinToolStripMenuItem.Enabled = false;
                    nhiệmVụToolStripMenuItem.Enabled = false;
                    dKTTToolStripMenuItem.Enabled = false;
                }
                else 
                {
                    quảnLýToolStripMenuItem.Enabled = true;
                    phânCôngToolStripMenuItem.Enabled = true;
                    checkTinToolStripMenuItem.Enabled = true;
                    nhiệmVụToolStripMenuItem.Enabled = true;
                    dKTTToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }


        private void daToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangtin.Show();
        }

        private void nhiệmVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            missionScreen.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            quanli.Show();
        }

        private void checkTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkTin.Show();
        }

        private void phânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            phanCong.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            doiMatKhau.Show();
        }

        private void dKTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            dKTT.Show();
        }

        void countInform()//in ra cac cot INFORMCONTENT,PLACE,SONGUOILQ cua cac vu viec da duoc xu li xong sau do hien thi ra gridview
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select INFORMCONTENT,PLACE,SONGUOILQ from THONGTIN join TINHTRANGVUVIEC on THONGTIN.INFORMID = TINHTRANGVUVIEC.INFORMID where THONGTIN.PLACE like '%" + cmbQuan.Text + "%' and TINHTRANGVUVIEC.HOANTHANH = @hoanthanh", sqlcon);
            querry.Parameters.AddWithValue("@hoanthanh", hoanthanh);
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(querry);
            //DataTable dta = new DataTable();
            sda.Fill(dta);
            sqlcon.Close();
            dataGridView1.DataSource = dta;
        }

        void bindingCount()//dem so luong thong tin tai nan da duoc xu li xong sau do in ra textbox
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select COUNT(THONGTIN.INFORMID) from THONGTIN join TINHTRANGVUVIEC on THONGTIN.INFORMID = TINHTRANGVUVIEC.INFORMID where THONGTIN.PLACE like '%" + cmbQuan.Text + "%' AND TINHTRANGVUVIEC.HOANTHANH = @hoanthanh", sqlcon);
            querry.Parameters.AddWithValue("@hoanthanh", hoanthanh);
            string temp = Convert.ToString(querry.ExecuteScalar());
            sqlcon.Close();
            txtCount.Clear();
            txtCount.Text = temp;
        }

        void bindingCount2()//dem so luong thong tin tai nan chua duoc xu li xong sau do in ra textbox
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select COUNT(THONGTIN.INFORMID) from THONGTIN join TINHTRANGVUVIEC on THONGTIN.INFORMID = TINHTRANGVUVIEC.INFORMID where THONGTIN.PLACE like '%" + cmbQuan.Text + "%' AND TINHTRANGVUVIEC.HOANTHANH = @hoanthanh", sqlcon);
            querry.Parameters.AddWithValue("@hoanthanh", chuahoanthanh);
            string temp = Convert.ToString(querry.ExecuteScalar());
            sqlcon.Close();
            txtViecChuaGQ.Clear();
            txtViecChuaGQ.Text = temp;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            countInform();
            bindingCount();
            bindingCount2();
        }

        private void cmbQuan_DropDown(object sender, EventArgs e)
        {
            txtCount.Clear();
            txtViecChuaGQ.Clear();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class CheckTin : Form
    {
        string connectsql;
        byte select;
        DataTable dta;
        DataSet ds;
        int i;
        Main f;
        public CheckTin(Main f,string connectsql)
        {
            InitializeComponent();
            this.f = f;
            this.connectsql = connectsql;
            txtChiTiet.ReadOnly = true;
            txtDiaDiem.ReadOnly = true;
            txtSoNguoiLQ.ReadOnly = true;
            txtThoiGian.ReadOnly = true;
            txtName.ReadOnly = true;
            txtIDInform.ReadOnly = true;
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        void bingding()//lay ra cac du lieu tu db
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select HOTEN from USERS Where TRANGTHAI= " + select, sqlcon);
            //DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(querry);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            sqlcon.Close();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)//gan cac du lieu tu datatable ra cac o du lieu
        {
            if (cmbLoai.Text.Equals("Unchecked"))
            {
                cmbTrangThai.Visible = true;
                select = 0;
            }
            else
            {
                cmbTrangThai.Visible = false;
                select = 1;
            }
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select * from THONGTIN join THONGTINCHECK on THONGTIN.INFORMID = THONGTINCHECK.INFORMID Where TRANGTHAI= " + select, sqlcon);
            //DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(querry);
            dta = new DataTable();
            ds = new DataSet();
            sda.Fill(dta);
            sda.Fill(ds);
            sqlcon.Close();
            txtChiTiet.DataBindings.Clear();
            txtChiTiet.DataBindings.Add("text", dta, "INFORMCONTENT");
            txtDiaDiem.DataBindings.Clear();
            txtDiaDiem.DataBindings.Add("text", dta, "PLACE");
            txtSoNguoiLQ.DataBindings.Clear();
            txtSoNguoiLQ.DataBindings.Add("text", dta, "SONGUOILQ");
            txtThoiGian.DataBindings.Clear();
            txtThoiGian.DataBindings.Add("text", dta, "THOIGIAN");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("text", dta, "USERID");
            txtIDInform.DataBindings.Clear();
            txtIDInform.DataBindings.Add("text",dta,"INFORMID");
            
        }

        private void button1_Click(object sender, EventArgs e)//cap nhat lai gia tri LOAI cua moi ban tin
        {
     
            byte loai;
            if (cmbTrangThai.Text.Equals("1"))
            {
                loai = 1;
            }
            else
            {
                loai = 0;
            }
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Update THONGTINCHECK set TRANGTHAI=@loai where INFORMID = @informid", sqlcon);
            querry.Parameters.AddWithValue("@loai",loai);
            querry.Parameters.AddWithValue("@informid", txtIDInform.Text);
            int result = querry.ExecuteNonQuery();
            if(result > 0)
            {
                MessageBox.Show("Update done");
            }
            else
            {
                MessageBox.Show("Update fail");
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)//dua den tin dau tien trong db
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                i = 0;
                txtName.Text = ds.Tables[0].Rows[i]["USERID"].ToString();
                txtIDInform.Text = ds.Tables[0].Rows[i]["INFORMID"].ToString();
                txtChiTiet.Text = ds.Tables[0].Rows[i]["INFORMCONTENT"].ToString();
                txtDiaDiem.Text = ds.Tables[0].Rows[i]["PLACE"].ToString();
                txtSoNguoiLQ.Text = ds.Tables[0].Rows[i]["SONGUOILQ"].ToString();
                txtThoiGian.Text = ds.Tables[0].Rows[i]["THOIGIAN"].ToString();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)//chuyen ve phia truoc mot tin
        {
            if (i < ds.Tables[0].Rows.Count || i!=0)
            {
                i--;
                txtName.Text = ds.Tables[0].Rows[i]["USERID"].ToString();
                txtIDInform.Text = ds.Tables[0].Rows[i]["INFORMID"].ToString();
                txtChiTiet.Text = ds.Tables[0].Rows[i]["INFORMCONTENT"].ToString();
                txtDiaDiem.Text = ds.Tables[0].Rows[i]["PLACE"].ToString();
                txtSoNguoiLQ.Text = ds.Tables[0].Rows[i]["SONGUOILQ"].ToString();
                txtThoiGian.Text = ds.Tables[0].Rows[i]["THOIGIAN"].ToString();

            }
            else
            {
                MessageBox.Show("You are in the first row");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)//chuyen ve phia sau mot tin
        {
            if (i < ds.Tables[0].Rows.Count - 1)
            {
                i++;
                txtName.Text = ds.Tables[0].Rows[i]["USERID"].ToString();
                txtIDInform.Text = ds.Tables[0].Rows[i]["INFORMID"].ToString();
                txtChiTiet.Text = ds.Tables[0].Rows[i]["INFORMCONTENT"].ToString();
                txtDiaDiem.Text = ds.Tables[0].Rows[i]["PLACE"].ToString();
                txtSoNguoiLQ.Text = ds.Tables[0].Rows[i]["SONGUOILQ"].ToString();
                txtThoiGian.Text = ds.Tables[0].Rows[i]["THOIGIAN"].ToString();
            }
            else
            {
                MessageBox.Show("You are in the last row");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)//dua den tin cuoi cung trong db
        {
            i = ds.Tables[0].Rows.Count - 1;
            txtName.Text = ds.Tables[0].Rows[i]["USERID"].ToString();
            txtIDInform.Text = ds.Tables[0].Rows[i]["INFORMID"].ToString();
            txtChiTiet.Text = ds.Tables[0].Rows[i]["INFORMCONTENT"].ToString();
            txtDiaDiem.Text = ds.Tables[0].Rows[i]["PLACE"].ToString();
            txtSoNguoiLQ.Text = ds.Tables[0].Rows[i]["SONGUOILQ"].ToString();
            txtThoiGian.Text = ds.Tables[0].Rows[i]["THOIGIAN"].ToString();
        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)//lam sach cac o thong tin
        {
            txtChiTiet.Clear();
            txtDiaDiem.Clear();
            txtSoNguoiLQ.Clear();
            txtThoiGian.Clear();
            txtName.Clear();
            txtIDInform.Clear();
            cmbTrangThai.ResetText();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void CheckTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

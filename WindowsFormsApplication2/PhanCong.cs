
using System;
using System.Collections;
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
    public partial class PhanCong : Form
    {
        string connectsql;
        int i = 1;
        DataTable dte;
        DataTable dta;
        DataTable dta1;
        int first = 1;
        Main f;
        public PhanCong(Main f,string connectsql)
        {
            InitializeComponent();
            this.f = f;
            this.connectsql = connectsql;
            LoadData();
            binding2();
            cmbListID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserID.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUserID.ReadOnly = true;
        }

        void LoadData()//gan du lieu INFORMID cho cmbListID 
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select INFORMID from THONGTINCHECK where TRANGTHAI=1", sqlcon);
            DataTable dta = new DataTable();
            SqlDataReader reader;
            reader = querry.ExecuteReader();
            dta.Columns.Add("INFORMID", typeof(string));
            dta.Load(reader);
            cmbListID.ValueMember = "INFORMID";
            cmbListID.DisplayMember = "INFORMID";
            cmbListID.DataSource = dta;
            sqlcon.Close();
        }

        void LoadUserID()//Gan du lieu cho cmbUserID theo vi tri cua vu viec
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select PLACE from THONGTIN WHERE INFORMID = @id", sqlcon);
            querry.Parameters.AddWithValue("@id", cmbListID.Text);
            string count = Convert.ToString(querry.ExecuteScalar());
            string[] str = count.Split(',');

            SqlCommand querry1 = new SqlCommand("Select USERS.USERID from USERS where DIACHI like '%" + str[2] + "%' and LOAI='" + i + "'  EXCEPT (Select USERS.USERID from USERS join PHANCONG on USERS.USERID = PHANCONG.USERID where DIACHI like '%" + str[2] + "%' and LOAI='" + i + "'and THONGBAO = 1 ) ", sqlcon);
            dte = new DataTable();
            SqlDataReader reader;
            reader = querry1.ExecuteReader();
            dte.Columns.Add("USERID", typeof(string));
            dte.Load(reader);
            cmbUserID.ValueMember = "USERID";
            cmbUserID.DisplayMember = "USERID";
            cmbUserID.DataSource = dte;
            sqlcon.Close();

           
        }

        private void btnSubmit_Click(object sender, EventArgs e)//dua thong tin ve tinh trang cua mot vu viec vao db
        {
            byte a,b;
            if(checkBox1.Checked)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }

            if (checkBox3.Checked)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }

            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("SP_TINHTRANGINSERT", sqlcon);
            querry.CommandType = CommandType.StoredProcedure;
            querry.Parameters.AddWithValue("@id",cmbListID.Text);
            querry.Parameters.AddWithValue("@danhan",a);
            querry.Parameters.AddWithValue("@hoanthanh",b);
            int result = querry.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Insert done");
            }
            else
            {
                MessageBox.Show("Insert fail");
            }
           
        }

        void LoadPhanCong()//hien thi du lieu tren dataGridView1
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select * from PHANCONG where INFORMID=@id", sqlcon);
            querry.Parameters.AddWithValue("@id", cmbListID.Text);
            dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(querry);
            //DataTable dta = new DataTable();
            sda.Fill(dta);
            sqlcon.Close();
            dataGridView1.DataSource = dta;
        }


        void binding()//gan du lieu vao combobox cmbUserID
        {
            txtUserID.DataBindings.Clear();
            txtUserID.DataBindings.Add("text",dta,"USERID");
        }

        void binding2()//gan du lieu cua tung vu viec theo INFORMID
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select * from TINHTRANGVUVIEC where INFORMID=@id", sqlcon);
            querry.Parameters.AddWithValue("@id", cmbListID.Text);
            dta1 = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(querry);
            //DataTable dta = new DataTable();
            sda.Fill(dta1);
            sqlcon.Close();
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUserID();
        }

        private void btnSendNoti_Click(object sender, EventArgs e)//nhap thong tin vao bang PHANCONG dong thoi day la giao nhiem vu cho mot nhan vien cu the
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(connectsql);
                sqlcon.Open();
                SqlCommand querry = new SqlCommand("Insert into PHANCONG values(@idinform,@iduser,@thongbao)", sqlcon);
                querry.Parameters.AddWithValue("@idinform", cmbListID.Text);
                querry.Parameters.AddWithValue("@iduser", cmbUserID.Text);
                querry.Parameters.AddWithValue("@thongbao", first);
                int result = querry.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Have send the notification");
                    LoadPhanCong();
                    LoadUserID();
                }
                else
                {
                    MessageBox.Show("Send fail");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Loi");
            }
        }

        private void button1_Click(object sender, EventArgs e)//chuyen ve form main(co the xem la nut home)
        {
            this.Hide();
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)//nut xoa cac nhan vien ra khoi nhiem vu duoc phan cong
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            string command = "DELETE FROM PHANCONG WHERE USERID = @userid";
            SqlCommand querry = new SqlCommand(command, sqlcon);
            querry.Parameters.AddWithValue("@userid", txtUserID.Text);
            int result = querry.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Delete done");
                LoadPhanCong();
                binding();
            }
            else
            {
                MessageBox.Show("Delete fail");
            }
            txtUserID.Clear();
        }

        

        private void PhanCong_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbListID_SelectedIndexChanged(object sender, EventArgs e)//binding du lieu tu datable vao check box
        {
            binding2();
            checkBox1.DataBindings.Clear();
            checkBox1.DataBindings.Add("Checked", dta1, "DANHAN");
            checkBox3.DataBindings.Clear();
            checkBox3.DataBindings.Add("Checked", dta1, "HOANTHANH");
            LoadPhanCong();
        }

        private void cmbListID_ValueMemberChanged(object sender, EventArgs e)
        {
            binding2();
            checkBox1.DataBindings.Clear();
            checkBox1.DataBindings.Add("Checked", dta1, "DANHAN");
            checkBox3.DataBindings.Clear();
            checkBox3.DataBindings.Add("Checked", dta1, "HOANTHANH");
        }

        private void cmbListID_DropDown(object sender, EventArgs e)//moi khi check box drop down thi reset lai gia tri cua check box
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void PhanCong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report frm = new Report();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }

        
    }
}

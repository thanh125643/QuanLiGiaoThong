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
    public partial class QuanLi : Form
    {
        public string connectsql;
        Main f;
        BanScreen banScreen;
        public QuanLi(Main f,string connectsql)
        {
            InitializeComponent();
            this.f = f;
            this.connectsql = connectsql;
            LoadUser();
            binddingCMB();
            cmbLOAI.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCMND.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        void LoadUser()//ham dung de hien thi cac thong tin cua user trong bang USERS
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select * from USERS where LOAI!=3 AND LOAI!=0", sqlcon);
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(querry);
            //DataTable dta = new DataTable();
            sda.Fill(dta);
            sqlcon.Close();
            dataGridView1.DataSource = dta;
        }

        void binddingCMB() 
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select CMND from USERS where LOAI!=3 AND LOAI!=0", sqlcon);
            DataTable dta = new DataTable();
            SqlDataReader reader;
            reader = querry.ExecuteReader();
            dta.Columns.Add("CMND",typeof(string));
            dta.Load(reader);
            cmbCMND.ValueMember = "CMND";
            cmbCMND.DisplayMember = "CMND";
            cmbCMND.DataSource = dta;
            sqlcon.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != string.Empty && txtName.Text != string.Empty && txtSDT.Text != string.Empty && cmbCMND.Text != string.Empty && cmbLOAI.Text != string.Empty)
            {
                SqlConnection sqlcon = new SqlConnection(connectsql);
                sqlcon.Open();
                string command = "UPDATE USERS SET HOTEN=@name,SDT=@sdt,DIACHI=@diachi,LOAI=@loai WHERE CMND = @cmnd";
                SqlCommand querry = new SqlCommand(command, sqlcon);
                querry.Parameters.AddWithValue("@name", txtName.Text);
                querry.Parameters.AddWithValue("@sdt", txtSDT.Text);
                querry.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                querry.Parameters.AddWithValue("@cmnd", cmbCMND.Text);
                querry.Parameters.AddWithValue("@loai", cmbLOAI.Text);
                int result = querry.ExecuteNonQuery();
                sqlcon.Close();
                if (result > 0)
                {
                    MessageBox.Show("Update done");
                    LoadUser();
                    binddingCMB();
                }
                else
                {
                    MessageBox.Show("Update fail");
                }
            }
            else
            {
                MessageBox.Show("Xin điền đầy đủ thông tin");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            string command = "DELETE FROM USERS WHERE CMND = @cmnd";
            SqlCommand querry = new SqlCommand(command, sqlcon);
            querry.Parameters.AddWithValue("@cmnd",cmbCMND.Text);
            int result = querry.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Delete done");
                LoadUser();
                binddingCMB();
            }
            else 
            {
                MessageBox.Show("Delete fail");
            }
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            string command = "UPDATE USERS SET LOAI=@loai WHERE CMND = @cmnd";
            SqlCommand querry = new SqlCommand(command, sqlcon);
            querry.Parameters.AddWithValue("@cmnd", cmbCMND.Text);
            querry.Parameters.AddWithValue("@loai", cmbLOAI.Text);
            int result = querry.ExecuteNonQuery();
            sqlcon.Close();
            if (result > 0)
            {
                MessageBox.Show("Update done");
                LoadUser();
                binddingCMB();
            }
            else
            {
                MessageBox.Show("Update fail");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void btnBanScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            banScreen = new BanScreen(this,connectsql);
            banScreen.Show();
        }

        private void QuanLi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbCMND_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmnd = cmbCMND.Text;
            if (cmnd != "")
            {
                SqlConnection sqlcon = new SqlConnection(connectsql);
                sqlcon.Open();
                string command = "Select * from USERS WHERE CMND = @cmnd";
                SqlCommand querry = new SqlCommand(command, sqlcon);
                querry.Parameters.AddWithValue("@cmnd", cmnd);
                SqlDataReader reader = querry.ExecuteReader();
                reader.Read();
                txtName.Text = reader.GetString(4);
                txtSDT.Text = reader.GetString(5);
                txtDiaChi.Text = reader.GetString(7);
                cmbLOAI.Text = reader.GetInt32(8).ToString();
                reader.Close();
                sqlcon.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            cmbCMND.Text = row.Cells[6].Value.ToString();
        }
    }
}

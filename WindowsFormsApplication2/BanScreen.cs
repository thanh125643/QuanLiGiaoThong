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
    public partial class BanScreen : Form
    {
        string connectsql;
        DataTable dta;
        QuanLi f;
        public BanScreen(QuanLi f,string connectsql)
        {
            InitializeComponent();
            this.f = f;
            this.connectsql = connectsql;
            Loads();
            binding();
            this.Refresh();
        }

        void Loads()//load cac thong tin tu bang USER trong db len data grid view
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            SqlCommand querry = new SqlCommand("Select * from USERS where LOAI = 3", sqlcon);
            dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(querry);
            //DataTable dta = new DataTable();
            sda.Fill(dta);
            sqlcon.Close();
            dataGridView1.DataSource = dta;
        }

        void binding()//gan du lieu tu datata
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("text",dta,"USERID");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("text",dta,"CMND");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("text", dta, "HOTEN");
        }

        private void btnUnban_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connectsql);
            sqlcon.Open();
            string command = "UPDATE USERS SET LOAI=2 WHERE CMND = @cmnd";
            SqlCommand querry = new SqlCommand(command, sqlcon);
            querry.Parameters.AddWithValue("@cmnd", txtCMND.Text);
            int result = querry.ExecuteNonQuery();
            sqlcon.Close();
            if (result > 0)
            {
                MessageBox.Show("Update done");
                Loads();
                txtHoTen.Clear();
                txtCMND.Clear();
                txtID.Clear();
            }
            else
            {
                MessageBox.Show("Update fail");
            }
            binding();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void BanScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

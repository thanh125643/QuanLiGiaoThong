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
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        public string connectsql = "das";
        public string name = "aa";
        public string checkban = "unban";//kiem tra user co bi ban hay ko
        public string userid = "aa";
        public string vaiTro = "User";//kiem tra vai tro cua nguoi dang nhap
        Data data;
        public Login()
        {
            InitializeComponent();
            data = new Data(this);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register(this,connectsql);
            reg.Show();
        }



        void checkone()//kiem tra xem file config da ton tai chua neu chua thi tao ra file config
        {
            string path = "config.txt";
            if (!File.Exists(path))
            {
                this.Hide();
                data.ShowDialog();
            }
            else
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        connectsql = line;
                    }
                }
            }
        }
        void openmain()
        {
            this.Hide();
            Main fmr = new Main(this, connectsql, checkban, userid, vaiTro, name);
            fmr.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)//dang nhap
        {
            if (!txtUsername.Text.Equals("") && !txtPassword.Text.Equals(""))
            {
                SqlConnection sqlcon = new SqlConnection(connectsql);
                sqlcon.Open();
                SqlCommand querry = new SqlCommand("Select USERID,USERNAME,LOAI from USERS WHERE MK = @Password and USERNAME = @name", sqlcon);//lấy ra CMND nếu MK có trong cơ sở dữ liệu
                querry.Parameters.AddWithValue("@Password", txtPassword.Text);
                querry.Parameters.AddWithValue("@name", txtUsername.Text);
                SqlDataReader reader = querry.ExecuteReader();//Lấy ra phần tử CMND trong bảng để so sánh với username nhập vào
                
                
                if (reader.Read())//kiểm tra dữ liệu trả về từ sqlreader
                {
                    name = reader.GetString(1);
                    userid = reader.GetString(0);
                    string count1 = reader.GetInt32(2).ToString();//Lấy ra phần tử LOAI trong bảng để phân biệt cấp bậc cơ sở
                    if (count1.Equals("0"))
                    {
                        vaiTro = "Admin";
                        checkban = "unban";
                        //MessageBox.Show("You are admin");
                    }
                    else if (count1.Equals("1"))
                    {
                        vaiTro = "QuanLi";
                        checkban = "unban";
                        //MessageBox.Show("You are management");
                        
                    }
                    else if (count1.Equals("2"))
                    {
                        checkban = "unban";
                        vaiTro = "User";
                        //MessageBox.Show("You are user");
                        
                    }
                    else if (count1.Equals("3"))
                    {
                        checkban = "ban";
                        vaiTro = "User";
                        
                    }
                    else
                    {
                        checkban = "unban";
                        vaiTro = "QuanLi";
                        MessageBox.Show("Bạn cần đổi mật khẩu");
                    }
                    openmain();
                }
                else
                {
                    MessageBox.Show("You username or password are invalid");
                }
                reader.Close();
                sqlcon.Close();


            }
            else
            {
                MessageBox.Show("Chưa nhập Username hoặc password");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            checkone();
        }
    }
}

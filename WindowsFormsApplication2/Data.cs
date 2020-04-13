using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Data : Form
    {
        Login f;
        public Data(Login f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btnSubmit_Click(object sender, EventArgs e)//dua cac du lieu nhu la datasource,username va password cua database hien thoi vao config.txt
        {
            string cnn = @"Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtDBName.Text + ";Integrated Security=True";
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                cnn += ";User ID = " + txtUsername.Text + "; Password = " + txtPassword.Text;
            }
            string path = "config.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(cnn);

            }
            this.Hide();
            f.connectsql = cnn;
            f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)//nut home
        {
            this.Hide();
            f.Show();
        }

        private void Data_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show();
        }
    }
}

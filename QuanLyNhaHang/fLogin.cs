using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhaHang
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
       

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSignup f = new fSignup();
            f.ShowDialog();
            this.Show();
        }
        bool Login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName, password);
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (rBtnThuNgan.Checked == true && userName != "admin")
            {
                if (Login(userName, password) == true)
                {

                    fHomeStaff f = new fHomeStaff();
                    this.Hide();
                    f.ShowDialog();
                    // this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
                }

            }
            else if (rBtnAdmin.Checked == true && userName == "admin" && Login(userName, password) == true)
            {
                fHome f = new fHome();
                this.Hide();
                f.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
            }
        }
    }
}

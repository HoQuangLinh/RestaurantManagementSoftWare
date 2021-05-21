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


namespace QuanLyNhaHang
{
    public partial class fSignup : Form
    {
        public fSignup()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new fLogin().Show();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string newusername = txtUsername.Text;
            string newpass = txtPassword.Text;
            string repass = txtRePassword.Text;
            string idconfirm = txtIdConfirm.Text;
            
            if (newpass != repass)
            {
                MessageBox.Show("Mật khẩu không khớp !");
               
            }
           if(idconfirm!="*#1234")
            {
                MessageBox.Show("Mã xác nhận không hợp lệ");
            }
            else if (newpass == ""||newusername==""||repass==""||idconfirm=="")
            {
                MessageBox.Show("Không được để trống thông tin  !");
                
            }
           
        }

        private void txtIdConfirm_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

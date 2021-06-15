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


            if (newpass == "" || newusername == "" || repass == "" || idconfirm == "")
            {
                MessageBox.Show("Không được để trống thông tin  !");

            }
            else
            {
                try
                {
                    AccountDAO.Instance.InsertAccout(newusername, newpass);
                    MessageBox.Show("thêm tài khoản thành công !");
                    this.Close();
                    new fLogin().Show();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Đăng ký không thành công");

                }

            }

        }

        private void txtIdConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            ;
            if (AccountDAO.Instance.IsExitAccount(txtUsername.Text) == true)
            {
                e.Cancel = true;

                errorProvider1.SetError(txtUsername, "Tên tài khoản đã tồn tại");
                MessageBox.Show("Tên tài khoản đã tồn tại");

            }


            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtIdConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (txtIdConfirm.Text != "*#1234")
            {
                e.Cancel = true;

                errorProvider1.SetError(txtIdConfirm, "Mã xác nhận không hợp lệ");
                MessageBox.Show("Mã xác nhận không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtIdConfirm, null);
            }
        }

        private void txtRePassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != txtRePassword.Text)
            {
                e.Cancel = true;

                errorProvider1.SetError(txtRePassword, "Mật khẩu không khớp");
                MessageBox.Show("Mật khẩu không khớp");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRePassword, null);
            }
        }
    }
}

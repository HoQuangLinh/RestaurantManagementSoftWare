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
    public partial class fAddStaff : Form
    {
        public fAddStaff()
        {
            InitializeComponent();
            txtIdStaff.Text = (StaffDAO.Instance.GetMaxIdStaff() + 1).ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAddStaff_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {


            if (cbbSex.SelectedItem == null || txtNameStaff.Text == ""
            || txtPosition.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {

                    string tennhanvien = txtNameStaff.Text;
                    string chucvu = txtPosition.Text;
                    string gioitinh = cbbSex.SelectedItem.ToString();
                    DateTime ngaysinh = Convert.ToDateTime(txtDate.Text);
                    if (StaffDAO.Instance.
                       InsertStaff(tennhanvien, chucvu, gioitinh, ngaysinh) == true)
                    {
                        MessageBox.Show("thêm nhân viên thành công !");
                    }
                    //Khi thêm xong các textbox trở thành rỗng
                    txtIdStaff.Text = (Convert.ToInt32(txtIdStaff.Text) + 1).ToString();
                    txtDate.Text = "";
                    txtNameStaff.Text = "";
                    txtPosition.Text = "";
                    cbbSex.Text = "";
                }



                catch (FormatException ex)
                {

                    MessageBox.Show(" Ngày phải nhập theo mm/dd/yyyy");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Thêm nhân viên không thành công");
                }
            }



        }

        private void cbbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdStaff_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {

            if (cbbSex.SelectedItem == null || txtNameStaff.Text == ""
            || txtPosition.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {

                    string tennhanvien = txtNameStaff.Text;
                    string chucvu = txtPosition.Text;
                    string gioitinh = cbbSex.SelectedItem.ToString();
                    DateTime ngaysinh = Convert.ToDateTime(txtDate.Text);
                    if (StaffDAO.Instance.
                       InsertStaff(tennhanvien, chucvu, gioitinh, ngaysinh) == true)
                    {
                        MessageBox.Show("thêm nhân viên thành công !");
                    }
                    //Khi thêm xong các textbox trở thành rỗng
                    txtIdStaff.Text = (Convert.ToInt32(txtIdStaff.Text) + 1).ToString();
                    txtDate.Text = "";
                    txtNameStaff.Text = "";
                    txtPosition.Text = "";
                    cbbSex.Text = "";
                }



                catch (FormatException ex)
                {

                    MessageBox.Show(" Ngày phải nhập theo mm/dd/yyyy");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Thêm nhân viên không thành công");
                }
            }
        }
    }
}

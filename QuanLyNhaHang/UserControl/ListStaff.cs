using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class ListStaff : UserControl
    {
        public ListStaff()
        {
            InitializeComponent();
            LoadStaff();




        }
        void LoadStaff()
        {
            dtgvStaff.DataSource = StaffDAO.Instance.LoadStaff();
            dtgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dtgvStaff.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            fAddStaff f = new fAddStaff();
            f.ShowDialog();
            LoadStaff();
        }

        private void txtIdStaff_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateStaff_Click(object sender, EventArgs e)
        {
            if (txtIdStaff.Text == "" || txtDate.Text == "" || txtNameStaff.Text == ""|| txtPosition.Text == "" || txtSex.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    int manhanvien = Convert.ToInt32(txtIdStaff.Text);
                    string tennhanvien = txtNameStaff.Text;
                    string chucvu = txtPosition.Text;
                    string gioitinh = txtSex.Text;
                    DateTime ngaysinh = Convert.ToDateTime(txtDate.Text);
                    if (StaffDAO.Instance.
                        UpdateStaff(manhanvien, tennhanvien, chucvu, gioitinh, ngaysinh) == true)
                    {
                        MessageBox.Show("Cập nhật thành công thành công !");
                        LoadStaff();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại");
                    }

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Một số thông tin không chính xác, vui lòng kiểm tra lại");
                }


            }
        }

        private void buttonDeleteStaff_Click(object sender, EventArgs e)
        {
            if (txtIdStaff.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được trống");

            }
            else
            {
                int id = Convert.ToInt32(txtIdStaff.Text);
                if (StaffDAO.Instance.DeleteStaff(id) == true)
                {
                    MessageBox.Show("xóa thành công !");
                    LoadStaff();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không tồn tại");
                }

            }
            txtPosition.Text = "";
            txtSex.Text = "";
            txtDate.Text = "";
            txtIdStaff.Text = "";
            txtNameStaff.Text = "";
        }

        private void ListStaff_Load(object sender, EventArgs e)
        {
            dtgvStaff.DataSource = StaffDAO.Instance.LoadStaff();
            dtgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dtgvStaff.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text;
            DataTable data = StaffDAO.Instance.SearchStaffByName(name);
            if (data.Rows.Count == 0 || name == "")
                MessageBox.Show("Không có thông tin nhân viên cần tìm");
            else
            {
                dtgvStaff.DataSource = data;
                for (int i = 0; i < dtgvStaff.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                        dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                    }
                    else
                    {
                        dtgvStaff.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        dtgvStaff.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                    }
                }
            }
        }

        private void dtgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvStaff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvStaff.Rows[e.RowIndex];
                txtDate.Text = row.Cells["Ngày sinh"].Value.ToString();
                txtIdStaff.Text = row.Cells["Mã nhân viên"].Value.ToString();
                txtNameStaff.Text = row.Cells["Họ tên"].Value.ToString();
                txtPosition.Text = row.Cells["Chức vụ"].Value.ToString();
                txtSex.Text = row.Cells["Giới tính"].Value.ToString();
            }
        }
    }

}

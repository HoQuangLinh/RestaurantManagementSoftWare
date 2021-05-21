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

                 
                if(txtIdStaff.Text==""||cbbSex.SelectedItem.ToString()==""||txtNameStaff.Text==""
                ||txtPosition.Text==""||cbbSex.SelectedItem.ToString()=="")
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
                    string gioitinh = cbbSex.SelectedItem.ToString();
                    DateTime ngaysinh = Convert.ToDateTime(txtDate.Text);
                   
                }



                catch (FormatException ex)
                {
                    MessageBox.Show("Một số thông tin sai định dạng");
                    MessageBox.Show("Gợi ý: Ngày phải nhập theo mm/dd/yyyy"
                        + " hoặc mã nhân viên phải là số");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Mã nhân viên không được trùng");
                }
            }    

            
        }

        private void cbbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

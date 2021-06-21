using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace QuanLyNhaHang
{
    public partial class ListBill : UserControl
    {
        public ListBill()
        {
            InitializeComponent();
            LoadBill();
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int TongTien(int MABAN)
        {

            List<Menu> menus = MenuDAO.Instance.GetListMenusById(MABAN);


            int tongtien = 0;
            foreach (var i in menus)
            {
                tongtien += i.Thanhtien;
            }
            return tongtien;


        }
        void LoadBill()
        {
            string date = datetimeGetDay.Value.ToShortDateString();
            dtgvBill.DataSource = BillDAO.Instance.GetBillByDate(date);
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
            try
            {
                DataGridViewRow row = dtgvBill.Rows[0];
                if (row.Cells["Mã hoá đơn"].Value != null)
                {
                    int mahoadon = Convert.ToInt32(row.Cells["Mã hoá đơn"].Value.ToString());
                    dtgvBillDetail.DataSource = BillDAO.Instance.GetListHistoryMenusById(mahoadon);
                }
            }
            catch (Exception ex)
            {

            }


        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBill_Load(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = datetimeGetDay.Value.ToShortDateString();
            dtgvBill.DataSource = BillDAO.Instance.GetBillByDate(date);
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            try
            {
                int maban = Convert.ToInt32(txtIdTable.Text);
                dtgvBill.DataSource = BillDAO.Instance.SearchBillByIdTable(maban);
                dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataGridViewRow row = dtgvBill.Rows[0];
                if (row.Cells["Mã hoá đơn"].Value != null)
                {
                    int mahoadon = Convert.ToInt32(row.Cells["Mã hoá đơn"].Value.ToString());
                    dtgvBillDetail.DataSource = BillDAO.Instance.GetListHistoryMenusById(mahoadon);
                    for (int i = 0; i < dtgvBill.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                            dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                        }
                        else
                        {
                            dtgvBill.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            dtgvBill.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có hoá đơn cần tìm kiếm");
            }



        }

        private void dtgvBill_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dtgvBill.Rows[e.RowIndex];
                    txtIdBill.Text = row.Cells["Mã hoá đơn"].Value.ToString();
                    txtIdTable.Text = row.Cells["Mã bàn"].Value.ToString();
                    txtStatus.Text = row.Cells["Trạng thái"].Value.ToString();
                    txtSum.Text = row.Cells["Tổng tiền"].Value.ToString();
                    int mahoadon = Convert.ToInt32(txtIdBill.Text);
                    dtgvBillDetail.DataSource = BillDAO.Instance.GetListHistoryMenusById(mahoadon);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Bạn chưa nhập gì");
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvBillDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class fOrder : Form
    {
        private int Maban = 0;

        public fOrder(int maban, string tenban)
        {
            InitializeComponent();
            this.Maban = maban;
            txtNameTable.Text = tenban;

            LoadDanhMuc();
        }

        void LoadDanhMuc()
        {
            List<FoodCategory> categories =
                 FoodCategoryDAO.Instance.GetListFoodCategories();
            cbTenDanhMuc.DataSource = categories;
            cbTenDanhMuc.DisplayMember = "TenLoai";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            if (listFood.Count == 0)
            {
                MessageBox.Show("Loại này chưa có món");
                cbTenDanhMuc.SelectedIndex = 0;
                LoadFoodListByCategoryID(1);
            }
            else
            {
                cbTenThucAn.DataSource = listFood;
                cbTenThucAn.DisplayMember = "Tenthucan";
            }







        }
        private void cmbTenBan_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void cbTenDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maloai = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            FoodCategory selected = cb.SelectedItem as FoodCategory;
            maloai = selected.Maloai;

            LoadFoodListByCategoryID(maloai);

        }



        private void fGoiMon_Load(object sender, EventArgs e)
        {

        }

        private void cbTenThucAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Food food = cb.SelectedItem as Food;
            int gia = food.Gia;
            txtGia.Text = gia.ToString();

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddfood_Click(object sender, EventArgs e)
        {

            int mathucan = (cbTenThucAn.SelectedItem as Food).Mathucan;
            int mahoadon = BillDAO.Instance.GetIdBillByCheckStatusTable(Maban);
            TableDAO.Instance.UpdateStatusById(Maban);


            int soluong = (int)nmSoluong.Value;
            if (soluong <= 0)
            {
                MessageBox.Show("Số lượng món tối thiểu là 1");
                return;
            }
            //Khi bàn chưa có hoá đơn
            if (mahoadon == -1)
            {
                BillDAO.Instance.InsertBill(Maban);
                //  Tạo hoá đơn mới cho bàn
                mahoadon = BillDAO.Instance.GetMaxIDBill();
                BillDAO.Instance.UpdateDayOrder(mahoadon);
                if (BillInfoDAO.Instance.InsertBillInfo
                    (mahoadon, mathucan, soluong) == true)
                {
                    MessageBox.Show("Thêm thành công");
                }


            }
            //Khi bàn đã có hoá đơn
            else
            {
                if (BillInfoDAO.Instance.InsertBillInfo(mahoadon, mathucan, soluong) == true)
                {

                    MessageBox.Show("Thêm thành công");
                }
            }


        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTenBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameTable_TextChanged(object sender, EventArgs e)
        {

        }

        private void fOrder_Load(object sender, EventArgs e)
        {

        }
    }

}

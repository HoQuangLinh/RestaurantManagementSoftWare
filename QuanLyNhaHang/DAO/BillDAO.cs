
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }


        /*
          Chú thích hàm
          Sử dụng câu truy vấn bên dưới để lấy ra thông tin hoá đơn có trạng thái là chưa
            thanh toán theo mã bàn,sau đó trả về mã hoá đơn của bàn đó


         */
        public int GetIdBillByCheckStatusTable(int maban)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM HOADON " +
                "WHERE MABAN = " + maban + " AND TRANGTHAI =N'Chưa thanh toán'");


            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Mahoadon;
            }

            return -1;
        }
        public DataRow GetInforBillByIdTable(int maban)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HOADON " +
               "WHERE MABAN = " + maban + " AND TRANGTHAI =N'Chưa thanh toán'");
            if(data.Rows.Count>0)
            {
                return data.Rows[0];
            }
            return null;
        }
        public bool InsertBill(int maban)
        {
            string query = "insert into HOADON(MABAN)"
                         + "values (" + maban + ")";
            int x=DataProvider.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(MAHOADON) FROM HOADON");
            }
            catch
            {
                return 1;
            }
        }
        public bool Checkout(int mahoadon)
        {
            string query = "Update HOADON set TRANGTHAI=N'Đã thanh toán'"
                + "where mahoadon=" + mahoadon;
            
            int x = DataProvider.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;//Đã thanh toán
            return false;


        }
        public bool UpdateBill(int mahoadon,DateTime ngaythanhtoan,int tongtien)
        {
            string query = "Update HOADON set NGAYTHANHTOAN='" + ngaythanhtoan
                + "',TONGTIEN=" + tongtien
                + " where MAHOADON=" + mahoadon;
            int x = DataProvider.Instance.ExecuteNonQuery(query);
            if (x > 0) return true; //Update Bill thanh cong
            return false; //Update that bai
        }
        public bool IsExistBill(int maban)
        {
            string query = "select count(NGAYTHANHTOAN) "
                          + "from HOADON "
                           + "where MABAN =" + maban
                    + " and TRANGTHAI=N'Chưa thanh toán'";
            
            int x = DataProvider.Instance.ExecuteScalar(query);
                 if (x > 0) return true; //Hoá đơn đã được lưu
                 return false;   //Hoá đơn chưa được lưu
        }
        public DataTable GetBillByDate(string date)
        {
            DataTable data = new DataTable();
            string query = "select MAHOADON as N'Mã hoá đơn'," +
                "MABAN as N'Mã bàn',TRANGTHAI as N'Trạng thái'," +
                "TONGTIEN as N'Tổng tiền'" +
                " from HOADON where NGAYTHANHTOAN='" +
               date+"'";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;

        }
        public DataTable GetListHistoryMenusById(int mahoadon)
        {
            string query = "select ta.TENTHUCAN as N'Tên thức ăn',sum(ct.SOLUONG) as N'Số lượng'," +
                "sum(ta.GIA) as N'Giá',sum(ct.SOLUONG*ta.GIA) as N'Thành tiền'" +
                " from THUCAN as ta,CHITIETHOADON as ct,HOADON as hd " +
                "where ta.MATHUCAN=ct.MATHUCAN and ct.MAHOADON=hd.MAHOADON" +
                " and hd.MAHOADON=" + mahoadon+" Group by ta.TENTHUCAN" ;
            
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public DataTable SearchBillByIdTable(int maban)
        {
            DataTable data = new DataTable();
            string query = "Select MAHOADON as N'Mã hoá đơn'," +
                "MABAN as N'Mã bàn',TRANGTHAI as N'Trạng thái'," +
                "TONGTIEN as N'Tổng tiền' " +
                "from HOADON where MABAN= " + maban + " and TRANGTHAI=N'Đã thanh toán'";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;

        }
        public int GetCountBillToDay()
        {
            string query = "select count(MAHOADON) from HOADON where NGAYGOIMON='" +
                DateTime.Now.ToShortDateString() + "'";
            int count = DataProvider.Instance.ExecuteScalar(query);
            return count;
        }
        public void UpdateDayOrder(int mahoadon)
        {
            string query = "Update HOADON set NGAYGOIMON='" +
                DateTime.Now.ToShortDateString() +
                "' where MAHOADON=" + mahoadon;
              DataProvider.Instance.ExecuteNonQuery(query);
            
        }
    }
    
}
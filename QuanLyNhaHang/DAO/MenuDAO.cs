using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace QuanLyNhaHang
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        private MenuDAO() { }
        public static MenuDAO Instance
        {
            get
            {
                if (instance == null) instance = new MenuDAO();
                return instance;
            }
        }
        public List<Menu> GetListMenusById(int MaBan)
        {
            string query = "select ta.TENTHUCAN as N'Tên thức ăn',ct.SOLUONG as N'Số lượng'," +
                "ta.GIA as N'Giá',ct.SOLUONG*ta.GIA as N'Thành tiền'" +
                " from THUCAN as ta,CHITIETHOADON as ct,HOADON as hd " +
                "where ta.MATHUCAN=ct.MATHUCAN and ct.MAHOADON=hd.MAHOADON" +
                " and hd.MABAN="+MaBan+" and hd.TRANGTHAI=N'Chưa thanh toán'";
            List<Menu> menus = new List<Menu>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in data.Rows)
            {
                Menu menu = new Menu(dataRow);
          
                menus.Add(menu);

            }
            return menus;
        }
        public DataTable LoadBillByIdTable(int Maban)
        {
            DataTable data = new DataTable();
            string query = "select ta.TENTHUCAN as N'Tên món ăn',sum(ct.SOLUONG) as N'Số lượng'," +
                "sum(ta.GIA) as N'Giá',sum(ct.SOLUONG*ta.GIA) as N'Thành tiền'" +
                " from THUCAN as ta,CHITIETHOADON as ct,HOADON as hd " +
                "where ta.MATHUCAN=ct.MATHUCAN and ct.MAHOADON=hd.MAHOADON" +
                " and hd.MABAN=" + Maban + " and hd.TRANGTHAI=N'Chưa thanh toán'" +
                " group by TA.TENTHUCAN";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

    }
}

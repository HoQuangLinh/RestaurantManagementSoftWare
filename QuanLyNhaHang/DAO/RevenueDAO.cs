using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

namespace QuanLyNhaHang
{
    public class RevenueDAO
    {
        private static RevenueDAO instance;
        public static RevenueDAO Instance
        {
            get { if (instance == null) instance = new RevenueDAO(); return RevenueDAO.instance; }
            private set { RevenueDAO.instance = value; }
        }

        private RevenueDAO() { }
        public DataTable LoadRevenue_ByDay(string fromDate, string toDate, int selectRows, int exceptRows)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT DAY(NGAYTHANHTOAN) as N'Ngày', MONTH(NGAYTHANHTOAN) as N'Tháng', YEAR(NGAYTHANHTOAN) as N'Năm', "
                                + "sum(TONGTIEN) as N'Doanh thu' from HOADON where TONGTIEN > 0 "
                                + "AND NGAYTHANHTOAN >= '" + fromDate + "' AND NGAYTHANHTOAN <= '" + toDate + "' "
                                + "group by DAY(NGAYTHANHTOAN), MONTH(NGAYTHANHTOAN), YEAR(NGAYTHANHTOAN) "
                                + "order by DAY(NGAYTHANHTOAN), MONTH(NGAYTHANHTOAN), YEAR(NGAYTHANHTOAN) asc) "
                                + "select top " + selectRows + " * from RevenueShow except select top " + exceptRows + " * from RevenueShow;";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadRevenue_ByMonth(string fromDate, string toDate, int selectRows, int exceptRows)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT MONTH(NGAYTHANHTOAN) as N'Tháng', YEAR(NGAYTHANHTOAN) as N'Năm', "
                                + "sum(TONGTIEN) as N'Doanh thu' from HOADON where TONGTIEN > 0 "
                                + "AND MONTH(NGAYTHANHTOAN) >= '" + fromDate + "' AND MONTH(NGAYTHANHTOAN) <= '" + toDate + "' "
                                + "group by MONTH(NGAYTHANHTOAN), YEAR(NGAYTHANHTOAN) "
                                + "order by MONTH(NGAYTHANHTOAN), YEAR(NGAYTHANHTOAN) asc) "
                                + "select top " + selectRows + " * from RevenueShow except select top " + exceptRows + " * from RevenueShow;";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadRevenue_ByYear(string fromDate, string toDate, int selectRows, int exceptRows)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT YEAR(NGAYTHANHTOAN) as N'Năm', "
                                + "sum(TONGTIEN) as N'Doanh thu' from HOADON where TONGTIEN > 0 "
                                + "AND YEAR(NGAYTHANHTOAN) >= '" + fromDate + "' AND YEAR(NGAYTHANHTOAN) <= '" + toDate + "' "
                                + "group by YEAR(NGAYTHANHTOAN) "
                                + "order by YEAR(NGAYTHANHTOAN) asc) "
                                + "select top " + selectRows + " * from RevenueShow except select top " + exceptRows + " * from RevenueShow;";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public int GetNumBillList_ByDay(string fromDate, string toDate)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT DAY(NGAYTHANHTOAN) as N'Ngày', MONTH(NGAYTHANHTOAN) as N'Tháng', YEAR(NGAYTHANHTOAN) as N'Năm', "
                                + "sum(TONGTIEN) as N'Doanh thu' from HOADON where TONGTIEN > 0 "
                                + "AND NGAYTHANHTOAN >= '" + fromDate + "' AND NGAYTHANHTOAN <= '" + toDate + "' "
                                + "group by DAY(NGAYTHANHTOAN), MONTH(NGAYTHANHTOAN), YEAR(NGAYTHANHTOAN) "
                                + "order by DAY(NGAYTHANHTOAN), MONTH(NGAYTHANHTOAN), YEAR(NGAYTHANHTOAN) asc) "
                                + "select count(*) from RevenueShow;";
            int x = DataProvider.Instance.ExecuteScalar(query);
            return x;
        }
        public int GetNumBillList_ByMonth(string fromDate, string toDate)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT MONTH(NGAYTHANHTOAN) as N'Tháng', YEAR(NGAYTHANHTOAN) as N'Năm', "
                                + "sum(TONGTIEN) as N'Doanh thu' from HOADON where TONGTIEN > 0 "
                                + "AND MONTH(NGAYTHANHTOAN) >= '" + fromDate + "' AND MONTH(NGAYTHANHTOAN) <= '" + toDate + "' "
                                + "group by MONTH(NGAYTHANHTOAN), YEAR(NGAYTHANHTOAN) "
                                + "order by MONTH(NGAYTHANHTOAN), YEAR(NGAYTHANHTOAN) asc) "
                                + "select count(*) from RevenueShow;";
            int x = DataProvider.Instance.ExecuteScalar(query);
            return x;
        }
        public int GetNumBillList_ByYear(string fromDate, string toDate)
        {
            string query = ";with RevenueShow as (SELECT TOP 100 PERCENT YEAR(NGAYTHANHTOAN) as N'Năm', "
                                + "sum(TONGTIEN) as N'Doanh thu' from HOADON where TONGTIEN > 0 "
                                + "AND YEAR(NGAYTHANHTOAN) >= '" + fromDate + "' AND YEAR(NGAYTHANHTOAN) <= '" + toDate + "' "
                                + "group by YEAR(NGAYTHANHTOAN) "
                                + "order by YEAR(NGAYTHANHTOAN) asc) "
                                + "select count(*) from RevenueShow;";
            int x = DataProvider.Instance.ExecuteScalar(query);
            return x;
        }
        public int GetRevenueToDay()
        {
            string query = "select SUM(TONGTIEN) from HOADON where NGAYTHANHTOAN='" +
                DateTime.Now.ToShortDateString() + "'";
            int revenue = DataProvider.Instance.ExecuteScalar(query);
            return revenue;
        }

    }
}
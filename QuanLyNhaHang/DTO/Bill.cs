using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyNhaHang
{
    class Bill
    {
        int mahoadon;
        int maban;
        DateTime ngaycheckin;
        DateTime ngaycheckout;
        string trangthai;
        public Bill(DataRow row)
        {
            mahoadon = (int)row["MAHOADON"];
            maban = (int)row["MABAN"];
            trangthai = (string)row["TRANGTHAI"];
            try
            {
                ngaycheckin = (DateTime)row["NGAYCHECKIN"];
                ngaycheckout = (DateTime)row["NGAYCHECKOUT"];
            }
            catch
            { 
                    
            }
           

        }
       
        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public int Maban { get => maban; set => maban = value; }
        public DateTime Ngaycheckin { get => ngaycheckin; set => ngaycheckin = value; }
        public DateTime Ngaycheckout { get => ngaycheckout; set => ngaycheckout = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}

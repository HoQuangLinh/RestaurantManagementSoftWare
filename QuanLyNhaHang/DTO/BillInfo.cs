using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyNhaHang
{
    class BillInfo
    {
        int machitiet;
        int mahoadon;
        int mathucan;
        int soluong;
        public BillInfo(DataRow row)
        {
            machitiet = (int)row["MACHITIET"];
            mahoadon =(int) row["MAHOADON"];
            mathucan =(int) row["MATHUCAN"];
            soluong = (int)row["SOLUONG"];
        }
        public int Machitiet { get => machitiet; set => machitiet = value; }
        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public int Mathucan { get => mathucan; set => mathucan = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}

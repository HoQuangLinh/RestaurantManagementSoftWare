using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class FoodCategory
    {
        private int maloai;
        private string tenloai;

       public FoodCategory(DataRow row)
        {
            maloai =(int) row["MALOAI"];
            tenloai = (string)row["TENLOAI"];

        }
        public int Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        
    }
}

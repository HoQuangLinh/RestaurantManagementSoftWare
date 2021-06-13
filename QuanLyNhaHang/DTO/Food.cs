using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyNhaHang
{
    public class Food
    {
        private int mathucan;
        private int gia;
        private string tenthucan;
        private int maloai;
        public Food(DataRow row)
        {
            mathucan =(int) row["MATHUCAN"];
            gia = (int)row["GIA"];
            tenthucan = (string)row["TENTHUCAN"];
            maloai = (int)row["MALOAI"];
        }
        public int Mathucan { get => mathucan; set => mathucan = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Tenthucan { get => tenthucan; set => tenthucan = value; }
        public int Maloai { get => maloai; set => maloai = value; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class Table
    {
        private int maban;
        private string tenban;
        private string trangthai;
        public Table(DataRow data)
        {
            this.Maban = (int)data["MABAN"];
            this.Trangthai = (string)data["TRANGTHAI"];
            this.Tenban= (string)data["TENBAN"];

        }
        public Table() { }


        public int Maban { get => maban; set => maban = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}

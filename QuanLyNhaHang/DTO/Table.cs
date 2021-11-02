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
            this.Tenban = (string)data["TENBAN"];

        }
        public Table(int maban, string trangthai)
        {
            this.maban = maban;

            this.trangthai = trangthai;
        }


        public int Maban { get => maban; set => maban = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public static bool IsValidateSwitchTable(Table tablemoving, Table tablemovedto)
        {
            string[] listTrangThai = new String[] { "Trống", "Có người" };
            if (tablemoving == null || tablemovedto == null)
            {
                return false;
            }
            if (tablemoving.maban <= 0 | tablemovedto.maban <= 0)
            {
                return false;
            }
            if (Array.IndexOf(listTrangThai, tablemoving.trangthai) == -1)
            {
                return false;
            }
            if (Array.IndexOf(listTrangThai, tablemovedto.trangthai) == -1)
            {
                return false;
            }

            if (tablemoving.trangthai == "Trống")
            {
                return false;
            }
            if (tablemoving.maban == tablemovedto.maban)
            {

                return false;

            }

            return true;



        }
        public static bool IsValidateMergeTable(Table tablemoving, Table tablemovedto)
        {
            string[] listTrangThai = new String[] { "Trống", "Có người" };
            if (tablemoving == null || tablemovedto == null)
            {
                return false;
            }
            if (tablemoving.maban <= 0 | tablemovedto.maban <= 0)
            {
                return false;
            }
            if (Array.IndexOf(listTrangThai, tablemoving.trangthai) == -1)
            {
                return false;
            }
            if (Array.IndexOf(listTrangThai, tablemovedto.trangthai) == -1)
            {
                return false;
            }

            if (tablemoving.trangthai == "Trống")
            {
                return false;
            }
            if (tablemoving.maban == tablemovedto.maban)
            {

                return false;

            }

            return true;
        }
    }
}

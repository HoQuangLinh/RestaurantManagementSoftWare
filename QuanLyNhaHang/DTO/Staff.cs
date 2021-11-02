using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace QuanLyNhaHang
{
    public class Staff
    {
        int manhanvien;
        string gioitinh;
        string hoten;
        string ngaysinh;
        string chucvu;
        public Staff() { }
        public Staff(string manhanvien, string gioitinh, string hoten,
            string ngaysinh, string chucvu)

        {
            try
            {
                this.manhanvien = Convert.ToInt32(manhanvien);
                this.gioitinh = gioitinh;
                this.hoten = hoten;
                this.ngaysinh = ngaysinh;
                this.chucvu = chucvu;
            }
            catch (FormatException e)
            {


            }

        }

        public bool CompareStaff(Staff staff)
        {
            if (this == null)
            {
                return false;
            }
            if (manhanvien == staff.manhanvien &&
                gioitinh == staff.gioitinh && hoten == staff.hoten
                && ngaysinh == staff.ngaysinh && chucvu == staff.chucvu)
            {
                return true;
            }
            return false;
        }
        public static bool IsValidateInsertStaff(string manhanvien, 
            string gioitinh, string hoten,
            string ngaysinh, string chucvu)
        {
            DateTime dt;
            string[] listGioitinh = new String[] { "Nam", "Nữ", "Khác", "nam", "nữ", "khác" };
            bool validNgaySinh = DateTime.TryParseExact(ngaysinh, "d", new CultureInfo("en-US"), DateTimeStyles.None, out dt);
            if (String.IsNullOrEmpty(manhanvien) ||
                String.IsNullOrEmpty(hoten) ||
                String.IsNullOrEmpty(ngaysinh) || String.IsNullOrEmpty(chucvu))
            {
                return false;
            }
            //Kiểm tra giới tính có nằm trong list giới tính không
            if (Array.IndexOf(listGioitinh, gioitinh) == -1)
            {
                return false;
            }

            if (manhanvien.Length > 100 || hoten.Length > 100 || chucvu.Length > 100 || gioitinh.Length > 10)
            {
                return false;
            }
            if (!validNgaySinh)
            {
                return false;
            }

            return true;
        }
        public static Staff ValidateUpdateStaff(string manhanvien,
                string gioitinh, string hoten,
            string ngaysinh, string chucvu)
        {
            DateTime dt;
            string[] listGioitinh = new String[] { "Nam", "Nữ", "Khác", "nam", "nữ", "khác" };
            bool validNgaySinh = DateTime.TryParseExact(ngaysinh, "d", new CultureInfo("en-US"), DateTimeStyles.None, out dt);
            if (
                String.IsNullOrEmpty(hoten) ||
                String.IsNullOrEmpty(ngaysinh) || String.IsNullOrEmpty(chucvu))
            {
                return null;
            }
            //Kiểm tra giới tính có nằm trong list giới tính không
            if (Array.IndexOf(listGioitinh, gioitinh) == -1)
            {
                return null;
            }
            //Kiểm tra độ dài họ tên với chức vụ có nhỏ hơn 100 hay không
            if (hoten.Length > 100 || chucvu.Length > 100)
            {
                return null;
            }
            if (!validNgaySinh)
            {
                return null;
            }
            try
            {


                if (Convert.ToInt32(manhanvien) < 0)
                {
                    return null;
                }

                return new Staff()
                {
                    manhanvien = Convert.ToInt32(manhanvien),
                    gioitinh = gioitinh,
                    hoten = hoten,
                    ngaysinh = ngaysinh,
                    chucvu = chucvu,

                };

            }
            catch (FormatException ex)
            {
                return null;
                throw new Exception("Mã nhân viên là số");
            }


        }
        public static bool ValidateDeleteStaff(List<Staff> staffs, string manhanvien)
        {
            //Tìm index của nhân viên theo mã nhân viên nếu ko có trả về -1
            try
            {
                int index = staffs.FindIndex(value => value.manhanvien == Convert.ToInt32(manhanvien));
                if (index == -1)
                {
                    return false;
                }
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }


        }

    }
}

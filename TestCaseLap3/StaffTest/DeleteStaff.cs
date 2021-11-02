using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaHang;


namespace TestCaseLap3;
[TestClass]
public class DeleteStaff
{
    //Perform test for delete Staff
    
    //[TestMethod]
    public void IsValidateDeleteStaff()
    {
        bool actual;
            try
        {
            var staff1 = new Staff("1a", "Nam", "Hồ Quang Linh", "1/2/2001", "nhân viên bán hàng");
            var staff2 = new Staff("2", "Nam", "Hồ Quang Linh", "1/2/2001", "nhân viên bán hàng");
            var staff3 = new Staff("3", "Nam", "Hồ Quang Linh", "1/2/2001", "nhân viên bán hàng");
            List<Staff> staffs = new List<Staff> { staff1, staff2, staff3 };
            string manhanvien = "1";
             actual = Staff.ValidateDeleteStaff(staffs,manhanvien);
        }
       catch(FormatException e)
        {
            actual = false;
        }
      
        
        var expected = false;
       
        Assert.AreEqual(expected, actual);

    }
   

}
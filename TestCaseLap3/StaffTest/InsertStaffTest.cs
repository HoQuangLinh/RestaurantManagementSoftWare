using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaHang;


namespace TestCaseLap3;
[TestClass]
public class InsertStaff
{
    //Perform test for login method
    /*
     This method check if user exist on database and 
     */
    [TestMethod]
    public void IsValidateInsertStaff_UTCID01()
    {
        string manhanvien = "";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = "a";
        
        var actual = Staff.IsValidateInsertStaff(manhanvien,gioitinh,hoten,ngaysinh,chucvu);
        var expected = false;
        Assert.AreEqual(expected,actual);

    }
    [TestMethod]
    public void IsValidateInsertStaff_UTCID02()
    {
        string manhanvien = "11";
        string gioitinh = "nam";
        string hoten = "";
        string ngaysinh = "03/30/2001";
        string chucvu = "a";

        var actual = Staff.IsValidateInsertStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        var expected = false;
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void IsValidateInsertStaff_UTCID03()
    {
        string manhanvien = "11";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "";
        string chucvu = "a";

        var actual = Staff.IsValidateInsertStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        var expected = false;
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void IsValidateInsertStaff_UTCID04()
    {
        string manhanvien = "11";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = "";

        var actual = Staff.IsValidateInsertStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        var expected = false;
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void IsValidateInsertStaff_UTCID05()
    {
        string manhanvien = "11";
        string gioitinh = "abc";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = "a";

        var actual = Staff.IsValidateInsertStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        var expected = false;
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void IsValidateInsertStaff_UTCID06()
    {
        string manhanvien = new string('1',101);
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = "a";

        var actual = Staff.IsValidateInsertStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        var expected = false;
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void IsValidateInsertStaff_UTCID07()
    {
        string manhanvien = "11";
        string gioitinh = "nam";
        string hoten = new String('a',101);
        string ngaysinh = "03/30/2001";
        string chucvu = "a";

        var actual = Staff.IsValidateInsertStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        var expected = false;
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void IsValidateInsertStaff_UTCID08()
    {
        string manhanvien = "11";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = new String('a',101);

        var actual = Staff.IsValidateInsertStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        var expected = false;
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void IsValidateInsertStaff_UTCID09()
    {
        string manhanvien = "11";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "303/303/2001";
        string chucvu = "a";

        var actual = Staff.IsValidateInsertStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        var expected = false;
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void IsValidateInsertStaff_UTCID10()
    {
        string manhanvien = "11";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = "a";

        var actual = Staff.IsValidateInsertStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        var expected = true;
        Assert.AreEqual(expected, actual);

    }


}
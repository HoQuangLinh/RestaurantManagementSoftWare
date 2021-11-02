using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaHang;


namespace TestCaseLap3;
[TestClass]
public class UpdateStaff
{
    //Perform test for login method
    /*
     This method check if user exist on database and 
     */
    [TestMethod]
    public void ValidateUpdateStaff_UTCID01()
    {
        string manhanvien = "1";
        string gioitinh = "nam";
        string hoten = "";
        string ngaysinh = "";
        string chucvu = "";
        
        var staff = new Staff(manhanvien,gioitinh,hoten,ngaysinh,chucvu);
         Staff expected = null;
        var actual = Staff.ValidateUpdateStaff(manhanvien,gioitinh,hoten,ngaysinh,chucvu);

        if (!object.ReferenceEquals(expected, null))
        {
            Assert.IsTrue(expected.CompareStaff(actual));

        }
        else {
            Assert.IsTrue(object.ReferenceEquals(expected, actual));
        }

    }

    [TestMethod]
    public void ValidateUpdateStaff_UTCID02()
    {
        string manhanvien = "1";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "";
        string chucvu = "";

        var staff = new Staff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        Staff expected = null;
        var actual = Staff.ValidateUpdateStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);

        if (!object.ReferenceEquals(expected, null))
        {
            Assert.IsTrue(expected.CompareStaff(actual));

        }
        else
        {
            Assert.IsTrue(object.ReferenceEquals(expected, actual));
        }

    }
    [TestMethod]
    public void ValidateUpdateStaff_UTCID03()
    {
        string manhanvien = "1";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = "";

        var staff = new Staff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        Staff expected =null;
        var actual = Staff.ValidateUpdateStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);

        if (!object.ReferenceEquals(expected, null))
        {
            Assert.IsTrue(expected.CompareStaff(actual));

        }
        else
        {
            Assert.IsTrue(object.ReferenceEquals(expected, actual));
        }

    }
    [TestMethod]
    public void ValidateUpdateStaff_UTCID04()
    {
        string manhanvien = "1";
        string gioitinh = "abc";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = "a";

        var staff = new Staff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        Staff expected = null;
        var actual = Staff.ValidateUpdateStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);

        if (!object.ReferenceEquals(expected, null))
        {
            Assert.IsTrue(expected.CompareStaff(actual));

        }
        else
        {
            Assert.IsTrue(object.ReferenceEquals(expected, actual));
        }

    }
    [TestMethod]
    public void ValidateUpdateStaff_UTCID05()
    {
        string manhanvien = "1";
        string gioitinh = "nam";
        string hoten = new String('a', 101);
        string ngaysinh = "03/30/2001";
        string chucvu = "a";

        var staff = new Staff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        Staff expected = null;
        var actual = Staff.ValidateUpdateStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);

        if (!object.ReferenceEquals(expected, null))
        {
            Assert.IsTrue(expected.CompareStaff(actual));

        }
        else
        {
            Assert.IsTrue(object.ReferenceEquals(expected, actual));
        }

    }
    [TestMethod]
    public void ValidateUpdateStaff_UTCID06()
    {
        string manhanvien = "1";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = new String('a',101);

        var staff = new Staff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        Staff expected = null;
        var actual = Staff.ValidateUpdateStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);

        if (!object.ReferenceEquals(expected, null))
        {
            Assert.IsTrue(expected.CompareStaff(actual));

        }
        else
        {
            Assert.IsTrue(object.ReferenceEquals(expected, actual));
        }

    }
    [TestMethod]
    public void ValidateUpdateStaff_UTCID07()
    {
        string manhanvien = "1";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "303/320abc";
        string chucvu = "a";

        var staff = new Staff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        Staff expected = null;
        var actual = Staff.ValidateUpdateStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);

        if (!object.ReferenceEquals(expected, null))
        {
            Assert.IsTrue(expected.CompareStaff(actual));

        }
        else
        {
            Assert.IsTrue(object.ReferenceEquals(expected, actual));
        }

    }
    [TestMethod]
    public void ValidateUpdateStaff_UTCID08()
    {
        string manhanvien = "abc";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = "a";

        var staff = new Staff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        Staff expected = null;
        var actual = Staff.ValidateUpdateStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);

        if (!object.ReferenceEquals(expected, null))
        {
            Assert.IsTrue(expected.CompareStaff(actual));

        }
        else
        {
            Assert.IsTrue(object.ReferenceEquals(expected, actual));
        }

    }
    [TestMethod]
    public void ValidateUpdateStaff_UTCID09()
    {
        string manhanvien = "-1";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = "a";

        var staff = new Staff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        Staff expected = null;
        var actual = Staff.ValidateUpdateStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);

        if (!object.ReferenceEquals(expected, null))
        {
            Assert.IsTrue(expected.CompareStaff(actual));

        }
        else
        {
            Assert.IsTrue(object.ReferenceEquals(expected, actual));
        }

    }
    [TestMethod]
    public void ValidateUpdateStaff_UTCID10()
    {
        string manhanvien = "1";
        string gioitinh = "nam";
        string hoten = "a";
        string ngaysinh = "03/30/2001";
        string chucvu = "a";

        var staff = new Staff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);
        Staff expected = staff;
        var actual = Staff.ValidateUpdateStaff(manhanvien, gioitinh, hoten, ngaysinh, chucvu);

        if (!object.ReferenceEquals(expected, null))
        {
            Assert.IsTrue(expected.CompareStaff(actual));

        }
        else
        {
            Assert.IsTrue(object.ReferenceEquals(expected, actual));
        }

    }



}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaHang;


namespace TestCaseLap3;
[TestClass]
public class InsertFood
{
    //Perform test for login method
    /*
     This method check if user exist on database and 
     */
   // [TestMethod]
    public void IsValidateInsertFood_1()
    {

        var expected = true;
        var actual = Food.IsValidateInsertFood("1", "110000", "12", "Cá rô chiên");
        Assert.AreEqual(expected, actual);

    }
   // [TestMethod]
    public void IsValidateInsertFood_2()
    {
        var actual = Food.IsValidateInsertFood("1a", "10000", "12", "Cá rô chiên");
        var expected = false;
        Assert.AreEqual(expected, actual);
    }
   // [TestMethod]
    public void IsValidateInsertFood_3()
    {
        var actual = Food.IsValidateInsertFood("1", "10000a", "12", "Cá rô chiên");
        var expected = false;
        Assert.AreEqual(expected, actual);
    }
   




}
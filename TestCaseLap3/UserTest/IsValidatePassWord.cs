using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaHang;


namespace TestCaseLap3;
[TestClass]
public class IsValidatePassword
{
    //Perform test for login method
    /*
     This method check if user exist on database and 
     */
    [TestMethod]
    public void IsValidatePassWord_UTCID01()
    {
       
        var password = "1";
        var expected = true;
       

        var actual = User.IsValidatePassWord(password);

        //Assert
        Assert.AreEqual(expected, actual);

    }
    
    [TestMethod]
    public void IsValidatePassWord_UTCID02()
    {

        var password = "";
        var expected = false;

        var actual = User.IsValidatePassWord(password);

        //Assert
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void IsValidatePassWord_UTCID03()
    {

       string password = null;
        var expected = false;

        var actual = User.IsValidatePassWord(password);

        //Assert
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void IsValidatePassWord_UTCID04()
    {
        string password = new String('1', 101);
        var expected = false;
        var actual = User.IsValidatePassWord(password);

        //Assert
        Assert.AreEqual(expected, actual);
    }




}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaHang;


namespace TestCaseLap3;
[TestClass]
public class IsValidateUserName
{
    //Perform test for login method
    /*
     This method check if user exist on database and 
     */
    [TestMethod]
    public void IsValidateUserName_UTCID01()
    {
        string username=null ;
        var actual = User.IsValidateUserName(username);
        var expected = false;
        //Assert
        Assert.AreEqual(actual, expected);

    }
    [TestMethod]
    public void IsValidateUserName_UTCID02()
    {
        var username = "";
        var actual = User.IsValidateUserName(username);
        var expected = false;
        //Assert
        Assert.AreEqual(actual, expected);

    }
    [TestMethod]
    public void IsValidateUserName_UTCID03()
    {
        var username = "aáda";
       
        var expected= false;
        var actual = User.IsValidateUserName(username);
       
        //Assert
        Assert.AreEqual(actual, expected);

      
    }
    [TestMethod]
    public void IsValidateUserName_UTCID04()
    {
        var username = new String('a', 101);

        var expected = false;
        var actual = User.IsValidateUserName(username);

        //Assert
        Assert.AreEqual(actual, expected);

    }
    [TestMethod]
    public void IsValidateUserName_UTCID05()
    {
        var username = "admin";

        var expected = true;
        var actual = User.IsValidateUserName(username);

        //Assert
        Assert.AreEqual(actual, expected);

    }




}
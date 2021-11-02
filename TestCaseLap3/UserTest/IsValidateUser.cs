using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaHang;


namespace TestCaseLap3;
[TestClass]
public class IsValidateUser
{
    //Check user login
    //Test case 1
    [TestMethod]
    public void IsValidateUser_UTCID01()
    {
        var username = "";
        var password = "";
        var isAdmin = true;
        var expected = false;

        var actual = User.IsValidateUser(username, password, isAdmin);

        //Assert
        Assert.AreEqual(expected, actual, "user name or password is null or empty");

    }
    [TestMethod]
    public void IsValidateUser_UTCID02()
    {
        var username = "";
        var password = "1";
        var isAdmin = false;
        var expected = false;

        var actual = User.IsValidateUser(username, password, isAdmin);

        //Assert
        Assert.AreEqual(expected, actual, "user name or password is null or empty");

    }
    [TestMethod]
    public void IsValidateUser_UTCID03()
    {
        var username = "aáda";
        var password = "";
        var isAdmin = true;
        var expected = false;

        var actual = User.IsValidateUser(username, password, isAdmin);

        //Assert
        Assert.AreEqual(expected, actual, "user name or password is null or empty");


    }
    [TestMethod]
    public void IsValidateUser_UTCID04()
    {
        var username = "aáda";
        var password = "1";
        var isAdmin = false;
        var expected = false;

        var actual = User.IsValidateUser(username, password, isAdmin);

        //Assert
        Assert.AreEqual(expected, actual, "user name contains vietkey");


    }
    [TestMethod]
    public void IsValidateUser_UTCID05()
    {
        string username = new string('a', 101);
        var password = "";
        var isAdmin = true;
        var expected = false;

        var actual = User.IsValidateUser(username, password, isAdmin);

        //Assert
        Assert.AreEqual(expected, actual, "user name is too long");

    }
    [TestMethod]
    public void IsValidateUser_UTCID06()
    {
        string username = new string('a', 101);

        var password = "";
        var isAdmin = false;
        var expected = false;

        var actual = User.IsValidateUser(username, password, isAdmin);

        //Assert
        Assert.AreEqual(expected, actual, "user name is too long");

    }
    [TestMethod]
    public void IsValidateUser_UTCID07()
    {
        string username = "admin";

        var password = "";
        var isAdmin = false;
        var expected = false;

        var actual = User.IsValidateUser(username, password, isAdmin);

        //Assert
        Assert.AreEqual(expected, actual, "user name or password is null or empty");

    }
    [TestMethod]
    public void IsValidateUser_UTCID08()
    {
        string username = "admin";

        var password = "1";
        var isAdmin = false;
        var expected = false;

        var actual = User.IsValidateUser(username, password, isAdmin);

        //Assert
        Assert.AreEqual(expected, actual, "Invalid username or password");

    }
    [TestMethod]
    public void IsValidateUser_UTCID09()
    {
        string username = "admin";

        var password = "1";
        var isAdmin = true;
        var expected = true;

        var actual = User.IsValidateUser(username, password, isAdmin);

        //Assert
        Assert.AreEqual(expected, actual, "Success");

    }
    [TestMethod]
    public void IsValidateUser_UTCID10()
    {
        string username = "staff";

        var password = "1";
        var isAdmin = false;
        var expected = true;

        var actual = User.IsValidateUser(username, password, isAdmin);

        //Assert
        Assert.AreEqual(expected, actual, "Success");

    }
    [TestMethod]
    public void IsValidateUser_UTCID11()
    {
        string username = "staff";

        var password = "1";
        var isAdmin = true;
        var expected = false;

        var actual = User.IsValidateUser(username, password, isAdmin);
        //Assert
        Assert.AreEqual(expected, actual, "Invalid username or password");

    }
}
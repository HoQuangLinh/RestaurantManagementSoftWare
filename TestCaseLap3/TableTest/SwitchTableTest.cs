using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaHang;


namespace TestCaseLap3;
[TestClass]
public class SwitchTable
{
    //Perform test for login method
    /*
     This method check if user exist on database and 
     */
   // [TestMethod]
  
    public void Is_Validate_SwitchTable_1_2()
    {
        var tablemoving = new Table(1, "Trống");
        var tablemovedTo = new Table(2, "Có người");

        var expected = false;
        var actual = Table.IsValidateSwitchTable(tablemoving, null);
        Assert.AreEqual(expected, actual);

    }



}
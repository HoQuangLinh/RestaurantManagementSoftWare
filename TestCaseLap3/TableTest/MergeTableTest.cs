using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaHang;


namespace TestCaseLap3;
[TestClass]
public class MergeTable
{
    //Perform test for login method
    /*
     This method check if user exist on database and 
     */
   // [TestMethod]
    
    public void Is_Validate_MergeTable_1_1()
    {
        var tablemoving = new Table(1, "Có người");
        var tablemovedTo = new Table(1, "Có người");

        var expected = false;
        var actual = Table.IsValidateMergeTable(null, null);
        Assert.AreEqual(expected, actual);

    }
   
   



}
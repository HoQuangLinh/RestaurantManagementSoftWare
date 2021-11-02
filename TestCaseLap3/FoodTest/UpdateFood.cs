using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaHang;


namespace TestCaseLap3;
[TestClass]
public class UpdateFood
{
    //Perform test for login method
    /*
     This method check if user exist on database and 
     */
    //[TestMethod]
    public void IsValidateUpdateFood()
    {
        string mathucan = "1";
        string gia = "100a0";
        string maloai = "12";
        string tenthucan = "Bánh canh cua";


        var food = new Food(mathucan, gia, maloai,tenthucan);
        
        Food expected = null;
        var actual = Food.ValidateUpdateFood(mathucan,gia,maloai,tenthucan);
      
        if (!object.ReferenceEquals(expected, null))
        {
            Assert.IsTrue(expected.CompareFood(actual));

        }
        else
        {
            Assert.IsTrue(object.ReferenceEquals(expected, actual));
        }

    }




}
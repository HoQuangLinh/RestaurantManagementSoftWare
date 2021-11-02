using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyNhaHang;


namespace TestCaseLap3;
[TestClass]
public class DeleteFood
{
    //Perform test for delete Food

   // [TestMethod]
    public void IsValidateDeleteFood()
    {
        bool actual;
        try
        {
            var food1 = new Food("1", "10000", "12", "1");
            var food2 = new Food("2", "10000", "12", "1");
            var food3 = new Food("3", "10000", "12", "1");
            List<Food> foods = new List<Food> { food1, food2, food3 };
            var mathucan = "1";
            var result = Food.ValidateDeleteFood(foods, mathucan);
            actual = Food.ValidateDeleteFood(foods, mathucan);
        }
        catch (Exception ex)
        {
            actual = false;
        }
        var expected = true;
        Assert.AreEqual(expected, actual);

    }
   




}
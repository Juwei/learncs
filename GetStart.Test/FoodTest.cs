using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetStart.Test
{
    [TestClass]
    public class FoodTest
    {
        [TestMethod]
        public void FoodTest_Normal()
        {
            Food apple = new Food();
            apple.Name = "apple";
            apple.Price = 15;
            Assert.AreEqual("apple:15", apple.ToString());
            Assert.AreEqual("[Extension Print] apple:15", apple.ToStringExt());
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetStart.Test
{
    [TestClass]
    public class FoodTest
    {
        [TestMethod]
        public void FoodTest_Normal()
        {
            Food Apple = new Food();
            Apple.Name = "Apple";
            Apple.Price = 15;
            Assert.AreEqual("Apple:15", Apple.ToString());
        }
    }
}
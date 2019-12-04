using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetStart.Test
{
    internal class MathOps
    {
        public static double MultiplyByTwo(double value) => value * 2;
        public static double Square(double value) => value * value;
    }

    [TestClass]
    public class HelloDelegateTest
    {
        [TestMethod]
        public void HelloDelegateTest_normal()
        {
            Assert.AreEqual("Ops is MultiplyByTwo, Value is 2, result of operation is 4", 
                HelloDelegate.ProcessAndDispalyDoubleNumber(MathOps.MultiplyByTwo, 2.0));
            Assert.AreEqual("Ops is Square, Value is 3.15, result of operation is 9.9225", 
                HelloDelegate.ProcessAndDispalyDoubleNumber(MathOps.Square, 3.15));
        }
    }
}

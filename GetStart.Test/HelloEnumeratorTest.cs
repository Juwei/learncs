using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetStart.Test
{
    [TestClass]
    public class HelloEnumeratorTest
    {
        [TestMethod]
        public void HelloEnumerator_normal()
        {
            TestHelloEnumerator(1000, 1001);
            TestHelloEnumerator(1001, 1000);
            TestHelloEnumerator(1000, 1000);
        }

        private void TestHelloEnumerator(int maxIter1, int maxIter2)
        {
            HelloEnumerator enumerator = new HelloEnumerator(maxIter1);
            foreach (var item in enumerator.GetEnumerator())
            {
                if (enumerator.GetCounter() % 2 == 1){
                    Assert.AreEqual("Hello", item);
                }
                else
                {
                    Assert.AreEqual("Enumerator", item);
                }
                if (enumerator.GetCounter() == maxIter2)
                {
                    break; // will not execute if the yield break condition in HellowEnumerator is less than this condition
                }
            }
            Assert.AreEqual(Math.Min(maxIter1, maxIter2), enumerator.GetCounter());
        }
    }
}

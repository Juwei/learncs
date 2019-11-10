using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetStart.Test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void PersonTest_Normal()
        {
            Person me = new Person();
            me.FirstName = "Juwei";
            me.LastName = "Shi";
            Assert.AreEqual("Juwei\tShi", me.ToString());
            Assert.AreEqual(8, me.LetterCount());
        }
    }
}

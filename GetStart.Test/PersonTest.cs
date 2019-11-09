using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetStart.Test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void PersonTest_Normal()
        {
            Person Me = new Person();
            Me.FirstName = "Juwei";
            Me.LastName = "Shi";

            Assert.AreEqual("Juwei\tShi", Me.ToString());
        }
    }
}

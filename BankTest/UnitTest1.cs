using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ConsoleApp82.Program;

namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double expected = 1195;
            BankAccount b1 = new BankAccount(1200, "Aziz");
            b1.Remove(5);
            Assert.AreEqual(expected, b1.GetBalance());
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using web_app_test.Models;

namespace UnitTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestNewCustomer()
        {
            Customer c = new Customer(1, "pippo");
            Assert.AreEqual(1, c.Id);
            Assert.AreEqual("pippo", c.Name);
        }
    }
}

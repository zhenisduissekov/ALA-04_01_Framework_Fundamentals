using NUnit.Framework;
using Task1;

namespace OutputCustomerDataTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Joe","87913241", 123321)]
        [TestCase("Roegan", "+1(313)323 23 1", 999)]
        public void CreateAndOutput(string name, string contactphone, decimal revenue)
        {
            var a = new OutputCustomerData(name, revenue, contactphone);
           
            Assert.AreEqual(name, a.Name);
            Assert.AreEqual(revenue, a.Revenue);
            Assert.AreEqual(contactphone, a.ContactPhone);
        }

        [TestCase("Joe", "87913241", 123321, "A", "-Customer record: Joe, 87913241, 123,321.00")]
        [TestCase("Roegan", "+1(313)323 23 1", 999, "B", "-Customer record: +1(313)323 23 1")]
        [TestCase("Roegan", "+1(313)323 23 1", 999, "C", "-Customer record: Roegan, +1(313)323 23 1")]
        public void TestToString(string name, string contactphone, decimal revenue, string fmt, string result)
        {
            var a = new OutputCustomerData(name, revenue, contactphone);
            Assert.AreEqual(a.ToString(fmt), result);
        }
    }
}
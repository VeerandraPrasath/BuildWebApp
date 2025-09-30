using NUnit.Framework;
using BuildWebApp.Pages;
using NUnit.Framework.Legacy;

namespace BuildWebAppTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestMethod1()
        {
            var index = new IndexModel(null);
            var value = index.GetBusinessValue();
            var expectation = 5;
            ClassicAssert.AreEqual(expectation, value);
        }
    }
}

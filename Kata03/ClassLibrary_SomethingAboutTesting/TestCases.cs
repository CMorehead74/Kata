using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ClassLibraryTake01;

namespace ClassLibrary_SomethingAboutTesting
{
    [TestFixture]
    public class TestCases
    {
        [Test]
        public void TestCheckRuleSet()
        {
            ClassLibraryTake01.Main obj = new Main();
            var result = obj.CheckRuleSet("corey12345");
            Assert.That(result, Is.True);
        }
    }
}

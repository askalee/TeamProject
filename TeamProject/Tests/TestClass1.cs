using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Tests
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void Test1()
        {
            Assert.That(3 + 3, Is.EqualTo(6));
            Assert.That(1 - 1, Is.EqualTo(0));
            Assert.That("abc" + "d", Is.EqualTo("abcd"));
        }
    }
}

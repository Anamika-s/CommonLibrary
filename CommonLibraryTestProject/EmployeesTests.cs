using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibraryTestProject
{
    [TestFixture]
    internal class EmployeesTests
    {
        [Test]
        public void GetLeavesTest()
        {
           CommonLibrary.Employee employee = new CommonLibrary.Employee();
            string actual = employee.GetLeaves(13);
            Assert.AreEqual("You will get 20 days", actual);

        }

        [TestCase(10, "You will get 15 days")]
        [TestCase(2, "You will get 10 days")]
        [TestCase(15, "You will get 20 days")]
        public void GetLeavesTests(int exp, string expected)
        {
            CommonLibrary.Employee employee = new CommonLibrary.Employee();
            string actual = employee.GetLeaves(exp);
            Assert.AreEqual(expected, actual);

        }

    }
}

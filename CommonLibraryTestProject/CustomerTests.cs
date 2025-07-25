using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibraryTestProject
{
    [TestFixture]
    internal class CustomerTests
    {
        //[Test]
        //public void TestCustomer()
        //{
        //    CommonLibrary.Customer customer = new CommonLibrary.Customer();
        //    bool actual = customer.AddCustomer();
        //    Assert.IsTrue(actual);
        //}


        [Test]
        public void TestCustomer()
        {
            CommonLibrary.Customer customer = new CommonLibrary.Customer();
            Mock<CommonLibrary.EMail> email = new Mock<CommonLibrary.EMail>();

            email.Setup(x => x.SendMail()).Returns(true);
            bool res = customer.AddCustomer(email.Object);
            Assert.IsTrue(res);
        }

    }
}

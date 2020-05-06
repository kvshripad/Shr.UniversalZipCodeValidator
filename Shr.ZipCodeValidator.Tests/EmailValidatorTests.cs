using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shr.ZipCodeValidator.Tests
{
    [TestClass]
    public class EmailValidatorTests
    {
        [TestMethod]
        public void TestPlainEmail()
        {
            Assert.IsTrue(EmailValidator.Validate("shripad.xyz@gmail.com"));
        }
    }
}

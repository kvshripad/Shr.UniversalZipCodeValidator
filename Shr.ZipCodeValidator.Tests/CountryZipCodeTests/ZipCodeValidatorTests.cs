using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shr.ZipCodeValidator.Common;

namespace Shr.ZipCodeValidator.Tests
{
    [TestClass]
    public class ZipCodeValidatorTests
    {
        #region US Tests
        [TestMethod]
        public void US_Valid_12345_1234()
        {
            Assert.IsTrue(UniversalZipCodeValidator.Validate(CountryCode.US, "12345-6789"));
        }
        [TestMethod]
        public void US_Invalid_1234567890()
        {
            Assert.IsFalse(UniversalZipCodeValidator.Validate(CountryCode.US, "1234567890"));
        }
        [TestMethod]
        public void US_Valid_12345_6789()
        {
            Assert.IsTrue(UniversalZipCodeValidator.Validate(CountryCode.US, "12345 6789"));
        }
        [TestMethod]
        public void US_Invalid_1234_6789()
        {
            Assert.IsFalse(UniversalZipCodeValidator.Validate(CountryCode.US, "1234-6789"));
        }
        #endregion

        #region IN Tests
        [TestMethod]
        public void IN_Valid_123456()
        {
            Assert.IsTrue(UniversalZipCodeValidator.Validate(CountryCode.IN, "123456"));
        }
        #endregion

        #region AD Tests
        [TestMethod]
        public void AD_Valid_AD123()
        {
            Assert.IsTrue(UniversalZipCodeValidator.Validate(CountryCode.AD, "AD123"));
        }
        [TestMethod]
        public void AD_Invalid_AD1234()
        {
            Assert.IsFalse(UniversalZipCodeValidator.Validate(CountryCode.AD, "AD1234"));
        }
        #endregion
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shr.ZipCodeValidator.CountryValidators;

namespace Shr.ZipCodeValidator.Tests.CountryZipCodeTests
{
    [TestClass]
    public class NegativeTests
    {
        [TestMethod]
        public void NullStrategyWhenInitializing()
        {
            Assert.ThrowsException<Exception>(() => new USZipCodeValidator(null));
        }
    }
}

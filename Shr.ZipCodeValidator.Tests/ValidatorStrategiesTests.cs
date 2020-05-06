using Shr.ZipCodeValidator.ValidatorStrategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Shr.ZipCodeValidator.Tests
{
    [TestClass]
    public class ValidatorStrategiesTests
    {
        IValidatorStrategy<List<string>, string> _regexStrategy = new RegexValidatorStrategy(true);
        #region Do not change below regex, All Tests in this file are written for it
        List<string> _patterns = new List<string>
            {
                "^[0-9][0-9][0-9]-[0-9][0-9]$",
                "^[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]$",
                "^[2-7][a-z][A-Z]+$"
            };
        #endregion

        [TestMethod]
        public void ValidTest_123_45()
        {
            Assert.IsTrue(_regexStrategy.Validate(_patterns, "123-45"));
        }
        [TestMethod]
        public void ValidTest_123_4567()
        {
            Assert.IsTrue(_regexStrategy.Validate(_patterns, "123-4567"));
        }
        [TestMethod]
        public void InvalidTest_12345678()
        {
            Assert.IsFalse(_regexStrategy.Validate(_patterns, "12345678"));
        }
        [TestMethod]
        public void ValidTest_3aBCD()
        {
            Assert.IsTrue(_regexStrategy.Validate(_patterns, "3aBCD"));
        }
        [TestMethod]
        public void InvalidTest_1aBCD()
        {
            Assert.IsFalse(_regexStrategy.Validate(_patterns, "1aBCD"));
        }
        [TestMethod]
        public void InvalidTest_2a9B()
        {
            Assert.IsFalse(_regexStrategy.Validate(_patterns, "2a9B"));
        }

        [TestMethod]
        public void EmptyPatternTest()
        {
            var _strategy = new RegexValidatorStrategy(true);
            Assert.ThrowsException<Exception>( () => _strategy.Validate(new List<string>(), "123"));
        }
        [TestMethod]
        public void NullPatternTest()
        {
            var _strategy = new RegexValidatorStrategy(true);
            Assert.ThrowsException<Exception>(() => _strategy.Validate(null, "123"));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shr.ZipCodeValidator.ValidatorStrategies;
using System.Collections.Generic;

namespace Shr.ZipCodeValidator.Tests
{
    [TestClass]
    public class ValidatorStrategyMatchAllTests
    {
        IValidatorStrategy<List<string>, string> _regexStrategy = new RegexValidatorStrategy(false);
        #region Do not change below regex, All Tests in this file are written for it
        List<string> _patterns = new List<string>
            {
                "^[0-9][0-9][0-9][0-9]$",
                "^[0-9]+$"
            };
        #endregion

        [TestMethod]
        public void Valid_MatchAllTest()
        {
            Assert.IsTrue(_regexStrategy.Validate(_patterns, "1234"));
        }
    }
}

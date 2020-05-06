using Shr.ZipCodeValidator.ValidatorStrategies;
using System.Collections.Generic;

namespace Shr.ZipCodeValidator
{
    internal class EmailValidator
    {
        private static readonly IValidatorStrategy<List<string>, string> _matchAnyStrategy;
        private static List<string> _emailPatterns;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailString"></param>
        /// <returns></returns>
        public static bool Validate(string emailString)
        {
            return _matchAnyStrategy.Validate(_emailPatterns, emailString);
        }

        /// <summary>
        /// Initializes static properties of the class
        /// </summary>
        static EmailValidator()
        {
            // Initialize strategy
            _matchAnyStrategy = new RegexValidatorStrategy();

            // Initialize patterns
            _emailPatterns = new List<string>
            {
                @"^(?!.*\.@)^(?!.*\.{2})^(?!@*\@{2})^[^\s@]+@[^\s@]+\.?[^\s@]+[^\.]$"
            };
        }
    }
}

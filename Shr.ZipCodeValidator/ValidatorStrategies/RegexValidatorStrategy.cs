using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Shr.ZipCodeValidator.ValidatorStrategies
{
    internal class RegexValidatorStrategy : IValidatorStrategy<List<string>, string>
    {
        private readonly bool _matchAny;

        public RegexValidatorStrategy(bool matchAny = true)
        {
            this._matchAny = matchAny;
        }

        public bool Validate(List<string> listRegexPatterns, string input)
        {
            if (null == listRegexPatterns || !listRegexPatterns.Any())
                throw new Exception("Null or empty regex patterns passed while constructing regex strategy.");

            var result = this._matchAny? false : true;

            foreach (var pattern in listRegexPatterns)
            {
                result = this._matchAny
                            ? (result || Regex.IsMatch(input, pattern, RegexOptions.CultureInvariant, new TimeSpan(0, 0, 60)))
                            : (result && Regex.IsMatch(input, pattern, RegexOptions.CultureInvariant, new TimeSpan(0, 0, 60)));

                if (this._matchAny && result) break;
            }

            return result;
        }
    }
}

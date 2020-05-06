using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EC.VL.QUOT.UniversalValidator
{
    public class RegexValidatorStrategy : IValidatorStrategy
    {
        private readonly List<string> _listRegexPatterns;
        private readonly bool _matchAny;

        public RegexValidatorStrategy(List<string> listRegexPatterns, bool matchAny = true)
        {
            if(null == listRegexPatterns || !listRegexPatterns.Any())
                throw new Exception("Null or empty regex patterns passed while constructing regex strategy.");

            this._listRegexPatterns = listRegexPatterns;
            this._matchAny = matchAny;
        }

        public bool Validate(string input)
        {
            var result = false;
            foreach (var pattern in this._listRegexPatterns)
            {
                result = this._matchAny
                            ? (result || Regex.IsMatch(input, pattern))
                            : (result && Regex.IsMatch(input, pattern));

                if (this._matchAny && result) break;
            }

            return result;
        }
    }
}

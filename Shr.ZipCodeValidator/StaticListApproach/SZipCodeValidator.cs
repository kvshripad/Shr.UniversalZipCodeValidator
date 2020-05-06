using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.VL.SHARED.ZipCodeValidator.StaticListApproach
{
    public class SZipCodeValidator
    {
        private static readonly IValidatorStrategy _strategy = new RegexValidatorStrategy(true);

        public static bool Validate(string countryCode, string zipCode)
        {
            var patterns = Utility.GetPatterns(countryCode);
            return _strategy.Validate(patterns, zipCode);
        }
    }
}

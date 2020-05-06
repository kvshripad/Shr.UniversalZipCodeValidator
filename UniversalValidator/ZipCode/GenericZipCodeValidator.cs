using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.VL.QUOT.UniversalValidator.ZipCode
{
    public class GenericZipCodeValidator
    {
        private static Dictionary<string, List<string>> CountryZipValidatorPatterns;

        public static bool Validate(string countryCode, string zipCode)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(countryCode)) throw new Exception("Invalid country code passed for zip validation.");
            if (string.IsNullOrWhiteSpace(zipCode)) throw new Exception("Null or empty zip code passed for validation.");

            // Extract patterns
            var validationEntry = CountryZipValidatorPatterns.FirstOrDefault(x => x.Key == countryCode.Trim());
            var patterns = validationEntry.Value;

            //Create strategy
            IValidatorStrategy strategy = new RegexValidatorStrategy(patterns, true);

            // Validate
            return strategy.Validate(zipCode.Trim());
        }

        static GenericZipCodeValidator()
        {
            InitializeCountryZipValidatorPatterns();
        }

        private static void InitializeCountryZipValidatorPatterns()
        {
            /*
             * US = 1234-567 | 1234-56 
             * IN = 123456
             */

            CountryZipValidatorPatterns = new Dictionary<string, List<string>>
            {
                { "US", new List<string>{ "^[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9]$", "^[0-9][0-9][0-9][0-9][-][0-9][0-9]$" } },
                { "IN", new List<string>{ "^[1-9][0-9][0-9][0-9][0-9][0-9]$" } }
            };
        }
    }
}

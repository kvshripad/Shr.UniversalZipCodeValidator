using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class GGZipCodeValidator : BaseZipCodeValidator
    {
        public GGZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.GG;
            this.ZipCodePatterns = new List<string>
            {
                @"^GY\d[\dA-Z]?[ ]?\d[ABD-HJLN-UW-Z]{2}$"
            };
        }
    }
}

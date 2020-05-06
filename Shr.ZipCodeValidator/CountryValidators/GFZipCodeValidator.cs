using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class GFZipCodeValidator : BaseZipCodeValidator
    {
        public GFZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.GF;
            this.ZipCodePatterns = new List<string>
            {
                @"^9[78]3\d{2}$"
            };
        }
    }
}

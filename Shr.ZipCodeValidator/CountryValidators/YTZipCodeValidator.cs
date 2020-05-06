using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class YTZipCodeValidator : BaseZipCodeValidator
    {
        public YTZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.YT;
            this.ZipCodePatterns = new List<string>
            {
                @"^976\d{2}$"
            };
        }
    }
}

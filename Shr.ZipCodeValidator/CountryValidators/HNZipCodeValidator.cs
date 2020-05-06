using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class HNZipCodeValidator : BaseZipCodeValidator
    {
        public HNZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.HN;
            this.ZipCodePatterns = new List<string>
            {
                @"^(?:\d{5})?$"
            };
        }
    }
}

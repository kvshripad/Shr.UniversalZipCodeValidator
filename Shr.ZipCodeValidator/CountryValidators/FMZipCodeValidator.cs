using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class FMZipCodeValidator : BaseZipCodeValidator
    {
        public FMZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.FM;
            this.ZipCodePatterns = new List<string>
            {
                @"^(9694[1-4])([ \-]\d{4})?$"
            };
        }
    }
}

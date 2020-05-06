using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class VIZipCodeValidator : BaseZipCodeValidator
    {
        public VIZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.VI;
            this.ZipCodePatterns = new List<string>
            {
                @"^008(([0-4]\d)|(5[01]))([ \-]\d{4})?$"
            };
        }
    }
}

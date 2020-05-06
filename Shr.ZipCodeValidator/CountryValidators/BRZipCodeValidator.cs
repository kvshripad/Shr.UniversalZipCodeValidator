using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class BRZipCodeValidator : BaseZipCodeValidator
    {
        public BRZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.BR;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{5}[\-]?\d{3}$"
            };
        }
    }
}

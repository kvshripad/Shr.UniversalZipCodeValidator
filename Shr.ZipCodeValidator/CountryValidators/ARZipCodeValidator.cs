using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class ARZipCodeValidator : BaseZipCodeValidator
    {
        public ARZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.AR;
            this.ZipCodePatterns = new List<string>
            {
                @"^([A-HJ-NP-Z])?\d{4}([A-Z]{3})?$"
            };
        }
    }
}

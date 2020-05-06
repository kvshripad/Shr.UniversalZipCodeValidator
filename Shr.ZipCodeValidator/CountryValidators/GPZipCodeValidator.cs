using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class GPZipCodeValidator : BaseZipCodeValidator
    {
        public GPZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.GP;
            this.ZipCodePatterns = new List<string>
            {
                @"^9[78][01]\d{2}$"
            };
        }
    }
}

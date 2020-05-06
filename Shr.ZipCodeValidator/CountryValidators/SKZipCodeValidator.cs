using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class SKZipCodeValidator : BaseZipCodeValidator
    {
        public SKZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.SK;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}[ ]?\d{2}$"
            };
        }
    }
}

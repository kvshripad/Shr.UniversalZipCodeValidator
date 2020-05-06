using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class AMZipCodeValidator : BaseZipCodeValidator
    {
        public AMZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.AM;
            this.ZipCodePatterns = new List<string>
            {
                @"^(37)?\d{4}$"
            };
        }
    }
}

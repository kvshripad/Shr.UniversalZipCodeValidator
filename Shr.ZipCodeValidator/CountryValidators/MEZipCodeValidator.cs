using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class MEZipCodeValidator : BaseZipCodeValidator
    {
        public MEZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.ME;
            this.ZipCodePatterns = new List<string>
            {
                @"^8\d{4}$"
            };
        }
    }
}

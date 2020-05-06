using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class MGZipCodeValidator : BaseZipCodeValidator
    {
        public MGZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.MG;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}$"
            };
        }
    }
}

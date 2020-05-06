using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class REZipCodeValidator : BaseZipCodeValidator
    {
        public REZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.RE;
            this.ZipCodePatterns = new List<string>
            {
                @"^9[78]4\d{2}$"
            };
        }
    }
}

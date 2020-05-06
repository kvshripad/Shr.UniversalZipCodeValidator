using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class SMZipCodeValidator : BaseZipCodeValidator
    {
        public SMZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.SM;
            this.ZipCodePatterns = new List<string>
            {
                @"^4789\d$"
            };
        }
    }
}

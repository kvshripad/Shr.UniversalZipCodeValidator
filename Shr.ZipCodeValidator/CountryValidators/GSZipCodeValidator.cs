using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class GSZipCodeValidator : BaseZipCodeValidator
    {
        public GSZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.GS;
            this.ZipCodePatterns = new List<string>
            {
                @"^SIQQ 1ZZ$"
            };
        }
    }
}

using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class TCZipCodeValidator : BaseZipCodeValidator
    {
        public TCZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.TC;
            this.ZipCodePatterns = new List<string>
            {
                @"^TKCA 1ZZ$"
            };
        }
    }
}

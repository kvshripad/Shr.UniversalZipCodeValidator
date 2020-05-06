using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class PNZipCodeValidator : BaseZipCodeValidator
    {
        public PNZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.PN;
            this.ZipCodePatterns = new List<string>
            {
                @"^PCRN 1ZZ$"
            };
        }
    }
}

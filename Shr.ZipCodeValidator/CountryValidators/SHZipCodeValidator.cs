using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class SHZipCodeValidator : BaseZipCodeValidator
    {
        public SHZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.SH;
            this.ZipCodePatterns = new List<string>
            {
                @"^(ASCN|STHL) 1ZZ$"
            };
        }
    }
}

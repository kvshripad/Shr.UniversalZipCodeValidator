using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class CCZipCodeValidator : BaseZipCodeValidator
    {
        public CCZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.CC;
            this.ZipCodePatterns = new List<string>
            {
                @"^6799$"
            };
        }
    }
}

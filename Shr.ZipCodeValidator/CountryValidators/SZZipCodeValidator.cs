using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class SZZipCodeValidator : BaseZipCodeValidator
    {
        public SZZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.SZ;
            this.ZipCodePatterns = new List<string>
            {
                @"^[HLMS]\d{3}$"
            };
        }
    }
}

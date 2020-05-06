using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class KRZipCodeValidator : BaseZipCodeValidator
    {
        public KRZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.KR;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}[\-]\d{3}$"
            };
        }
    }
}

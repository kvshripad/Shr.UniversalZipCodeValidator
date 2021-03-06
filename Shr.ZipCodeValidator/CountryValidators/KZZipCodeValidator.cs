using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class KZZipCodeValidator : BaseZipCodeValidator
    {
        public KZZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.KZ;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{6}$"
            };
        }
    }
}

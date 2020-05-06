using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class TWZipCodeValidator : BaseZipCodeValidator
    {
        public TWZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.TW;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}(\d{2})?$"
            };
        }
    }
}

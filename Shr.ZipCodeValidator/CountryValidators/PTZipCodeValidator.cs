using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class PTZipCodeValidator : BaseZipCodeValidator
    {
        public PTZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.PT;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{4}([\-]\d{3})?$"
            };
        }
    }
}

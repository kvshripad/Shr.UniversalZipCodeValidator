using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class NOZipCodeValidator : BaseZipCodeValidator
    {
        public NOZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.NO;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{4}$"
            };
        }
    }
}

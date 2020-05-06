using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class AXZipCodeValidator : BaseZipCodeValidator
    {
        public AXZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.AX;
            this.ZipCodePatterns = new List<string>
            {
                @"^22\d{3}$"
            };
        }
    }
}

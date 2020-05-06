using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class WFZipCodeValidator : BaseZipCodeValidator
    {
        public WFZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.WF;
            this.ZipCodePatterns = new List<string>
            {
                @"^986\d{2}$"
            };
        }
    }
}

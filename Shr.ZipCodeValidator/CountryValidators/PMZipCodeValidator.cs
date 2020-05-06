using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class PMZipCodeValidator : BaseZipCodeValidator
    {
        public PMZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.PM;
            this.ZipCodePatterns = new List<string>
            {
                @"^9[78]5\d{2}$"
            };
        }
    }
}

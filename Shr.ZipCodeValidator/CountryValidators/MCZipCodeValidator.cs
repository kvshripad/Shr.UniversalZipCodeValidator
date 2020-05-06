using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class MCZipCodeValidator : BaseZipCodeValidator
    {
        public MCZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.MC;
            this.ZipCodePatterns = new List<string>
            {
                @"^980\d{2}$"
            };
        }
    }
}

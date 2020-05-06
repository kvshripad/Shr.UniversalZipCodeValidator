using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class MUZipCodeValidator : BaseZipCodeValidator
    {
        public MUZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.MU;
            this.ZipCodePatterns = new List<string>
            {
                @"^(\d{3}[A-Z]{2}\d{3})?$"
            };
        }
    }
}

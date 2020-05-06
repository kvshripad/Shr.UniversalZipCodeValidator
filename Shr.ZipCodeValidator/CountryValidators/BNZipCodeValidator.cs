using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class BNZipCodeValidator : BaseZipCodeValidator
    {
        public BNZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.BN;
            this.ZipCodePatterns = new List<string>
            {
                @"^[A-Z]{2}[ ]?\d{4}$"
            };
        }
    }
}

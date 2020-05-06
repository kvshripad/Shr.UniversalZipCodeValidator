using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class FKZipCodeValidator : BaseZipCodeValidator
    {
        public FKZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.FK;
            this.ZipCodePatterns = new List<string>
            {
                @"^FIQQ 1ZZ$"
            };
        }
    }
}

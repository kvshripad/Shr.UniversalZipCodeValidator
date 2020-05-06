using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class FRZipCodeValidator : BaseZipCodeValidator
    {
        public FRZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.FR;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{2}[ ]?\d{3}$"
            };
        }
    }
}

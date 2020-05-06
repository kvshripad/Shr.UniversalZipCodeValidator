using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class CRZipCodeValidator : BaseZipCodeValidator
    {
        public CRZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.CR;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{4,5}|\d{3}-\d{4}$"
            };
        }
    }
}

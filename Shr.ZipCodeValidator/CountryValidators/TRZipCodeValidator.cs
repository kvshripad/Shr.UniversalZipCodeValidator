using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class TRZipCodeValidator : BaseZipCodeValidator
    {
        public TRZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.TR;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{5}$"
            };
        }
    }
}

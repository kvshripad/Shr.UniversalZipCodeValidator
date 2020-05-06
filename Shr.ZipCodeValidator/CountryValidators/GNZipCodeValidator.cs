using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class GNZipCodeValidator : BaseZipCodeValidator
    {
        public GNZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.GN;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}$"
            };
        }
    }
}

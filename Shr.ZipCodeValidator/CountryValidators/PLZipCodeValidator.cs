using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class PLZipCodeValidator : BaseZipCodeValidator
    {
        public PLZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.PL;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{2}-\d{3}$"
            };
        }
    }
}

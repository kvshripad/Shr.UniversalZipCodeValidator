using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class USZipCodeValidator : BaseZipCodeValidator
    {
        public USZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.US;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{5}([ \-]\d{4})?$"
            };
        }
    }
}

using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class PRZipCodeValidator : BaseZipCodeValidator
    {
        public PRZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.PR;
            this.ZipCodePatterns = new List<string>
            {
                @"^00[679]\d{2}([ \-]\d{4})?$"
            };
        }
    }
}

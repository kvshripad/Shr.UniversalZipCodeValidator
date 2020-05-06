using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class MPZipCodeValidator : BaseZipCodeValidator
    {
        public MPZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.MP;
            this.ZipCodePatterns = new List<string>
            {
                @"^9695[012]([ \-]\d{4})?$"
            };
        }
    }
}

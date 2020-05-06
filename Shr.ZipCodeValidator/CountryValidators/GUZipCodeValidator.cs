using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class GUZipCodeValidator : BaseZipCodeValidator
    {
        public GUZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.GU;
            this.ZipCodePatterns = new List<string>
            {
                @"^969[123]\d([ \-]\d{4})?$"
            };
        }
    }
}

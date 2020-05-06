using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class ADZipCodeValidator : BaseZipCodeValidator
    {
        public ADZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.AD;
            this.ZipCodePatterns = new List<string>
            {
                @"^AD\d{3}$"
            };
        }
    }
}

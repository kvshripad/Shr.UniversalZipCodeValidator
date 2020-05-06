using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class BHZipCodeValidator : BaseZipCodeValidator
    {
        public BHZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.BH;
            this.ZipCodePatterns = new List<string>
            {
                @"^((1[0-2]|[2-9])\d{2})?$"
            };
        }
    }
}

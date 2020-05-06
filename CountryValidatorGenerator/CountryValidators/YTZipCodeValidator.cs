using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class YTZipCodeValidator : BaseZipCodeValidator
    {
        public YTZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.YT;
            this.ZipCodePatterns = new List<string>
            {
                @"^976\d{2}$"
            };
        }
    }
}

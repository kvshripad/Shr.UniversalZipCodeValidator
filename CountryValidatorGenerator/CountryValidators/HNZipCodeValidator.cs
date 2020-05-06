using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class HNZipCodeValidator : BaseZipCodeValidator
    {
        public HNZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.HN;
            this.ZipCodePatterns = new List<string>
            {
                @"^(?:\d{5})?$"
            };
        }
    }
}

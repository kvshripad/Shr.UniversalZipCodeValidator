using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class PTZipCodeValidator : BaseZipCodeValidator
    {
        public PTZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.PT;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{4}([\-]\d{3})?$"
            };
        }
    }
}

using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class SZZipCodeValidator : BaseZipCodeValidator
    {
        public SZZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.SZ;
            this.ZipCodePatterns = new List<string>
            {
                @"^[HLMS]\d{3}$"
            };
        }
    }
}

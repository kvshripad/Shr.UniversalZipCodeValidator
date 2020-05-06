using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class VIZipCodeValidator : BaseZipCodeValidator
    {
        public VIZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.VI;
            this.ZipCodePatterns = new List<string>
            {
                @"^008(([0-4]\d)|(5[01]))([ \-]\d{4})?$"
            };
        }
    }
}

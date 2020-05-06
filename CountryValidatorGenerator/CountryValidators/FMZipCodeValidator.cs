using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class FMZipCodeValidator : BaseZipCodeValidator
    {
        public FMZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.FM;
            this.ZipCodePatterns = new List<string>
            {
                @"^(9694[1-4])([ \-]\d{4})?$"
            };
        }
    }
}

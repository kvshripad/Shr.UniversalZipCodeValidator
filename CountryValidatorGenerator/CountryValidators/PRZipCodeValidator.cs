using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class PRZipCodeValidator : BaseZipCodeValidator
    {
        public PRZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.PR;
            this.ZipCodePatterns = new List<string>
            {
                @"^00[679]\d{2}([ \-]\d{4})?$"
            };
        }
    }
}

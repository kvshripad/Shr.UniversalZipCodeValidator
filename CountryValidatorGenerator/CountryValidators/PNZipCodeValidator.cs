using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class PNZipCodeValidator : BaseZipCodeValidator
    {
        public PNZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.PN;
            this.ZipCodePatterns = new List<string>
            {
                @"^PCRN 1ZZ$"
            };
        }
    }
}

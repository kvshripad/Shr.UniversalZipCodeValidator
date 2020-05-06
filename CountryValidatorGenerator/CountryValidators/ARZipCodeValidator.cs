using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class ARZipCodeValidator : BaseZipCodeValidator
    {
        public ARZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.AR;
            this.ZipCodePatterns = new List<string>
            {
                @"^([A-HJ-NP-Z])?\d{4}([A-Z]{3})?$"
            };
        }
    }
}

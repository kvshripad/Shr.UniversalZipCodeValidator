using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class AXZipCodeValidator : BaseZipCodeValidator
    {
        public AXZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.AX;
            this.ZipCodePatterns = new List<string>
            {
                @"^22\d{3}$"
            };
        }
    }
}

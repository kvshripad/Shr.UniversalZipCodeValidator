using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class GWZipCodeValidator : BaseZipCodeValidator
    {
        public GWZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.GW;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{4}$"
            };
        }
    }
}

using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class AMZipCodeValidator : BaseZipCodeValidator
    {
        public AMZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.AM;
            this.ZipCodePatterns = new List<string>
            {
                @"^(37)?\d{4}$"
            };
        }
    }
}

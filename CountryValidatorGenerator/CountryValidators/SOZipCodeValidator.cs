using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class SOZipCodeValidator : BaseZipCodeValidator
    {
        public SOZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.SO;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{5}$"
            };
        }
    }
}

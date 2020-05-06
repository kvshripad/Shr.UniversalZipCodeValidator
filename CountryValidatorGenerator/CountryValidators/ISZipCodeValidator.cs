using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class ISZipCodeValidator : BaseZipCodeValidator
    {
        public ISZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.IS;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}$"
            };
        }
    }
}

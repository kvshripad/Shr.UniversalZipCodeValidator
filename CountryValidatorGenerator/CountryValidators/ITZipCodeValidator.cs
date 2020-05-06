using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class ITZipCodeValidator : BaseZipCodeValidator
    {
        public ITZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.IT;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{5}$"
            };
        }
    }
}

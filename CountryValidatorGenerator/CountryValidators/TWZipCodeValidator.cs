using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class TWZipCodeValidator : BaseZipCodeValidator
    {
        public TWZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.TW;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}(\d{2})?$"
            };
        }
    }
}

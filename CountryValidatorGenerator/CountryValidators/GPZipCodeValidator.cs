using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class GPZipCodeValidator : BaseZipCodeValidator
    {
        public GPZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.GP;
            this.ZipCodePatterns = new List<string>
            {
                @"^9[78][01]\d{2}$"
            };
        }
    }
}

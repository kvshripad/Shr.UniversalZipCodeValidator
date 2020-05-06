using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class BHZipCodeValidator : BaseZipCodeValidator
    {
        public BHZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.BH;
            this.ZipCodePatterns = new List<string>
            {
                @"^((1[0-2]|[2-9])\d{2})?$"
            };
        }
    }
}

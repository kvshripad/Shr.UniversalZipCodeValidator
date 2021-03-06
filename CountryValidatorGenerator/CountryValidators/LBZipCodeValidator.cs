using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class LBZipCodeValidator : BaseZipCodeValidator
    {
        public LBZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.LB;
            this.ZipCodePatterns = new List<string>
            {
                @"^(\d{4}([ ]?\d{4})?)?$"
            };
        }
    }
}

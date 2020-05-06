using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class FRZipCodeValidator : BaseZipCodeValidator
    {
        public FRZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.FR;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{2}[ ]?\d{3}$"
            };
        }
    }
}

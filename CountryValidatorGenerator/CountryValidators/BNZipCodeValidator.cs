using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class BNZipCodeValidator : BaseZipCodeValidator
    {
        public BNZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.BN;
            this.ZipCodePatterns = new List<string>
            {
                @"^[A-Z]{2}[ ]?\d{4}$"
            };
        }
    }
}

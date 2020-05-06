using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class FKZipCodeValidator : BaseZipCodeValidator
    {
        public FKZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.FK;
            this.ZipCodePatterns = new List<string>
            {
                @"^FIQQ 1ZZ$"
            };
        }
    }
}

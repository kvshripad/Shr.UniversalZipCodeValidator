using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class GSZipCodeValidator : BaseZipCodeValidator
    {
        public GSZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.GS;
            this.ZipCodePatterns = new List<string>
            {
                @"^SIQQ 1ZZ$"
            };
        }
    }
}

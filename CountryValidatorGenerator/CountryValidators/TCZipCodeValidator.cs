using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class TCZipCodeValidator : BaseZipCodeValidator
    {
        public TCZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.TC;
            this.ZipCodePatterns = new List<string>
            {
                @"^TKCA 1ZZ$"
            };
        }
    }
}

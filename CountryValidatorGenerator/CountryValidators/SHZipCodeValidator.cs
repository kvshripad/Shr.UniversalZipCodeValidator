using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class SHZipCodeValidator : BaseZipCodeValidator
    {
        public SHZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.SH;
            this.ZipCodePatterns = new List<string>
            {
                @"^(ASCN|STHL) 1ZZ$"
            };
        }
    }
}

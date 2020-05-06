using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class CCZipCodeValidator : BaseZipCodeValidator
    {
        public CCZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.CC;
            this.ZipCodePatterns = new List<string>
            {
                @"^6799$"
            };
        }
    }
}

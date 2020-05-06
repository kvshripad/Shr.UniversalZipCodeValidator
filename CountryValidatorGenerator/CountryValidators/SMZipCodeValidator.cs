using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class SMZipCodeValidator : BaseZipCodeValidator
    {
        public SMZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.SM;
            this.ZipCodePatterns = new List<string>
            {
                @"^4789\d$"
            };
        }
    }
}

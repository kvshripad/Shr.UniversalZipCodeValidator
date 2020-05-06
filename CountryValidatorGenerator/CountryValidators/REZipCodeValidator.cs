using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class REZipCodeValidator : BaseZipCodeValidator
    {
        public REZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.RE;
            this.ZipCodePatterns = new List<string>
            {
                @"^9[78]4\d{2}$"
            };
        }
    }
}

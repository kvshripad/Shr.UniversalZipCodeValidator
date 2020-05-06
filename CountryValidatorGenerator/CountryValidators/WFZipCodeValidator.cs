using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class WFZipCodeValidator : BaseZipCodeValidator
    {
        public WFZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.WF;
            this.ZipCodePatterns = new List<string>
            {
                @"^986\d{2}$"
            };
        }
    }
}

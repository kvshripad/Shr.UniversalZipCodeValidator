using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class NIZipCodeValidator : BaseZipCodeValidator
    {
        public NIZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.NI;
            this.ZipCodePatterns = new List<string>
            {
                @"^((\d{4}-)?\d{3}-\d{3}(-\d{1})?)?$"
            };
        }
    }
}
